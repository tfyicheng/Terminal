   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5   
   G(clr-namespace:Terminal.Library.ViewModelTerminal.Library.ViewModel  5      *    $Terminal.Component.Pages.AddressBook   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >controls)clr-namespace:Terminal.Component.Controls     5   
   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      9
viewmodels(clr-namespace:Terminal.Library.ViewModel  5      -   5          N� 
Background
  ����� N� Title$ AddressBook��5
       � 	Resources 5      7   1Terminal.Library.ViewModel.ContactPersonViewModel   mainData�� 5   
   %   &	          5      60   5       � DataContext 5      �� 5   
    �� Source# [  6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��340 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��5.875 �6    �� 5      $��84.125 �6    �� 5      $��* �6    .+�5!      �� $��3��6   ���#FFFFFF �� CornerRadius$ 4��6;    J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#      	   ShadowDepth$	 0Q�6'   
   
BlurRadius$
 8Q�67      Color$ #C0C4CC��6F      Opacity$	 0.2Q�6V   5%      � 5'      $��0��6   $��0,0,0,0q�6    $��2��61   .+�5(      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��
15,20,15,0q�6Q   .+�5)      %  HandyControl.Controls.SearchBar  $	��255��6#   $��38��6/   '  !HandyControl.Controls.InfoElement   Placeholder$ 搜索��6;   $��15(�6[   #  HandyControl.Controls.TextBox   ShowClearButton . $��0q�6�   ���#eee  SearchBarPlus#��[ 6�   �� 5*      $��0q�6   ���#eee$��15q�6D   $��38��6P   $��38��6\    � Cursor$
 Hand��6g   $��18(�6u     ElementIcon#��[ 6�   .��6�   6�   5+      5,      �� 5.      $��2��6   ���#EBEEF5$��0,0,0,0q�68   ._�5/      �� -   5         ��Name$ 
itcFriends��5/        ItemsControlVirtualization#��[ 63   ��6g   �� *	Friends+��50      �� 51      .R�52      ,   &Terminal.Component.Controls.FriendItem   62   �� y�6J   �� *FriendInfos+  FriendItemVisibilityConvert �� 	Converter# [ 53      55      56      57      � 59   
   $��1��6   .+�5:      *   $Terminal.Component.Controls.InfoPage  -   5          Name$ conFriendInfoCard��5:   #   $y�	Collapsed=�6?   5;      5=      5>      