   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      chk.Comparativa   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:chk     -     � Title$  Comparativa de registros��$	��720��$
��1000��.���  � ColumnDefinitions �� $	��100 ��� $	��800 ��� $	��100 �.+�&   System.Windows.Controls.DataGrid  -     Name$ 
dgComparar��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   
IsReadOnly$
 True��$��12,122,0,51q�$
��Left=�$	��404��$��1������    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$ 	 Matriculas con Asistencia ��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *MatriculaRepetida+  $	 Matriculas sin Asistencia��
 �� *MatriculaNoRepetida+�� $4��.Tabla Comparativa de Asistencias para el dia: ��$
��Left=�$��	27,22,0,0q�$	��Top=�$	��492��$��24(� J� RenderTransformOrigin$ 0.329,0.103&�$��1��$��Arial)��� -    ��Name$ lblFechaActual��$��24(�$��Right=�$	��Top=�$��0,24,8,0q�$��1��$��34��$	��270��$��Arial)��� -    ��Name$ tbBuscar��$��1��$
��Left=�$��453,118,0,0q� �� TextWrapping$
 Wrap=�$��Buscar Matricula:��$	��Top=�$	��207��$��42��$��14(��� -    ��Name$ 	btnBuscar��$��1��$��Buscar��$��696,126,26,0q�$	��Top=�$��1��$��44���� -   $ lblMatricula��$��	Matricula��$
��Left=�$��452,210,0,0q�$	��Top=�$��28��$	��163��$��1��$��14(��� -   $ 	lblNombre��$��1��$��Nombre��$
��Left=�$��455,256,0,0q�$	��Top=�$��26��$	��156��$��14(��� -   $ lblApellido��$��1��$��Apellido��$
��Left=�$��457,304,0,0q�$	��Top=�$��28��$	��154��$��14(��� -	   $ lblGrado��$��1��$��Grado:��$
��Left=�$��459,344,0,0q�$	��Top=�$��27��$	��104��$��14(��� -
   $ lblDepartamento��$��1��$��Departamento��$
��Left=�$��457,379,0,0q�$	��Top=�$��14(��� -   $ lblFechaHoraAsistencia��$��1��$��FechaHoraAsistencia��$
��Left=�$��460,417,0,0q�$	��Top=�$	��139��$��14(�