   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5      1    +Terminal.Component.Controls.ReadOnlyRichBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Terminal.Component.Controls     5      $��16(�5        � 	Resources  5	       �� 
TargetType �� Property �� Value��%X   'J�       �� 5
   
   " J�6   .�5      ��  �@��Margin$ 0q�6'   5      5      .��5      � $��Center=�6   .+�5   
   �� -   5         ��Name$ 
txbRichBox��5      $��20(�6)   $
��Wrap=�68    J� Opacity$ 0Q�6L   �� 5   
   -   5         ��Name$ 
rtbRichBox��5      
������ $��17(�6�   $��0q�6�    �� 
IsReadOnly . ��6+   ��  �� ElementName$ 
txbRichBox��	 �� Path$	 ActualWidth�   RichTextBoxWidthConvert
 �� 	Converter#
 [  6�   5      5      