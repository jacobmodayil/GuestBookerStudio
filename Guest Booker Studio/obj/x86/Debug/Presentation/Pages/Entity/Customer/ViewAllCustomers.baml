   M S B A M L   `   `   `  ����  Guest Booker StudioD    >Guest_Booker_Studio.Presentation.Pages.Entity.ViewAllCustomers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  ViewAllCustomersForm��5   -    � Triggers 5      :� 5	   
    :� RoutedEvent$ UserControl.Loaded��6   .[�5
      �� .��5      �� -   5         g�Name$ FormFade��5      .��5      W� -   5        $ FormFadeAnimation��5   '    �� 
TargetName$ ViewAllCustomersForm��5       �� TargetProperty$ (Window.Opacity)�5       W� From$	 0.0X�5      	 W� To$	 1.0X�6    g� Duration$ 0:0:0.2D�6    	 g� AutoReverse	 .  
 g� RepeatBehavior$
 1x��5       5      5      5      :� 5   
   $ UserControl.Unloaded��6   .[�5      �� .��5      �� -   5        $ FormFadeOut��5      .��5      W� -   5        $ FormFadeOutAnimation��5   '   $ ViewAllCustomersForm��5      $ (Window.Opacity)�5      $	 1.0X�5      $	 0.0X�6   $ 0:0:0.2D�6    	 .  $
 1x��5       5      5      5       .��5"      � .+�5#      �� ���	#90EEEEEE �� CornerRadius$ 6��6D   y�6"   �� *
Visibility+._�5$      �� -   5         ��Name$ ModalBorder��5$   4   
���   �$��1q�6    $ 6��5%      $��Center=�6   ���#FFF$��Center=�5&      $	��700��6#   $	��350��6/    J� BitmapEffect 5(      F� 5)       F� Color$ Black��6    F� Opacity$	 0.5Q�6,    F� 	Direction$	 270Q�6:    F� ShadowDepth$	 0.7Q�6J   ._�5+      �  � RowDefinitions 5,      �� 5-      $��30 �6   �� 5.      $��* �6   .+�50      �� ���#3C3324 �� Padding$ 10, 3, 3, 3q�6#   ._�51      � $��0��6    � ColumnDefinitions 52   	   �� 53   
   $��* �6   �� 54   
   $��22 �6   .+�56   	   �� -   5        $��viewallcustomerlabel��56      $��View All Customers��6+   $��0,0,0,-2q�57      $��0��6   $
��Left=�6.   $��Center=�6I   
�������$��Calibri)�58      $��14(�64   $��DemiBold"�6B   $��SemiExpanded&�6X   �� 59   	   -   5        $��	cmdCancel��5<   
   $��3��59      
������ $��0q�5:   #   
������ $��Stretch=�5;   
   $��Center=�6(   |�.  $��2q�6U    � ToolTip$ Close��5<      .��5=   
   �� $.��(/Presentation/Resources/Images/close.gif��6   5>   
   5?   	   5@      � 5A      $��10,0,0,0q�6   $��2��6   $��2��6/    5B      �� 5C   	   $��30 �6   �� 5D   	   $��* �6   �� 5E   	   $��50 �6   .+�5G      c� $��-5,0,5,0q�6   ���#FFF���#EEE.@�5H   	   �� -	   5        $ Refresh Grid��5H      .��5I   
   �� $2��,/Presentation/Resources/Images/Refresh16.png��6   $��Center=�6F   $��14��6a   $��14��6m   $ 	Open XAML��6x   6�   5J   
   �� 5K   	   $��5q�6   �� 5L   	   -
   5        $ Export to Excel��5L      .��5M   
   �� $3��-/Presentation/Resources/Images/excel logo.jpg��6   $��Center=�6G   $��18��6b   $��18��6n   6{   5N   
   5P   	   � 5Q      -   5        $��grdNewCustomer��5Q      $��1��6#   $��	-9,2,9,48q�60   $��2��6C    5R   	   �� 5T   
   $��50 �6   �� 5U   
   $��30 �6   �� 5V   
   $	��30* �6    5Y   	   �� 5Z   
   $	��103 �6   �� 5[   
   $	��130 �6   �� 5\   
   $	��100 �6   �� 5]   
   $	��130 �6   �� 5^   
   $	��150 �6   �� 5_   
   $	��20* �6   .+�5c   	   &   System.Windows.Controls.DataGrid  -   5        $��datagrdViewCustomer��5c   �   $��6��6   $��Center=�6&   $��2��6C   "   VerticalScrollBarVisibility$
 Auto=�6P   $   HorizontalScrollBarVisibility$
 Auto=�6s      AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .     SelectionMode$ Single=�6�   $��
37,2,38,33q�6  $��2��6$     Columns 5d   
   0  *System.Windows.Controls.DataGridTextColumn  5e      ,  &System.Windows.Controls.DataGridColumn   Header$ Organization��6      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6x   1  +System.Windows.Controls.DataGridBoundColumn    Binding  64   �� ! �� Path$! Organization�" �� Mode$" OneWay=�6x     5f      $ Purpose��6   $ * 6\     6/   �� $! Purpose�$" OneWay=�6\     5g      $ FromDate��6   $ * 6^     60   �� $! FromDate�$" OneWay=�6^     5h      $ ToDate��6   $ * 6Z     6.   �� $! ToDate�$" OneWay=�6Z     5i      $ IsActive��6   $ * 6^     60   �� $! IsActive�$" OneWay=�6^   5k   
   �� 5m   	   -   5        $��lblFromDate��5m   w   $��0��6   $��0��6   $��	From Date��6,   $��Right=�6@   $��Center=�6\   6w   �� 5n      -   5        # ��Name$# txtFromDate��5n   &   $��0��6;   $��1��6H   $��25��6X   �� 5p      -   5        $��	lblToDate��5p   �   $��0��6$   $��2��61   $��To Date��6A   $��Right=�6S   $��Center=�6o   6�   �� 5q      -   5        $# 	txtToDate��5q   &   $��0��69   $��3��6F   $��25��6V   �� 5r      -   5        $��0��5r   %   $��4��62      GlassButton#���   6B   $��12(�6h   
�������$��Search��6�   $��30��6�   $��60��6�   $��
44,8,46,12q�6�   5t   	   5u      5v      5w      5x      5y      5z      