   M S B A M L   `   `   `  ����A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5   	   '    !client.CustomerManagementForAdmin   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:client     5   	     � Title$   CustomerManagementForAdmin��5   	   $	��450��6,   $	��800��69   .��5
      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      .+�5   
   �� $��0��6   $
��Bold"�6   $��20(�6/   $��Center=�6=   $��Center=�6Z   $��Admin Customer Management��6u   &   System.Windows.Controls.DataGrid  5   
   -   5        $��CustomersDG��5   N   $��1��6      AutoGenerateColumns$ False��6    $��5,5,5,69q�6<      
IsReadOnly$
 True��6a      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
CustomerId+  5      $ Personal ID��6%    6:   �� *
PersonalId+  5      $ 
First Name��6%    69   �� *	FirstName+  5      $ 	Last Name��6%    68   �� *
LastName+  5      $ Address��6%    66   �� *	Address+5        5   
   -   5        $��CustomersAndMeetingDG��5   Q   $��2��6   $ False��6    $��400,5,10,10q�6<   $
 True��6n    5!        5"      $ Customer ID��6%    6:   �� *
CustomerId+  5#      $ Personal ID��6%    6:   �� *
PersonalId+  5$      $ 
First Name��6%    69   �� *	FirstName+  5%      $ 	Last Name��6%    68   �� *
LastName+  5&      $ Address��6%    66   �� *	Address+  5'      $ 
Meeting ID��6%    69   �� *	MeetingId+  5(      $
 Date��6%    63   �� *Date+  5)      $ Subject��6%    66   �� *MeetingSubject+  5*      $ Description��6%    6:   �� *Description+5.      � 52   
   $��2��6    � ColumnDefinitions 54      �� 55      $
��182* �6#   �� 56      $
��105* �6#   �� 57      $	��66* �6#   �� 58      $	��22* �6#   �� 59      $	��25* �6#   �� 5:      $
��400* �6#   .+�5=      �� $��0��6   
���   �$��1q�69   $��	5,-46,5,5q�6M   $��5��6`   ._�5>      �� $��5q�6   .+�5?      �� $��Add new Customer��6   $��Center=�67   $��Center=�6T   � 5A      -   5         �Name$ AddNewCustomerGrid��5A   &   $��5q�6    5B      �� 5C      �� 5D       5G      �� 5H      �� 5I      �� 5J      �� 5K      �� 5L      .+�5Q      �� $��1��6    $��0��6-   $��Personal ID��6=   �� 5R      -   5        $��
personalId��5R   "   $��1��64   $��1��6A   ��6Q   �� *
PersonalId+�� 5T      $��2��6    $��0��6-   $��
First Name��6=   �� 5U      -   5        $��	firstName��5U   "   $��2��63   $��1��6@   ��6P   �� *	FirstName+�� 5W      $��3��6    $��0��6-   $��	Last Name��6=   �� 5X      -   5        $��lastName��5X   "   $��3��62   $��1��6?   ��6O   �� *
LastName+�� 5Z      $��4��6    $��0��6-   $��Address��6=   �� 5[      -   5        $��address��5[   "   $��4��61   $��1��6>   ��6N   �� *	Address+�� 5]      -   5        $��4��5]   !   $��2��6.   $	��Add��6B   $��0,35,10,-25q�6P   6e   5_      5a      5b      5d      �� 5f   
   -	   5        $��	BackClick��5f      $
��Back��6"   $
��Left=�61   $��
657,30,0,0q�6L   $	��Top=�6`   $��18��6x   $��91��6�   6�   �� 5g   
   $��Customers Meetings��6   $
��Left=�6-   $��476,145,0,0q�6H   $��1��6]   $	��Top=�6j   $	��179��6�   �� 5h   
   $��Customers Table��6   $
��Left=�6*   $��	28,22,0,0q�6E   $	��Top=�6X   $	��179��6p   5j      5k      