   M S B A M L   `   `   `  ����I  EHospitalAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:HospitalAppWPF.Views.UserPagesHospitalAppWPF.Views.UserPages  5      8    2HospitalAppWPF.Views.UserPages.AllAppointmentsView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:HospitalAppWPF.Views.UserPages     5      -   5          �Name$  pageappo��5	   #    � Title$ AllAppointmentsView��6    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � 
ResizeMode$ NoResize=�6m   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      .+�5   
   �� $��0��6   
������ $��Right=�6�   $��0q�6�   $��Right=�6�   $��0 0 5 0q�6�   ��6   �� *	backbtn+��6;   ��  �� ElementName$ pageappo��.��5      �� $��0��6   $ ��../../../StaticFiles/R.png��6"   $��30��6F   $��20��6Q   $��Right=�6^   $��0 0 5 0q�6z   5      �� 5   
   $��1��6   $
��Auto=�6$   $��	0 10 0 10q�6G   .��5      �� -   5         ��Name$ myList��5   /   
������ �� SelectionMode$ Single=�6n   ��6@   �� *AppointmentsConfirmed+	 �� View	 5      �� 5      .P�5      �� 
 �� Width$
 50��6)   $��Id��65    �� DisplayMemberBinding 6A   �� *Id+�� 5      $	
 100��6)   $��Doctor Name��65    6J   �� *
DoctorName+�� 5      $	
 100��6)   $��	User Name��65    6H   �� *
UserName+�� 5       $	
 100��6)   $��	Date Time��65    6H   �� *
Datetime+�� 5!      $	
 100��6)   $��Is Confirmed��65    6K   �� *IsConfirmed+5"      5$      5%      �� 5'   
   $��2��6   $
��Auto=�6%   $��	0 10 0 10q�6H   .��5(      �� -   5        $ myList2��5(   ,   ���#f27575$ Single=�6o   ��6>   �� *AppointmentsNotConfirmed+	 5)      �� 5*      .P�5+      �� $
 50��6)   $��Id��65    6A   �� *Id+�� 5,      $	
 100��6)   $��Doctor Name��65    6J   �� *
DoctorName+�� 5-      $	
 100��6)   $��	User Name��65    6H   �� *
UserName+�� 5.      $	
 100��6)   $��	Date Time��65    6H   �� *
Datetime+�� 5/      $	
 100��6)   $��Is Confirmed��65    6K   �� *IsConfirmed+50      53      54      5<      5>      