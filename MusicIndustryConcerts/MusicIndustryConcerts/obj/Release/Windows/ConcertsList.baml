   M S B A M L   `   `   `  ���� P  LMusicIndustryConcerts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MusicIndustryConcerts.WindowsMusicIndustryConcerts.Windows  =#clr-namespace:MusicIndustryConcertsMusicIndustryConcerts  0    *MusicIndustryConcerts.Windows.ConcertsList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     =local+clr-namespace:MusicIndustryConcerts.Windows     EMusicIndustryConcerts#clr-namespace:MusicIndustryConcerts       N� Title$  ConcertsList�� � 	Resources 8   2MusicIndustryConcerts.MusicIndustryConcertsDataSet    musicIndustryConcertsDataSet  concertsViewSource �� Source �� Source(  "System.Windows.Controls.DatePicker �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%w  &	        &	      7   '  %     '�� {       ��  �� *
Concerts+8   �� "  .���  � ��
 ���� ��  � ��
 ���� ��  � �� �#fff�� " ��.���  � �� �� " ��.R��� #��z��#��z��._�� .+��� $ 
background��#��z���� #��z��#��z��	 P� 
 �@J�IsMouseOver . . ��� $ 
background�� �@J�Opacity$	 0.8Q�.��� ���#333333 � DataContext# [ .+�� ����  �� ImageSource$ /Imgs/placesbg2.png�� j� Stretch$
 None=�.+��� -   $��Create a new concert +��$��168,611,584,64q�$��45��$	��248��$��Poppins)�$��18(����#4277d4���#fff���#4277d4$��Center=�$��Center=��� $��Center=�$��170,72,452,0q�$
��Wrap=�$	��Top=�$��Poppins)�$��50(����#fff$	��378��$��List of concerts��� -    �Name$ 
nav_panel3��$
��Left=�$	��110�����#3A3A3A.+��� -    ��Name$ panel4��.+��� -    ��Name$ menu_list11��
������ 
������ $��Disabled=�.@��� $
��Left=�$��0,0,0,80q����#44688C$��76��.����  �� Orientation$ 
Horizontal=�$	��230��.+��� -    ��Name$ Home_btn��$��98��$��73��$��0q�
������ ���� $4 ./MusicIndustryConcerts;component/Imgs/home.png��$
 None=��� $
��Home��$��42,0,0,0q��� $
��Left=�$��	0,30,0,15q�$��76��.���� $ 
Horizontal=�$	��230��.+��� -   $ 	Place_btn��$��95��$��57��$��0q�
������ ���� $3 -/MusicIndustryConcerts;component/Imgs/pin.png��$
 None=��� $��Add a place��$��42,0,0,0q��� $
��Left=�$��0,0,0,15q�$��76��.���� $ 
Horizontal=�$	��230��.+��� -   $ 
Artist_btn��$��95��$��57��$��0q�
������ ���� $7 1/MusicIndustryConcerts;component/Imgs/artists.png��$
 None=��� $��Create a concert��$��42,0,0,0q��� $
��Left=�$��0,0,0,15q�$��76��.���� $ 
Horizontal=�$	��230��.+��� -   $ Concerts_btn��$��95��$��57��$��0q�
������ ���� $7 1/MusicIndustryConcerts;component/Imgs/concert.png��$
 None=��� $��Create a concert��$��42,0,0,0q��� $
��Left=�$��0,0,0,15q�$��76��.���� $ 
Horizontal=�$	��230��.+��� -	   $ Tickets_btn��$��95��$��57��$��0q�
������ ���� $7 1/MusicIndustryConcerts;component/Imgs/tickets.png��$
 None=��� $��Reserve a ticket��$��42,0,0,0q��� $
��Left=�$��	0,90,0,15q�$��76��.���� $ 
Horizontal=�$	��230��.+��� -
   $ 	Close_btn��$��95��$��57��$��0q�
������ ���� $4 ./MusicIndustryConcerts;component/Imgs/quit.png��$
 None=��� $��Close the app��$��42,0,0,0q�&   System.Windows.Controls.DataGrid  -     Name$ concertsDataGrid��   AutoGenerateColumns .     EnableRowVirtualization . $��168,186,108,146q�   RowDetailsVisibilityMode$ VisibleWhenSelected=�
������ 
������    CanUserAddRows .   J� IsHitTestVisible .     HeadersVisibility$ Column=�����    ColumnHeaderStyle �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��$
 Bold"���  � ��$ 12(���  � �� �#fff��  � ��
 ���� ��  � ��$ Center=�   RowStyle �� )  #System.Windows.Controls.DataGridRow"  .���  � ��
 ����    	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ 11(���  � ��$ 
ExtraLight"���  � �� �#fff��  � ��
 ���� ��  � ��
 ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   concertIDColumn��,  &System.Windows.Controls.DataGridColumn    Header$  
Concert ID��!   
IsReadOnly! . "   Width5	  /System.Windows.Controls.DataGridLengthConverter$" SizeToHeader	 1
  +System.Windows.Controls.DataGridBoundColumn# 
  Binding# �� *	ConcertID+4  .System.Windows.Controls.DataGridTemplateColumn  -   eventDateColumn��$  
Event Date��$" *	 $   CellTemplate$ �� .R�  %   SelectedDate% �� *	EventDate+& �� Mode$& TwoWay=�' �� NotifyOnValidationError' . ( �� ValidatesOnExceptions( .  :  4System.Windows.Controls.Primitives.DatePickerTextBox  Key) �� Color'  !System.Windows.VisualStateManager*   VisualStateGroups%  System.Windows.VisualStateGroup+   Transitions%  System.Windows.VisualTransition,   GeneratedDuration	-   To.   States   System.Windows.VisualState/   
Storyboard0 g� Duration	1 W� To2 �� TargetProperty3 �� 
TargetName4 ��Name5 �� CornerRadius6 J� Opacity7 �� Padding8 ��Name9 ��Name��%A  '        �� "  .���  � �� �� "  .R��  ���� WatermarkBrush $
) #fff��*   CommonStates��+   $, 0D�  $, 0:0:0.1D�$- 	MouseOver��..   
Normal��  	MouseOver��  WatermarkStates��+   $, 0D�..   Unwatermarked��  Watermarked��./ �� .��W� $0 0D�$1 0X�$2 Opacity�$3 ContentElement��W� $0 0D�$1 1X�$2 Opacity�$3 PART_Watermark��  FocusStates��+   $, 0D�..   	Unfocused��  Focused��.+��� $4 Border��
������ $��0q�
������ $5 1��$6 1Q�#7 z��._�� $ WatermarkContent��#��z��#��z��.+��� $4 ContentElement��
������ $��1q��� $4 watermark_decorator��
������ $��1q�._��� $8 PART_Watermark��|�.   .  $6 0Q�$��2q��� $9 PART_ContentHost��#��z��$��0q�#��z��  -   placeIDColumn��$  Place ID��$" *	 # �� *	PlaceID+  -   artistIDColumn��$  	Artist ID��$" *	 # �� *
ArtistID+  -   baseTicketPriceColumn��$  Base Ticket Price��$" *	 # �� *BaseTicketPrice+  -   vIPTicketPriceColumn��$  VIP Ticket Price��$" *	 # �� *VIPTicketPrice+  -   remainingCapacityColumn��$  Capacity��$" *	 # �� *RemainingCapacity+