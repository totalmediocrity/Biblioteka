   M S B A M L   `   `   `  ����I  EBibliotekaFull, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BibliotekaFullBibliotekaFull  5   	   '    !BibliotekaFull.AllOrderShowWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BibliotekaFull     5   	     � Title$  AllOrderShowWindow��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
   
   �� $
��Left=�6   $��Center=�60   $��70,0,0,0q�6K   .+�5      �� -   5         ��Name$ ItemProd��5   0   $	��240��6   $	��298��6$    �� View 5      �� 5      .P�5      ��  �� DisplayMemberBinding 6)   ��  �� Path$ Id�.��6T   Код6Y   �� 5       6)   �� $
 Date�.��6V   Дата заказа6c   �� 5       6)   �� $ 
User.Login�.��6\   Пользователь6j   �� 5       6)   �� $ Address.Address1�.��6b   
Адрес6i   5      5      5      �� 5   
   $��423,97,141,97q�6   .+�5      �� $!��Адрес доставки��6   6/   �� 5      -   5         ��Name$ AddressProd��5      $��5q�6,   69   �� 5      -   5         ��Name$ 
EditButton��5      $#��Изменить данные��6)   $��5q�6C   6j   �� 5      -   5        $ 	DelButton��5      $��Отмена заказа��6(   $��5q�6@   6f   �� 5      -   5        $ 
BackButton��5      $��
Назад��6)   $��5q�69   $��3q�6D   
�������6~   5      5      5      