   M S B A M L   `   `   `  ����F  BSocialLidia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SocialLidiaSocialLidia  5   	       SocialLidia.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SocialLidia     5   	     � Title$  Window2��5   	    � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�6,    � WindowState$ 	Maximized=�6B   $	��600��6Z   $
��1300��6g   .��5	      � ���	#FFDDDDDD � RowDefinitions 5
   
   �� 5      $	��79* �6   �� 5      $	��41* �6   �� 5      $	��60* �6   �� 5      $	��60* �6   �� 5      $	��60* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Username_Label��5      $��username��6(   $��0��6;   $��0��6H   $��Center=�6X   $��190,46,190,21q�6u   $��Center=�6�   $��60(�6�   $��91��6�   $	��270��6�   $��Palatino Linotype)�6�   �� 5   
   -   5         ��Name$ NeuPost_Textbox��5      $��Center=�6+   $��1��6H   $��0��6U   $��44��6e   $��225,20,225,0q�6q    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��180��6�   $��Palatino Linotype)�6�   �� 5   
   -   5        	 ��Name$	 
Posten_Btn��5      $��Post veröffentlichen��6%   $��4��6D   $��0��6Q   $
��Left=�6a   $��40��6|   $��	15,0,0,15q�6�   $��20(�6�   $��Bottom=�6�   $	��180��6�   $��Palatino Linotype)�6�   ���	#FF173D55���	#FFEEEEEE6  �� 5   
   -   5        $	 
Privat_Btn��5      $��Post privat stellen��6%   $��4��6C   $��0��6P   $��Right=�6`   $��	0,0,15,15q�6|   $��40��6�   $��20(�6�   $��Bottom=�6�   $	��180��6�   $��Palatino Linotype)�6�   ���	#FF173D55���	#FFEEEEEE6  �� 5   
   -   5        $��Beitraege_Listbox��5      $��3��6+   $��0��68   $��2��6H   $��Center=�6Y   $��225,58q�6w   $��Center=�6�   $	��170��6�   $��Palatino Linotype)�6�   �� 5   
   -   5        $ Friends_Label��5      $��Meine Freunde��6'   $��0��6?   $��1��6L   $��Center=�6\   $��121,46,121,21q�6y   $��Center=�6�   $��60(�6�   $��91��6�   $	��408��6�   $��Palatino Linotype)�6�   �� 5   
   -   5        
 ��Name$
 Freunde_ListBox��5      $��2��6+   $��1��68   $��3��6H   $��Center=�6Y   $��225,58q�6w   $��Center=�6�   $	��170��6�   $��Palatino Linotype)�6�   �� 5   
   $��Neuer Post:��6   $
��Left=�6&   $��	25,20,0,0q�6A   $��1��6T   $	��Top=�6a   $	��200��6y   $��20(�6�   $��Palatino Linotype)�6�   �� 5   
   -   5        $	 FreundAnzeigen_Btn��5      $��Freund anzeigen��6-   $��4��6G   $��1��6T   $��Right=�6d   $��
0,0,230,15q�6�   $��40��6�   $��20(�6�   $��Bottom=�6�   $	��180��6�   $��Palatino Linotype)�6�   ���	#FF173D55���	#FFEEEEEE6,  5       5!      