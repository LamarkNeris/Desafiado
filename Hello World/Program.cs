using Hello_World.Domain;


//Calcular média de idade
int idadeMinima, idadeMaxima;

Console.WriteLine("Insira a idade mínima:");
idadeMinima = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a idade máxima:");
idadeMaxima = int.Parse(Console.ReadLine());

var mediaIdade = (idadeMinima + idadeMaxima) / 2;

Console.WriteLine($"A média das idades é: {mediaIdade}");



// Conversor de moedas

double euro, valorReal;

euro = 5.26;

Console.WriteLine("Insira o valor da compra:");

valorReal = double.Parse(Console.ReadLine()) * euro;

Console.WriteLine($"O valor da sua compra em reais é: {valorReal}");



// Comissão de vendas

double comissao, valorVenda;

Console.WriteLine("Insira o valor vendido:");

valorVenda = double.Parse(Console.ReadLine());
comissao = (valorVenda/ 20) + valorVenda;

Console.WriteLine($"O valor da sua comissão é: {comissao}");



//converter Calcius para  Fahrenheit

double celcius, fahren;

Console.WriteLine("Digite o valor em graus Celcius:");
celcius = double.Parse(Console.ReadLine());

fahren = (9 * celcius + 160) / 5;

Console.WriteLine($"O valor em graus Fahrenheit é: {fahren}");


//converter Fahrenheit para Celcius

double c, F;

Console.WriteLine("Digite o valor em graus Fahrenheit:");
F = double.Parse(Console.ReadLine());

c = (F - 32) * 5 / 9;

Console.WriteLine($"O valor em graus Calcius é: {c}");


// calculadora de peso

double peso, altura, pesoIdeal;

Console.WriteLine("Digite o seu peso:");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua altura:");
altura = double.Parse(Console.ReadLine());

pesoIdeal = (peso * altura) - 58;

Console.WriteLine($"O seu peso ideal é: {pesoIdeal}");



//Calculadora de notas

double[] notas = new double[4];
double media;

Console.WriteLine("Digite as suas notas:");

for(int i = 0; i < 4; i++)
{
    notas[i] = double.Parse(Console.ReadLine());
}

    media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

if (media > 7)
{
    Console.WriteLine("Aprovado!!");
}
else
    Console.WriteLine("Reprovado");



//calculadora subtração

double valor1, valor2, resultado;

valor1 = double.Parse(Console.ReadLine());
valor2 = double.Parse(Console.ReadLine());

resultado = valor1 - valor2;

if(resultado > 0)
{
    Console.WriteLine($"Total positivo = {resultado}");
}
else
    Console.WriteLine($"Total negativo = {resultado}");



// Calculadora divisão

double v1, v2, res;

v1 = double.Parse(Console.ReadLine());
v2 = double.Parse(Console.ReadLine());

res = valor1 / valor2;

if (v1 == 0 || v2 == 0 )
{
    Console.WriteLine("Impossível efetuar a divisão por 0");
}
else
    Console.WriteLine($"O valor da sua divisão é: {res}");
