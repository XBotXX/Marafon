   M S B A M L   `   `   `  ����F  BWSR2016_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WSR2016_WPFWSR2016_WPF  5   	   !    WSR2016_WPF.ManageCharities   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WSR2016_WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ManageCharities��5	   	   $	��450��6!   $	��800��6.   .��5
      �  � RowDefinitions 5   
   �� 5      $	��21* �6   �� 5      $
��172* �6   �� 5      $	��14* �6   .+�5   
   �� 
�������
���   �$��1q�67   $
��Left=�6K   $��41��6f   $	��Top=�6r   $	��794��6�   $��
0,0,-0.4,0q�6�   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��
Назад��5      $��5,5,30,5q�6)   $��96��6;   $��15(�6F   6T   �� 5      $��MARATHON SKILLS 2016��6   $��20(�67   $
��Bold"�6E   
�������6W   �� 5      -   5        $��Logout��5      $��
300,5,30,5q�6*   $��96��6>   $��15(�6I   6W   5      5      �� 5   
   
�������
���   �$��1q�67   $��Center=�6K   $��28��6h   $��0q�6t   $��Center=�6   $	��795��6�   $��2��6�   ._�5      �� $��dmckdmck��6   $��Center=�6'   $��Center=�6D   $��Center=�6_   $��Center=�6�   $��13(�6�   
�������6�   5      �� 5   
   $��1��6   .+�5      �� $Z��TУправление благотворительными организациями��6   $��Center=�6J   $��Center=�6g   $��Center=�6�   $��Center=�6�   $��20(�6�   
�������6�   �� 5      -   5        $%��+ Добавить нового��5      $
��Left=�61   $��Center=�6L   $��Center=�6g   $��Center=�6�   $��15(�6�   $��	50,20,0,0q�6�   $��	10,5,10,5q�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgUsers��5         AutoGenerateColumns .     CanUserAddRows .  $��1��6[   $��
50,20,50,0q�6h   $	��240��6|   $��15(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Лого��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 0.5* 67   
   FontSize$
 15Q�6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *CharityLogo+6d     5       $ Наименование��6)   $	 1* 6?   $
 15Q�6j    6J   �� *CharityName+6j     5!      $ Описание��6)   $	 1* 6;   $
 15Q�6m    6F   �� *CharityDescription+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $
	 0.5* 6-      CellTemplate 5#      �� 5$      .R�5%   "   ��  ��Name$ GotoEditCharity��6�   -   5        $
��Edit��5%   )   $��Center=�68   $��15(�6\   $��	15,0,15,0q�6j   $��25��6~   6�   5&      5(      5*      5+      5,      5-      