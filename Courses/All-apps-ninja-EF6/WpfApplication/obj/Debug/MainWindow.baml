   M S B A M L   `   `   `  ????O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   I EWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApplicationWpfApplication 5   	   N JNinjaDomain.Classes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:NinjaDomain.Classes;assembly=NinjaDomain.ClassesNinjaDomain.Classes 5   	      WpfApplication.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   
   9System&clr-namespace:System;assembly=mscorlib     5   	   .localclr-namespace:WpfApplication     5   	   RClasses>clr-namespace:NinjaDomain.Classes;assembly=NinjaDomain.Classes     5   	   -   5          ? Title$  
MainWindow??5
   	   $	??522??6   $	??743??6)    ? 	Resources 5         ninjaViewSource ! ninjaEquipmentOwnedViewSource ?? Source ?? Source  dataFromEnum S? 
MethodName S? 
ObjectType   System.Enum S? MethodParameters M? TypeName ?? 
TargetType  	baseStyle	 ?? Property
 ?? Value ?? BasedOn&   System.Windows.Controls.DataGrid(  "System.Windows.Controls.DatePicker  ninjaViewSource1 " ninjaEquipmentOwnedViewSource1??%?  &	        &	      7   &	 G     &	 ?     '??     7  '?? '    7  '?? I    7  '?? k    7  '  ?    7  '  ?    7  '?? ?    7  &	 ?    &	     7  S? 5   
   6   ?? 5   
    6E   ?? *EquipmentOwned+8   S? 5   
   $ 	GetValues??5      "  6    5      M? 5      $ Classes:EquipmentType??6   5      ?? 5   
   " ??6   .?5      ?? 	 ? ??$
 20(?6)   5      ?? 5   
   " ??6   8   6T   ?? 5   
   " ??6   8   6S   ?? 5   
   " ??6   8   6U   ?? 5   
   " ??6   8   6V   ?? 5   
   "  6   8   6V   ?? 5    
   "  6   8   6X   ?? 5!   
   " ??6   8   6V   ?? 5"   
   6   ?? 5#   
    6F   ?? *EquipmentOwned+8   5$      .??5%      ?  ? DataContext# [ 6   $??0,0,0,2q?6H   .+?5&   
   ? -   5         ?Name$ grid1??5&      # [  6   $
??Left=?6M   $??10,198,0,-16q?6h   $	??Top=?6~   $	??373??6?    ? ColumnDefinitions 5'      ?? 5(      $
??Auto ?6#   $	??132??60   ?? 5)      $
??Auto ?6#   $	??129??60    ? RowDefinitions 5+      ?? 5,      $
??Auto ?6    ?? 5-      $
??Auto ?6    ?? 5.      $
??Auto ?6    ?? 5/      $
??Auto ?6    ?? 50      $
??Auto ?6    ?? 51      $
??Auto ?6    ?? 52      $
??Auto ?6    ?? 53      $
??Auto ?6    ?? 54      $
??Auto ?6    .+?56      ?? $??Name:??6   $??0??6$   $
??Left=?64   $??3,3,0,3q?6O   $??0??6`   $??Center=?6m   $??37??6?   $??67??6?   ?? 57      -   5         ??Name$ nameTextBox??57      $
??Left=?6+   $??30??6F   $??61,10,-83,3q?6R   $??0??6g   $??Center=?6?   $	??304??6?   $??2??6?   ??6t   ?? *Name+ ?? Mode$ TwoWay=? ?? NotifyOnValidationError .  ?? ValidatesOnExceptions . 6  ?? 59      $??Clan:??6   $??0??6$   $
??Left=?64   $??3,3,0,0q?6O   $??1??6`   $	??Top=?6m   $??37??6?   $??53??6?   ?? 5:      -   5         ??Name$ clanComboBox??5:       ?? DisplayMemberPath$ ClanName??5;      $
??Left=?5<      $??28??62    ?? SelectedValuePath$ Id??5>      $??61,10,-85,18q?5B      $??1??6-   $??Center=?5C      $	??302??62   $??2??5D      ??5=      ??  ?? SelectedValue 5?      ??  ?? ElementName$ ninjaListBox?? ?? Path$ SelectedItem.ClanId?$ OneWayToSource=?5D      ?? 5E      $??Date of Birth:??6   $??0??6-   $
??Left=?6=   $??3,3,0,3q?6X   $??4??6i   $??Center=?6v   $??37??6?   $	??129??6?     5F      -   5          Name$ dateOfBirthDatePicker??5F      $??1??68   $
??Left=?6H   $??
3,9,-61,10q?6c   $??4??6w   $??Center=?6?   $??24??6  $	??190??6  $??14.667(?6#     SelectedDate 6?   ?? *DateOfBirth+$ TwoWay=? .  . 65  ?? 5G      $??Served In Oniwaban:??6   $??0??62   $
??Left=?6B   $??3,10,0,3q?6]   $??8??6o   $??Center=?6|   $??56??6?   $	??196??6?   $??2??6?   ?? 5H      -   5         ??Name$ servedInOniwabanCheckBox??5H      $?? ??69   $??1??6D   $??Right=?6T   $??
0,23,44,20q?6?   $??8??6?   $??Center=?6?   $??26??6  $??20??6&   d? 	IsChecked 6p   ?? *ServedInOniwaban+$ TwoWay=? .  . 6\  5I      ?? 5J   
   -   5         ??Name$ ninjaListBox??5J      $
??Left=?6(   $	??183??6C   $??	23,10,0,0q?6P   $	??Top=?6c   $	??350??6{   $ Id??6?   $
 Name??6?   ?? 5K   
   -   5         ??Name$ btnNewNinja??5K      $??378,162,213,0q?6&   $??	New Ninja??6=   $??31??6k   $	??Top=?6w     5L   
   -	   5           Name$  equipmentOwnedDataGrid??5L      !   AutoGenerateColumns! .  "   EnableRowVirtualization" . $??388,246,21,52.667q?5M   +   #   RowDetailsVisibilityMode$# VisibleWhenSelected=?5N      ??5M      ?? $   Columns$ 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      -
   5        idColumn??,  &System.Windows.Controls.DataGridColumn%   Header$% Id??5S   N   &   Width5  /System.Windows.Controls.DataGridLengthConverter$& SizeToHeader 6Z   '   
Visibility$' Hidden=?6o   1  +System.Windows.Controls.DataGridBoundColumn(   Binding( 67   ?? *Id+6o     5T      -   5        
nameColumn??$
% Name??5T   R   $& 6* 6`   ( 69   ?? *Name+6`   4  .System.Windows.Controls.DataGridComboBoxColumn  5U      -   5        equipTypeColumn??$
% Type??5X   )   $& 4* 67   )   SelectedItemBinding) 5V   )   ?? *Type+*   ItemsSource* 5W   )   ?? # [ 5X   7   5f      ?? 5g   
   -   5        $ BtnSave??5g      $
??Save??6"   $
??Left=?61   $??27??6L   $??621,452,0,0q?6X   $	??Top=?6m   $	??104??6?   6?   5i      5j      