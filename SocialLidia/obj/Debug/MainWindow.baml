   M S B A M L   `   `   `  ����F  BSocialLidia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SocialLidiaSocialLidia  5   	       SocialLidia.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SocialLidia     5   	     � Title$  Window1��5   	    � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�6,    � WindowState$ 	Maximized=�6B   $	��600��6Z   $
��1300��6g   .��5	      � ���	#FFDDDDDD � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Login��6   $��0��6    $��0��6-   $��20q�6=   $��2��6I   $��Center=�6]   $��40(�6z   $��Palatino Linotype)�6�   �� 5   
   $��	Username:��6   $��1��6$   $��0��61   $��Right=�6A   $��Center=�6]   $��20(�6x   $��Palatino Linotype)�6�   �� 5   
   -   5         ��Name$ username_textbox��5      $��1��6,   $��1��69   $��20q�6I   $	��170��6U   $��30��6a   $
��Left=�6m   $��Palatino Linotype)�6�   �� 5   
   $��	Passwort:��6   $��2��6$   $��0��61   $��Right=�6A   $��Center=�6]   $��20(�6x   $��Palatino Linotype)�6�   �� 5   
   -   5        $ passwort_textbox��5      $��2��6,   $��1��69   $��20q�6I   $	��170��6U   $��30��6a   $
��Left=�6m   $��Palatino Linotype)�6�   �� 5   
   -   5        $��registrieren��5      $��3��6(   $��0��65   $��20q�6E   $��40��6Q   $	��150��6]   $��Right=�6i   $��2��6�   $��20(�6�   $��Palatino Linotype)�6�   ���	#FF173D55���	#FFEEEEEE6�   �� 5   
   -   5        $��anmelden��5      $��3��6$   $��0��61   $��20q�6A   $��40��6M   $	��150��6Y   $��2��6e   $
��Left=�6y   $��20(�6�   $��Palatino Linotype)�6�   ���	#FF173D55���	#FFEEEEEE6�   �� 5   
   -   5         ��Name$ FehlerLabel��5      $��4��6%   $��0��62   $��2��6B   $4��.Fehler: Username oder Passwort nicht gefunden!��6V   $
��Left=�6�   $��127,19,0,20.5q�6�   
������� J� Opacity$ 0Q�6�   $��Palatino Linotype)�6�   ���	#FFAB0F0F6   5      5       