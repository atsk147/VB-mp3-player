   M S B A M L   `   `   `  ����J  FTMA2MediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TMA2MediaPlayerTMA2MediaPlayer  5      "    TMA2MediaPlayer.UserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:TMA2MediaPlayer     5      $��477.324��5      $��349.071��60     � 	Resources  5         TableViewSource��%   &	        �� 5	   
   6   5
      .��5      � $��22,10,-0.2,22.6q�6    � DataContext# [  6$    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��451* �6   .+�5   
   �� -   5         ��Name$ 
playerlogo��5      $
��Left=�6$   $	��445��6?   $��
0,0,0,-0.2q�6L   $	��Top=�6`   $	��327��6x   $��2��6�   $��playerlogo.png��6�   �� 5   
   -   5         ��Name$ 
lstBoxUser��5      $
��Left=�6&   $	��131��6A   $��	45,10,0,0q�6N   $	��Top=�6a   $	��237��6y    �� DisplayMemberPath$ Id��6�    �� SelectedValuePath$ Id��6�   $��1��6�    J� RenderTransformOrigin$ 0.642,0.542&�6�   ��6�   �� 6�   �� 5   
   -   5         ��Name$ btnStop��5      $
��stop��6"   $
��Left=�61   $��128,308,0,0q�6L   $	��Top=�6a   $��73��6y   $��1��6�   $ 0.514,-3.705&�6�   $��42��6�   �� 5   
   -   5        $ btnPrevious��5      $��previous��6&   $
��Left=�69   $��
45,247,0,0q�6T   $	��Top=�6h   $��73��6�   $��1��6�   $��42��6�   �� 5   
   -   5        $ btnNext��5      $
��next��6"   $
��Left=�61   $��221,247,0,0q�6L   $	��Top=�6a   $��75��6y   $��1��6�   $��42��6�   �� 5   
   -   5        $ btnPlay��5      $
��play��6"   $
��Left=�61   $��128,183,0,0q�6L   $	��Top=�6a   $��75��6y   $��1��6�   $ 0.455,-2.737&�6�   $��42��6�   �� 5   
   -   5        $ btnPause��5      $��pause��6#   $
��Left=�63   $��128,247,0,0q�6N   $	��Top=�6c   $��75��6{   $��1��6�   $��42��6�   5      5      