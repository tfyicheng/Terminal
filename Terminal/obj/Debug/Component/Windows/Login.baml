   M S B A M L   `   `   `  ����  Terminal&     Terminal.Component.Windows.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      -   5        
������   � Title$  登陆��5      $	��382��6   $	��310��6#    � WindowStyle$
 None=�6/    � WindowStartupLocation$ CenterScreen=�6B    � 
ResizeMode$ NoResize=�6g    � Icon$/ )pack://application:,,,/Resources/icon.ico��6}    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$ #888888��6      ShadowDepth$ 0Q�6+      Opacity$	 0.3Q�6;   '  !System.Windows.Shell.WindowChrome	   WindowChrome	 5
        5   
   
   UseAeroCaptionButtons
 .     GlassFrameThickness$ -1q�65      CaptionHeight$	 382Q�6N   .��5      � $	��372��6   $	��300��6   ���#fff   IsHitTestVisibleInChrome .  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��50��5      $	����5      
���  ��   ElementIcon#��[  5      $��16(�5      $��0q�5      $��247,4,3,167q�5      $��2��5       � Cursor$
 Hand��60   �� 5    
   -   5        $��80��5       $��接入配置��5!      ���	#FF888888$
��Bold"�5#      $��
10,3,210,0q�5%      $��0q�5&      5(      �� 5)   
   $�� ��6   $��60��6   $��
9,23,210,0q�6&   $	��Top=�6:   $��0,0,0,2q�6R   ���	#FF666666���	#FF666666$��2��6�   $��2��6�   �� 5,   
   $��1��6   $-��'pack://application:,,,/Resources/tx.png��6   $	��100��6N   $	��100��6Z   $��	0,25,0,47q�6g   6}   �� 5.   
   -   5         ��Name$ 	LoginName��5.      $��40,161,40,0q�6%   $��1��6:    �� TextWrapping$ NoWrap=�6G     TextBoxExtend#��[ 5/      '  !HandyControl.Controls.InfoElement   Placeholder$ 输入账号��6;   )  #HandyControl.Controls.BorderElement   CornerRadius$ 0��50      $��15(�51      $	��Top=�52      $	��220��6*   $��0,0,0,1q�66    �� TextAlignment$
 Left=�6P   $��28��6e   $��2��6q   G� 53   
   -   5         G�Name$ Password��53      $ 0��54      $��0,0,0,1q�55        PasswordBoxExtend#���  56       G� PasswordChar$	 ●��6>   -  'HandyControl.Controls.PasswordBoxAttach   PasswordLength$ 0��57      $ 输入密码��58      $��15(�5:      $��
40,43,40,0q�5<      $��2��6*   $	��Top=�67   $	��220��6O   $��28��6\   $ IBeam��6h   �� 5>   
   -   5         ��Name$ Loginbtn��5>      $	��160��6   $��18(�5?      $
 Hand��6"   $��0q�5@      $��37��5A      $��登录��6   $��19(�6+   
�������$��70,102,70,0q�6`   $��2��6u   $	��Top=�6�   ��5B      �� 5C       �� 
StartPoint$	 0,4&�6&    �� EndPoint$	 1,0&�67   .��5D      �  � Color$ #a4ebff��6#    � Offset$	 0.5Q�63   � 5E      $ #67aefb��6#   $ 1Q�63   5F      5H      5I      5J      