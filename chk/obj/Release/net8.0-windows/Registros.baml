   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      chk.Window1   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:chk     -     � Title$  TablaRegistroDeAsistencia��$	��450��$	��800��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dgFechaHoraAsistencia��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   
IsReadOnly$
 True��$��0,112,0,111q�$��Center=�$	��780������    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
IDRegistro��	   
Visibility$	 Hidden=�1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
IDRegistro+  $ 	Matricula��
 �� *	Matricula+  $ Nombre��
 �� *Nombre+  $ Apellido��
 �� *
Apellido+  $ Departamento��
 �� *Departamento+  $ Grado��
 �� *Grado+  $ FechaHoraAsistencia��
 �� *FechaHoraAsistencia+  $
 Foto��$	 Hidden=�
 �� *Foto+  $ Huella��$	 Hidden=�
 �� *Huella+�� $��Tablero de Asistencia ✅��$��Center=�$��0,26,0,0q�$	��Top=�$��Arial Black)����#08426c$��36(�$	��568��