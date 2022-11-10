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
  double altura, peso, salario;
  string nomePai, rua, bairro, dtNasc;
  bool temCasa;
}
```

# Estruturas

# Sequencial
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
***
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
***
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

### Cálculo de porcentagem:

Exemplo: 13% de algum valor...

>`0.13 * valor` ou `(13/100)` * valor;
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
   // Impressão dos resultados
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

- 1º Parênteses
- 2º Operadores `*`, `/` e `%`
- 3º Operadores `+` e `-`


## Condicional
## de Repetição
