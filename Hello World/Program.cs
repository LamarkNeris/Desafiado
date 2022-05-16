using Hello_World.Domain;


//Calcular média de idade

var idadeMinima = 20;

var idadeMaxima = 50;

var mediaAluno = (idadeMinima + idadeMaxima) / 2;

Console.WriteLine(mediaAluno);



// Conversor de moedas

double euro, valorReal;

euro = 5.26;

Console.WriteLine("Insira o valor da compra:");

valorReal = double.Parse(Console.ReadLine()) * euro;

Console.WriteLine($"O valor da sua compra em reais é: {valorReal}");


// Comissão de vendas

double comissao, valorVenda;

valorVenda = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor vendido:");

comissao = (valorVenda/ 20) + valorVenda;


Console.WriteLine($"O valor da sua comissão é: {comissao}");


//




