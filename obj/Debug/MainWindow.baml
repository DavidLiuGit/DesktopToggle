   M S B A M L   `   `   `  ����I  EDesktop Toggle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Desktop_ToggleDesktop_Toggle  5   	       Desktop_Toggle.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Desktop_Toggle     5   	     � Title$  Desktop Toggle��5   	   $��280.589��6    $��393.824��61    � 
ResizeMode$ CanMinimize=�6A   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $
��152* �6   .+�5   
   �� -   5         ��Name$ desktopButton��5      $��Show desktop��6(   $
��Left=�6?   $��	10,10,0,0q�6Z   $	��Top=�6m   $	��366��6�   $��46��6�   $��Roboto Light)�6�   $��22(�6�   $��2��6�   
�������6�   �� 5   
   -   5         ��Name$ timeTextbox��5      $
��Left=�6'   $��46��6B   $��	10,67,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $��94��6�   $��Roboto Light)�6�   $��25(�6�   $��2��6�   �� 5   
   -   5        $ setTimerButton��5      $��	Set Timer��6)   $
��Left=�6=   $��26.529,67,0,0q�6X   $	��Top=�6o   $	��267��6�   $��46��6�   $��22(�6�   $��Roboto Light)�6�   $��1��6�   
�������6�   	� 5   
   -   5         	�Name$ minRadio��5      $��Minutes��6(   $
��Left=�6:   $��
10,124,0,0q�6U   $	��Top=�6i    	� 	GroupName$ timeUnit��6�    d� 	IsChecked$
 TrueY�6�   $��Roboto Light)�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   	� 5   
   -   5        $ secRadio��5      $��Seconds��6(   $
��Left=�6:   $��
10,144,0,0q�6U   $	��Top=�6i   $ timeUnit��6�   $��Roboto Light)�6�   $	 0.5,0.5&�6�   �� 5   
   -   5        
 ��Name$
 statusLabel��5      $
��Left=�6%   $��
10,196,0,0q�6@   $	��Top=�6T   $	��366��6l   $��46��6x   $��22(�6�   $��Roboto Light)�6�   $��2��6�   .��5      �� -   5        $
 label��5      $��Ready��6#   {�.  63   5      �� 5   
   -   5         ��Name$ restoreCheck��5      $��Restore on input��6)   $
��Left=�6D   $��116,144,0,0q�6_   $	��Top=�6t   $	 0.5,0.5&�6�   $��Roboto Light)�6�   $��1��6�   �� 5   
   -	   5        $ startupCheck��5      $��Start with Windows��6)   $
��Left=�6F   $��116,124,0,0q�6a   $	��Top=�6v   $	 0.5,0.5&�6�   $��Roboto Light)�6�   $��1��6�   5      5      