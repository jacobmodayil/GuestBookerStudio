   M S B A M L   `   `   `  ����  Guest Booker StudioK    EGuest_Booker_Studio.Presentation.Pages.Entity.Contact.ViewAllContacts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  ViewAllContactsFrom��5   ?    � Triggers 5      :� 5   
    :� RoutedEvent$ UserControl.Loaded��6   .[�5	      �� .��5
      �� -   5         g�Name$ FormFade��5
      .��5      W� -   5        $ FormFadeAnimation��5   '    �� 
TargetName$ ViewAllContactsFrom��5       �� TargetProperty$ (Window.Opacity)�5       W� From$	 0.0X�5      	 W� To$	 1.0X�6    g� Duration$ 0:0:0.2D�6    	 g� AutoReverse	 .  
 g� RepeatBehavior$
 1x��5       5      5      5      :� 5   
   $ UserControl.Unloaded��6   .[�5      �� .��5      �� -   5        $ FormFadeOut��5      .��5      W� -   5        $ FormFadeOutAnimation��5   '   $ ViewAllContactsFrom��5      $ (Window.Opacity)�5      $	 1.0X�5      $	 0.0X�6   $ 0:0:0.2D�6    	 .  $
 1x��5       5      5      5      .��5!      � .+�5"      �� ���	#90EEEEEE �� CornerRadius$ 6��6D   y�6"   �� *
Visibility+._�5#      �� -   5         ��Name$ ModalBorder��5#   4   
���   �$��1q�6    $ 6��5$      $��Center=�6   ���#FFF$��Center=�5%      $	��730��6#   $	��350��6/    J� BitmapEffect 5'      F� 5(       F� Color$ Black��6    F� Opacity$	 0.5Q�6,    F� 	Direction$	 270Q�6:    F� ShadowDepth$	 0.7Q�6J   ._�5*      �  � RowDefinitions 5+      �� 5,      $��30 �6   �� 5-      $��* �6   .+�5/      �� ���#3C3324 �� Padding$ 10, 3, 3, 3q�6#   ._�50      � $��0��6    � ColumnDefinitions 51   	   �� 52   
   $��* �6   �� 53   
   $��22 �6   .+�55   	   �� -   5        $��viewallcontactslabel��55      $��View All Contacts��6+   $��0,0,0,-2q�56      $��0��6   $
��Left=�6.   $��Center=�6I   
�������$��Calibri)�57      $��14(�64   $��DemiBold"�6B   $��SemiExpanded&�6X   �� 58   	   -   5        $��	cmdCancel��5;   
   $��3��58      
������ $��0q�59   #   
������ $��Stretch=�5:   
   $��Center=�6(   |�.  $��2q�6U    � ToolTip$ Close��5;      .��5<   
   �� $.��(/Presentation/Resources/Images/close.gif��6   5=   
   5>   	   5?      � 5@      $��10,0,0,0q�6   $��2��6   $��2��6/    5A      �� 5B   	   $��30 �6   �� 5C   	   $��* �6   �� 5D   	   $��50 �6   .+�5F      c� $��-5,0,5,0q�6   ���#FFF���#EEE.@�5G   	   �� -	   5        $ Refresh Grid��5G      .��5H   
   �� $2��,/Presentation/Resources/Images/Refresh16.png��6   $��Center=�6F   $��14��6a   $��14��6m   $ 	Open XAML��6x   6�   5I   
   �� 5J   	   $��5q�6   �� 5K   	   -
   5        $ Export to Excel��5K      .��5L   
   �� $3��-/Presentation/Resources/Images/excel logo.jpg��6   $��Center=�6G   $��18��6b   $��18��6n   6{   5M   
   5O   	   � 5P      -   5        $��grdNewCustomer��5P      $��1��6#   $��	-9,2,9,48q�60   $��2��6C    5Q   	   �� 5R   
   $��30 �6   �� 5S   
   $	��30* �6    5V   	   �� 5W   
   $	��103 �6   �� 5X   
   $	��130 �6   �� 5Y   
   $	��100 �6   �� 5Z   
   $	��130 �6   �� 5[   
   $	��150 �6   �� 5\   
   $	��20* �6   .+�5`   	   &   System.Windows.Controls.DataGrid  -   5        $��datagrdViewContact��5`   {   $��1��6   $��6��6   "   VerticalScrollBarVisibility$
 Auto=�63   $   HorizontalScrollBarVisibility$
 Auto=�6V      AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .     SelectionMode$ Single=�6�   $��4,0,-4,0q�6�      Columns 5a   
   0  *System.Windows.Controls.DataGridTextColumn  5b      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6h   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6,   �� ! �� Path$
! Name�" �� Mode$" OneWay=�6h     5c      $ Designation��6   $ * 6d     63   �� $! Designation�$" OneWay=�6d     5d      $ Phone Number��6   $ * 6e     64   �� $! PhoneNumber�$" OneWay=�6e     5e      $ Organization��6   $ * 6f     64   �� $! Organization�$" OneWay=�6f   5g   
   5i   	   5j      5k      5l      5m      5n      5o      