# 🧵 Algoritmo de Threads em C#

Este algoritmo em C# permite que você execute múltiplas operações de cálculo de fatorial
em paralelo usando threads. O número de cálculos e o número para o cálculo desejado são 
solicitados ao usuário por meio de entrada de teclado.

## Como usar
* Execute o programa em um ambiente de desenvolvimento C#
* Insira o número de cálculos que deseja executar
* Insira o número para cada cálculo desejado
* Aguarde a execução de todas as threads
* Os resultados serão exibidos no console.

## Funcionamento do algoritmo
O algoritmo cria um array de threads com base no número de cálculos que o usuário deseja executar.
Em seguida, cada thread é inicializada com uma função que executa o cálculo de fatorial para o 
número fornecido pelo usuário. 
O nome de cada thread é atribuído com base no número de cálculo correspondente.
As threads são iniciadas usando o método Start() e, em seguida, o programa aguarda a execução 
de todas as threads usando o método Join(). A função CalcularFatorial() executa a operação de
cálculo de fatorial e exibe os resultados de cada iteração e o resultado final para cada cálculo.

## Author
👨‍💻 Vitor Santos
