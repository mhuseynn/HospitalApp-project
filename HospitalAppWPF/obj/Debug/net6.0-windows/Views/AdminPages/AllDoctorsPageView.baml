   M S B A M L   `   `   `  ����I  EHospitalAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:HospitalAppWPF.Views.AdminPagesHospitalAppWPF.Views.AdminPages  5      8    2HospitalAppWPF.Views.AdminPages.AllDoctorsPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:HospitalAppWPF.Views.AdminPages     5      -   5          N�Name$  
doctors_pg��5	   "    N� Title$ AllDoctorsPageView��6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��0.5* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��1* �6    �� 5      $
��0.2* �6    .+�5      �� $
��Left=�6   $	��Top=�60   $��50��6H   $��30��6S   $
��Back��6_   $��15(�6n   ��6|   �� *	backbtn+��6�   ��  �� ElementName$ 
doctors_pg���� 5      $
��Auto=�6   $��0 40 0 0q�6>   .��5      �� -   5         ��Name$ myList��5       �� SelectionMode$ Single=�6L   ��6,   �� *	Doctors+ �� View 5      �� 5      .P�5      ��  �� Width$ 50��6-   $��Id��69   	 �� DisplayMemberBinding	 6E   �� *Id+�� 5      $	 100��6-   $��	FirstName��69   	 6L   �� *	FirstName+�� 5      $	 100��6-   $��LastName��69   	 6K   �� *
LastName+�� 5       $	 100��6-   $��Username��69   	 6K   �� *
UserName+�� 5!      $	 100��6-   $��Password��69   	 6K   �� *
Password+�� 5"      $	 100��6-   $��Department Id��69   	 6P   �� *DepartmentId+5#      5&      5'      �� 5)      $��1��6   
 �� Orientation$
 
Horizontal=�6'   $��Center=�6@   .+�5*      �� $��Remove��5,      $	��100��6'   $��50��63   $��Center=�6?   $��Center=�6\   ��5*      �� *	removebtn+��5+      �� $ myList��5,   \   �� 5/      $��10 0 0 0q�51      $
��Edit��6,   $	��100��6;   $��50��6G   $��Center=�6S   $��Center=�6p   ��5/      �� *	editbtn+��50      �� $ myList��51   p   53      54      � 57   
   
�������$��1��6"   .+�58      �� $��Add or Edit Doctor��6   $��30(�62   $��0 30 0 0q�6@   $��Center=�6R   $	��Top=�6o   �� 59      $��Center=�6   $��Center=�66   $
 Vertical=�6Q   .+�5:      �� $��Id��6   �� 5;      ${�False��6   $	��200��6,   $��30��68   ��6D   �� *	Doctor.Id+ �� Mode$ TwoWay=��� 5=      $��
First Name��6   �� 5>      $	��200��6   $��30��6'   ��63   �� *Doctor.FirstName+$ TwoWay=��� 5@      $��	Last Name��6   �� 5A      $	��200��6   $��30��6'   ��63   �� *Doctor.LastName+$ TwoWay=��� 5C      $��Username��6   �� 5D      $	��200��6   $��30��6'   ��63   �� *Doctor.UserName+$ TwoWay=��� 5F      $��Password��6   �� 5G      $	��200��6   $��30��6'   ��63   �� *Doctor.Password+$ TwoWay=��� 5I      $��Department Id��6   �� 5J      $	��200��6   $��30��6'   ��63   �� *Doctor.DepartmentId+$ TwoWay=��� 5L      $	��200��6   $��30��6%   $
��Save��61   ��6@   �� *	savebtn+��6\   �� *	Doctor.Id+5M      5O      5P      5Q      