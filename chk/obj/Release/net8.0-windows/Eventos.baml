   M S B A M L   `   `   `  ���� >  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk      chk.Eventos   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:chk     -     � Title$  Registro de Eventos��$	��720��$
��1080��.��� -    � ColumnDefinitions �� $	��100 ��� $	��800 ��� $	��100 �.+�&   System.Windows.Controls.DataGrid  -     Name$ 	dgEventos��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   
IsReadOnly$
 True��$��50,0,0,0q�$	��506��$��Center=�$��3��$
��Left=�$
��1020������    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 IDEvento��
   
Visibility$
 Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
IDEvento+  $	 	FechaHora�� �� *	FechaHora+  $	 Accion�� �� *Accion+  $	 Detalle�� �� *	Detalle+�� $*��$Tablero de Eventos 👁️‍🗨️��$
��Left=�$��
190,40,0,0q�$	��Top=�$��Arial Black)����#08426c$��40(�$	��500��$��1��