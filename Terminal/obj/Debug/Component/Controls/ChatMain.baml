   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Terminal.Library.ViewModelTerminal.Library.ViewModel  5       *    $Terminal.Component.Controls.ChatMain   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?
viewmodels(clr-namespace:Terminal.Library.ViewModel     5       -   5          � DataContext  5      2   ,Terminal.Library.ViewModel.ChatMainViewModel  5   
   .��5
      ]� .+�5   
   �� $��90��6   ���#DFE1E5$��0,0,0,1q�63   $	��Top=�6M   ._�5      �� -   5         ��Name$ txbFriendNickName��5      $��	30,15,0,0q�63   $
��Left=�6F   $��Center=�6a   $��28(�6|   5      � 5   
   $	��180��6   $��Bottom=�6   .+�5      �� ���#FFFFFF J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 0Q�6'      
BlurRadius$ 8Q�67      Color$ #C0C4CC��6F      Opacity$	 0.2Q�6V   5      ]� 5      .+�5      �� ���#EBEEF5$��0,0,0,1q�60   $��0,0,0,6q�6J   $	��Top=�6[   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $��50 �6/   .+�5       �� $��0��6%    �� Orientation$ 
Horizontal=�65   $
��Left=�6N   $��
10,10,0,10q�6i   .+�5!      �� $��32��6%   ._�5"   "   �� -   5        $ txbScreenCapture��5"   ,    	  PicUp	 � ToolTip#	 �   6F   
 � Cursor$

 Hand��6h     ElementIcon#��[ 6v   $��Center=�6�   $��20(�6�   $	����6�   6�   5#      �� 5$      $��32��6%   ._�5%   "   �� -   5         
 FileUp#	 �  5%   ,   $

 Hand��6O   #��[ 6]   $��Center=�6�   $��20(�6�   $	����6�   6�   5&      �� 5'      $��32��6%   ._�5(   "   �� -   5        $ 	VoiceTalk��5(   ,     	VoiceTalk#	 �  6?   $

 Hand��6e   #��[ 6s   $��Center=�6�   $��20(�6�   $	����6�   6�   5)      �� 5*      $��32��6%   ._�5+   "   �� -   5        $ 	VideoTalk��5+   ,     	VideoTalk#	 �  6?   $

 Hand��6e   #��[ 6s   $��Center=�6�   $��20(�6�   $	����6�   6�   5,      �� 5-      $��32��6%   ._�5.   "   �� -   5          	VoiceSend#	 �  5.   ,   $

 Hand��6R   #��[ 6`   $��Center=�6�   $��20(�6�   $	����6�   6�   5/      �� 50      $��32��6%   ._�51   "   �� -   5          	VideoSend#	 �  51   ,   $

 Hand��6R   #��[ 6`   $��Center=�6�   $��20(�6�   $	����6�   6�   52      54      �� 55      $��32��6!   $��1��6,   ._�56      �� -	   5          MeetingTalk#	 �  56   (   $

 Hand��6P   #��[ 6^   $��Center=�6�   $��Center=�6�   $��20(�6�   $	����6�   6�   57      58      5;      �� 5=      -
   5         ��Name$ btnSend��5=      ���#21345C  ButtonPrimaryWait#��[ 6?   $��30��6j   $��60��6v   $��Right=�6�   $��	0,6,20,20q�6�   $��0q�6�   $��14(�6�   $��发送��6�   $��Bottom=�6�   �� 5?      -   5         ��Name$ 
rtbMessage��5?      $	��180��63   $	��350��6D   $��0q�6e   $��2,0,2,0q�6y    �� IsDocumentEnabled . $��16(�6�   $	��Top=�6�   ��6T   Z�  � 	Resources 5@       �� 
TargetType �� Property �� Value��%^   'J�       �� 5A      " J�6    .�5B      ��  �@��Margin$ 0,0,0,5q�67   5C      5D      5I      5J      5K      �� 5N   
   -   5         ��Name$ brdChat��5N      $��0,0,0,0q�6"   5O      5P      