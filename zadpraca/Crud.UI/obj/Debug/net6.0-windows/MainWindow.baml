   M S B A M L   `   `   `  ����B  >Crud.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Crud.UICrud.UI  5   	       Crud.UI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Crud.UI     5   	     � Title$  Produkty��5   	   $	��512��6   $
��1006��6'   .��5	      � $��	0,0,10,-6q�6    � ColumnDefinitions 5
   
   �� 5      $��25 �6   6,   �� 5      $��28.261 �6   60   �� 5      $��321.739 �6   �� 5      $��10 �6   6,   �� 5      $	��270 �6   6-   �� 5      $��25 �6   6,    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $
��217* �6   6,   �� 5      $
��167* �6   �� 5      $��25 �6   6*   .+�5   
   �� $��1��5      $��2��5      $��2��6   $��	0,167,0,0q�6.   $��2��6A   �� 5"   
   $��1��5#      $��1��5$      $��2��6   $��2��6.   .+�5&      �  5'      �� 5)      $	��100 �6'   �� 5*      $	��250 �6'    5,      �� 5-      $��25 �6$   62   �� 5.      $��5 �6$   61   �� 5/      $��17.54 �6$   65   �� 50      $
��7.46 �6$   �� 51      $��5 �6$   61   �� 52      $��25 �6$   62   �� 53      $��25 �6$   62   .+�57      �� $��
Product ID��58      $��0��59      $��0��5:      5;      �� 5=      -   5         ��Name$ txtProductID��5>      $��0��5?      $��2��6"   $��	68,0,32,0q�66   �� 5C      $��Product name��5D      $��1��5E      $��223,0,-73,0q�6&   �� 5G      -   5        $ 
txtProduct��5H      $��1��5I      $��305,0,-305,0q�6&   �� 5M      $��Number��5N      $��1��5O      $��560,0,-410,0q�6&   �� 5Q      -   5        $ 	txtNumber��5R      $��1��5S      $��610,0,-610,0q�6&   �� 5W       �� Orientation$ 
Horizontal=�5X      $��
-10,5,10,0q�6/   $��2��6C   $��2��6P   $��3��6d   .+�5[      �� -   5         ��Name$ 	ButtonAdd��5^      $��50��5\      $	��Add��5]      $��	10 0 10 0q�5_      5`      �� 5c      -   5        $ 
ButtonEdit��5f      $��50��5d      $��Update��5e      $��	10 0 10 0q�5g      �� 5i      -   5        $ ButtonSearch��5l      $��50��5j      $��Search��5k      $��	10 0 10 0q�5m      �� 5o      -   5        $ ButtonDelete��5r      $��50��5p      $��Delete��5q      $��	10 0 10 0q�5s      �� 5u      -   5        $ 
ButtonList��5x      $��50��5v      $
��List��5w      $��	10 0 10 0q�5y      5|      �� 5~      -	   5        $ ButtonHistoryList��5�      $��All History��5~       J� RenderTransformOrigin$ 0.162,0.703&�5�   4   $��1��6X   $��273,5,-101,0q�6h   $��3��6~   $��2��6�   �� 5�      -
   5        $ ButtonHistorySearch��5�      $��History of Product��5�      $��1��5�   6   $��370,5,-240,0q�6F   $��3��6\   $��2��6m   5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ DataGridBrand��5�      $��1��5�      $��1��5�      $��0,143,171,174q�5�      $��4��6$   $��2��68     5�   
   -   5        $ DataHistoryGridBrand��5�      $��4��5�      $��1��5�      $��126,143,-287,168q�5�      $��2��6'   $��2��6;   �� 5�   
   $��2��6   $
��Left=�6$   $��147,114,0,0q�6?   $��1��6T   $
��Wrap=�6a   $	��Top=�6u   �� 6�    � Language$ pl-pl�6�   $�Lista Produktow��6�   �� 6�   �� 6�   $ pl-pl�6�   6�   �� 5�   
   $��4��6   $
��Left=�6$   $��1��6?   $
��Wrap=�6L   $	��Top=�6`   $��87��6x   $��29��6�   $��183,106,0,0q�6�   �� 6�   $ pl-pl�6�   $�Historia Produktow��6�   �� 6�   �� 6�   $ pl-pl�6�   6�   5�      5�      