   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5   	   '    !Terminal.Component.Windows.Config   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8my)clr-namespace:Terminal.Component.Controls     5   	     � Title$  参数配置��5   	   $	��658��6   $	��560��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F   
�������.��5      �  � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5	      $
��160* �6   .+�5   
   �� -   5        $��
tabControl��5      
������� �� TabStripPlacement$
 Left=�6:   $��0,0,0,41q�6S   
�������$��2��6y   .@�5      �� -   5        $��tabItemGeneral��5   #   $��45��6   $��1q�69   ���#326CF3��5      �� 5      $��通用配置��6   $��14(�6+   $
��Bold"�69   $��0q�6K   .��5      0   *Terminal.Component.Controls.GeneralCfgView  -   5          Name$ tabItemGeneralContent��5   $   5      �� 5      -   5        $��tabItemNetwork��5   #   $��45��6   $��1q�69   ���#326CF3��5      �� 5      $��网络配置��6   $��14(�6+   $
��Bold"�69   $��0q�6K   .��5      0   *Terminal.Component.Controls.NetworkCfgView  -   5          Name$ tabItemNetworkContent��5   $   5      �� 5      -   5        $��tabItemContact��5   "   $��45��6   $��1q�68   ���#326CF3��5      �� 5       $��	通讯录��6   $��14(�6*   $
��Bold"�68   $��0q�6J   .��5#      1   +Terminal.Component.Controls.ContactsCfgView  -   5          Name$ tabItemContactsContent��5#   %   5$      �� 5&      -   5        $��tabItemCodecs��5&   "   $��45��6   $��1q�68   ���#326CF3��5'      �� 5(      $��媒体编码��6   $��14(�6+   $
��Bold"�69   $��0q�6K   .��5+      /   )Terminal.Component.Controls.CodecsCfgView  -	   5          Name$ tabItemCodecsContent��5+   #   5,      �� 5-      -
   5        $��
tabItemQos��5-   "   $��45��6   $��1q�65   ���#326CF3��5.      �� 5/      $��	QoS参数��6   $��14(�6,   $
��Bold"�6:   $��0q�6L   .��52      ,   &Terminal.Component.Controls.QosCfgView  -   5        	  Name$	 tabItemQosView��52       53      54      �� 56   
   -   5        $��
buttonSave��56   [   $��保存��6   $��15(�6   $
��Left=�6-   $��	297,0,0,7q�6H   $��75��6m   $��32��6x   $��Bottom=�6�   
������ ���#326CF3$��1��6�   
�������6�   �� 57   
   -   5        $��buttonCancel��57   f   $��取消��6   $��15(�6   $��32��6,   $��Right=�68   $��0,0,21,7q�6T   $��Bottom=�6z   $��75��6�   
������ ���#326CF3$��1��6�   
�������6�   59      5:      