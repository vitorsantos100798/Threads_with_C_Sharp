<!DOCTYPE html>
<html>
<head>
	
</head>
<body>
	<h1>Algoritmo de Threads em C#</h1>

	<p>Este algoritmo em C# permite que você execute múltiplas operações de cálculo de fatorial em paralelo usando threads. O número de cálculos e o número para o cálculo desejado são solicitados ao usuário por meio de entrada de teclado.</p>

	<h2>Como usar</h2>

	<ol>
		<li>Execute o programa em um ambiente de desenvolvimento C# de sua escolha</li>
		<li>Insira o número de cálculos que deseja executar</li>
		<li>Insira o número para cada cálculo desejado</li>
		<li>Aguarde a execução de todas as threads</li>
		<li>Os resultados serão exibidos no console.</li>
	</ol>

	<h2>Funcionamento do algoritmo</h2>

	<p>O algoritmo cria um array de threads com base no número de cálculos que o usuário deseja executar. Em seguida, cada thread é inicializada com uma função que executa o cálculo de fatorial para o número fornecido pelo usuário. O nome de cada thread é atribuído com base no número de cálculo correspondente. As threads são iniciadas usando o método Start() e, em seguida, o programa aguarda a execução de todas as threads usando o método Join(). A função CalcularFatorial() executa a operação de cálculo de fatorial e exibe os resultados de cada iteração e o resultado final para cada cálculo.</p>

	<h2>Referências</h2>

	<h2>author</h2>
</body>
</html>
