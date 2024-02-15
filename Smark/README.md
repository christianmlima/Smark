## Teste para processo seletivo da Smark

> Escreva um programa e C# que gera um protocolo de atendimento baseado na l�gica a seguir:

	Forma��o do Protocolo: XXXXXXAAAAMMDDNNNNNN
		Ex: 31970820230921000001
		onde:
		XXXXXX = N�mero identificador da empresa: 6 d�gitos num�ricos. Ex: Empresa A = 319708
		AAAAMMDD = Ano, M�s e Dia. Ex: 20230921
		NNNNNN = N�mero sequencial do protocolo: 6 d�gitos num�ricos (confirmar). Ex: 000001, 000002, etc.

### Algoritmo:
- Implementar m�todo de gera��o do sequencial do protocolo com controle de concorr�ncia (m�todo s�ncrono), somente um processo de cada vez pode gerar protocolo para n�o gerar dois sequenciais id�nticos para a mesma empresa. 
- N�mero identificador da empresa � sempre o mesmo.
- A identifica��o da data muda a cada dia.
- O n�mero sequencial do protocolo deve ser reiniciado diariamente. Ao longo do dia, o sequencial incrementa � cada solicita��o de novo protocolo