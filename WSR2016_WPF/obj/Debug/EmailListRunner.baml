   M S B A M L   `   `   `  ����F  BWSR2016_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WSR2016_WPFWSR2016_WPF  5   	   !    WSR2016_WPF.EmailListRunner   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WSR2016_WPF     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � WindowStyle$ 
ToolWindow=�5	   	    � Title$ EmailListRunner��5
   	   $	��300��6!   $	��500��6.   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��0.2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUsersEmail��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 62   
   FontSize$
 15Q�6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Name+6V     5      $ Фамилия��6%   $	 1* 66   $
 15Q�6]    6A   �� *	Surname+6]     5      $ Email��6%   $	 1* 64   $
 15Q�6Y    6?   �� *Email+6Y   5      �� 5   
   -   5         ��Name$
 Copy��5      $��	CopyEmail��6   $��Right=�63   $��Center=�6O   $��0,0,20,0q�6j   $
��10,5q�6|   $��1��6�   6�   5      5      