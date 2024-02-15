## Teste para processo seletivo da Smark

> Escreva um programa e C# que gera um protocolo de atendimento baseado na lógica a seguir:

	Formação do Protocolo: XXXXXXAAAAMMDDNNNNNN
		Ex: 31970820230921000001
		onde:
		XXXXXX = Número identificador da empresa: 6 dígitos numéricos. Ex: Empresa A = 319708
		AAAAMMDD = Ano, Mês e Dia. Ex: 20230921
		NNNNNN = Número sequencial do protocolo: 6 dígitos numéricos (confirmar). Ex: 000001, 000002, etc.

### Algoritmo:
- Implementar método de geração do sequencial do protocolo com controle de concorrência (método síncrono), somente um processo de cada vez pode gerar protocolo para não gerar dois sequenciais idênticos para a mesma empresa. 
- Número identificador da empresa é sempre o mesmo.
- A identificação da data muda a cada dia.
- O número sequencial do protocolo deve ser reiniciado diariamente. Ao longo do dia, o sequencial incrementa à cada solicitação de novo protocolo