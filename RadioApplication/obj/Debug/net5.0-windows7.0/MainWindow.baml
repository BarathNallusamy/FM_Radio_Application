   M S B A M L   `   `   `  ����K  GRadioApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RadioApplicationRadioApplication  5   	   !    RadioApplication.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:RadioApplication     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��500��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��FM Radio��6   $��15(�6%   $
��Bold"�5   
   $��0��6   $��0��60   �� 5   
   $��	10,0,10,0q�6   $��0��6(   $��2��6:    �� Orientation$ 
Horizontal=�6I   $	��478��6d   .+�5      �� -   5        $��btnOne��5      $	��115��6;   .��6H   	BBC ONE6Q   �� 5      -   5        $��btnTwo��5      $	��115��6;   .��6G   	BBC TWO6P   �� 5      -   5        $��btnThree��5      $	��115��6?   .��6K   	BBC THREE6V   �� 5      -   5        $��btnFour��5      $	��115��6=   .��6I   
BBC FOUR6S   5      �� 5   
   $��	10,0,10,0q�6   $��0��6)   $��3��6;   $ 
Horizontal=�6J   $��Center=�6e   $��Center=�6�   .+�5       �� $��Power:��6   $��5q�6'   	� 5!      -   5         	�Name$ ONButton��5!      $��5q�6,    	� 	GroupName$ First Group��5"      $��On��6%   	� 5#      -   5        $ 	OFFButton��5#      $��5q�6-   $ First Group��5$      $	��Off��6%    d� 	IsChecked$
 TrueY�63   5%      5(      5)      