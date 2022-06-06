//Operadores relacionais

//int a = 10;
//int b = 20;


//Console.WriteLine($"a é igual a b ? {a == b}");
//Console.WriteLine($"a é diferente de b ? {a != b}");
//Console.WriteLine($"a é maior a b ? {a > b}");
//Console.WriteLine($"a é menor a b ? {a < b}");
//Console.WriteLine($"a é maior ou igual a b ? {a >= b}");
//Console.WriteLine($"a é menor ou igual a b ? {a <= b}");



/* 
    Console.WriteLine("Digite a sua idade:");
int idade = int.Parse(Console.ReadLine());


while (idade < 18)
{
    idade++;

    Console.WriteLine(idade);
}
*/


/*
int a = 10;
int b = 20;
int c = 30;
*/




// Implementar usando if e else e if ternário "eu como admin, de uma faculdade, gostaria de saber os alunos aprovados e reprovados,
// indice nota >= 7, menor que 5 é reprovado e entre 5 e 7 em recuperação, implementar um programa que faça isso.


Console.WriteLine("------Sistema de notas Faculdade JLL------");

Console.WriteLine("Digite a sua nota:");
double nota = double.Parse(Console.ReadLine());
var media = nota >= 7 ? "Aprovado" : "Reprovado";

Console.WriteLine(media);



if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if(nota >= 5 && nota < 7)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}















