   M S B A M L   `   `   `  ����D  @TheBasics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TheBasics	TheBasics  5   	       TheBasics.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TheBasics     5   	     � Title$  
Wpf Basics��5   	   $	��800��6   $	��400��6)    � WindowStartupLocation$ CenterScreen=�65   .��5      ��  �� Padding$ 10q�6   ._�5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��Apply��6)   $��0 0 10 0q�69   �� 5      $��1��6   $��Reset��6)   �� 5      $��2��6   $��Refresh��6)   $��10 0 0 0q�6;   5      �� 5      $��Pulse Properties��6   $
��Bold"�60   $
��0 10q�6B   �� 5      $��Description��6   �� 5      $��2q�6   � 5!       5"      �� 5#      $��2* �6'   �� 5$      $��* �6'   .+�5'      �� $��0��6   $��0 0 10 0q�6-   .+�5(      �� $��Status��6    �� 5)       �� 
IsReadOnly$
 True��6   ���#eee$��2q�6B   5*      �� 5+      $��1��6   .+�5,      �� $��Revision��6    �� 5-      $
 True��6   ���#eee$��2q�6B   5.      5/      �� 51      $��Part Number��6   �� 52      $
 True��6   ���#eee$��2q�6:   �� 55      $��Raw Material��6   $
��Bold"�6,   $
��0 10q�6>   �� 57      $��Material��6   �� 58      $��2q�6   �� 5;      $��Manufacturing Information��6   $
��Bold"�69   $
��0 10q�6K   �� 5=      $��Work Center��6   $��0 0 0 5q�6+   � 5?       5@      �� 5A      $��* �6'   �� 5B      $��* �6'   .+�5D      �� $��0��6   .+�5E      �� $
��Weld��6   �� 5F      $��Assembly��6   �� 5G      $��Plasma��6   �� 5H      $��Laser��6   �� 5I      $��Purchase��6   5J      �� 5K      $��1��6   .+�5L      �� $��Lathe��6   �� 5M      $��Drill��6   �� 5N      $
��Fold��6   �� 5O      $
��Roll��6   �� 5P      $	��Saw��6   5Q      5S      �� 5U      $��Length��6   $��0 10 0 0q�6&   �� 5V      $��2q�6   �� 5W      $
��Mass��6   $��0 10 0 0q�6$   �� 5X      $
 True��6   ���#eee$��2q�6:   �� 5Y      $��Finish��6   $��0 10 0 0q�6&   �� 5Z       �� SelectedIndex$ 0��6   $��2q�6)   .@�5[      �� $��Painted��6   �� 5\      $��Not Painted��6   5]      �� 5^      $��Purchase Information��6   $��0 10 0 0q�64   �� 5_      $ 0��6   $��2q�6)   .@�5`      �� $��Rubber��6   �� 5a      $��
Not Rubber��6   5b      �� 5d      $��Supplier Name��6   $��0 10 0 0q�6-   �� 5e      $��2q�6   �� 5f      $��Supplier Code��6   $��0 10 0 0q�6-   �� 5g      $��2q�6   �� 5h      $��Additional Information��6   $
��Bold"�66   $
��0 10q�6H   �� 5i      $
��Note��6   �� 5j      $��2q�6   5k      5l      5m      