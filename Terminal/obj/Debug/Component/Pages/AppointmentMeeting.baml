   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Terminal.Component.PagesTerminal.Component.Pages  5      I)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  6s   G(clr-namespace:Terminal.Library.ViewModelTerminal.Library.ViewModel  5      1    +Terminal.Component.Pages.AppointmentMeeting   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Terminal.Component.Pages     5      S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  6?   8controls)clr-namespace:Terminal.Component.Controls  6s   9
viewmodels(clr-namespace:Terminal.Library.ViewModel  5      -   5          N� 
Background
  ����� N� Title$ AppointmentMeeting��5	       � 	Resources 5
      -   'Terminal.Library.ViewModel.MeetingModel   mainData�� 5   
   %   &	          5      6&   5       � DataContext 5      �� 5   
    �� Source# [  6   .��5      �  � RowDefinitions 5   
   �� 5      $��90 �6   �� 5      $��* �6   .+�5   
   �� $��28(�6   $��Center=�6"   $��25q�6=   预约会议6P   �� 5   
   $��Bottom=�6   $��1��6+   	 �� X1$ 0��66   	 �� Y1$ 0��6=   	 �� X2$ 14400��6D   		 �� Y2$	 0��6O   ���#ddd6f   � 5   
   $��1��6   
 � ColumnDefinitions
 5      �� 5      $	��340 �6#   �� 5       $��* �6#   .+�5#      � $��0��6    5$      �� 5%      $��5.875 �6$   �� 5&      $��54.125 �6$   �� 5'      $��* �6$   .+�5)      �� $��3��6   ���#FFFFFF �� CornerRadius$ 4��6?    J� Effect 5*      3  -System.Windows.Media.Effects.DropShadowEffect  5+         ShadowDepth$ 0Q�6+      
BlurRadius$ 8Q�6;      Color$ #C0C4CC��6J      Opacity$	 0.2Q�6Z   5-      � 5/      $��1��6   $��0,0,0,0q�6$   $��2��65    50      �� 51      $��50 �6(   �� 52      $��* �6(   .+�55      � .+�56      ]� $��Center=�6&   $��Center=�6A   $��0,0,0,5q�6^   .+�57      �� $
��Left=�6%   $��0,0,60,0q�6;   $��0q�6N   ���#4D9FFF���#fff$��32��6�   $	��110��6�    � Cursor$
 Hand��6�   $��17(�6�     ElementIcon#��[ 6�   .��6�    加入会议6�   �� 58      $��Right=�6&   $��0q�6=   ���#4D9FFF���#fff$��32��6x   $	��110��6�   $
 Hand��6�   $��17(�6�     ElementIcon2#��[ 6�   .��6�    快速会议6�   59      �� 5:      $��Bottom=�6   $ 0��6:   $ 0��6A   $
 2400��6H   $	 0��6R   ���#C0C4CC6Y   5;      �� 5=      $��1��6!   .@�5?      �� $��18(�6"   $��40��61   #��[ 6=   $�� 当前会议��6h   $	��170��6�   $
 Hand��6�   .��5B      �� $��0,0,0,0q�6-     ItemsControlVirtualization#��[ 6c   ��6@   �� *
Meetings+��5C   &   �� 5D   *   .R�5E   .   -   'Terminal.Component.Controls.MeetingItem   6C   �� 5F   +   5H   #   5J      �� 5L      $��18(�6"   #��[ 60   $�� 历史会议��6[   $	��170��6r   $
 Hand��6~   .��5O      �� $��0,0,0,0q�6-   #��[ 6b   ��6?   �� *
Meetings+��5P   "   �� 5Q   &   .R�5R   *   4   .Terminal.Component.Controls.MeetingHistoryItem   6F   �� 5S   '   5U      5W      5X      5Y      5[      � 5]      $��1��6    5^      �� 5_      $��* �6$   �� 5`      $��90 �6$   .+�5d      �� $��
25,10,25,0q�6   $
��Left=�61   .+�5e      �� $��22(�6    $��	0,10,0,15q�6.   会议主题6G   �� 5f      $	��300��6   $��18(�6*   6:   �� 5g      $��22(�6    $��	0,20,0,10q�6.   开始时间6G   *  $HandyControl.Controls.DateTimePicker  5h         ShowClearButton . 6,   �� 5i      $��22(�6    $��	0,20,0,10q�6.   结束时间6G     5j       . 6(   �� 5k      $��22(�6    $��	0,20,0,10q�6.   时区6E   $  HandyControl.Controls.ComboBox  5l         ShowClearButton .  �� SelectedIndex$ 0��6Z   ��69   �� *
DataList+6Z   �� 5m      $��22(�6    $��	0,20,0,10q�6.   会议设置6G   �� 5n      $��	0,10,0,10q�6   $��周期性会议��62    d� 	IsChecked$
 TrueY�6B   �� 5o      $��	0,10,0,10q�6   $3��-允许成员在主持人进会前加入会议��62   $
 TrueY�6L   �� 5p      $��	0,10,0,10q�6   $��入会时静音��62   $
 TrueY�6B   �� 5q      -   5        $
��Left=�5q   2   $��0,0,00,0q�6M   $��0q�6`   ���#A5A5A5���#fff$��32��6�   $	��110��6�   $
 Hand��6�   $��17(�6�   #��[ 6�   .��6�    成员管理6	  5r      � 5s      $��1��6   .+�5u      �� $��Center=�6   $	��Top=�6:   $��0,0,60,0q�6R   $��0q�6e   ���#4D9FFF���#fff$��42��6�   $	��130��6�   $
 Hand��6�   $��17(�6�   #��[ 6�   .��6�   预定会议6  5v      5w      5x      5y      5z      