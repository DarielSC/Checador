   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5          chk.Comparativa   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:chk     5      -   5          � Title$  Comparativa de registros��5      $	��675��6(   $
��1110��65   .��5
      � $��	0,0,-8,-3q�6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��800 �6   �� 5      $	��200 �6   .+�5   
   �� $4��.Tabla Comparativa de Asistencias para el dia: ��6   $
��Left=�6I   $��	28,38,0,0q�6d   $	��Top=�6w   $	��492��6�   $��24(�6�    J� RenderTransformOrigin$ 0.329,0.103&�6�   $��1��6�   $��Arial)�6�   �� 5   
   -   5         ��Name$ lblFechaActual��5      $��24(�6(   $��Right=�66   $	��Top=�6R   $��0,40,3,0q�6j   $��1��6|   $��34��6�   $	��270��6�   $��Arial)�6�   $ 0.508,1.131&�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgAsistencia��5   +      AutoGenerateColumns$ False��6A      CanUserAddRows$ False��6]      
IsReadOnly$
 True��6t   $��0,90,28,303q�6�   $��Right=�6�   $	��330��6�   $��1��6�   $��2��6�   ��6   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Matrícula��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 68   �� *MatriculaRepetida+  5      $	 Nombre��6%   
 65   �� *Nombre+  5      $	 Apellido��6%   
 67   �� *
Apellido+  5      $	 Cargo��6%   
 64   �� *Cargo+  5      $	 Departamento��6%   
 6;   �� *Departamento+  5      $	 Fecha Asistencia��6%   
 6?   �� *FechaHoraAsistencia+ �� StringFormat$ {0:dd/MM/yyyy HH:mm}��5        5   
   -   5        $ dgFaltas��5   +   $ False��6=   $ False��6Y   $
 True��6p   $��0,95,539,309q�6�   $��Right=�6�   $	��320��6�   $��2��6�   ��6   ��  5        5       $	 
Matrícula��6%   
 68   �� *MatriculaNoRepetida+  5!      $	 Nombre��6%   
 65   �� *Nombre+  5"      $	 Apellido��6%   
 67   �� *
Apellido+  5#      $	 Cargo��6%   
 64   �� *Cargo+  5$      $	 Departamento��6%   
 6;   �� *Departamento+5&        5)   
   -   5        $ dgMotivosFaltas��5)   +   $ False��6D   $ False��6`   $
 True��6w   $��
281,92,0,0q�6�   $	��278��6�   $	��Top=�6�   $
��Left=�6�   $	��344��6  $��1��6  ��6   ��    ColumnHeaderStyle 5*      �� 5+       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    5-        5.      $	 IDFalta��6%      
Visibility$ Hidden=�6R   
 66   �� *	IDFalta+6R     5/      $	 	Matricula��6%   
 68   �� *	Matricula+  50      $	 Nombre��6%   
 65   �� *Nombre+  51      $	 Apellido��6%   
 67   �� *
Apellido+  52      $	 Departamento��6%   $ Hidden=�6]   
 6;   �� *Departamento+6]     53      $	 Grado��6%   
 64   �� *Grado+  54      $	 MotivoFalta��6%   
 6:   �� *MotivoFalta+  55      $	 FechaInicioFalta��6%   
 6?   �� *FechaInicioFalta+  56      $	 FechaFinFalta��6%   
 6<   �� *FechaFinFalta+58      5:      5;      