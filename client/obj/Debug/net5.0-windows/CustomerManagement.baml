   M S B A M L   `   `   `  ����A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5   	       client.CustomerManagement   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:client     5   	     � Title$  CustomerManagement��5   	   $	��450��6$   $	��800��61   .��5
      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      .+�5   
   �� $��0��6   $
��Bold"�6   $��20(�6/   $��Center=�6=   $��Center=�6Z   $��Customer Management��6u   &   System.Windows.Controls.DataGrid  5   
   -   5        $��CustomersDG��5   N   $��1��6      AutoGenerateColumns$ False��6    $��5,5,5,69q�6<      
IsReadOnly$
 True��6a      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
CustomerId+  5      $ Personal ID��6%    6:   �� *
PersonalId+  5      $ 
First Name��6%    69   �� *	FirstName+  5      $ 	Last Name��6%    68   �� *
LastName+  5      $ Address��6%    66   �� *	Address+5        5   
   -   5        $��CustomersAndMeetingDG��5   N   $��2��6   $ False��6    $��5,5,5,10q�6<   $
 True��6k    5!        5"      $ Customer ID��6%    6:   �� *
CustomerId+  5#      $ Personal ID��6%    6:   �� *
PersonalId+  5$      $ 
First Name��6%    69   �� *	FirstName+  5%      $ 	Last Name��6%    68   �� *
LastName+  5&      $ Address��6%    66   �� *	Address+  5'      $ 
Meeting ID��6%    69   �� *	MeetingId+  5(      $
 Date��6%    63   �� *Date+  5)      $ Subject��6%    66   �� *MeetingSubject+  5*      $ Description��6%    6:   �� *Description+5.      � 51   
   $��2��6    J� RenderTransformOrigin$ 0.149,0.535&�6    � ColumnDefinitions 53      �� 54      $
��182* �6#   �� 55      $
��105* �6#   �� 56      $	��66* �6#   �� 57      $	��22* �6#   �� 58      $	��25* �6#   �� 59      $
��247* �6#   �� 5:      $	��22* �6#   �� 5;      $	��27* �6#   �� 5<      $
��104* �6#   5>      �� 5@   
   -   5        $��	BackClick��5@      $
��Back��6"   $
��Left=�61   $��
657,30,0,0q�6L   $	��Top=�6`   $��18��6x   $��91��6�   6�   �� 5A   
   $��Customers Meetings Table��6   $
��Left=�63   $��
10,149,0,0q�6N   $��1��6b   $	��Top=�6o   �� 5B   
   $��Customers Table��6   $
��Left=�6*   $��	10,22,0,0q�6E   $	��Top=�6X   $	��139��6p   5D      5E      