   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Terminal.Component.WindowsTerminal.Component.Windows  5   	   I)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5   	   K*clr-namespace:Terminal.Library.ResultModelTerminal.Library.ResultModel  5	   
   G(clr-namespace:Terminal.Library.ViewModelTerminal.Library.ViewModel  6I   )    #Terminal.Component.Windows.Memebers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Terminal.Component.Windows     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      8controls)clr-namespace:Terminal.Component.Controls  5   	   <viewmodels1*clr-namespace:Terminal.Library.ResultModel  5	   
   ;viewmodels11(clr-namespace:Terminal.Library.ViewModel  6I   -   5        
������   � WindowStyle$
  None=�5
       � WindowStartupLocation$ CenterScreen=�6.    � 
ResizeMode$ NoResize=�6S    � Title$ 选择成员��5   	   $	��490��6   $	��710��6$    � 	Resources 5      7   1Terminal.Library.ViewModel.ContactPersonViewModel   
friendData�� 5   
   %   &	          5      63   5       � DataContext 5      �� 5   
    �� Source# [  6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$ #888888��6   	   ShadowDepth$	 0Q�6+   
   Opacity$	
 0.3Q�6;   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      UseAeroCaptionButtons .     GlassFrameThickness$ -1q�65      CaptionHeight$	 490Q�6N   .��5      �    IsHitTestVisibleInChrome . $	��480��6:   $	��700��6G   ���#FFFFFF � ColumnDefinitions 5   
   �� 5       $	��320 �6   �� 5!      $��* �6   .+�5%   
   �  � RowDefinitions 5&      �� 5'      $��75 �6    �� 5(      $��* �6    .+�5*      �� $��2��6   ���#F7F7F7 �� CornerRadius$ 0��6<    5+        5,      $	 0Q�6'      
BlurRadius$ 8Q�68   $
 gray��6G   $	
 0.3Q�6T   5.      %  HandyControl.Controls.SearchBar  5/      $	��280��6   $��38��6'   '  !HandyControl.Controls.InfoElement   Placeholder$ 搜索��63   $��15(�6S   #  HandyControl.Controls.TextBox   ShowClearButton . $��0q�6x   ���#eee  SearchBarPlus#��[ 6�   � 50      $��1��6   .+�52      �� -   5         ��Name$ 
itcFriends��52        ItemsControlVirtualization#��[ 6S   ��63   �� *	Friends+��53      �� 54      .R�55      )   #Terminal.Component.Controls.AddItem   61   �� y�6J   �� *FriendInfos+  FriendItemVisibilityConvert �� 	Converter# [ 56      58      5:      5;      � 5=   
   $��1��6    5>      �� 5?      $��70 �6    �� 5@      $��* �6    �� 5A      $��90 �6    .+�5C      �� $��18(�6   $��Center=�6&   $��20,0,0,0q�6A   创建会议聊天6[   � 5D      $��1��6   .+�5E      �� -   5        $ 	itcFriend��5E      #��[ 6R   ��62   �� *	Friends+��5F      �� 5G      .R�5H      .   (Terminal.Component.Controls.SelectedItem   66   �� 5I      5K      5N      ]� 5O      ��.  $��2��6/   $	��250��6>   .+�5P      �� -   5         � Cursor$
 Hand��5P   (   $��0q�66   $
��Left=�6A   ���#4E9FFF���#ccc$��16(�6~   $	��100��6�   $��35��6�   $��0q�6�     ElementIcon#��[ 6�   $��
 取消��6�   6�   �� 5Q      -   5        $
 Hand��5Q   )   $��0q�67   $��Right=�6B   ���#fff���#4E9FFF$��16(�6�   $	��100��6�   $��35��6�   $��0q�6�   #��[ 6�   $��
 确定��6�   6�   5R      5S      5T      5U      