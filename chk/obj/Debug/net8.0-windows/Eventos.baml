   M S B A M L   `   `   `  ����>  :chk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chkchk  5          chk.Eventos   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:chk     5      -   5          � Title$  Registro de Eventos��5      $	��720��6#   $
��1080��60   .��5
      � -   5         � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��800 �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgEventos��5   +      AutoGenerateColumns$ False��6>      CanUserAddRows$ False��6Z      
IsReadOnly$
 True��6q   $��50,0,0,0q�6�   $	��506��6�   $��Center=�6�   $��3��6  $
��Left=�6*  $
��1020��6E  ��6   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 IDEvento��6%   
   
Visibility$
 Hidden=�6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
IDEvento+6T     5      $	 	FechaHora��6%    68   �� *	FechaHora+  5      $	 Accion��6%    65   �� *Accion+  5      $	 Detalle��6%    66   �� *	Detalle+5      �� 5   
   $*��$Tablero de Eventos 👁️‍🗨️��6   $
��Left=�65   $��
190,40,0,0q�6P   $	��Top=�6d   $��Arial Black)�6|   ���#08426c$��40(�6�   $	��500��6�   $��1��6�   5!      5"      