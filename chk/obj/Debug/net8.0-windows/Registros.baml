   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5   	       chk.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:chk     5   	   -   5          � Title$  TablaRegistroDeAsistencia��5   	   $	��450��6+   $	��800��68   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgFechaHoraAsistencia��5
   +      AutoGenerateColumns$ False��6J      CanUserAddRows$ False��6f      
IsReadOnly$
 True��6}   $��0,112,0,111q�6�   $��Center=�6	  $	��780��6&  ��6   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
IDRegistro��6%   	   
Visibility$	 Hidden=�6X   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *
IDRegistro+6X     5      $ 	Matricula��6%   
 68   �� *	Matricula+  5      $ Nombre��6%   
 65   �� *Nombre+  5      $ Apellido��6%   
 67   �� *
Apellido+  5      $ Departamento��6%   
 6;   �� *Departamento+  5      $ Grado��6%   
 64   �� *Grado+  5      $ FechaHoraAsistencia��6%   
 6B   �� *FechaHoraAsistencia+  5      $
 Foto��6%   $	 Hidden=�6L   
 63   �� *Foto+6L     5      $ Huella��6%   $	 Hidden=�6P   
 65   �� *Huella+6P   5      �� 5   
   $��Tablero de Asistencia ✅��6   $��Center=�62   $��0,26,0,0q�6O   $	��Top=�6a   $��Arial Black)�6y   ���#08426c$��36(�6�   $	��568��6�   5      5      