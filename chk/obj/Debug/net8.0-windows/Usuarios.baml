   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5          chk.Usuarios   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:chk     5      -   5          � Title$  Registro de Usuarios��5      $	��720��6$   $
��1000��61   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��800 �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgUsuarios��5         AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         
IsReadOnly$
 True��5      $��
18,30,0,30q�5      $
��Left=�5      $	��750��5      $��2��5   B   ��5      ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   
   
Visibility$
 Hidden=�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5#      $	 	Matricula��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6V    68   �� *	Matricula+6V     5$      $	 Nombre��6%   $	 150 6P    65   �� *Nombre+6P     5%      $	 Apellido��6%   $	 150 6T    67   �� *
Apellido+6T     5&      $		 Rol��6%   $	 100 6J    62   �� *Rol+6J     5'      $	 Fecha Registro��6%   $	 150 6�    6=   �� *FechaRegistro+ �� StringFormat$ {0:dd/MM/yyyy HH:mm}��6�     5(      $	 Contraseña��6%   $
 Hidden=�6X    69   �� *
Contrasena+6X   5+      �� 5.   
   -   5         ��Name$ 	tbUsuario��5.      $��1��6%   $
��Left=�65   $��
690,37,0,0q�6P    �� TextWrapping$
 Wrap=�5/      $��
Matrícula��6&   $	��Top=�67   $	��198��6O   $��38��6[   $��2��6g   G� 51   
   -   5         G�Name$ tbContrasena��51      $��1��6,   $
��Left=�6<   $��670,136,0,0q�6W   $	��Top=�52      $	��190��6.   $��35��6:   $��2��6F   �� 54   
   $��1��6   $��Contraseña:��6    $
��Left=�66   $��686,110,0,0q�6Q   $	��Top=�55      $��99��6(   �� 57   
   -   5         ��Name$ cbRol��57      $��1��6"   $
��Left=�62   $��675,230,0,0q�6M   $	��Top=�58      $	��190��6+   $��37��67   $��2��6C   .@�59      �� $��admin��6   �� 5:      $	��mod��6   5;      �� 5=   
   -   5         ��Name$ btnRegistrar��5=      $��1��6'   $��Registrar Usuario��67   $��701,383,49,289q�6S   $��2��5>   ,   �� 5@   
   -   5        $ btnSeleccionar��5@      $��1��6)   $��Seleccionar Rol��69   $��700,316,51,356q�6S    J� RenderTransformOrigin$ 0.5,0.5&�5A      $��2��6N   �� 5C   
   $��1��6   $	��Rol��6    $
��Left=�6.   $��675,210,0,0q�6I   $	��Top=�5D      �� 5F   
   -   5        $ btnEliminar��5F      $��1��6&   $��Eliminar Usuario��66   $��703,446,47,226q�6Q   $��2��5G   #   5I      5J      