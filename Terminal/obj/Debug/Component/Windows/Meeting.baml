   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Terminal.Component.WindowsTerminal.Component.Windows  5   	   (    "Terminal.Component.Windows.Meeting   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Terminal.Component.Windows     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   
     � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�6-    � 
ResizeMode$ NoResize=�5   ?    � Title$ 视频会议��5	   	   $	��860��6   $	��600��6&   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      UseAeroCaptionButtons .     NonClientFrameEdges$
 None=�65      CaptionHeight$ 40Q�6P   .��5      � -   5         �Name$
 Main��5      	 � RowDefinitions	 5   
   �� 5      $��50 �6    �� 5      $��* �6    �� 5      $	��120 �6    .+�5   
   � ���#333$��0q�6"   .+�5      �� ���#fff$��18(�6*   $��15,0,0,0q�69   $��Center=�6L   视频会议6m   �� 5      
 �� Orientation$
 
Horizontal=�6   $��Right=�64   $	��Top=�6P      IsHitTestVisibleInChrome .  J� SnapsToDevicePixels . .+�5      �� -   5         ��Name$ btnMin��5         	ButtonMin#��[  6*   $��48��6N   $��50��6Z   6e   �� 5      -   5        $ btnState��5        ButtonState#��[ 6+   $��48��6P   $��50��6\   6g   �� 5      -   5        $ btnClose��5        ButtonClose#��[ 6+   $��48��6P   $��50��6\   6g   5      5      � 5   
   $��1��6   .+�5"      �� -   5         ��Name$	 itc��5"        ItemsControlVirtualization#��[ 6+   ��5#      �� 5$      .R�5%      � 5&      ��5(      �� 5)      .R�5*      ��  ��Name$
 itcb��6#   
�������$��5q�6�    �� CornerRadius$ 15��6�   ��62   �� *color+��6P   �� *lenght+��6i   �� *lenght+._�5+      �� $��25(�6@   ��6(   �� *title+6P   5,      5-      5/      5;      � 5?   
   $��2��6   ���#333$��0q�60   .+�5@      � $
��Left=�6   $��10q�6.   .+�5A      ��   ElementIcon#��[ 6   $	����6D   $��25(�6W   ���#fff � Cursor$
 Hand��6w   ���#999$��40��6�   $��40��6�   $��10q�6�   )  #HandyControl.Controls.BorderElement   CornerRadius$ 50��6�   $��0q�6�   5B      �� 5C      $��Center=�6   $��Bottom=�6:   $��10q�6U   ���#FFF添加成员6y   5D      � 5E      $y�Visible=�6   $	��120��6)   $��Bottom=�67   .+�5F      �� $��Center=�6   $��5q�69   ���#fff$��13(�6W   00:006l   � 5G      $��Center=�6   $��Center=�69   $��10,0,0,0q�6W   .+�5J      � .+�5K      �� -   5        $
 jybt��5K   "   #��[ 6C   $	����6m   $��25(�6�   ���#fff$
 Hand��6�   ���#999$��40��6�   $��40��6�   $��10q�6�   $
��Left=�6�   $ 50��6�   $��0q�6  5L      �� 5M      -   5         ��Name$
 jytb��5M   $   $��Center=�62   $��Bottom=�6O   $	��-10q�6j   ���#FFF静音6�   5N      � 5P      .+�5Q      �� #��[ 6!   $	����6K   $��18(�6_   ���#fff$
 Hand��6   ���#FF6565$��40��6�   $��40��6�   $��
50,0,50,10q�6�   $ 50��6�   $��0q�6�   6	  �� 5R      $��Center=�6$   $��Bottom=�6A   $	��-10q�6\   ���#FFF挂断6   5S      � 5U      .+�5V      �� -   5        $ cameraB��5V   7   #��[ 6H   $	����6r   $��18(�6�   ���#fff$
 Hand��6�   ���#999$��40��6�   $��40��6�   $��
15,0,15,10q�6�   $ 50��6�   $��0q�6  5W      �� 5X      -	   5        $ cameraT��5X   %   $��Center=�66   $��Bottom=�6S   $	��-10q�6n   ���#FFF关闭摄像头6�   5Y      5Z      5[      � 5\      $��Right=�6   $��10q�6/   .+�5]      �� #��[ 6   $	����6D   $��25(�6W   ���#fff$
 Hand��6w   ���#999$��40��6�   $��40��6�   $��10q�6�   $ 50��6�   $��0q�6�   5^      �� 5_      $��Center=�6   $��Bottom=�6:   $��10q�6U   ���#FFF成员管理6y   5`      5a      5b      5c      