   M S B A M L   `   `   `  ����K  GAestheticService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AestheticServiceAestheticService  5   	        AestheticService.PriceList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0localclr-namespace:AestheticService     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Icon$  ../../Resources/1.ico��5       � Title$# Прейскурант цен��5   	   $	��450��6!   $	��800��6.      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � WindowState$ 	Maximized=�5   	     MaterialDesignFont#���  5   	     BackgroundWindows#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Center=�6%   $	��Top=�6B   $��
0 180 0 0 q�6Z   .+�5      ��  �� Orientation$ Vertical=�6   $��4q�60   .+�5      ��  $  MaterialDesignHeadline5TextBlock#��[ 5      $��
Поиск��5       $��0 0 0 14q�6"   $��Center=�5!      �� 5#      -   5        $��ServiceNameSearchText��5$   =   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Услуга��6    % !MaterialDesignFloatingHintTextBox#��[ 5%        ButtonWidth#��[ 6P   $��4q�5&   G   $��Center=�5'      �� 5(      -   5        $��CategorySearchCombo��5)   K   $ Категория��6   $��4q�6@   	 �� 
IsEditable	 . #��[ 5*   '   �� 5+      -   5          MaterialDesignRaisedButton#��[ 5,      $��4q�6I   #��[ 5-      $��Искать��5.      �� 50      -   5        $��0��50      $��2��6)    # MaterialDesignRaisedLightButton#��[ 51      #��[ 52      $��4q�53   3   $>��8Редактировать прейскурант цен��54      �� 55      -   5        $
��Back��56      $��0��55      $��3��6)   #��[ 56   %   #��[ 57      $��4q�58      $��
Назад��5:      5;      5<      &   System.Windows.Controls.DataGrid  5>   
   -   5        $��
Preykurant��5?      $��1��5>      
   AutoGenerateColumns
 .  $��14(�5@         CanUserAddRows .  $	��500��68   $
��Left=�6D      SelectionUnit$
 Cell=�5A         CanUserDeleteRows .     
IsReadOnly .   BackgroundDataGrids#���  5B   %      SelectionMode$ Extended=�5C         Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Услуга��5G       )	 %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [	 5H       0
 ,MaterialDesignDataGridTextColumnEditingStyle   EditingElementStyle# [
 5I         Binding 5F      �� *name+5I        5J      $* $Стоимость (в рублях)��5L      # [	 5M      # [
 5N       5K      �� *price+5N      5P      5S      5V      