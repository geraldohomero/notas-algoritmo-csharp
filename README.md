# Notas Agoritmo em C# (PUC Minas)

<!--ts-->
- [Variáveis](#variáveis)

- [Estrutura Sequencial](#estrutura-sequencial)

    - [Comando de saída de dados](#comandos-de-saídas-de-dados)
    - [Comando de entrada de dados](#comando-de-entrada-de-dados)
    - [Operações aritméticas](#operações-aritméticas)
      - [Operadores](#operadores)
        - [Operadores de atribuição combinados](#operadores-de-atribuição-combinados)
        - [Operadores de incremento e descremento](#operadores-de-incremento-e-descremento)
    - [Potenciação e radiciação](#potenciação-e-radiciação)
    - [Cálculo de porcentagem](#cálculo-de-porcentagem)
    - [Ordem de execução dos operadores aritméticos](#ordem-de-execução-dos-operadores-aritméticos)
    - [Conversão de Tipos](#conversão-de-tipos)
      - [Implícita](#conversão-implícita)
      - [Explícita (Type casting)](#type-casting-conversão-explítica)

- [Estrutura Condicional](#estrutura-condicional)
  - [Condicional Simples](#condicional-simples)
  - [Condicional Composto](#condicional-composto)
  - [Blocos de Comandos](#blocos-de-comandos)
    - [Layout das {} chaves](#layout-das-chaves)
  - [Operadores relacionais ou comparativos](#operadores-relacionais-ou-comparativos)
  - [Operadores Booleanos](#operadores-booleanos)
  - [Tabela Verdade](#tabela-verdade)
  - [Ladder if](#ladder-if)
  - [Nested if](#nested-if)
  - [Else oscilante](#elseoscilante)
  - [Comando switch/case](#comando-switchcase)
  - [Operador ternário](#operador-ternário)

- [Estrutura de Repetição](#estrutura-de-repetição)

<!--te-->
## Variáveis

- `int`: variáveis numéricas do tipo inteiro (sem casas decimais) - 9, 12, 13, 500, 90...
- `double` ou `float`: variáveis numéricas do tipo real (com casas decimais) - 9.8, 13.990...
- `string`: variáveis do tipo caractere - 'João da Silva', 'Av. Brasil'...
- `bool`: variáveis do tipo "booleano" (`true` ou `false`)

### Exemplo:

```csharp
static void Main(string[] args)
{
  int idade, numero;
  double altura, peso, salario;
  string nomePai, rua, bairro, dtNasc;
  bool temCasa;
}
```

# Estrutura Sequencial
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
## Comandos de saídas de dados

```csharp
Console.Write("Mensagem a ser impressa");
Console.Write(var);
Console.Write("Mansagem1 "+var1+"Mensagem 2 "+var2);
```
>Importante usar o espaço dentro das aspas paa que os dados (textos e conteúdos de variáveis) sejam impressos separados uns dos outros.

```csharp 
Console.WriteLine(...)
```
>O  cursor pula para a primeira coluna da próxima linha.
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
## Comando de entrada de dados

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
variavel = float.Parse(Console.ReadLine());
variavel = Convert.ToDouble(Console.ReadLine());
```

- Lendo texto
>sem a necessidade de conversão
```csharp
variavel = ConsoleReadLine();
```
- Lendo valores booleanos
```csharp
variavel = bool.Parse(Console.ReadLine():
```
### Exemplo:
```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    int n1, n2;
    double n3, n4;
    float n5;
    string s;
    bool b1, b2;
    // Leitura de Inteiros
    Console.Write("Digite um número inteiro: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número inteiro: ");
    n2 = Convert.ToInt32(Console.ReadLine());
    // Leitura de valores ponto-flutuante
    Console.Write("Digite um número real: ");
    n3 = double.Parse(Console.ReadLine());
    Console.Write("Digite outro número real: ");
    n4 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Digite mais um número real: ");
    n5 = float.Parse(Console.ReadLine());

    Console.Write("Digite um booleano (digite true ou false): ");
    b1 = bool.Parse(Console.ReadLine());
    Console.ReadKey();
  }
}
```
>interessante sempre o `Console.ReadLine();` vir acompanhado de um `Console.Write();`:

```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    int n1, n2, soma;
    double media;
    Console.Write("Digite um número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número: ");
    n2 = int.Parse(Console.ReadLine());
    soma = n1 + n2;
    media = soma / 2;
    Console.WriteLine("Soma = "+soma);
    Console.WriteLine("Media = "+media);
  }
}
```
## Operações aritméticas

### Operadores:

|Operador |    Operação | Exemplo                |
|:-------:|:------------|:------------------------|
| `+`     |     Soma    | soma = numero + 100;   | 
| `-`     |   Subtração | result = 100 - soma;   |
| `*`     |Multiplicação| INSS = salario * 0.11; |
| `\`     |   Divisão   | media = soma / qtde;   |
| `%`     |Resto de uma divisão inteira| resto = numero % 2;|

>Exemplo `%` | `resto = numero % 2` (pega o valor da variável `numero` dividido por 2 e calcular o "resto" desta divisão)

### Operadores de atribuição combinados:

|Operador |    Operação | Exemplo                | Significado |
|:-------:|:------------|:-----------------------| :--------   |
|`+=`     | Soma        |      soma += 100;      | soma = soma + 100; |
|`-=`     | Subtração   |      result -= 20;     | result = result - 20;|
| `*=`    | Multiplicação| dobro *= 2;           | dobro = dobro * 2; |
|`/=`     | Divisão     | metade /= 2;           |metade = metade / 2;|
|`%`| Resto de uma divisão inteira| resto %=7;   | resto = resto / 7; |

>Mesma variável aparecendo do lado `direito` e `esquerdo` da operação

### Operadores de incremento e descremento
|Operador |    Operação    | Exemplo| Significado|
|:-------:|:---------------|:-----| :-------  |
| `++`    | Pré-incremento | ++x; | x = x + 1;|
|         | Pós-incremento | x++; | x = x + 1;|
| `--`    | Pré-decremento | --x; | x = x - 1;|
|         | Pós-decremento | x--; | x = x - 1;|

### Exemplo:
```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    int preinc = 7, posinc = 7, predec = 7, posdec = 7;
    Console.WriteLine($"preinc = {++preinc}");
    Console.WriteLine($"posinc = {posinc++}");
    Console.WriteLine($"predec = {--predec}");
    Console.WriteLine($"posdec = {posdec--}");
    Console.WriteLine("\nREIMPRIMINDO");
    Console.WriteLine($"preinc = {preinc}");
    Console.WriteLine($"posinc = {posinc}");
    Console.WriteLine($"predec = {predec}");
    Console.WriteLine($"posdec = {posdec}");
  }
}
```
> `++x` Primeiro incrementa, depois imprime a variável `++preinc = 8`

> `x++` Primeiro imprime, depois incrementa `posinc = 7`

> `--x` Primeiro decrementa, depois imprime `--predec = 6`

> `x--`Primeiro imprime, depois decrementa `posdec = 7`

- 9 dividido por 4 é igual a 2 e resta 1

![image](https://user-images.githubusercontent.com/70844369/201221434-e27ec068-ddc5-415a-b70d-79fafdde5535.png)

### Potenciação e radiciação

| Função | Operação | Exemplo |
|:---: | :---- | :-------|
|`Math.Sqrt()` | Radiciação | Raiz = Math.Sqrt(9);|
|`Math.Pow()` |Potenciação e Radiciação | Quadrado = Math.Pow(9, 2);|
|             |                     | RaizCubica = Math.Pow(81, (1.0/3)); |

>Variáveis que recebem o resuldado das funções `Math.Pow()` e `Math.Sqrt()` devem ser do tipo `Double`, pois as funções retornam valores do tipo `Double`.

## Cálculo de porcentagem:

Exemplo: 13% de algum valor...

>`0.13 * valor` ou `(13/100) * valor`;
***
### Exemplos de operações aritméticas:
```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
   int a = 5, b = 2, c;
   int Soma, Subt, Mult, Quociente, Resto;
   Double DivExata, RaizQuadrada, Quadrado, Cubo, RaizCubica;
   // Realização dos cálculos
   Soma = a + b;
   Subt = a - b;
   Mult = a * b;
   Quociente = a / b;
   Resto = a % b;
   DivExata = 9 / 2.0;
   RaizQuadrada = Math.Sqrt(36);
   Quadrado = Math.Pow(a, b);
   c = b + 1;
   Cubo = Math.Pow(c, c);
   RaizCubica = Math.Pow(125, 1/3.0);
   // Impressão
   Console.WriteLine($"{a} + {b} = {Soma}");
   Console.WriteLine($"{a} - {b} = {Subt}"); 
   Console.WriteLine($"{a} * {b} = {Mult}");
   Console.WriteLine($"{a} / {b} = {Quociente}");
   Console.WriteLine($"{a} % {b} = {Resto}");
   Console.WriteLine($"9 / 2.0 = {DivExata}"); 
   Console.WriteLine($"A raiz quadrada de 36 = {RaizQuadrada}");
   Console.WriteLine($"{a} elevado a {b} = {Quadrado}"); 
   Console.WriteLine($"{c} elevado a {c} = {Cubo}"); 
   Console.WriteLine($"A raiz cubica de 125 = {RaizCubica}"); 
  }
}
```
### Ordem de execução dos operadores aritméticos:

- 1º Parênteses `()`
- 2º Operadores `*`, `/` e `%`
- 3º Operadores `+` e `-`

### Conversão de tipos

#### Conversão implícita
```csharp
int x = 5;
Double y = x;
```
#### Type casting (conversão explítica)

```csharp
int x = 5, y = 2;
float f = (float)x/y;
Double d = x/(Double)y;
```

# Estrutura Condicional

### Condicional simples

- `if` se um comando será execurato ou não, dependendo se a condição é `verdadeira` ou `falsa`.

```
se estiver chovendo
  vou levar o guarda-chuva
```

### Condicional composto

- `if-else` qual comando será executado, se o comando seguinte ao `if` ou o seguinte ao `else`.

```
se estiver chovendo
  vou de carro
senão
  vou de moto
```

### Sintaxe
```csharp
if (condição) // "true" ou "false"
  comando;

// // //

if (condição) //"true" ou "false"
  comando1;
else
  comando2;
```

### Exemplo: 

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
      int nota;
      Console.Write("Digite a nota do aluno: ");
      nota = int.Parse(Console.ReadLine());
      if (nota >= 60)
        Console.WriteLine("O aluno foi aprovado.");
      else 
        Console.WriteLine("O aluno foi reprovado.");
  }
}
```
## Blocos de comandos

>Normalmente os comandos com `if` e/ou `else` são constituidos por múltiplos comandos. Devemos agrupá-los por `{}` para a formação dos `blocos` de comandos.

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
      int nota;
      Console.Write("Digite a nota do aluno: ");
      nota = int.Parse(Console.ReadLine());
      if (nota >= 60)
      {
        Console.WriteLine("O aluno foi aprovado.");
        Console.WriteLine("Parabéns!!!"); // comando adicional...tornando o uso de chaves obrigatório.
      }
      else 
        Console.WriteLine("O aluno foi reprovado."); // um único comando...tornando o uso das chaves opcional.
  }
}
```

## Layout das chaves `{}`
>Para o compilados não há diferença. Importante sempre manter um padrão durante todo o código.
```csharp
if (nota >= 60)
{
  Console.WriteLine("O aluno foi aprovado.");
  Console.WriteLine("Parabéns!!!");
}

//

if (nota >= 60) {  //essa forma reduz o código em UMA LINHA
  Console.WriteLine("O aluno foi aprovado.");
  Console.WriteLine("Parabéns!!!");
}
```

### Operadores relacionais ou comparativos

|Operador |    Operação| Exemplo|
|:-------:|:-----------|:-------|
|`==`|Igualdade| n1 == n2|
|`<` | Menor | valor < 100 |
|`>` | Maior | numero1 > numero2|
|`<=`| Menor ou igual| soma <= 0|
|`>=`| Maior ou igual| idade >= maioridade|
|`!=`| Desigualdade| x != y|

>O operador `==` é para fazer comparação entre valores ou entre variáveis, sendo diferente do operador `=` de ATRIBUIÇÃO (aquele que armazena um valor).

## Operadores booleanos

`&&` (AND), `||`(OR),  `!`(NOT)

|Operador |    Operação| Exemplo|
|:-------:|:-----------|:-------|
|`&&`(AND)|Todos V = V | if (nota >= 60 `&&` faltas <= 17); |
|`2 pipes`(OR)|Um V = V    | if (idade >= 65 `OR` salario < 1000);| 
|`!`(NOT)|Nega a condição| if (`!` (x == y `&&` a >= b)) |

## Tabela verdade
`&&` AND
|A|B|A&&B|
|-|-|----|
|true|true|true|
|true|false|false|
|false|true|false|
|false|false|false|

`||` OR

|A|B|A(OR)B|
|-|-|------|
|true|true|true|
|true|false|true|
|false|true|true|
|false|false|false|

`!` NOT
|A|!A|
|-|--|
|true|false|
|false|true|

### Exercício:
>Faça um programa em C# para calcular e imprimir o valor a ser descontado de INCC no salário de um empregado utilizando a tabela abaixo. O usuário fornecerá o salário.

|Faixa salarial| Alíquota|
|--------------|---------|
|Até R$ 1000,00| 8%|
|Entre R$1000,00 e 1800,00| 10%|
|Acima de R$1800,00| 12%|

[Resultado](./csharp-code/exercicio-csharp-inss.cs)

### Ladder `if`

```csharp
if (condição1)
  comando1;
else if (condição2)
  comando2;
...
else if (condiçãoN)
  comandoN;
```

### Nested `if`

```csharp
if (condição1)
  comando1;
else
if (condição2)
    comando2;
  else
    if (condição3)
      comando3;
...
          else
            if (condiçãoN)
              comandoN;
              else
                comandoN+1;
```

## `Else`oscilante

```csharp
if (Richter >= 0)
{
    if (Richter <= 4)
      Console.WriteLine("Terremoto inofensivo!");
}
else
  Console.WriteLine("Escola Richter não permite valores negativos!");
```
>Agora `else` se refere ao primeiro `if`.

>Sem as chaves `{}` o `else` estaria ligado ao `if` mais próximo.

## Comando `switch`/`case`
- É uma estrutura condicional que define o código a ser executado baseando-se não em uma condição, mas em uma comparação de valores e/ou alternativas.

### Sintaxe
```csharp
switch(opcao)
{
  case op1:
    //comandos caso a opção 1 tenha sido escolhida
    break;
  case op2:
    //comandos caso a opção 2 tenha sido escolhida
    break;
...

  case opN:
    //comandos caso a opção N tenha sido escolhida
    break;
  default:
    //comandos caso nenhuma das opções anteriores tenha sido escolhida
    //operação padrão...
}
```
[Exemplo-switch-case](./csharp-code/teste-switch-mes.cs)

### Operador ternário
>Trabalha sobre 3 operandos. Pode ser utilizado, em alguns casos, no lugar do `if` e `else`.

- Sintaxe:
```csharp
condicao ? expressao_true:expressao_false
```
>`condicao` é qualquer expressão que retorna um valor `booleano`

>Se a `condicao` é `true`, a `expressao_true` será avaliada e retornada

>Se a `condicao` é `false`, a `expressao_false` será avaliada e retornada

#### Exemplo 1:

```csharp
bool passou;
if (nota >= 60)
    passou = true;
else
    passou = false;
```

>Pode ser substituída pelo operador ternário:

```csharp
passou = nota >= 60 ? true : false;
```

>Usando parênteses pode tornar mais legível:

```csharp
passou = (nota >= 60 ? true : false);
// ou //
passou = (nota >= 60) ? true : false
```

#### Exemplo 2:

```csharp
string status;
if (nota >= 60)
    status = "aprovado";
else
    status = "reprovado";
Console.WriteLine("O aluno foi "+status);
```

>Utilizando ternário:

```csharp
Console.WriteLine("O aluno foi "+ (nota >= 60?"aprovado":"reprovado"));
```

```csharp
INSS = (salario <= 1000 ? salario * 0.8 : salario * 0.10);
```

# Estrutura de repetição

- 