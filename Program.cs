//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

// Meu Algoritimo

// - Insira nome
// - Ler nome
// - while (nome.Lenght == 0)
// 	- Insira um nome valido
// 	- Ler nome

// - Insira idade
// - Ler idade
// - while (idade < 0) || (idade > 100)
// 	- Insira uma idade valida
// 	- Ler idade

// - Insira salario
// - Ler salario
// - while (salario < 0)
// 	- Insira um salario valido
// 	- Ler salario

// - Insira seu estado civil
// - Ler estadoCivil
// - switch (estadoCivil)
// 	- case 's'
// 	- solteiro

// 	- case 'c'
// 	- casado

// 	- case 'v'
// 	- viuvo

// 	- case 'd'
// 	- divorsiado

//SOLUCAO

Console.WriteLine($"Insira seu nome:");
string nome = Console.ReadLine();

while (nome.Length == 0)
{
    Console.WriteLine($"Insira um nome valido:");
    nome = Console.ReadLine();
}

Console.WriteLine($"Insira sua idade:");
int idade = int.Parse(Console.ReadLine());

while ((idade < 0) || (idade > 100))
{
    Console.WriteLine($"Insira uma idade valida (Um numero de 0 a 100):");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Insira seu salario:");
double salario = double.Parse(Console.ReadLine());

while (salario < 1)
{
    Console.WriteLine($"Insira um salario valido (nao pode ser 0):");
    salario = double.Parse(Console.ReadLine());
}

bool estadoCivilValidacao = false; 

do
{
    Console.WriteLine(@$"Insira seu Estado Civil:
- Digite 's' para solteiro
- Digite 'c' para casado
- Digite 'v' para viuvo
- Digite 'd' para divorciado");

    char estadoCivil = char.Parse(Console.ReadLine().ToLower());

    switch (estadoCivil)
    {
        case 's':
            Console.WriteLine($"Estado civil solteiro selecionado");
            estadoCivilValidacao = true;
            break;
        case 'c':
            Console.WriteLine($"Estado civil casado selecionado");
            estadoCivilValidacao = true;
            break;
        case 'v':
            Console.WriteLine($"Estado civil viuvo selecionado");
            estadoCivilValidacao = true;
            break;
        case 'd':
            Console.WriteLine($"Estado civil divorciado selecionado");
            estadoCivilValidacao = true;
            break;
        default:
            Console.WriteLine($"Estado Civil incorreto");
            estadoCivilValidacao = false;
            break;
    }
} while (estadoCivilValidacao == false);