   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5   	       chk.Empleados   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:chk  5   	   -   5          � Title$  	Empleados��5	   	   $	��720��6   $
��1080��6(   .��5
      �  � Cursor$
 Hand��6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��0 �6   �� 5      $
��Auto �6   �� 5      $��0 �6   �� 5      $	��800 �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEmpleados��5   +      AutoGenerateColumns$ False��6@      CanUserAddRows$ False��6\      
IsReadOnly$
 True��6s   $��10,24,340,0q�6�   $	��654��6�   $	��Top=�6  $��4��6  ��6   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      
Visibility$ Hidden=�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 	Matricula��6%    68   �� *	Matricula+  5      $
 Departamento��6%    6;   �� *Departamento+  5       $
 Cargo��6%    64   �� *Cargo+  5!      $
 Nombre��6%    65   �� *Nombre+  5"      $
 Apellido��6%    67   �� *
Apellido+5$      �� 5%   
   -   5         ��Name$ tbCargo��5'   5   $	��Top=�5&      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cargo:��5'       %  !MaterialDesignFloatingHintTextBox#��[  5(      $��4��6H   $��513,123,10,0q�6X   $��36��6n   �� 5)   
   -   5        $ tbNombre��5+   6   $	��Top=�5*      $ Nombre:��5+      #��[  5,      $��4��6H   $��513,174,10,0q�6X   $��33��6n   �� 5-   
   -   5        $ 
tbApellido��5/   8   $	��Top=�5.      $ 	Apellido:��5/      #��[  50      $��4��6H   $��513,224,10,0q�6X   $��33��6n   �� 51   
   -   5        $ tbMatricula��53   9   $	��Top=�52      $ 
Matricula:��53      #��[  54      $��4��6H   $��513,26,10,0q�6X   $��33��6m   �� 55   
   -   5        $ tbDepartamento��57   <   $	��Top=�56      $ Departamento:��57      #��[  58      $��4��6H   $��513,76,10,0q�6X   $��33��6m   �� 59   
   -   5         ��Name$ 
btnCaptura��59      $��Capturar Huella��5:        MaterialDesignRaisedButton#��[ 5<       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5=      $��4��6A   $��564,319,60,0q�6Q   $��45��6g   $	��Top=�6s   {�5;      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5=   �   �� 5>   
   -	   5        $ 
btnGuardar��5>      $��Guardar��5?      #��[ 5A      $/ )Resource name: MaterialDesignRaisedButton��5B      $��4��6A   $��564,396,62,0q�6Q   $��38��6g   $	��Top=�6s   {�5@      �� *DataContext.ControlsEnabled+ �� " � �� Mode$ FindAncestor=�5B   �   �� 5C   
   -
   5         ��Name$ imgVerHuella��5C       $��4��6   $!��Resources/autenticacion.png��66   $��Uniform=�6[   $y�Hidden=�6m   $
��Left=�6�   $��32��6�   $��532,257,0,0q�6�   $	��Top=�6�   $��31��6�   �� 5D   
   -   5        $ btnEliminar��5D      $��4��6&   $��Eliminar��66   $
��Left=�6I   $��564,470,0,0q�6d   $	��Top=�6y   $	��174��6�   $��37��6�   �� 5E   
   -   5        $ btnListaAsis��5E      $��4��6'   $��Lista de asistencia��67   $
��Left=�6U   $��564,542,0,0q�6p   $	��Top=�6�   $	��176��6�   $��38��6�   6�   �� 5F   
   -   5        $ btnListaFalta��5F      $��4��6(   $��Lista de falta��68   $
��Left=�6Q   $��562,613,0,0q�6l   $	��Top=�6�   $	��176��6�   $��41��6�   6�   5G      5H      