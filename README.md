# Notas Agoritmo em C# (PUC Minas)

# Variáveis

- `int`: variáveis numéricas do tipo inteiro (sem casas decimais) - 9, 12, 13, 500, 90...
- `double` ou `float`: variáveis numéricas do tipo real (com casas decimais) - 9.8, 13.990...
- `string`: variáveis do tipo caractere - 'João da Silva', 'Av. Brasil'...
- `bool`: variáveis do tipo "booleano" (`true` ou `false`)

## Exemplo:

```csharp
static void Main(string[] args)
{
  int idade, numero;
  double altura, peso, salário;
  string nomePai, rua, bairro, dtNasc;
  bool temCasa;
}
```

# Estruturas

## Sequencial
Executar os comandos na sequencia que foram determinados.

- Comando de atribuição

C# - símbolo `=`

Sintaxe: `variável = expressão`

```csharp
using System;

class MainClass {
  public static void Main(string[] args) {
    int idade;
    double altura, peso, copiaPeso, IMC;
    string nome;
    bool temCNH;
    
    idade = 23;
    altura = 1.76;
    peso = 78.9;
    nome = "João da Silva";
    temCNH = true;
    copiaPeso = peso
    IMC - peso / (altura * altura);
  }
}
```

- Juntando as variáveis...

```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    int idade = 23;
    double altura = 1.76, peso = 78.9;
    string nome = "João da Silva";
    bool temCNH = true;
    
    copiaPeso = peso;
    IMC = peso / (altura * altura);
  }
}
```
### Comandos de saídas de dados

```csharp
Console.Write("Mensagem a ser impressa");
Console.Write(var);
Console.Write("Mansagem1 "+var1+"Mensagem 2 "+var2);
```
>Importante usar o espaço dentro das aspas paa que os dados (textos e conteúdos de variáveis) sejam impressos separados uns dos outros.

```csharp 
Console.WriteLine(...)
```
>O  cursos pula para a primeira coluna da próxima linha.
```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    int idade = 27;
    string nome = "João da Silva";

    // Concatenação
    Console.WriteLine("Meu nome é "+nome+" e tenho "+idade+" anos de idade.");
    // Placeholder
    Console.WriteLine("Meu nome é {0} e tenho {1} anos de idade.", nome, idade);
    // Interpolação
    Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos de idade.");

    Console.ReadKey();
    
  }
}
```
### Comando de entrada de dados

```csharp
variavel = ConsoleReadLine();
```
>Comando utilizado para receber valores digitados pelos usuários

- Lendo valoes inteiros
```csharp
variavel = int.Parse(Console.ReadLine()); // Valor convertido para inteio
varariavel = Convet.ToInt32(Console.ReadLine()); // valor convetido para inteiro
```
- Lendo valores reais
```csharp
variavel = Double.Parse(Console.ReadLine());
variavel = float.Pase(Console.ReadLine());
variavel = Convert.ToDouble(Console.ReadLine());
```

## Condicional
## de Repetição
