   M S B A M L   `   `   `  ����K  GAestheticService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AestheticServiceAestheticService  5   	   (    "AestheticService.AppointmentEditor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0localclr-namespace:AestheticService     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Icon$  ../../Resources/1.ico��5       � Title$= 7Редактор записей на процедуры��5   	   $	��450��6/   $	��800��6<      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � WindowState$ 	Maximized=�5   	     MaterialDesignFont#���  5   	     BackgroundWindows#���  5   	    � 	Resources 5      .   (AestheticService.DateTimeToDateConverter  myDateConverter��%   &	         5   
   6(   5      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��AppointmentGrid��5    +   $��1��6   $��14(�6      SelectionUnit$ FullRow=�6B   	   CanUserAddRows	 .  
   CanUserDeleteRows
 .     
IsReadOnly .  $	��800��5!   Q      AutoGenerateColumns .    BackgroundDataGrids#���  5"   )      SelectionMode$ Extended=�5#         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��5'       ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5(       0 ,MaterialDesignDataGridTextColumnEditingStyle   EditingElementStyle# [ 5)         Binding 5&      �� *	who_fname+5)        5*      $ Фамилия��5,      # [ 5-      # [ 5.       5+      �� *	who_sname+5.        5/      $ Телефон��51      # [ 52      # [ 53       50      �� *phone+53        55      $ Дата��57      # [ 58      # [ 59       56      �� *date+59        5:      $ 
Время��5<      # [ 5=      # [ 5>       5;      �� *time+5>        5?      $ Услуга��5A      # [ 5B      # [ 5C       5@      �� *	service+5C      4  .System.Windows.Controls.DataGridCheckBoxColumn  5E      $% Выполнена услуга��5F   -    - )MaterialDesignDataGridCheckBoxColumnStyle# [ 5G       4 0MaterialDesignDataGridCheckBoxColumnEditingStyle# [ 5H       5F      �� *was+5H      5K      �� 5L   
   $��0��6   $��12q�6%   .+�5M      �� -   5        $
��Save��5N       	 ButtonWidth#��[	 6    #
 MaterialDesignRaisedLightButton#��[
 5O      $��
20,12,20,0q�5P      $��Сохранить��5R      �� 5S      -   5        $��	DeleteBtn��5T      #��[	 6"   #��[
 5U      $��
20,12,20,0q�5V      $��Удалить��5X      �� 5Y      -   5        $
��Back��5Z      #��[	 6   #��[
 5[      $��
20,12,20,0q�5\      $��
Назад��5^      5_      5`      5a      