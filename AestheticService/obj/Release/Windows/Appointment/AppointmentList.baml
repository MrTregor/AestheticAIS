   M S B A M L   `   `   `  ���� K  GAestheticService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AestheticServiceAestheticService  &     AestheticService.AppointmentList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:AestheticService     _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Icon$  ../../Resources/1.ico�� � Title$0 *Записи на обслуживание��$	��450��$	��800��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=� � WindowState$ 	Maximized=�  MaterialDesignFont#���    BackgroundWindows#���  .���  � RowDefinitions ��  � ColumnDefinitions �� $��3* ��� $��* �.+�&   System.Windows.Controls.DataGrid  -   $��AppointmentGrid��$��0��$��14(�   AutoGenerateColumns .     CanUserAddRows .  	   SelectionUnit$	 FullRow=�
   CanUserDeleteRows
 .     
IsReadOnly .   BackgroundDataGrids#���     SelectionMode$ Extended=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Клиент�� ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  0 ,MaterialDesignDataGridTextColumnEditingStyle   EditingElementStyle# [    Binding �� *who+  $ Дата��# [ # [  �� *date+  $ 
Время��# [ # [  �� *time+  $ Услуга��# [ # [  �� *	service+4  .System.Windows.Controls.DataGridCheckBoxColumn  $% Выполнена услуга�� - )MaterialDesignDataGridCheckBoxColumnStyle# [  4 0MaterialDesignDataGridCheckBoxColumnEditingStyle# [  �� *was+)  #MaterialDesignThemes.Wpf.DialogHost  -   $��AddDialogHost��$��1��$	��Top=�   IsOpen .  $��12q�   CloseOnClickAway .   PrimaryHueDarkBrush   OverlayBackground# �     DialogTheme$ Inherit=�.����  �� Orientation$ Vertical=�.+���  $	  MaterialDesignHeadline5TextBlock#��[	 $��Center=�$��Действия���� -   $��AddPriem�� #
 MaterialDesignRaisedLightButton#��[
   ButtonWidth#��[ $��0 24 0 4q�$7��1Добавить запись на сегодня���� -   $��
EditPriems��#��[
 #��[ $��0 4 0 4q�$��48������ $��Center=� $  MaterialDesignSubtitle2TextBlock#��[ )'Редактировать список�� (&записей на процедуры�� -   $	��Was��#��[
 #��[ $��0 4 0 4q�$��Выполнена���� -   $��NotWas��#��[
 #��[ $��0 4 0 4q�$��Не выполнена���� -   $
��Back��#��[
 #��[ $��0 24 0 4q�$��
Назад��   DialogContent �� $ Vertical=�$��12q�.+��� #��[	 $��Center=�$��0 4 0 4q�$��Новая запись��(  "System.Windows.Controls.DatePicker  -	   $��
DatePicker��#��[ )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Выберите дату��$��0 4 0 4q� ( $MaterialDesignFloatingHintDatePicker#��[ )
  #MaterialDesignThemes.Wpf.TimePicker
  -
    
 Name$ 
TimePicker��$��14(� 
  SelectedTimeFormat$ Short=�$! Выберите время�� 
  	Is24Hours . $��0 4 0 4q�#��[  
  WithSeconds .   
  SelectedTime �� *time+�� -   $��ServiceChoose��$��14(�#��[ $ Услуга��$��0 4 0 4q� �� 
IsEditable .  �� Text �� *	service+�� -   $��ClientNameCombo��$��14(�#��[ $ Клиент��$��0 4 0 4q� .  �� *who+�� -   #��[ $��4q�  MaterialDesignFlatButton#��[ $��Добавить���� -   #��[ $��0 4 0 4q�#��[ $��Отмена��