   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5      0    *Terminal.Component.Controls.GeneralCfgView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Terminal.Component.Controls     5      .��5	      � .+�5   
   �� -   5        $��labelGeneralTitle��5   O   $��通用配置��6   
���   �$��33��62   $��0,0,0,0q�6>   $
��Left=�6h   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   $��0q�6�   �� 5   
   -   5        $��	groupBox1��5   '   $��
10,43,10,0q�6   $	��150��68   $	��Top=�6E   ��5      �� 5      $��参数设置��6   $��14(�6(   $
��Bold"�66   
���   �6H   .��5      � .+�5      �� -   5        $��checkBoxLaunchWhenStart��5   [   $��随系统启动��6   
���   �$��24��6>   $��3,5,0,0q�6J   $	��Top=�6z     d� 	IsChecked  6�   ��  �� Path$ IsAutoStart� �� UpdateSourceTrigger$ Explicit=� �� Mode$ TwoWay=��� 5      -   5        $��checkBoxKeepAlive��5   |   $ ��启动心跳检测(毫秒)��6   
���   �$��16��6C   $
��Left=�6O   $��3,40,0,0q�6j   $	��Top=�6�     6�   �� $ IsEnableHeartbeat�$ Explicit=�$ TwoWay=��� 5      -   5        $��textBoxKaTimerVal��5   H   $��130,33,40,0q�6   $��23��60   $	��200��6<   $	��Top=�6a   ��6y   �� $ 
HbInterval�$ Explicit=�$ TwoWay=�{�6�   �� $ 	IsChecked� �� ElementName$ checkBoxKeepAlive���� 5      -   5        $��checkBoxDebugMode��5   v   $��调试模式��6   
���   �$��16��6=   $
��Left=�6I   $��3,75,0,0q�6d   $	��Top=�6�     6�   �� $ IsEnableDebugMode�$ Explicit=�$ TwoWay=�5      5      5      5      