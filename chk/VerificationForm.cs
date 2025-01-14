using chk;
using chk.Modelos;
using chk.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Enrollment
{
    /* NOTE: This form is inherited from the CaptureForm,
		so the VisualStudio Form Designer may not load it properly
		(at least until you build the project).
		If you want to make changes in the form layout - do it in the base CaptureForm.
		All changes in the CaptureForm will be reflected in all derived forms 
		(i.e. in the EnrollmentForm and in the VerificationForm)
	*/
    public class VerificationForm : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        public Empleado EmpleadoVerificado { get; private set; }
        public bool HuellaVerificada { get; private set; }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Duplicidad de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Crear el verificador de huellas
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Mostrar el valor de False Accept Rate (FAR)
            SetStatus($"False Accept Rate (FAR) = {FAR}");
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Extraer características del Sample para verificación
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            if (features != null)
            {
                List<Empleado> empleados = DatoEmpleado.MuestraEmpleado();
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                foreach (var empleado in empleados)
                {
                    if (empleado.Huella != null)
                    {
                        using (var stream = new MemoryStream(empleado.Huella))
                        {
                            var template = new DPFP.Template(stream);
                            Verificator.Verify(features, template, ref result);

                            if (result.Verified)
                            {
                                EmpleadoVerificado = empleado;
                                HuellaVerificada = true;
                                System.Windows.MessageBox.Show($"HUELLA YA REGISTRADA PARA: {empleado.Matricula}",
                                    "HUELLA ENCONTRADA", MessageBoxButton.OK, MessageBoxImage.Warning);
                                return;
                            }
                        }
                    }
                }

                System.Windows.MessageBox.Show("Empleado Guardado Correctamente.",
                    "Exito!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }

}