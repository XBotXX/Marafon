   M S B A M L   `   `   `  ����F  BWSR2016_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WSR2016_WPFWSR2016_WPF  5   	       WSR2016_WPF.MyRaceResult   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WSR2016_WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ MyRaceResult��5	   	   $	��450��6   $	��800��6+   .��5
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
   $��1��6   .+�5      �� $!��Мои результаты��6   $��Center=�6-   $��Center=�6Q   
�������$��20(�6�   �� 5      $����   Это - список всех ваших прошлых результатов гонки для Marathon Skills,
                             Общее место сравнивает всех бегунов.
Место по категории compares runners in the same gender and age categories��6   $��Center=�6�   $��Center=�6   $��15(�6B  �� 5      $ 
Horizontal=�6   .+�5      �� $��Пол:��6   $��Center=�6'   $��Center=�6K   $��15(�6m   $
��Bold"�6{   $��	230,0,0,0q�6�   �� 5      $��мужской��6   $��Center=�6*   $��Center=�6N   $��15(�6p   �� 5       $.��(Возрастная категория:��6   $��Center=�68   $��Center=�6\   $��15(�6~   $
��Bold"�6�   �� 5!      $��18-29��6   $��Center=�6(   $��Center=�6L   $��15(�6n   5"      &   System.Windows.Controls.DataGrid  5#      -   5          Name$ ResultationRunner��5#      $	��140��62   $��	0,10,0,10q�6?      AutoGenerateColumns .     Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Марафон��6)      FontSize$ 15Q�6Z   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6h   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *MarafonName+6h     5&      $ Дистанция��6)   $ 15Q�6Y   $	 1* 6g   
 6<   �� *
Distance+6g     5'      $ 
Время��6)   $ 15Q�6T   $	 1* 6b   
 68   �� *	TimeRun+6b     5(      $ Общее место��6)   $ 15Q�6[   $	 1* 6i   
 6>   �� *
Mestoall+6i     5)      $( "Место по категории��6)   $ 15Q�6g   $	 1* 6u   
 6E   �� *MestoCategory+6u   5+      �� 5,      -   5        $2��,Показать все результаты��5,      $��Center=�67   $��Center=�6[   $��15(�6}   $��Center=�6�   $��Center=�6�   $��	15,5,15,5q�6�   $��5q�6�   6�   5-      5.      5/      