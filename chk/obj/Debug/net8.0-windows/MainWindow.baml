   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5   	       chk.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:chk  5   	   -   5          � Title$  Tablero��5
   	   $	��720��6   $
��1080��6&    � Icon$ /Resources/icono.png��63   .��5      � $��	0,10,0,-6q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��300 �6   �� 5      $	��300 �6   �� 5      ��5   
   �� 5       �� ImageSource$ /Resources/background.png��6    j� Stretch$ UniformToFill=�6A   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   $��	0,156,0,0q�6.   $��Center=�6A   $	��200��6^   $	��413��6j   $	��Top=�6w   .��5      � $��0,0,0,24q�6    � RowDefinitions 5      �� 5      $	��140 �5      �� 5      $��* �5      �� 5      $
��Auto �5       .+�5"      �� $��/Resources/2808392.png��5#      $��UniformToFill=�5$      $��2��6-   $��Center=�6>   $	��200��6[   $	��200��6g   $	��Top=�6t   �� 5%      -   5         ��Name$ btnEmpleados��5%      $��1��5&      $��0,88,0,0q�5'      $	��Top=�5(       *  &MaterialDesignFloatingActionMiniButton#��[  5)      $��Center=�6U   $��40��6r   .��5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountEdit=�5+      $��30��6,   $��30��68   5,      �� 5-      $��1��6   $��
8,147,8,18q�6*   .+�5.      �� $
��Wrap=�5/      $��Arial Black)�6-   $��Center=�6F   $��Center=�6a   �� 6   $�AGREGAR Y EDITAR ��6�   �� 6�   $� ��6�   �� 6�    � Language$ es-mx�6�   $�	EMPLEADOS��6�   �� 6�   �� 6�   $ es-mx�6�   6�   50      �� 51      $��2��52      $��8q�53      $��Right=�54      	 �� Orientation$	 
Horizontal=�55      56      57      58        59   
   $��2��6   $��
48,157,0,0q�6.   $
��Left=�6B   $	��200��6]   
 J� RenderTransformOrigin$
 0.5,0.5&�6i   $	��413��6�   $	��Top=�6�   z�5:      V� 5;      .~�5<      �� �� 5=       �� AngleX$ 0.213Q�6$   �� 5>      T� 5?       T� X$ 0.996Q�6)   5@      .��5B      � $��0,0,0,24q�6    5C      �� 5D      $	��140 �5E      �� 5F      $��* �5G      �� 5H      $
��Auto �5I      .+�5K      �� $��/Resources/Huella.jpg��5L      $��UniformToFill=�5M      $��2��6-   $��Center=�6>   $	��200��6[   $	��200��6g   $	��Top=�6t   �� 5N      -   5        $ btnChecador��5N      $��1��5O      $��0,87,0,0q�5P      $	��Top=�5Q      #��[  5R      $��Center=�6U   $��40��6r   .��5S        $ Fingerprint=�5T      $��30��6,   $��30��68   5U      �� 5V      $��1��5W      $��
9,144,7,21q�5X      .+�5Y      �� $��CHECADOR��5Z      $
��Wrap=�5[      $��Arial Black)�6-   $��Center=�6F   $��Center=�6a   5\      �� 5]      $��2��5^      $��8q�5_      $��Right=�5`      $	 
Horizontal=�5a      5b      5c      5d      �� 5e   
   
���   �$��4��6#   ���#08426c$	��100��6F   $	��Top=�6S   �� 5f   
   $$��Tablero de Administración ⚓��6   $
��Left=�66   $��	18,18,0,0q�6Q   $	��Top=�6d   $��36(�6|   $
��Bold"�6�   
�������$��58��6�   $��2��6�   $	��508��6�   $��1��6�   �� 5g   
   -   5        $ btnRespaldo��5g      $��Realizar Respaldo��6&   $
��Left=�6B   $��77,622,0,46q�6]   6r   �� 5h   
   -   5        $ btnCerrarSesion��5h      $��3��6*   $��Cerrrar Sesion��6:   $��Right=�6S   $��0,622,79,46q�6o   $	��137��6�   6�   �� 5i   
   -   5        $ btnRegistroEventos��5i      $��3��6-   $��Registro de eventos��6=   $��
0,156,27,0q�6[   $	��Top=�6o   $��41��6�   $��Right=�6�   $	��165��6�   �� 5j   
   -   5        $ btnListaAsistencia��5j      $��1��6-   $��Lista de Asistencia��6=   $
��Left=�6[   $��
20,622,0,0q�6v   $	��170��6�   $��32��6�   $	��Top=�6�   �� 5k   
   -   5        $ btnListaFaltas��5k      $��2��6)   $��Lista Motivos Falta��69   $
��Left=�6W   $��120,622,0,0q�6r   $	��150��6�   $��32��6�   $	��Top=�6�   �� 5l   
   -	   5        $ btnUsuarios��5l      $��Usuarios��6&   $
��Left=�69   $��
77,156,0,0q�6T   $	��Top=�6h   $��41��6�   $	��115��6�   6�   �� 5m   
   -
   5        $ btnComparar��5m      $��1��6&   $��Lista Comparativa��66   $��Center=�6R   $��	0,622,0,0q�6o   $	��Top=�6�   $��2��6�   6�   �� 5n   
   -   5         ��Name$ 	lblSaludo��5n      $��236,28,10,0q�6#   $	��Top=�68   $��15(�6P   $
��Bold"�6^   
�������$��47��6�   $��2��6�   $��2��6�   5o      5p      