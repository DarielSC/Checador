   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      chk.Empleados   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  localclr-namespace:chk  -     � Title$  	Empleados��$	��720��$
��1080��.���  � Cursor$
 Hand�� � ColumnDefinitions �� $	��100 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $	��800 ��� $	��100 �.+�&   System.Windows.Controls.DataGrid  -     Name$ dgEmpleados��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   
IsReadOnly$
 True��$��	10,24,0,0q�$	��654��$	��Top=�$��5��$
��Left=�$	��661������    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $
 	Matricula�� �� *	Matricula+  $
 Departamento�� �� *Departamento+  $
 Grado�� �� *Grado+  $
 Nombre�� �� *Nombre+  $
 Apellido�� �� *
Apellido+  $
 	Condicion�� �� *	Condicion+  $
 FechaHoraAlta�� �� *FechaHoraAlta+�� -    ��Name$ tbGrado��$	��Top=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Grado:�� %  !MaterialDesignFloatingHintTextBox#��[  $��4��$��680,123,-56,0q�$��36��$��2���� -   $ tbNombre��$	��Top=�$ Nombre:��#��[  $��4��$��678,181,-55,0q�$��33��$��2���� -   $ 
tbApellido��$	��Top=�$ 	Apellido:��#��[  $��4��$��679,231,-54,0q�$��33��$��2���� -   $ tbMatricula��$	��Top=�$ 
Matricula:��#��[  $��4��$��679,24,-55,0q�$��33��$��2���� -   $ tbDepartamento��$	��Top=�$ Departamento:��#��[  $��4��$��680,71,-56,0q�$��33��$��2���� -    ��Name$ 
btnCaptura��$��Capturar Huella��  MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��4��$��734,351,-6,0q�$��45��$	��Top=�$��2��{��� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window�� -	   $ 
btnGuardar��$��Guardar��#��[ $/ )Resource name: MaterialDesignRaisedButton��$��4��$��733,418,-6,0q�$��38��$	��Top=�$��2��{��� *DataContext.ControlsEnabled+ �� " � �� Mode$ FindAncestor=��� -
    ��Name$ imgVerHuella��$��4��$!��Resources/autenticacion.png��$��Uniform=�$y�Hidden=�$
��Left=�$��32��$��532,257,0,0q�$	��Top=�$��31���� -   $ btnEliminar��$��4��$��Eliminar��$��733,540,-3,0q�$	��Top=�$��38��$��2���� -   $ tbCondicion��$	��Top=�$ Condición:��#��[  $��4��$��679,280,-55,0q�$��33��$��2���� -   $ btnActualizarEmpleado��$��4��$��
Actualizar��$��733,478,-5,0q�$	��Top=�$��43��$��2���� -    ��Name$ lblCantidadEmpleados��$��Total empleados: 0��$��20(�$
��Left=�$	��Top=�$��706,642,0,0q�$��4��$��36��$��2��$	��231�� J� RenderTransformOrigin$ 1.036,0.529&��� -   $ 	btnBuscar��$��4��$��Buscar��$��730,599,-3,0q�$	��Top=�$��2��$��38��