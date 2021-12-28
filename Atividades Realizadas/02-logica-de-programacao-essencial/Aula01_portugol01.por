programa
{
	
	funcao inicio()
	{
		real janeiro, fevereiro, marco, abril, media 
		cadeia funcionario
		
		escreva("Nome do funcionário: ")
		leia(funcionario)
		escreva("Vendas de janeiro: ")
		leia(janeiro)
		escreva("Vendas de fevereiro: ")
		leia(fevereiro)
		escreva("Vendas de março: ")
		leia(marco)
		escreva("Vendas de abril: ")
		leia(abril)

		media = (janeiro+fevereiro+marco+abril)/4

		escreva("Olá, " + funcionario + "! Sua média de vendas foi: " + media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 483; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */