   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Terminal.Component.ControlsTerminal.Component.Controls  5      '    !Terminal.Component.Controls.Table   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Terminal.Component.Controls     5      S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5         RowHeaderWidth$ 60Q�6!    	  tbRow   RowStyle# [  65     tbStyle#��[ 6W    
 tbHead   ColumnHeaderStyle# [ 6x    
 tbCell   	CellStyle# [ 6�   ��6�   ��    RowHeaderTemplate 5      �� 5      .R�5      ��  d� 	IsChecked 6   �� *
IsSelected+ �� RelativeSource �� 	 �� AncestorType$	 DataGridRowL�5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6%      Header$ 任务��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+  5      $ 2* 6&   $ 编号��61    6>   �� *Name+  5      $ 2* 6&   $ 名称��61    6>   �� *
Birthday+  5      $ 1* 6&   $ 名称��61    6>   �� *
Birthday+5!      � 5$   
   $��1��6   $��Center=�6   $��Center=�68   .+�5%      &   HandyControl.Controls.Pagination     MaxPageCount$ 10��6      IsJumpEnabled .    	PageIndex 6/   �� *	PageIndex+,  &HandyControl.Interactivity.Interaction   Triggers 5&      -  'HandyControl.Interactivity.EventTrigger  5'         	EventName$ PageUpdated��6&   ,	  &HandyControl.Interactivity.TriggerBase 	  Actions. 5(      /
  )HandyControl.Interactivity.EventToCommand
   
  PassEventArgsToCommand .  
  Command 6,   �� *PageUpdatedCmd+6O   5)      5+      5,      5.      51      