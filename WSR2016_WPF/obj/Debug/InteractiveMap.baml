   M S B A M L   `   `   `  ����F  BWSR2016_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WSR2016_WPFWSR2016_WPF  5   	        WSR2016_WPF.InteractiveMap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WSR2016_WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ InteractiveMap��5	   	   $	��450��6    $	��800��6-   .��5
      �  � RowDefinitions 5   
   �� 5      $	��21* �6   �� 5      $
��186* �6   .+�5   
   �� 
�������
���   �$��1q�67   $
��Left=�6K   $��41��6f   $	��Top=�6r   $	��794��6�   $��
0,0,-0.4,0q�6�   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��
Назад��5      $��5,5,30,5q�6)   $��96��6;   $��15(�6F   6T   �� 5      $��MARATHON SKILLS 2016��6   $��20(�67   $
��Bold"�6E   
�������6W   5      5      � 5   
   $��1��6   .+�5      �� $��12_1.jpg��6   $
��Left=�6&   $��50,0,0,0q�6A   �� 5      -   5         ��Name$ Checkpoint_1��5      $��268,15,495.6,332.6q�6+    J� Opacity$ 0Q�6G   6S   �� 5      -   5        $ Checkpoint_2��5      $��309,120,454.6,227.6q�6+   $ 0Q�6H   6T   �� 5      -   5        $ Checkpoint_3��5      $��300,196,463.6,151.6q�6+   $ 0Q�6H   6T   �� 5      -   5        $ Checkpoint_4��5      $��392,277,371.6,70.6q�6+   $ 0Q�6G   6S   �� 5      -   5        $ Checkpoint_5��5      $��248,328,515.6,19.6q�6+   $ 0Q�6G   6S   �� 5      -   5        $ Checkpoint_6��5      $��132,290,631.6,57.6q�6+   $ 0Q�6G   6S   �� 5      -   5        $ Checkpoint_7��5      $��95,226,668.6,121.6q�6+   $ 0Q�6G   6S   �� 5      -	   5        $ Checkpoint_8��5      $��86,118,677.6,229.6q�6+   $ 0Q�6G   6S   �� 5       $!��icon map\map-icon-start.png��6   $��178,15,562.6,316.6q�69   �� 5!      $!��icon map\map-icon-start.png��6   $��278,322,462.6,9.6q�69   �� 5"      $!��icon map\map-icon-start.png��6   $��86,153,654.6,178.6q�69   �� 5#      -
   5        $ FM��5#      $��178,15,562.6,316.6q�6!   $ 0Q�6=   6I   �� 5$      -   5        $ HM��5$      $��283,322,462.6,9.6q�6!   $ 0Q�6<   6H   �� 5%      -   5        $ FR��5%      $��86,153,659.6,178.6q�6!   $ 0Q�6=   6I   �� 5(      -   5         ��Name$ ChekPointBorder��5(   )   $y�Hidden=�6   
�������$��Right=�6Y   $��Center=�6u   $��	0,0,100,0q�6�   $��1q�6�   
���   �._�5)      �� .+�5*      �� $ 
Horizontal=�6!   .+�5+      �� -   5         ��Name$ ChekName��5+       $��Checkpoint 1��62   $
��Left=�6I   $��Center=�6d   $��Center=�6   $��Center=�6�   $��20(�6�   $
��Bold"�6�   
�������$��20,0,0,0q�6�   �� 5,      -   5        $ 	CloseList��5,   !   $��X��64   $��5q�6@   $��Center=�6L   $��Center=�6i   6�   5-      �� 5.      -   5        $ landN��5.      $��
Landmark: ��6+   $
��Left=�6@   $��Center=�6[   $��Center=�6v   $��Center=�6�   $��15(�6�   $
��Bold"�6�   
�������$��20,0,0,0q�6�   �� 5/      -   5         ��Name$ Landmark��5/   :   $
��Left=�6L   $��15(�6g   $��	20,0,10,0q�6u   $
��Wrap=�6�   ��6    �� *
LandMark+6�   �� 50      -   5        $ ServiceProv��50      $��Services Provided: ��61   $
��Left=�6O   $��Center=�6j   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   
�������$��20,0,0,0q�6�   �� 51      -   5        	 ��Name$
	 list��51   5   
�������$��15(�6C   $��20,0,0,0q�6Q   $��0q�6c   $��10q�6w   ��52      �� 53      .R�54   "   � $��	10,0,10,0q�6'   .+�55   &   �� $ 
Horizontal=�61   .+�56   *   �� 
 ��Name$
 Image��60   $��30��6X   $��30��6d   $
��Fill=�6o   $��0,0,10,0q�6~   ��6?   �� *image+6~   �� 57   *   $��13(�64   $��1��6B   $
��Wrap=�6d   ��6O   �� *str+6d   58   '   59   #   5:      5<      5=      5>      5A      5B      5C      