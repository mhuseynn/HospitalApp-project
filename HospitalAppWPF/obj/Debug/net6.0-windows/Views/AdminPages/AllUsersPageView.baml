   M S B A M L   `   `   `  ����I  EHospitalAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:HospitalAppWPF.Views.AdminPagesHospitalAppWPF.Views.AdminPages  5      6    0HospitalAppWPF.Views.AdminPages.AllUsersPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:HospitalAppWPF.Views.AdminPages     5      -   5          N�Name$  users_pg��5	        N� Title$ AllUsersPageView��6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��0.5* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��1* �6    �� 5      $
��0.2* �6    .+�5      �� $
��Left=�6   $	��Top=�60   $��50��6H   $��30��6S   $
��Back��6_   $��15(�6n   ��6|   �� *	backbtn+��6�   ��  �� ElementName$ users_pg���� 5      $
��Auto=�6   $��0 40 0 0q�6>   .��5      �� -   5         ��Name$ myList��5       �� SelectionMode$ Single=�6J   ��6,   �� *Users+ �� View 5      �� 5      .P�5      ��  �� Width$ 50��6-   $��Id��68   	 �� DisplayMemberBinding	 6D   �� *Id+�� 5      $	 100��6-   $��	FirstName��69   	 6L   �� *	FirstName+�� 5      $	 100��6-   $��LastName��69   	 6K   �� *
LastName+�� 5      $	 100��6-   $��Username��69   	 6K   �� *
UserName+�� 5       $	 100��6-   $��Password��69   	 6K   �� *
Password+5!      5$      5%      �� 5'      $��1��6   
 �� Orientation$
 
Horizontal=�6'   $��Center=�6@   .+�5(      �� $��Remove��5*      $	��100��6#   $��50��6/   $��Center=�6;   $��Center=�6X   ��5(      �� *	removebtn+��5)      �� $ myList��5*   X   �� 5-      $��10 0 0 0q�5/      $
��Edit��6(   $	��100��67   $��50��6C   $��Center=�6O   $��Center=�6l   ��5-      �� *	editbtn+��5.      �� $ myList��5/   l   51      52      � 55   
   
�������$��1��6"   .+�56      �� $��Add or Edit User��6   $��30(�60   $��0 30 0 0q�6>   $��Center=�6P   $	��Top=�6m   �� 57      $��Center=�6   $��Center=�66   $
 Vertical=�6Q   .+�58      �� $��Id��6   �� 59      ${�False��6   $	��200��6,   $��30��68   ��6D   �� *	User.Id+ �� Mode$ TwoWay=��� 5;      $��
First Name��6   �� 5<      $	��200��6   $��30��6'   ��63   �� *User.FirstName+$ TwoWay=��� 5>      $��	Last Name��6   �� 5?      $	��200��6   $��30��6'   ��63   �� *User.LastName+$ TwoWay=��� 5A      $��Username��6   �� 5B      $	��200��6   $��30��6'   ��63   �� *User.UserName+$ TwoWay=��� 5D      $��Password��6   �� 5E      $	��200��6   $��30��6'   ��63   �� *User.Password+$ TwoWay=��� 5G      $	��200��6   $��30��6%   $
��Save��61   ��6@   �� *	savebtn+��6\   �� *	User.Id+5H      5J      5K      5L      