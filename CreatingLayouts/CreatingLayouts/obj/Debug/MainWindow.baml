   M S B A M L   `   `   `  ����J  FCreatingLayouts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CreatingLayoutsCreatingLayouts  5   	   =#clr-namespace:CreatingLayouts.ViewsCreatingLayouts.Views  5   	        CreatingLayouts.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CreatingLayouts     5   	   2UC#clr-namespace:CreatingLayouts.Views     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   $   CreatingLayouts.Views.HomeView  -   5          Name$
 Home��5      $��0��6$   $��2��61   $y�Hidden=�6E   %   CreatingLayouts.Views.AboutView  5   
   -   5          Name$ About��5      $��0��6&   $��2��63   $y�Visible=�6G   �� 5   
   -   5         ��Name$ 	ClickHome��5      $��1��6$   $��0��61   $��25��5      $	��100��6   $
��Home��6*   69   �� 5   
   -   5        $ 
ClickAbout��5      $��1��6&   $��1��63   $��25��5      $	��100��6   $��About��6+   
�������5   &   5      5      