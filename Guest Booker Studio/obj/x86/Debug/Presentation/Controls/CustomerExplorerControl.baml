   M S B A M L   `   `   `  ����T  PAvalonDock, Version=1.3.3571.0, Culture=neutral, PublicKeyToken=85a1e0ada7ec13e4;,clr-namespace:AvalonDock;assembly=AvalonDock
AvalonDock  5      N JGuest Booker Studio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Guest_Booker_Studio.CommandsGuest_Booker_Studio.Commands 5      9!clr-namespace:Guest_Booker_StudioGuest_Booker_Studio 5      e7clr-namespace:Guest_Booker_Studio.Presentation.Controls)Guest_Booker_Studio.Presentation.Controls 5	      G   AGuest_Booker_Studio.Presentation.Controls.CustomerExplorerControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      =dock,clr-namespace:AvalonDock;assembly=AvalonDock     5      8c*clr-namespace:Guest_Booker_Studio.Commands     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0cx!clr-namespace:Guest_Booker_Studio     5      Lcontrols7clr-namespace:Guest_Booker_Studio.Presentation.Controls     5	         AvalonDock.ManagedContent    Title$  Customer Explorer��5          AvalonDock.DockableContent   DockableStyle$ DockableButNotAutoHidden=�5      $��Right=�5         Icon 5      �� 5   
    �� 	UriSource$/ )/Presentation/Resources/Images/Search.png?�6   .��5      � 
������� � ToolTip$: 4Right Click on an item to view possible edit options��6#    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� 
������ y�6*   �� *
Visibility+._�5      �� 
������ $��1q�6/   
������� �� CornerRadius$ 2,2,2,2��6[   $��Center=�6r   $
��Left=�6�   ._�5      � $	��300��6   $��0��6#    � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $��30 �6+   �� 5      $��30 �6+   �� 5      $��20 �6+   .+�5       �� -   5        $��txtSearchTree��5       $
��Left=�6�   $��Center=�6�   $��10, 0, 0, 0q�6�   $	��200��6�   $��23��6�   $��SearchTree:��6  $��Palatino Linotype)�6  $��0��67  .��6o  5"      �� 5$      -   5        $��
btnRefresh��5$   -   $��1��6   $ Refresh��6?   $5��/c:CustomerExplorerCommands.LoadCustomerExplorer��6Q   .��5&      �� $2��,/Presentation/Resources/Images/Refresh16.png��6    $��20��6V   5'      �� 5)      -   5        $��btnAscending��5)   -   $��2��6   .��5*      �� $/��)/Presentation/Resources/Images/ascend.png��6    $��20��6S   5+       � 	Resources 5,      	 �� 
TargetType
 �� Property �� Value��%z   '��       �� 5-      "	 ��6    .�5.      �� 
 � ��
 ���� 6;   �� 5/      
 � ��
 ���� 6<   50      51      52      53      54      R� 55   
   -   5         R�Name$ CustomerTree��55   U   
������ $��Verdana)�6-   $��Light"�6B   $��1��6k   .@�56      Q� -   5        $��CustomersTreeItem��56      $��	Customers��64      Entities#���   6G    57       �� Orientation��%�  &	        'Q�     �� 59      .R�5:      �� $ 
Horizontal=�6%   .+�5;      �� $	��img��6$   $��18��5<      $��18��5=      $��1q�5>      $6��0/Presentation/Resources/Images/complex-types.png��5?      �� 5@      $	��5,0q�69   ��6(   �� 69   5A      5B      �� 5C      "	 Q�6   .�5D      �� 
 �@�ToolTip$8 2Right Click on Entity to Edit Structure/ Behaviour��64   5E      5F      5K      Q� 5L      -   5        $��ContactsTreeItems��5L      $��Contacts��64     HierarchyTemplate#���  6F    5M      ��%�  &	       'Q� !    �� 5O      HierarchyTemplate��.R�5P      �� $ 
Horizontal=�6%   .+�5Q      �� $	��img��6$   $��18��5R      $��18��5S      $��1q�5T      $5��//Presentation/Resources/Images/simple-types.png��5U      �� 5V      $	��5,0q�69   ��6(   �� 69   5W      5X      �� 5Y      "	 Q�6   .�5Z      �� 
 �@�ToolTip$8 2Right Click on Entity to Edit Structure/ Behaviour��64   5[      5\      5]      5^      5_      5`      