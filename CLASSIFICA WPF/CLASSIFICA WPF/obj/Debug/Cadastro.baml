   M S B A M L   `   `   `  ����I  ECLASSIFICA WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CLASSIFICA_WPFCLASSIFICA_WPF  5   	       CLASSIFICA_WPF.Cadastro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CLASSIFICA_WPF     5   	     � Title$  	Cadastrar��5   	   $	��355��6   $	��355��6(   $	��355��68   $	��525��6H   $	��525��6T   $	��525��6c    � Icon$ Imagens\icon.ico��5	   	      MaterialDesignFont#���   5
   	    � WindowStartupLocation$ CenterScreen=�6;   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��269* �6   �� 5      $
��248* �6   .+�5   
   �� $��Cadastrar Pessoa��6   $
��Left=�6+   $��	134,7,0,0q�6F   $	��Top=�6Y   $	��232��6q   $��Center=�6}   $��16(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��23��6<   $��	69,55,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��193��6�   ���	#89000000$��1q�6�   �� 5   
   $	��ID:��6   $
��Left=�6   $��	40,55,0,0q�69   $	��Top=�6L    J� RenderTransformOrigin$ 1.208,0.833&�6d   �� 5   
   $��Nome:��6   $
��Left=�6    $��	40,91,0,0q�6;   $	��Top=�6N   �� 5   
   $��Sexo:��6   $
��Left=�6    $��
40,135,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��23��6>   $��	90,91,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��172��6�   $��1q�6�   ���	#890000006�   � 5   
   -   5         �Name$ rbSexo��5      $
��Left=�6   $��31��6:   $��
83,128,0,0q�6F   $	��Top=�6Z   $	��199��6r   $��2��6~   .+�5      	� -   5         	�Name$ rbMasculino��5      $��	Masculino��6/   $
��Left=�6C   $��	10,10,0,0q�6^   $	��Top=�6q   $ 0.803,1.333&�6�   	� 5      -   5        $ 
rbFeminino��5      $��Feminino��6.   $
��Left=�6A   $��
111,10,0,0q�6\   $	��Top=�6p   5      �� 5   
   $��Data de Nascimento:��6   $
��Left=�6.   $��
40,177,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        	 ��Name$	 	btnVoltar��5      $��Voltar��6$   $
��Left=�65   $��
54,273,0,0q�6P   $	��Top=�6d   $	��120��6|   6�   �� 5   
   -   5        $	 	btnLimpar��5      $��Limpar��6$   $
��Left=�65   $��190,273,0,0q�6P   $	��Top=�6e   $	��120��6}   $��2��6�   �� 5   
   -   5        $	 btnConfirmar��5      $��	Confirmar��6'   $
��Left=�6;   $��
64,273,0,0q�6V   $	��Top=�6j   $	��120��6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5        
  Name$
 dataPickerNascimento��5      $
��Left=�63   $��163,178,0,0q�6N   $	��Top=�6c   $��99��6{   ���	#89000000$��1q�6�   �� 5   
   $"��Lista de Pessoas Cadastradas��6   $
��Left=�67   $��	64,54,0,0q�6R   $	��Top=�6e   $��1��6}   &   System.Windows.Controls.DataGrid  5    
   -
   5          Name$ dataGridCadastroCadastro��5       $
��Left=�65   $	��160��6P   $��	64,83,0,0q�6]   $	��Top=�6p   $	��162��6�   $��1q�6�   $��1��6�   5"      5#      