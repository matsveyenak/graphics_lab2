   M S B A M L   `   `   `  ���� @  <lab_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab_2lab_2      lab_2.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:lab_2       � Title$  Metadata��$	��600��$	��800��.��� .+�� $
��Auto�����#FFF$	��Top=�$��Stretch=�$��0 25 0 0q� � ColumnDefinitions �� $��* ��� $��* ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+�� $
��Auto��$��1��$��0�� �� $��* � �� $
��Auto ��� $��* �.+��� $��0��$��1�� �� TextAlignment$ Center=�$��Center=�$��30(�$
��Bold"�$��Image Metadata��
���   ��� -    ��Name$ warning_textbox��$��1��$��1��$��0 10 0 0q�$��14(�$��Regular"�$y�Visible=�$
��Wrap=�
�������$��Center=�$ Center=�$@��:Supported file extensions: 
 jpg, gif, tif, bmp, png, pcx ��� $
��Auto��$��1��$��1��$��0 25 0 0q� �� $��* ��� $��* � �� $
��Auto �.+��� -   $��0��$��0��$��Select file��$��80��$��Center=�$��Center=��� -   $��1��$��0��$��Select folder��$��80��$��Center=�$	��Top=�&   System.Windows.Controls.DataGrid  -   $��gridList��$��0��$��2��$��3��$��Center=�$��Center=�   AutoGenerateColumns .     CanUserAddRows .     CanUserResizeColumns . $
��Auto��$	��700��$	��450��$��	0 25 0 25q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 	File name��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Name+  $	 
Image size��
 �� *Size+  $		 DPI��
 �� *DPI+  $	 Color depth (bpp)��
 �� *Depth+  $	 Compression type��
 �� *Compression+