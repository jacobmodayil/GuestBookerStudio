   M S B A M L   `   `   `  ����  Guest Booker StudioB    <Guest_Booker_Studio.Presentation.Pages.Entity.DeleteCustomer   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  DeleteCustomerForm��5   -    � Triggers 5      :� 5	       :� RoutedEvent$ UserControl.Loaded��6   .[�5
      �� .��5      �� -   5         g�Name$ FormFade��5      .��5      W� -   5        $ FormFadeAnimation��5       �� 
TargetName$ DeleteCustomerForm��5       �� TargetProperty$ (Window.Opacity)�5       W� From$	 0.0X�5      	 W� To$	 1.0X�6    g� Duration$ 0:0:0.2D�6    	 g� AutoReverse	 .  
 g� RepeatBehavior$
 1x��5       5      5      5      :� 5      $ UserControl.Unloaded��6   .[�5      �� .��5      �� -   5        $ FormFadeOut��5      .��5      W� -   5        $ FormFadeOutAnimation��5      $ DeleteCustomerForm��5      $ (Window.Opacity)�5      $	 1.0X�5      $	 0.0X�6   $ 0:0:0.2D�6    	 .  $
 1x��5       5      5      5       .��5"      � .+�5#      �� ���	#90EEEEEE �� CornerRadius$ 6��6D   y�6"   �� *
Visibility+._�5$      �� -   5         ��Name$ ModalBorder��5$   4   
���   �$��1q�6    $ 6��5%      $��Center=�6   ���#FFF$��Center=�5&      $	��600��6#   $	��350��6/    J� BitmapEffect 5(      F� 5)       F� Color$ Black��6    F� Opacity$	 0.5Q�6,    F� 	Direction$	 270Q�6:    F� ShadowDepth$	 0.7Q�6J   ._�5+      �  � RowDefinitions 5,      �� 5-      $��30 �6   �� 5.      $��* �6   .+�50      �� ���#3C3324 �� Padding$ 10, 3, 3, 3q�6#   ._�51      � $��0��6    � ColumnDefinitions 52   	   �� 53   
   $��* �6   �� 54   
   $��22 �6   .+�56   	   �� -   5        $��delcustomerlabel��56      $��Delete Customer��6'   $��0,0,0,-2q�57      $��0��6   $
��Left=�6.   $��Center=�6I   
�������$��Calibri)�58      $��14(�64   $��DemiBold"�6B   $��SemiExpanded&�6X   �� 59   	   -   5        $��	cmdCancel��5<   
   $��3��59      
������ $��0q�5:   #   
������ $��Stretch=�5;   
   $��Center=�6(   |�.  $��2q�6U    � ToolTip$ Close��5<      .��5=   
   �� $.��(/Presentation/Resources/Images/close.gif��6   5>   
   5?   	   5@      � 5A      $��10,0,0,0q�6   $��2��6    5B      �� 5C   	   $��30 �6   �� 5D   	   $��* �6   �� 5E   	   $��50 �6   .+�5G      � -	   5        $��grdNewCustomer��5G      $��1��6#   $��	9,1,-9,49q�60   $��2��6C    5H   	   �� 5I   
   $��15 �6   �� 5J   
   $��35 �6   �� 5K   
   $��30 �6   �� 5L   
   $��50 �6   �� 5M   
   $	��30* �6    5O   	   �� 5P   
   $	��103 �6   �� 5Q   
   $	��130 �6   �� 5R   
   $	��100 �6   �� 5S   
   $	��130 �6   �� 5T   
   $��97 �6   .+�5W   	   �� -
   5        $��lblCustomerOrg��5W   V   $��20,5,0,0q�6   $��1��6"   $��0��6/   $��Organization��6?   6V   �� 5X   	   -   5        $��txtOrganization��5X   0   $��1��6   $��1��6    $��30��6G   .��6S   5Y   
   �� 5[   	   -   5        $��lblName��5[   J   $��1��6   $��2��6   $
��Name��6-   $��12(�6<   $��55,5,0,0q�6Y   �� 5\   	   -   5        $��txtName��5\   /   $��1��6   $��3��6   $��30��6>   .��6K   5]   
   �� 5^   	   -   5        $��1��5^      $��4��6      GlassButton#���   6-   $��12(�6S   
�������$��Search��6y   $��30��6�   $��60��6�   6�   &   System.Windows.Controls.DataGrid  5_   	   -   5        $��datagrdDelContact��5_   {   $��3��6   $��5��6   "   VerticalScrollBarVisibility$
 Auto=�63   $   HorizontalScrollBarVisibility$
 Auto=�6V      AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .     SelectionMode$ Single=�6�      Columns 5`   
   0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn   Header$ Organization��6      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6x   1  +System.Windows.Controls.DataGridBoundColumn    Binding  64   �� ! �� Path$! Organization�" �� Mode$" OneWay=�6x     5b      $ Purpose��6   $ * 6\     6/   �� $! Purpose�$" OneWay=�6\     5c      $ FromDate��6   $ * 6^     60   �� $! FromDate�$" OneWay=�6^     5d      $ ToDate��6   $ * 6Z     6.   �� $! ToDate�$" OneWay=�6Z   5f   
   5g   	   �� 5h      -   5        $��2��5h      #���   6   
�������$��Delete Customer��6Z   $��30��6t   $	��118��6�   $��Right=�6�   $��Center=�6�   6�   5i      5j      5k      5l      5m      5n      