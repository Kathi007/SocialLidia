   M S B A M L   `   `   `  ����F  BSocialLidia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SocialLidiaSocialLidia  5   	       SocialLidia.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SocialLidia     5   	     � Title$  Window1��5   	    � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�6,    � WindowState$ 	Maximized=�6B   $	��600��6Z   $
��1300��6g   .��5	      � -   5         �Name$ Vorname_Textbox��5	      $��10,0,0,0q�6$   ���	#FFDDDDDD � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      �� 5      �� 5      �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Registrieren��6   $��0��6'   $��0��64   $��2��6D   $��Center=�6X   $��1q�6u   $��Center=�6�   $��60(�6�   $��Palatino Linotype)�6�   �� 5   
   $��	Vorname: ��6   $��1��6$   $��0��61   $
��Left=�6A   $��5q�6\   $��Center=�6g   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   -   5         ��Name$ Vorname_Textbox1��5      $��1��6,   $��0��69   $��Right=�6I   $��30��6e   $��10q�6q    �� TextWrapping$
 Wrap=�6}   $�� ��6�   $��Center=�6�   $	��450��6�   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   $��	Nachname:��6   $��1��6$   $
��Left=�64   $��5q�6O   $��1��6Z   $��Center=�6g   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   -   5        $ Nachname_Textbox��5      $��1��6,   $��1��69   $��Right=�6I   $��30��6e   $��10q�6q   $
 Wrap=�6}   $�� ��6�   $��Center=�6�   $	��450��6�   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   $��Alter: ��6   $
��Left=�6"   $��5q�6=   $��2��6H   $��Center=�6U   $��20(�6p   $��Palatino Linotype)�6~   �� 5   
   -   5        $ Alter_Textbox��5      $��2��6)   $��0��66   $��Right=�6F   $��30��6b   $��5q�6n   $
 Wrap=�6y   $�� ��6�   $��Center=�6�   $	��450��6�   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   $��	Username:��6   $��1��6$   $
��Left=�64   $��5q�6O   $��2��6Z   $��Center=�6g   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   -   5        $ Username_Textbox��5      $��2��6,   $��1��69   $��Right=�6I   $��30��6e   $��10q�6q   $
 Wrap=�6}   $�� ��6�   $��Center=�6�   $	��450��6�   $��20(�6�   $��Palatino Linotype)�6�   	� 5   
   -   5        	 	�Name$	 w_Radiobutton��5      $��3��6-   $��0��6:   $��weiblich��6J   $
��Left=�6]   $��10q�6x   $��Center=�6�   $	��150��6�   $��20(�6�   $��Palatino Linotype)�6�   	� 5    
   -   5        $	 m_RadioButton��5       $��3��6-   $��0��6:   $��	männlich��6J   $��Right=�6]   $��10q�6y   $��Center=�6�   $	��150��6�   $��20(�6�   $��Palatino Linotype)�6�   �� 5!   
   $��
Passwort: ��6   $��1��6%   $��2��65   $
��Left=�6F   $��10q�6a   $��3��6m   $��Center=�6z   $��20(�6�   $��Palatino Linotype)�6�   �� 5"   
   -   5        $ Passwort_Textbox��5"      $��3��6-   $��1��6:   $��2��6J   $��Right=�6[   $��30��6w   $��10q�6�   $
 Wrap=�6�   $�� ��6�   $��Center=�6�   $	��450��6�   $��20(�6�   $��Palatino Linotype)�6�   6�   �� 5#   
   -	   5        $��5��5#      $��0��6   $��2��6.   $��2��6B   $��registrieren��6S   $��Center=�6j   $��10q�6�   $	��200��6�   $	��Top=�6�   $��40��6�   $��20(�6�   $��Palatino Linotype)�6�   ���	#FF173D55���	#FFEEEEEE6  �� 5$   
   -
   5        
 ��Name$
 Fehler_Label��5$      $��
��6&   $
��Left=�6;   $��	79,26,0,0q�6V   $��4��6i   $	��Top=�6v   $��76��6�   $	��397��6�   $��Palatino Linotype)�6�   
�������$��20(�6�   ���	#FFAB0F0F6�   5'      5(      