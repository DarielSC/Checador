   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5   	       
chk.Faltas   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:chk     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  Faltas��5	   	   $	��720��6   $
��1000��6%   .��5
      �  � Cursor$
 Hand��6   $��0,0,0,15q�6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��800 �6   �� 5      $	��100 �6   .+�5   
   �� -   5         ��Name$ tbMatricula��5   5   $	��Top=�5   	   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Matricula:��5   	    %  !MaterialDesignFloatingHintTextBox#��[  5   	   $��1��6D   $��64,278,459,0q�6T   $��33��6j   �� 5   
   -   5        $ tbNombre��5   6   $	��Top=�5      $ Nombre:��5      #��[  5      $��1��6H   $��64,344,459,0q�6X   $��33��6n   �� 5   
   -   5        $ 
tbApellido��5   8   $	��Top=�5      $ 	Apellido:��5      #��[  5      $��1��6H   $��64,409,460,0q�6X   $��32��6n   �� 5   
   -   5        $ tbCargo��5   5   $	��Top=�5      $ Grado:��5      #��[  5      $��1��6H   $��64,532,459,0q�6X   $��36��6n   �� 5    
   -   5        $ tbDepartamento��5"   <   $	��Top=�5!      $ Departamento:��5"      #��[  5#      $��1��6H   $��64,471,460,0q�6X   $��33��6n   �� 5$   
   $��Motivo Falta:��6   $��1��6(   $
��Left=�68   $��400,278,0,0q�6S   $	��Top=�6h   �� 5%   
   -   5         ��Name$ cbMotivoFalta��5%      $��1��6*   $
��Left=�6:   $��400,295,0,0q�6U   $	��Top=�6j   $	��277��6�   .@�5&      �� .��6   
Licencia6%   �� 5'      .��6   
Vacaciones6'   �� 5(      .��6   Azueto6#   �� 5)      .��6   Rebaja Domiciliada6/   �� 5*      .��6   Por Nupcias6(   �� 5+      .��6   Comision de Servicio61   �� 5,      .��6   
Maternidad6'   �� 5-      .��6   
Paternidad6'   �� 5.      .��6   Cita medica local6.   �� 5/      .��6   Cita medica foranea60   �� 50      .��6   Acompañante de cita medica67   �� 51      .��6   Permiso para llegar tarde66   �� 52      .��6   FALTA NO JUSTIFICADA61   53      �� 54   
   -   5         ��Name$ 
btnGuardar��54      $��1��6%   $��Guardar Falta��65   $
��Left=�6M   $��322,617,0,0q�6h   $	��Top=�6}   $��43��6�   $	��130��6�   �� 55   
   -	   5        $ btnSeleccionar��55      $��1��6)   $!��Seleccionar motivo de falta��69   $
��Left=�6_   $��436,532,0,0q�6z   $	��Top=�6�   6�   �� 56   
   $��Fecha Inicio Falta:��6   $��1��6.   $
��Left=�6>   $��398,335,0,0q�6Y   $	��Top=�6n   (  "System.Windows.Controls.DatePicker  57   
   -
   5          Name$ dpFechaInicioFalta��57      $��1��61   $
��Left=�6A   $��400,364,0,0q�6\   $	��Top=�6q   �� 58   
   $��Fecha Fin Falta:��6   $��1��6+   $
��Left=�6;   $��395,424,0,0q�6V   $	��Top=�6k     59   
   -   5        $ dpFechaFinFalta��59      $��1��6.   $
��Left=�6>   $��400,448,0,0q�6Y   $	��Top=�6n   &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ dgFaltas��5:   +   	   AutoGenerateColumns$	 False��6=   
   CanUserAddRows$
 False��6Y      
IsReadOnly$
 True��6p   $��0,26,0,0q�6�   $	��213��6�   $	��Top=�6�   $��3��6  $
��Left=�6%  $
��1043��6@  ��6   ��    ColumnHeaderStyle 5;      �� 5<       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ IDFalta��6%      
Visibility$ Hidden=�6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	IDFalta+6R     5@      $ 	Matricula��6%    68   �� *	Matricula+  5A      $ Nombre��6%    65   �� *Nombre+  5B      $ Apellido��6%    67   �� *
Apellido+  5C      $ Departamento��6%   $ Hidden=�6]    6;   �� *Departamento+6]     5D      $ Grado��6%    64   �� *Grado+  5E      $ MotivoFalta��6%    6:   �� *MotivoFalta+  5F      $ FechaInicioFalta��6%    6?   �� *FechaInicioFalta+  5G      $ FechaFinFalta��6%    6<   �� *FechaFinFalta+5I      �� 5J   
   -   5        $��txtClock��5J      $
��Left=�6$   $	��Top=�6?   $��146,617,0,0q�6W   $��16(�6l   �� 5K   
   -   5        $ btnActualizarFalta��5K      $��Actualizar Falta��6-   $
��Left=�6H   $��495,617,0,0q�6c   $	��Top=�6x   $	��153��6�   $��1��6�   $��43��6�   �� 5L   
   -   5        $ 	btnBuscar��5L      $��Buscar Empleado��6$   $
��Left=�6>   $��128,617,0,0q�6Y   $	��Top=�6n   $	��148��6�   $��43��6�   $��1��6�   6�   5M      5N      