using System;

class MainClass {
  public static void Main (string[] args) {
    Double preco, totalCompra = 0; // Acumulador

    Console.Write("Digite o preco do produto: R$ ");
    preco = Double.Parse(Console.ReadLine());
    while (preco > 0) 
    {
      totalCompra = totalCompra + preco;
      Console.Write("Digite o preco do produto: R$ ");
      preco = Double.Parse(Console.ReadLine());
    } 
    Console.Write($"\nO valor total da compra = R$ {totalCompra:0.00}");
  }
}