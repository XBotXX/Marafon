   M S B A M L   `   `   `  ����F  BWSR2016_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WSR2016_WPFWSR2016_WPF  5   	       WSR2016_WPF.Otchet   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WSR2016_WPF     5   	     � WindowStyle$  
ToolWindow=�5   	    � WindowStartupLocation$ CenterOwner=�5	   	    � Title$ Otchet��5
   	   $	��300��6   $	��500��6%   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��1* �6   �� 5      $
��0.3* �6   .+�5   
   �� $��Инвентарь��6   $��Center=�6$   $��Center=�6A   $��Center=�6\   $��Center=�6~   $��20(�6�   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5         AutoGenerateColumns .  $��	30,0,30,0q�6A   $��1��6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Комплект��6%      FontSize$ 15Q�6T   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6b   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *
Complect+6b     5      $ Тип A��6%   $ 15Q�6M   $	 1* 6[   
 64   �� *TipA+6[     5      $ Тип B��6%   $ 15Q�6M   $	 1* 6[   
 64   �� *TipB+6[     5      $ 	Тип С��6%   $ 15Q�6M   $	 1* 6[   
 64   �� *TipC+6[     5      $ Необходимо��6%   $ 15Q�6R   $	 1* 6`   
 69   �� *Summ+6`     5      $ Остаток��6%   $ 15Q�6R   $	 1* 6`   
 66   �� *	Ostatok+6`   5      �� 5   
   $��4��6   $��3��6   $��Печать��6.   $
��Left=�6?   $��Center=�6Z   $��Center=�6u   $��Center=�6�   $��15(�6�   $��30,0,0,0q�6�   $��	15,5,15,5q�6�   5      5      