   M S B A M L   `   `   `  ����A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5   	       client.ConsultantMenu   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:client     5   	     � Title$  ConsultantMenu��5   	   $	��450��6    $	��800��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��5* �6   .+�5   
   �� $��Select UserId:��6   �� 5   
   $��Enter Date:��6   $��1��6'   �� 5   
   -   5        $��usersLst��5      $��0��6#   $��1��60    �� DisplayMemberPath$ UserName��6@   $��	0,4,29,15q�6]   5      �� 5   
   -   5        $	��Top=�5      $��2��6)   $��See details��66   $	��100��6L   $��20��6X   6d   �� 5   
   -   5        $	��Top=�5      $��2��6)   $
��Back��66   $	��100��6E   $��20��6Q   $��1��6o   $��	30,0,30,0q�6   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��MeetingsList��5!         
IsReadOnly$
 True��6)   $��2��6;   $��5��6H   $��
8,39,12,14q�6\   $��4��6p   �� 5"   
   -   5        $��CustomerManagementClick��5"      $��Go to customer management��60   $��3��6T   $
��Left=�6d   $��	10,40,0,0q�6   $��1��6�   $	��Top=�6�   $��2��6�   $��32��6�   $��2��6�   $	��211��6�   6�   (  "System.Windows.Controls.DatePicker  5#   
   -   5        $��
DatePicker��5#      $��1��6'   $��Center=�67   $��0,3,0,0q�6T   $��1��6e   $	��Top=�6r   5%      5(      