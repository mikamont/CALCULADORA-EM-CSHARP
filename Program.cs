//int x;
//Console.WriteLine("Digite o valor de X");
//x = Convert.ToInt32(Console.ReadLine());

//usando concatenacao
//Console.WriteLine("O Usuario digitou: " + x + "parabens");

//interpolacao de strings
//Console.WriteLine($"O usuario digitou: {x} parabens!");

//usando placeholders
//Console.WriteLine("O usuario digitou: {0} parabens!", x);

int x, y;
double divisao, multiplicacao, adicao, subtracao;

Console.Write("digite o primeiro valor = ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("digite o segundo valor = ");
y = Convert.ToInt32(Console.ReadLine());

divisao = (double)x / y;
multiplicacao = x * y;
adicao = x + y;
subtracao = x - y;

Console.WriteLine($"O resultado da divisão de {x} por {y} é: {divisao}"); //interpolaçao
Console.WriteLine("o valor da adição é de: " + adicao ); //concatenaçao
Console.WriteLine("O valor da subtração é: {0}", subtracao); //placeholders
Console.WriteLine("o resultado da multiplicação é: {0}", multiplicacao); //placeholders



