   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      chk.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  localclr-namespace:chk  -     � Title$  Tablero��$	��720��$
��1080�� � Icon$ /Resources/icono.png��.��� $��	0,10,0,-6q� � ColumnDefinitions �� �� $	��300 ��� $	��300 ��� ����  �� ImageSource$ /Resources/background.png�� j� Stretch$ UniformToFill=�.+�#  MaterialDesignThemes.Wpf.Card  $��1��$��	0,156,0,0q�$��Center=�$	��200��$	��413��$	��Top=�.��� $��0,0,0,24q� � RowDefinitions �� $	��140 ��� $��* ��� $
��Auto �.+��� $��/Resources/2808392.png��$��UniformToFill=�$��2��$��Center=�$	��200��$	��200��$	��Top=��� -    ��Name$ btnEmpleados��$��1��$��0,88,0,0q�$	��Top=� *  &MaterialDesignFloatingActionMiniButton#��[  $��Center=�$��40��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountEdit=�$��30��$��30���� $��1��$��
8,147,8,18q�.+��� $
��Wrap=�$��Arial Black)�$��Center=�$��Center=��� $�AGREGAR Y EDITAR ����  � Language$ es-mx�$� ���� $�USUARIOS���� $��2��$��8q�$��Right=�	 �� Orientation$	 
Horizontal=�  $��2��$��
48,157,0,0q�$
��Left=�$	��200��
 J� RenderTransformOrigin$
 0.5,0.5&�$	��413��$	��Top=�z�V� .~��� ��  �� AngleX$ 0.213Q��� T�  T� X$ 0.996Q�.��� $��0,0,0,24q� �� $	��140 ��� $��* ��� $
��Auto �.+��� $��/Resources/Huella.jpg��$��UniformToFill=�$��2��$��Center=�$	��200��$	��200��$	��Top=��� -   $ btnChecador��$��1��$��0,87,0,0q�$	��Top=�#��[  $��Center=�$��40��.��  $ Fingerprint=�$��30��$��30���� $��1��$��
9,144,7,21q�.+��� $��CHECADOR��$
��Wrap=�$��Arial Black)�$��Center=�$��Center=��� $��2��$��8q�$��Right=�$	 
Horizontal=��� 
���   �$��4�����#08426c$	��100��$	��Top=��� $$��Tablero de Administración ⚓��$
��Left=�$��	52,18,0,0q�$	��Top=�$��36(�$
��Bold"�
�������$��58��$��2��$	��508��$��1���� -   $ btnRespaldo��$��Realizar Respaldo��$
��Left=�$��77,622,0,46q��� -   $ btnCerrarSesion��$��3��$��Cerrrar Sesion��$��Right=�$��0,622,79,46q�$	��137���� -   $ btnRegistroEventos��$��3��$��Registro de eventos��$��
0,156,27,0q�$	��Top=�$��41��$��Right=�$	��165���� -   $ btnListaAsistencia��$��1��$��Lista de Asistencia��$
��Left=�$��
20,622,0,0q�$	��170��$��32��$	��Top=��� -   $ btnListaFaltas��$��2��$��Lista de Faltas��$
��Left=�$��128,622,0,0q�$	��150��$��32��$	��Top=��� -	   $ btnUsuarios��$��Usuarios��$
��Left=�$��
77,156,0,0q�$	��Top=�$��41��$	��115���� -
   $ btnComparar��$��1��$��Lista Comparativa��$��Center=�$��	0,622,0,0q�$	��Top=�$��2��