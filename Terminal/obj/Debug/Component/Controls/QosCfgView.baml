   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5      ,    &Terminal.Component.Controls.QosCfgView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Terminal.Component.Controls     5      .��5      � $��
0,0,0,-114q�6   .+�5   
   �� -   5        $��labelNetworkTitle��5   n   $��QoS/QoE��6   $��0q�6#   $
��Left=�67   $��16(�6S   $��33��6a   $	��Top=�6�   $
��Bold"�6�   �� 5   
     �� Orientation$  Vertical=�6   .+�5      �� $��
10,40,10,0q�6   $	��Top=�6,   ��5      �� 5      $��14(�6   $
��Bold"�6*   
���   �$��视频参数��6O   .��5      �  � ColumnDefinitions 5      �� 5      $	��130 �6+   �� 5      $��* �6+   .+�5      �� $  Vertical=�6!   $��0��68   .+�5      �� -   5        $��label3��5   Z   $��视频分辨率��6    
���   �$��8q�6C   $	��100��6N   $	��Top=�6h   �� 5      -   5        $��label4��5   Z   $��视频帧率��6    
���   �$��8q�6B   $	��100��6M   $	��Top=�6h   �� 5      $��上行带宽(kbps)��6    
���   �$��8q�6H   $	��100��6S   $	��Top=�6_   �� 5      $��下行带宽(kbps)��6    
���   �$��8q�6H   $	��100��6S   $	��Top=�6`   5      �� 5      $  Vertical=�6!   $��1��68   .+�5       �� -   5        $��comboBoxPrefVideoSize��5    /   $��7q�6$   $��3��6w   $��22��6�   $	��Top=�6�    �� SelectedIndex 6L   ��  �� Path$ SelectIndex���6�   �� $ PrefVideoSizeValues� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ Explicit=���5!      �� 5"   "   .R�5#   &   �� $  
Horizontal=�61   .+�5$   *   �� ��64   �� $
 Text�5%   '   5&   #   5(      �� 5*      -   5        $��TextBoxVideoFPS��5*   #   $��24��6:   $��8q�6F   $	��Top=�6R   ��6j   �� $ VideoFPS��� 5,      -   5        $��TextBoxVideoBr��5,   #   $��24��69   $��8q�6E   $	��Top=�6R   ��6k   �� $ VideoBitrate��� 5.      -   5        $��TextBoxDownBandwidth��5.   #   $��24��6?   $��8q�6K   $	��Top=�6V   ��6n   �� $ VideoMaxDownBandwidth�5/      52      53      �� 56      $��10q�6   $	��Top=�6$   ��57      �� 58      $��14(�6    $
��Bold"�6.   
���   �$��网络自适应��6S   .��5;      � .+�5<      �� -   5        $��checkBoxRtcpFeedback��5<   `   $��
RTCP反馈��6   
���   �$��24��6C   $��6,5,0,0q�6O   $	��Top=�6|    d� 	IsChecked 6�   �� $ IsEnableRtcpFd�$ Explicit=�$ TwoWay=��� 5=      -	   5        $��checkBoxCongCtrl��5=   _   $��拥塞控制��6   
���   �$��24��6A   $��6,34,0,0q�6M   $	��Top=�6w    6�   �� $ IsEnableCongCtrl�$ Explicit=�$ TwoWay=�5>      5?      5A      5E      5F      