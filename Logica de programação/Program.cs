// Varáveis
// C# - linguagem Fortemente tipada
// tipos de dadosÇ string, int, float, double, bool
// tipoDeDado nomeDaVariavel = valorAtribuido

using System.Reflection.Metadata;

string nome = "Laura"; //Criando e atribuindo a variavel
int idade = 18; //Criei e atribui a variavel

//! Com o @ é possível quebrar as linhas
Console.WriteLine("O nome do usuário é: " + nome); //Imprimi a variável com concatenção 
Console.WriteLine(@$"A idade do usuário é: + {idade}");

var nomeDois = "Caio";
var idadeDois = "17";
var verificacao = true;

// Constantes
const int qntdMeses = 12;
Console.WriteLine(qntdMeses);

int anoAtual = 2025;
int anoNasc = 2008;

int idade3 = anoAtual - anoNasc;

Console.WriteLine("Operados aritmedicos");
Console.WriteLine("A idade da Dani é: " + idade3);

float trocadoMae = 2.20f;
float trocadoVo = 150.60f;

float trocadoTotal = trocadoMae + trocadoVo;

Console.WriteLine(" O trocado foi de R$" + trocadoTotal);

int n1 = 6;
int n2 = 2;

int multiplicacao = n1 * n2;
int divisao = n1 / n2;
int resto = n1 % n2;

Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
Console.WriteLine($"O resultado da multiplicação é: {divisao}");
Console.WriteLine($"O resultado da multiplicação é: {resto}");
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("-------------Operadores Logicos---------------------");
int idadeBelly = 18;
bool suco = false;
bool camisaDeTime = true;
//! inverte o valor do booleano 

if (idadeBelly >= 18 && !suco || !camisaDeTime) 
{
    Console.WriteLine("Vamos começar TutsTutsTuts");
}
else
{
    Console.WriteLine("Uma pena, a entrada de menores e consumos não é permitido!");
}
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("--------------------Operadores Condicionais----------------------");

// int dinheiroPessoa1 = 2500;
// int dinheiroPessoa2 = 1000000;

int dinheiroPessoa1 = int.Parse(Console.ReadLine());
int dinheiroPessoa2 = int.Parse(Console.ReadLine());

if (dinheiroPessoa1 > dinheiroPessoa2)
{
    Console.WriteLine("A pessoa1 paga a pizza hoje!");
}
else if (dinheiroPessoa1 < dinheiroPessoa2)
{
    Console.WriteLine("A pessoa2 paga a pizza hoje!");
}
else
{
    Console.WriteLine("A conta vai ser rachada!");
}
Console.WriteLine("--------------------------------------------------------");

// switch case
string diaSemana = "Terça-feira";

switch (diaSemana.ToLower())
{
    case "domingo":
        Console.WriteLine("Domingou, hora do fantástico");
        break; // sai do switch case
    case "segunda-feira":
        Console.WriteLine("Segudou, dia de tristeza");
        break; // sai do switch case
    case "terça-feira":
        Console.WriteLine("Terçou, masterchef na tv");
        break; // sai do switch case
    case "quarta-feira":
        Console.WriteLine("Quartou, feijuca hoje");
        break; // sai do switch case
    case "quinta-feira":
        Console.WriteLine("DQuintou, parece que a semana não acaba");
        break; // sai do switch case
    case "sexta-feira":
        Console.WriteLine("Sextou, dia de farra!");
        break; // sai do switch case
    case "sabado":
        Console.WriteLine("Sabadou, dia de sair!");
        break; // sai do switch case
    default:
        Console.WriteLine($"opss, esse dia não existe!");
        break;
}

// Laços
// for(inicializador, condiçõa, incrementa/decrementa)
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

// while
bool amarVoce = true;

while (amarVoce)
{
    Console.WriteLine($"te amo");
    amarVoce = false;
}

// do while
bool minerio = false;

do
{
    Console.WriteLine("Minerando.....");
} while (minerio);

Console.WriteLine("--------------------------------------------------------");