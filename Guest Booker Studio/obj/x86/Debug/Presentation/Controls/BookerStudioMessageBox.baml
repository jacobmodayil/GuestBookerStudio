   M S B A M L   `   `   `  ����  Guest Booker StudioF    @Guest_Booker_Studio.Presentation.Controls.BookerStudioMessageBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  GuestBookerMessageBox��5       � Title$) #ECC Guest booker Studio Message box��5   	    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�6�   ���#FFF$	��175��5   	   $	��350��65   
������ $��0q�6[   $	��175��6o   $	��350��6    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5	      �� -   5         g�Name$ FormFade��5	      .��5
      W� -   5        $ FormFadeAnimation��5
   '   	 �� 
TargetName$	 GuestBookerMessageBox��5      
 �� TargetProperty$
 (Window.Opacity)�5       W� From$	 0.0X�5      	 W� To$	 1.0X�6    g� Duration$ 0:0:0.2D�6     g� AutoReverse .   g� RepeatBehavior$ 1x��5       5      5      5      :� 5   
   $ Window.Unloaded��6   .[�5      �� .��5      �� -   5        $ FormFadeOut��5      .��5      W� -   5        $ FormFadeOutAnimation��5   '   $	 GuestBookerMessageBox��5      $
 (Window.Opacity)�5      $	 1.0X�5      $	 0.0X�6   $ 0:0:0.2D�6     .  $ 1x��5       5      5      5      .��5       ��  �� CornerRadius$ 7,7,0,0��6   
���   �$��1q�68   ._�5!   
   � ���#FFF � RowDefinitions 5"      �� 5#      $��25 �6    �� 5$      $��* �6    �� 5%      $��40 �6    .+�5'      � -   5         �Name$ 
Part_Title��5'   5   $��0��6   ���#3C3324 � ColumnDefinitions 5(      �� 5)      $��* �6'   $	��300��61   �� 5*      $��20 �6'   .+�5,      �� -   5         ��Name$! BookerStudioMessageBoxTitle��5,   ,   $��0��6   $��Center=�6S   $
��Left=�6p   
�������$��SemiExpanded&�6�   ��6�   �� �� 5-      -   5         ��Name$ closeMessageBoxButton��5-   )   $��1��6   .��5.      �� $.��(/Presentation/Resources/Images/close.gif��6   5/       � 	Resources 50       �� 
TargetType �� Property �� Value��%h  '��       '�� �     �� 51      " ��6   .�52      ��  � ��$ 18��63   �� 53       � ��$ 18��62   �� 54       � ��
 ���� 67   �� 55       � ��
 ���� 68   56      �� 57      " ��6   .�58      ��  � ��$ 18��63   �� 59       � ��$ DemiBold"�67   �� 5:       � ��$ 10,3,0,0q�63   5;      5<      5=      � 5>      $��1��6    5?      �� 5@      $��30 �6'   �� 5A      $��70 �6'   �� 5B      $��* �6'   .+�5D      �� -	   5         ��Name$! BookerStudioMessageBoximage��5D      $��1��6=   �� 5E      -
   5        $  BookerStudioMessageBoxText��5E      $��13(�6@   $��2��6N   $��WordEllipsis=�6^   $
��Wrap=�6z   $��Center=�5F      $��DemiBold"�67   $��Stretch=�6M   
���   � �� Padding$ 3q�6~   $��SemiExpanded&�6�   5G      �� 5H      -   5        $��cmdOk��5H   /   $��2��6   $��Ok��6"   $��30��6<   $��	221,0,0,6q�6\   $
��Left=�6o   �� 5I      -   5        $��	cmdCancel��5I   3   $��2��6   $��Cancel��6"   $��0,0,6,6q�6]    5J         GlassButton �� BasedOn��%   '��       7   �� 5K      " ��6   8   .�5L      ��  � ��$ Right=�6<   �� 5M       � ��$ Bottom=�6:   �� 5N       � ��$ 50��61   �� 5O       � ��$
 Auto��6.   �� 5P       � ��$ 10, 10, 10, 10q�6/   5Q      5R      5S      5T      5U      