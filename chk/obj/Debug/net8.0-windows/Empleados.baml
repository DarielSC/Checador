   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5   	       chk.Empleados   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:chk  5   	   -   5          � Title$  	Empleados��5	   	   $	��720��6   $
��1080��6(   .��5
      �  � Cursor$
 Hand��6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $	��800 �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEmpleados��5   +      AutoGenerateColumns$ False��6@      CanUserAddRows$ False��6\      
IsReadOnly$
 True��6s   $��	10,24,0,0q�6�   $	��654��6�   $	��Top=�6   $��5��6  $
��Left=�6,  $	��661��6G  ��6   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      
Visibility$ Hidden=�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 	Matricula��6%    68   �� *	Matricula+  5      $
 Departamento��6%    6;   �� *Departamento+  5      $
 Grado��6%    64   �� *Grado+  5       $
 Nombre��6%    65   �� *Nombre+  5!      $
 Apellido��6%    67   �� *
Apellido+  5"      $
 	Condicion��6%    68   �� *	Condicion+  5#      $
 FechaHoraAlta��6%    6<   �� *FechaHoraAlta+5%      �� 5&   
   -   5         ��Name$ tbGrado��5(   5   $	��Top=�5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Grado:��5(       %  !MaterialDesignFloatingHintTextBox#��[  5)      $��4��6H   $��680,123,-56,0q�6X   $��36��6o   $��2��6{   �� 5*   
   -   5        $ tbNombre��5,   6   $	��Top=�5+      $ Nombre:��5,      #��[  5-      $��4��6H   $��678,181,-55,0q�6X   $��33��6o   $��2��6{   �� 5.   
   -   5        $ 
tbApellido��50   8   $	��Top=�5/      $ 	Apellido:��50      #��[  51      $��4��6H   $��679,231,-54,0q�6X   $��33��6o   $��2��6{   �� 52   
   -   5        $ tbMatricula��54   9   $	��Top=�53      $ 
Matricula:��54      #��[  55      $��4��6H   $��679,24,-55,0q�6X   $��33��6n   $��2��6z   �� 56   
   -   5        $ tbDepartamento��58   <   $	��Top=�57      $ Departamento:��58      #��[  59      $��4��6H   $��680,71,-56,0q�6X   $��33��6n   $��2��6z   �� 5:   
   -   5         ��Name$ 
btnCaptura��5:      $��Capturar Huella��5;        MaterialDesignRaisedButton#��[ 5=       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5>      $��4��6A   $��734,351,-6,0q�6Q   $��45��6g   $	��Top=�6s   $��2��6�   {�5<      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5>   �   �� 5?   
   -	   5        $ 
btnGuardar��5?      $��Guardar��5@      #��[ 5B      $/ )Resource name: MaterialDesignRaisedButton��5C      $��4��6A   $��733,418,-6,0q�6Q   $��38��6g   $	��Top=�6s   $��2��6�   {�5A      �� *DataContext.ControlsEnabled+ �� " � �� Mode$ FindAncestor=�5C   �   �� 5D   
   -
   5         ��Name$ imgVerHuella��5D       $��4��6   $!��Resources/autenticacion.png��66   $��Uniform=�6[   $y�Hidden=�6m   $
��Left=�6�   $��32��6�   $��532,257,0,0q�6�   $	��Top=�6�   $��31��6�   �� 5E   
   -   5        $ btnEliminar��5E      $��4��6&   $��Eliminar��66   $��733,540,-3,0q�6I   $	��Top=�6_   $��38��6�   $��2��6�   �� 5F   
   -   5        $ tbCondicion��5H   9   $	��Top=�5G      $ Condición:��5H      #��[  5I      $��4��6H   $��679,280,-55,0q�6X   $��33��6o   $��2��6{   �� 5J   
   -   5        $ btnActualizarEmpleado��5J      $��4��60   $��
Actualizar��6@   $��733,478,-5,0q�6U   $	��Top=�6k   $��43��6�   $��2��6�   �� 5K   
   -   5         ��Name$ lblCantidadEmpleados��5K      $��Total empleados: 0��6.   $��20(�6K   $
��Left=�6Y   $	��Top=�6t   $��706,642,0,0q�6�   $��4��6�   $��36��6�   $��2��6�   $	��231��6�    J� RenderTransformOrigin$ 1.036,0.529&�6�   �� 5L   
   -   5        $ 	btnBuscar��5L      $��4��6$   $��Buscar��64   $��730,599,-3,0q�6E   $	��Top=�6[   $��2��6s   $��38��6�   6�   5N      5O      