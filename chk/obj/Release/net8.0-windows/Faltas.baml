   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      
chk.Faltas   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:chk     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$  Faltas��$	��720��$
��1000��.���  � Cursor$
 Hand��$��0,0,0,15q� � ColumnDefinitions �� $	��100 ��� $	��800 ��� $	��100 �.+��� -    ��Name$ tbMatricula��$	��Top=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Matricula:�� %  !MaterialDesignFloatingHintTextBox#��[  $��1��$��64,278,459,0q�$��33���� -   $ tbNombre��$	��Top=�$ Nombre:��#��[  $��1��$��64,344,459,0q�$��33���� -   $ 
tbApellido��$	��Top=�$ 	Apellido:��#��[  $��1��$��64,409,460,0q�$��32���� -   $ tbCargo��$	��Top=�$ Grado:��#��[  $��1��$��64,532,459,0q�$��36���� -   $ tbDepartamento��$	��Top=�$ Departamento:��#��[  $��1��$��64,471,460,0q�$��33���� $��Motivo Falta:��$��1��$
��Left=�$��400,278,0,0q�$	��Top=��� -    ��Name$ cbMotivoFalta��$��1��$
��Left=�$��400,295,0,0q�$	��Top=�$	��277��.@��� .��
Licencia�� .��
Vacaciones�� .��Azueto�� .��Rebaja Domiciliada�� .��Por Nupcias�� .��Comision de Servicio�� .��
Maternidad�� .��
Paternidad�� .��Cita medica local�� .��Cita medica foranea�� .��Acompañante de cita medica�� .��Permiso para llegar tarde�� .��FALTA NO JUSTIFICADA�� -    ��Name$ 
btnGuardar��$��1��$��Guardar Falta��$
��Left=�$��322,617,0,0q�$	��Top=�$��43��$	��130���� -	   $ btnSeleccionar��$��1��$!��Seleccionar motivo de falta��$
��Left=�$��436,532,0,0q�$	��Top=��� $��Fecha Inicio Falta:��$��1��$
��Left=�$��398,335,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  -
     Name$ dpFechaInicioFalta��$��1��$
��Left=�$��400,364,0,0q�$	��Top=��� $��Fecha Fin Falta:��$��1��$
��Left=�$��395,424,0,0q�$	��Top=�  -   $ dpFechaFinFalta��$��1��$
��Left=�$��400,448,0,0q�$	��Top=�&   System.Windows.Controls.DataGrid  -     Name$ dgFaltas��	   AutoGenerateColumns$	 False��
   CanUserAddRows$
 False��   
IsReadOnly$
 True��$��0,26,0,0q�$	��213��$	��Top=�$��3��$
��Left=�$
��1043������    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ IDFalta��   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	IDFalta+  $ 	Matricula�� �� *	Matricula+  $ Nombre�� �� *Nombre+  $ Apellido�� �� *
Apellido+  $ Departamento��$ Hidden=� �� *Departamento+  $ Grado�� �� *Grado+  $ MotivoFalta�� �� *MotivoFalta+  $ FechaInicioFalta�� �� *FechaInicioFalta+  $ FechaFinFalta�� �� *FechaFinFalta+�� -   $��txtClock��$
��Left=�$	��Top=�$��146,617,0,0q�$��16(��� -   $ btnActualizarFalta��$��Actualizar Falta��$
��Left=�$��495,617,0,0q�$	��Top=�$	��153��$��1��$��43���� -   $ 	btnBuscar��$��Buscar Empleado��$
��Left=�$��128,617,0,0q�$	��Top=�$	��148��$��43��$��1��