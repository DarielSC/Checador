   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      chk.Usuarios   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:chk     -     � Title$  Registro de Usuarios��$	��720��$
��1000��.���  � ColumnDefinitions �� $	��100 ��� $	��800 ��� $	��100 �.+�&   System.Windows.Controls.DataGrid  -     Name$ 
dgUsuarios��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   
IsReadOnly$
 True��$��1��$��	3,10,0,50q�$
��Left=�$	��552������    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��
   
Visibility$
 Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $	 	Matricula�� �� *	Matricula+  $		 Rol�� �� *Rol+  $	 FechaRegistro�� �� *FechaRegistro+  $	 
Contrasena�� �� *
Contrasena+�� -    ��Name$ 	tbUsuario��$��1��$
��Left=�$��
576,41,0,0q� �� TextWrapping$
 Wrap=�$��	Matricula��$	��Top=�$	��198��$��38��G� -    G�Name$ tbContrasena��$��1��$
��Left=�$��576,136,0,0q�$	��Top=�$	��190��$��35���� $��1��$��Contraseña:��$
��Left=�$��576,107,0,0q�$	��Top=�$��99���� -    ��Name$ cbRol��$��1��$
��Left=�$��576,230,0,0q�$	��Top=�$	��190��$��37��.@��� $��admin���� $	��mod���� -    ��Name$ btnRegistar��$��1��$��Registrar Usuario��$��600,392,50,277q��� -   $ btnSeleccionar��$��1��$��Seleccionar Rol��$��598,334,53,334q� J� RenderTransformOrigin$ 0.5,0.5&��� $��1��$	��Rol��$
��Left=�$��576,201,0,0q�$	��Top=�