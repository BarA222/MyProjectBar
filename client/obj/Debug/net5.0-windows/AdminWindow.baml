   M S B A M L   `   `   `  ����A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5   	       client.AdminWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:client     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      �� 5      .+�5   
   �� $��0��6   $
��Bold"�6   $��20(�6/   $��Center=�6=   $��Center=�6Z   $��
Management��6u   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	MeetingDG��5   N   $��1��6      AutoGenerateColumns$ False��6    $��5,5,5,69q�6<      
IsReadOnly$
 True��6_      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Meeting Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	MeetingId+  5      $
 Date��6%    63   �� *Date+  5      $ Subject��6%    66   �� *MeetingSubject+  5      $ Description��6%    6:   �� *Description+  5      $ Customer ID��6%    6:   �� *
CustomerId+  5      $ User ID��6%    66   �� *UserId+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Update Meeting��6)      CellTemplate 5      �� 5      .R�5       �� -   5        $
��Edit��5    %   64   5!      5#        5%      $ Delete Meeting��6)    5&      �� 5'      .R�5(      �� -   5        $��Delete��5(   %   66   5)      5+      5.      � 50   
   $��2��6    � ColumnDefinitions 52      �� 53      �� 54      .+�57      �� $��0��6   
���   �$��1q�69   $��5q�6M   ._�58      �� $��5q�6   .+�59      �� $��Add new Meeting��6   $��Center=�66   $��Center=�6S   � 5;      -   5        	 �Name$	 AddNewMeetingGrid��5;   &   $��5q�6    5<      �� 5=      �� 5>       5A      �� 5B      �� 5C      �� 5D      �� 5E      �� 5F      .+�5I      �� $��0��6    $��0��6-   $��Select user��6=   �� 5K      -   5        $��usersLst��5K   #   $��0��63   $��1��6@   
 �� DisplayMemberPath$
 UserName��6P   5M      �� 5O      $��1��6    $��0��6-   $��Select customer��6=   �� 5R      -   5        $��customersLst��5R   #   $��1��67   $��1��6D   $
 	FirstName��6T   5T      �� 5V      $��2��6    $��0��6-   $��Subject��6=   �� 5W      -   5        $��subject��5W   "   $��2��61   $��1��6>   ��6N   �� *MeetingSubject+�� 5Y      $��3��6    $��0��6-   $��Description��6=   �� 5Z      -   5        $��description��5Z   "   $��3��65   $��1��6B   ��6R   �� *Description+�� 5\      -	   5        $��4��5\   !   $��2��6.   $	��Add��6B   $��5q�6P   6[   5^      5`      5a      �� 5d      $��1��6   
���   �$��1q�69   $��5q�6M   ._�5e      �� $��5,0,5,5q�6   $	��165��6.   $��Bottom=�6;   .+�5f      �� $��Update Meeting��6   $��Center=�65   $��Center=�6R   � 5h      -
   5        $��UpdateMeetingGrid��5h   &   $��5q�6    5i      �� 5j      �� 5k       5n      �� 5o      �� 5p      �� 5q      �� 5r      �� 5s      .+�5v      (  "System.Windows.Controls.DatePicker  -   5        $��
DatePicker��5v   %   $��0��67   $��1��6D      Text 6T   �� *Date+�� 5w      $��0��6    $��0��6-   $
��Date��6=   �� 5z      $��1��6    $��0��6-   $��Subject��6=   �� 5{      -   5        $��Subject��5{   "   $��1��61   $��1��6>   ��6N   �� *MeetingSubject+�� 5}      $��2��6    $��0��6-   $��Description��6=   �� 5~      -   5        $��Description��5~   "   $��2��65   $��1��6B   ��6R   �� *Description+�� 5�      -   5        $��4��5�   !   $��2��6.   $��Update��6B   $��5q�6S   6^   5�      5�      5�      5�      �� 5�   
   -   5        $��	BackClick��5�      $
��Back��6"   $
��Left=�61   $��
657,30,0,0q�6L   $	��Top=�6`   $��18��6x   $��91��6�   6�   �� 5�   
   -   5        $��CustomerManageClick��5�      $��Go to customer Management��6,   $
��Left=�6P   $��574,155,0,0q�6k   $��1��6�   $	��Top=�6�   $��21��6�   $	��168��6�   6�   5�      5�      