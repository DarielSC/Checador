using DPFP;
using DPFP.Verification;
using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using chk.Modelos;
using chk.Servicios;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Drawing;



namespace chk
{
    /// <summary>
    /// Lógica de interacción para Check.xaml
    /// </summary>
    public partial class Check : Window, DPFP.Capture.EventHandler //hereda de la clase Window y de la interfaz DPFP.Capture.EventHandler
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Capture.Capture Capturer;
        public Check()
        {
            InitializeComponent();
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    lblReport.Content = "Can't initiate capture operation!";
            }
            catch
            {
               System.Windows.MessageBox.Show("Can't initiate capture operation!", "Error",System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        //Metodo para procesar la muestra de la huella
        protected void Process(DPFP.Sample Sample) 
        {
            

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                Verificator = new DPFP.Verification.Verification();
                DPFP.Template template = new DPFP.Template();
                Stream stream;

                List<Empleado> empleados = DatoEmpleado.MuestraEmpleado();
                bool verified = false;

                foreach(var empleado in empleados)
                {
                    if (empleado.Huella !=  null)
                    {
                        stream = new MemoryStream(empleado.Huella);
                        template = new DPFP.Template(stream);

                        Verificator.Verify(features, template, ref result);
                        if (result.Verified)
                        {
                            this.Dispatcher.Invoke(new Function(delegate () { 
                                Desplegar(empleado); // Llama al metodo para desplegar los datos del empleado
                                RegistrarAsistencia(empleado); //Llama al metodo para registrar la asistencia
                            }));
                            verified = true;
                            break;
                        }
                    }
                }

                if (!verified)
                {
                    this.Dispatcher.Invoke(new Function(delegate ()
                    {
                        System.Windows.MessageBox.Show($"HUELLA NO REGISTRADA", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }));
                }
            }
            Bitmap huellaBitmap = ConvertSampleToBitmap(Sample); 
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    lblReport.Content = "Lector Está Listo, Por Favor Escanee Su Huella.";
                }
                catch
                {
                    lblReport.Content = "Can't initiate capture!";
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    lblReport.Content = "Can't terminate capture!";
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
            Start();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Stop();
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        private BitmapImage ConvertBitmapToBitmapImage(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }



        //Metodo para desplegar los datos del empleado
        public void Desplegar (Empleado empleado)
        {
            string url = "";
            lblMatricula.Content = empleado.Matricula;
            lblNombre.Content = empleado.Nombre;
            lblApellido.Content = empleado.Apellido;
            lblCargo.Content = empleado.Grado;
            lblDepartamento.Content = empleado.Departamento;
                       
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            
            this.Dispatcher.Invoke(new Function(delegate () {
                lblReport.Content = "Se capturó la muestra de la huella.";
                lblStatus.Content = "Escanee nuevamente una huella.";
                Process(Sample);
            }));
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            this.Dispatcher.Invoke(new Function(delegate () {
                lblReport.Content = "La huella fue removida del lector de huellas, por favor vuelva a escanear.";
            }));

        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            this.Dispatcher.Invoke(new Function(delegate () {
                lblReport.Content = "Se tocó el lector de huellas.";
            }));
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            this.Dispatcher.Invoke(new Function(delegate () {
                lblReport.Content ="El lector de huellas está conectado.";
            }));        
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            this.Dispatcher.Invoke(new Function(delegate () {
                lblReport.Content ="El lector de huellas está desconectado.";
            }));
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            /*
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                this.Dispatcher.Invoke(new Function(delegate () {
                    lblReport.Content = "The quality of the fingerprint sample is good.";
                }));
            
            else
                this.Dispatcher.Invoke(new Function(delegate () {
                    lblReport.Content = "The quality of the fingerprint sample is poor.";
                }));
            */
        }

        #endregion

        //Metodo para registrar la asistencia del empleado con la huella
        private void RegistrarAsistencia(Empleado empleado)
        {
            try
            {
                // Crear el objeto de asistencia
                var asistencia = new Asistencia
                {
                    Matricula = empleado.Matricula,
                    Nombre = empleado.Nombre,
                    Apellido = empleado.Apellido,
                    Grado = empleado.Grado,
                    Departamento = empleado.Departamento,
                    FechaHoraAsistencia = DateTime.Now,
                    Huella = empleado.Huella
                };

                // Registrar en la base de datos
                int resultado = DatoAsistencia.RegistrarAsistencia(asistencia);

                if (resultado > 0)
                {
                    // Registro Automatico de la asistencia xd 
                }
                else
                {
                    System.Windows.MessageBox.Show("Solo puede checar dos veces al dia.", "Excepción", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Error al registrar asistencia: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
