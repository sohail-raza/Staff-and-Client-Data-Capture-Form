   M S B A M L   `   `   `  ����L  HMattioliWoodsTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MattioliWoodsTaskMattioliWoodsTask  5   	   "    MattioliWoodsTask.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MattioliWoodsTask     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��400��6)   .��5	      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��2��6   ��5      �� 5      .��5      �  � Color$ 	#FFFF2525��6'    � Offset$ 0Q�69   � 5      $ 	#FFD66FD6��6'   $ 1Q�69   5      5      5      �� 5   
   .+�5      ��  �� Orientation$ 
Horizontal=�6   ���	#FF747984.+�5       �� -   5         ��Name$ staffBtn��5    $   $��5q�6   $��14(�66   $
��Lato)�6D   ���	#FF747984
�������.��6�   STAFF6�   �� 5!      -   5        $ 	clientBtn��5!   $   $��5q�6   $��14(�67   $
��Lato)�6E   ���	#FF747984
�������.��6�   CLIENT6�   5"      �� 5#      .+�5$      �� $��images/avatarSmall.png��6   $	��156��68   6G   5%      �� 5'      .+�5(      �� $��Center=�6   $
��Lato)�69   $��18(�6K   
�������Staff Registry Form6�   5)      �� 5*      .+�5+      � $��2��6   5,      �� 5-      $��5q�6   ���	#FF747984$��10,10,10,10q�68    �� CornerRadius$ 5��6W   ._�5.      �� -   5        $��staffForenameBox��5.       �� 	MaxLength$ 20��62   $
��Lato)�6A   ���	#FF505256���	#FF747984$��14(�6�   $��0q�6�   .��6�   
Forename6�   50      �� 51      $��5q�6   ���	#FF747984$��10,10,10,10q�68   $ 5��6W   ._�52      �� -   5        $��staffSurnameBox��52      $ 20��61   $
��Lato)�6@   ���	#FF505256���	#FF747984$��14(�6�   $��0q�6�   .��6�   	Surname6�   54      � 55      .+�56      �� -   5         ��Name$ staffDOBBox��56      $
��Lato)�6-   ���	#FF505256���	#FF747984$��14(�6m   $��0q�6{   $
��10,0q�6�   .��6�   Date of Birth6�   (  "System.Windows.Controls.DatePicker  58      -   5        	  Name$	 dateOfBirthPicker��58   �   
   DisplayDateStart$
 
01-01-1920X�6      DisplayDateEnd$ 
06-21-2020X�6;   ���	#FF747984   Text$ Date of Birth��6�   $��113,1,10,-1q�6�      SelectedDate 6X   �� *dateSelection+ �� StringFormat$ 
dd/MM/yyyy��59      5<      �� 5?      -   5        $��staffSubmitBtn��5?      $��	49,5,52,0q�6+   .��6\   Submit6d   5A      5C      5E      