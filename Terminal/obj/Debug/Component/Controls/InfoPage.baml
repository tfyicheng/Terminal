   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5      K*clr-namespace:Terminal.Library.ResultModelTerminal.Library.ResultModel  5      *    $Terminal.Component.Controls.InfoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Terminal.Component.Controls     5      Cresultmodels*clr-namespace:Terminal.Library.ResultModel     5      -   5          � DataContext  5      3   -Terminal.Library.ResultModel.InfoDetailsModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��91 �6   �� 5      $��* �6   �� 5      $	��180 �6   .+�5      �� $��Bottom=�6   	 �� X1$ 0��6/   	 �� Y1$ 0��66   	 �� X2$
 2400��6=   	 �� Y2$ 0��6G   ���#C0C4CC6N   � 5!   
   $��1��6   $��20q�6    5"      �� 5#      $	��150 �6    �� 5$      $��* �6    .+�5'      � $��Center=�6   .+�5(      �� -   5         ��Name$ 	imgHead00��5(      $��0��6,   $��90��6<   $��90��6H   $��0q�6S   $-��'pack://application:,,,/Resources/tx.png��6^   6�   5)      � 5+      $��1��6   .+�5,      � $	��400��6   $��	20,0,20,0q�6&   .+�5-      �� ���#FFFFFF �� CornerRadius$ 3��62    J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/      	   ShadowDepth$	 0Q�6/   
   
BlurRadius$
 8Q�6?      Color$ #C0C4CC��6N      Opacity$	 0.2Q�6^   51      ]� 53      $��20q�6!   .+�54      ]� $��5,0,5,0q�6$   $��Bottom=�65   .+�55      ]� $��	0,5,10,20q�6(   $	��Top=�6;   .+�56   "   �� $	��120��6,   $��20(�68   ���#606266$��	用户名��6[   $
��Left=�6f   �� 57   "   -   5         ��Name$
 Nick��57   �   $��20(�6H   ���#303133$��CharacterEllipsis=�6k   $
��Left=�6�   ��6-   �� *
NickName+6�   58      ]� 5:      $��0,5,0,20q�6(   $	��Top=�6:   .+�5;   "   �� $	��120��6,   $��20(�68   ���#606266$��备注��6[   $
��Left=�6e   ]� 5<   "   $
��Left=�6,   .+�5=   &   �� -   5        $ txbRemarkNameAction��5=   0      TextBlockWait#��[  6M   $��20(�6t     ElementIcon2#��[ 6�   
 � Tag$ 
RemarkName��6�   $	����6�   $��Right=�6�   6�   � 5>   &   $��0,0,5,0q�6+   $��Right=�6<   .+�5?   *   �� -   5        $ txbRemarkName��5?   4   $��20(�6K   ���#303133$��CharacterEllipsis=�6n   ��6�   �� *
RemarkName+�� 5@   *   -   5         ��Name$ txtRemarkName��5@   2     TextBoxEmpty#��[ 6I   $��20(�6o    �� 	MaxLength$ 30��6}   $ 
RemarkName��6�   $y�	Collapsed=�6�   6�   5A   '   5B   #   5C      ]� 5E      $��0,5,0,20q�6(   $	��Top=�6:   .+�5F   "   �� $	��120��6,   $��20(�68   ���#606266$��地址��6[   $
��Left=�6e   �� 5G   "   $��20(�6,   ���#303133$��CharacterEllipsis=�6O   $
��Left=�6�   ��6p   �� *
Location+6�   5H      ]� 5J      $��0,5,0,20q�6(   $	��Top=�6:   .+�5K   "   �� $	��120��6,   $��20(�68   ���#606266$��个人��6[   $
��Left=�6e   �� 5L   "   $��20(�6J   ���#606266$
��Left=�6m   ��6-   �� *PhoneNumber+6m   5M      ]� 5O      $��0,5,0,5q�6(   $	��Top=�69   .+�5P   "   �� $	��120��6,   $��20(�68   ���#606266$��备注信息��6[   $
��Left=�6g   ]� 5Q   !   $
��Left=�6+   .+�5R   &   �� -   5        $  txbRemarkInformationAction��5R   0   $	��Top=�6U   $��20(�6m   #��[  6{   #��[ 6�   $ RemarkInformation��6�   $	����6�   $��Right=�6�    � Cursor$
 Hand��6<  � 5S   &   $��0,0,5,0q�6+   $��Right=�6<   .+�5T   *   �� -   5        $ txbRemarkInformation��5T   4   $��13(�6R   ���#303133$
��Wrap=�6u   $��CharacterEllipsis=�6�   ��6�   �� *RemarkInformation+�� 5U   *   -	   5        $ txtRemarkInformation��5U   2   #��[ 6P    �� TextWrapping$
 Wrap=�6v    �� AcceptsReturn . $��11(�6�   $	 100��6�   $ RemarkInformation��6�   $y�	Collapsed=�6�   6�   5V   '   5W   #   5X      5Y      5Z      5[      5\      5]      � 5_   
   $��1��6    � Orientation$ 
Horizontal=�6!   $��20q�6:   $	��Top=�6F   $y�Hidden=�6^   .+�5`      �� -
   5        $ imgHead��5`      $��0��6&   $��70��66   $��70��6B   $��20q�6M   $-��'pack://application:,,,/Resources/tx.png��6Y   6�   �� 5a      -   5        $ imgHead1��5a      $��0��6'   $��70��67   $��70��6C   $��20q�6N   $-��'pack://application:,,,/Resources/tx.png��6Z   6�   �� 5b      -   5        $ imgHead2��5b      $��0��6'   $��70��67   $��70��6C   $��20q�6N   $-��'pack://application:,,,/Resources/tx.png��6Z   6�   �� 5c      -   5        $ imgHead3��5c      $��0��6'   $��70��67   $��70��6C   $��20q�6N   $-��'pack://application:,,,/Resources/tx.png��6Z   6�   �� 5d      -   5        $ imgHead4��5d      $��0��6'   $��70��67   $��70��6C   $��20q�6N   $-��'pack://application:,,,/Resources/tx.png��6Z   6�   �� 5e      -   5        $ imgHead5��5e      $��0��6'   $��70��67   $��70��6C   $��20q�6N   $-��'pack://application:,,,/Resources/tx.png��6Z   6�   5f      �� 5h   
   -   5        $��2��5h      $
 Hand��6   ���#21345C���#fff$	��150��6S   $��40��6_   $��15(�6k   $��0q�6�   .��6�   发送消息6�   5j      5k      