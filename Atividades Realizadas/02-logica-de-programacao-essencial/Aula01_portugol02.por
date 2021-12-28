programa
{
	
	funcao inicio()
	{
		escreva("Escolha uma das opções: 1 - Abrir Netflix 2 - Abrir Amazon Prime 3 - Abrir HBO GO 4 - Fechar o menu")
		inteiro menu = 0
		escreva("\n" + "Sua escolha:")
		leia (menu)

		escolha (menu)
		{
			caso 1: //testa se o valor é igual a 1
			escreva ("Ok! Abrir Netiflix")
			pare

			caso 2:
			escreva("Ok! Abrir  Amazon Prime")
			pare

			caso 3:
			escreva ("Ok! Abrir HBO GO!")
			pare

			caso 4:
			escreva ("Saindo do menu...")
			pare

			caso contrario:
			escreva ("Você deve escolher as opções 1, 2 ou 3")
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 433; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */