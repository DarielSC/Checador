   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5   	       chk.Empleados   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:chk  5   	   -   5          � Title$  	Empleados��5	   	   $	��720��6   $
��1080��6(   .��5
      �  � Cursor$
 Hand��6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��0 �6   �� 5      $
��Auto �6   �� 5      $��0 �6   �� 5      $	��800 �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEmpleados��5   +      AutoGenerateColumns$ False��6@      CanUserAddRows$ False��6\      
IsReadOnly$
 True��6s   $��29,18,322,415q�6�   $��4��6�   ��6   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      
Visibility$ Hidden=�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 	Matricula��6%    68   �� *	Matricula+  5      $
 Departamento��6%    6;   �� *Departamento+  5       $
 Cargo��6%    64   �� *Cargo+  5!      $
 Nombre��6%    65   �� *Nombre+  5"      $
 Apellido��6%    67   �� *
Apellido+  5#      $

 Foto��6%   $ Hidden=�6L    63   �� *Foto+6L     5$      $
 Huella��6%   $ Hidden=�6P    65   �� *Huella+6P   5&      �� 5'   
   -   5         ��Name$ tbCargo��5)   5   $	��Top=�5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cargo:��5)       %  !MaterialDesignFloatingHintTextBox#��[  5*      $��4��6H   $��513,123,10,0q�6X   $��36��6n   �� 5+   
   -   5        $ tbNombre��5-   6   $	��Top=�5,      $ Nombre:��5-      #��[  5.      $��4��6H   $��513,174,10,0q�6X   $��33��6n   �� 5/   
   -   5        $ 
tbApellido��51   8   $	��Top=�50      $ 	Apellido:��51      #��[  52      $��4��6H   $��513,224,10,0q�6X   $��33��6n   �� 53   
   -   5        $ tbMatricula��55   9   $	��Top=�54      $ 
Matricula:��55      #��[  56      $��4��6H   $��513,26,10,0q�6X   $��33��6m   �� 57   
   -   5        $ tbDepartamento��59   <   $	��Top=�58      $ Departamento:��59      #��[  5:      $��4��6H   $��513,76,10,0q�6X   $��33��6m   �� 5;   
   -   5         ��Name$ imgFoto��5;       $��4��6   $
��Left=�61   $	��171��6L   $��579,357,0,0q�6Y   $	��Top=�6n   $	��185��6�   �� 5<   
   
���   �$��1q�6%   $��4��69   $
��Left=�6I   $	��172��6d   $��579,357,0,0q�6q   $	��Top=�6�   $	��190��6�   �� 5=   
   -	   5         ��Name$ btnFoto��5=      $��Editar Foto��5>        MaterialDesignRaisedButton#��[ 5@       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5A      $��4��6A   $��570,588,27,0q�6Q   $
 Hand��6g   $��32��6u   $	��Top=�6�   {�5?      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5A   �   �� 5B   
   -
   5        $ 
btnCaptura��5B      $��Capturar Huella��5C      #��[ 5E      $/ )Resource name: MaterialDesignRaisedButton��5F      $��4��6A   $��586,305,38,0q�6Q   $��32��6g   $	��Top=�6s   {�5D      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5F   �   �� 5G   
   -   5        $ 
btnGuardar��5G      $��Guardar��5H      #��[ 5J      $/ )Resource name: MaterialDesignRaisedButton��5K      $��4��6A   $��585,639,42,0q�6Q   $��32��6g   $	��Top=�6s   {�5I      �� *DataContext.ControlsEnabled+ �� " � �� Mode$ FindAncestor=�5K   �   �� 5L   
   -   5        $ 	tbUrlFoto��5N   /   $	��Top=�5M      $  ��5N       �� 
IsReadOnly$
 True��6B   #��[  5O      $��4��6H   $��568,529,24,0q�6X   $��46��6n   �� 5P   
   -   5        $ imgVerHuella��5P       $��4��6   $!��Resources/autenticacion.png��66   $��Uniform=�6[   $y�Hidden=�6m   $
��Left=�6�   $��32��6�   $��532,257,0,0q�6�   $	��Top=�6�   $��31��6�   5Q      5R      