   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5      1    +Terminal.Component.Controls.ContactsCfgView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Terminal.Component.Controls     5      .��5	      � .+�5
   
   �� -   5        $��labelGeneralTitle��5
   N   $��	通讯录��6   
���   �$��33��61   $��0,0,0,0q�6=   $
��Left=�6g   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   $��0q�6�   �� 5   
   $��通讯录获取方法��6   
���   �$��28��66   $��	10,90,0,0q�6B   $	��Top=�6U   $
��Left=�6m   �� 5      -   5        $��comboBoxRemoteContactType��5   0   $��23��6   $��150,90,10,0q�6   $	��Top=�6Q     �� SelectedIndex$  1��6i   ��5      ��  �� Path$ RemoteContactTypes� �� SelectedItem 6O   �� $ RemoteContactType� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�{�5      �� $ RemoteContactEnabled�5      �� 5'      -   5        $��groupBoxXCAP��5'   #   $��
6,85,6,172q�6   $y�Hidden=�67   $	��402��6K   {�6W   �� $ XcapEnabled�5(      �� 5)      $��通讯录存取方式��6   
���   �$��28��62   $
��Left=�6>   $��	10,43,0,0q�6Y   $	��Top=�6l   �� 5*   
   -   5        $ ��comboBoxContactStorageType��5*   e   $��23��6   $��151,43,10,0q�6P   $  0��6�   $	��Top=�5+   �   ��5*      �� $ ContactStorageTypes� 5+      �� $ ContactStorageType�$ PropertyChanged=�$ TwoWay=�5,      5-      5.      