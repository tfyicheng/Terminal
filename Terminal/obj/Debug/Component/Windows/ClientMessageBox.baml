   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Terminal.Component.WindowsTerminal.Component.Windows  5   	   1    +Terminal.Component.Windows.ClientMessageBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Terminal.Component.Windows     5   	   -   5          � Title$  ClientMessageBox��5   	   $	��196��6#   $	��432��60    � WindowStyle$
 None=�6<    � 
ResizeMode$ NoResize=�6O    � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=�6{   
������  J� Effect 5	      3  -System.Windows.Media.Effects.DropShadowEffect  5
   
      Color$ #888888��6      ShadowDepth$ 0Q�6+      Opacity$	 0.4Q�6;   '  !System.Windows.Shell.WindowChrome	   WindowChrome	 5        5   
   
   UseAeroCaptionButtons
 .     GlassFrameThickness$ -1q�65      CaptionHeight$	 196Q�6N    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�6&    W� From$ 0X�6J   	 W� To$ 1X�6S    g� Duration$ 0:0:0.3D�6Z   5      5      5      .��5      � $	��186��6   $	��422��6   ���#FFFFFF J� Clip 5   
   �� 5       �� RadiusX$ 5Q�6     �� RadiusY$ 5Q�6,    �� Rect 5      � 5       � Height$	 186Q�6    � Width$	 422Q�6(   5       � RowDefinitions 5    
   �� 5!      $��40 �6   �� 5"      $	��146 �6   .+�5$   
   �� $��0��6    �� Padding$ 	15,0,15,0q�6   ._�5%      � .+�5&      �� $
��Left=�6   $��Center=�67   $��18(�6R   ���#303133   Hint#���   6u   �� 5'      -   5         ��Name$ txbClose��5'      $��Right=�6.   $��Center=�6J     TextBlockIconDanger#��[ 6e     ElementIcon2#��[ 6�   ���#909399$��21(�6�   $	����6�    � Cursor$
 Hand��6�      IsHitTestVisibleInChrome . 6Z  5(      5)      �� 5*   
   $��1��6   $ 15,10,15,10q�6   ._�5+      ]� .+�5,      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R    . .+�5-      �� -   5         ��Name$ btnLeft��5-        ButtonElementWait#��[ 6.   $��30��6Y   $��80��6e   $��	15,0,15,0q�6s   $��12(�6�   
  � Tag$  1��6�   6�   �� 5.      -   5        $ btnRight��5.        ButtonPrimaryWait#��[ 6/   $��30��6Z   $��80��6f   $��10,0,0,0q�6t   $��	15,0,15,0q�6�   $��12(�6�   $  2��6�   6�   5/      ]� 50      $��Bottom=�6   .+�51      �� $��0,0,8,0q�6    #��[ 61   $��24(�6\   ���#E6A23C$	����6   $
��Left=�6�   �� 52      -   5        $ 
txbMessage��52       $
��Wrap=�64   $��16(�6H   ! �� 
LineHeight$! 24��6V   " �� LineStackingStrategy$" BlockLineHeight=�6f   ���#606266$
��Left=�6�   53      54      55      � 56   
   -   5        # �Name$# grdMask��56      $��2��6    
������ $y�	Collapsed=�6J   57      58      