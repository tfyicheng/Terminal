   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Terminal.Component.WindowsTerminal.Component.Windows  5   	   *    $Terminal.Component.Windows.VoiceSend   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Terminal.Component.Windows     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      -   5          � WindowStyle$
  None=�5      
������  � Title$ 语音发送��5	   
   $	��350��6   $	��290��6$    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V    � Icon$/ )pack://application:,,,/Resources/drcs.ico��6l    J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$ #888888��6      ShadowDepth$ 0Q�6+      Opacity$	 0.3Q�6;   '  !System.Windows.Shell.WindowChrome	   WindowChrome	 5        5   
   
   UseAeroCaptionButtons
 .     GlassFrameThickness$ -1q�65      CaptionHeight$	 350Q�6N   .��5      � $	��340��6   $	��280��6   ���#FFFFFF � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $	��120 �6   .+�5   
   ��  K� ZIndex$ 99��6   $��0��6'    �� Orientation$ 
Horizontal=�64   $��Right=�6M   $	��Top=�6i      IsHitTestVisibleInChrome .  J� SnapsToDevicePixels . .+�5      �� -   5         ��Name$ btnMin��5         	ButtonMin#��[  6%   $��48��6H   $��50��6T   6_   �� 5      -   5        $ btnClose��5        ButtonClose#��[ 6'   $��48��6L   $��50��6X   6c   5      � 5   
   $��1��6   $	��150��6   $	��150��6(   ���#EEEEEE.+�5      ��   ElementIcon#��[ 6   $	����6B   $	��150(�6R   ���#07C15F$��Center=�6v   $��Center=�6�   6�   �� 5       $	��Top=�6   $��Center=�6-   $��Bottom=�6J   $��15(�6e   $��	0,0,0,-30q�6s   3:336�   5!      ]� 5#   
    . $��2��6C   $��Center=�6P   $��Center=�6k   $	��200��6�   $��40,0,0,0q�6�   .+�5%      � .+�5&      �� #��[ 6   $	����6C   $��18(�6V   ���#fff � Cursor$
 Hand��6v   
���  ��$��40��6�   $��40��6�   $��10q�6�   $
��Left=�6�   )  #HandyControl.Controls.BorderElement   CornerRadius$ 50��6�   $��0q�6�   6  �� 5(      $��Center=�6   $��Bottom=�69   $	��-10q�6T   取消6e   5)      � 5*      .+�5+      �� #��[ 6   $	����6C   $��18(�6W   ���#fff$
 Hand��6w   ���#07C15F$��40��6�   $��40��6�   $��Right=�6�   $ 50��6�   $��0q�6�   6  �� 5,      $��Center=�6   $��Bottom=�69   $	��-10q�6T   发送6e   5-      5.      5/      51      