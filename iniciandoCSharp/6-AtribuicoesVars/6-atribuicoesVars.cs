using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projetp 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idade);

        idade = 25;
        Console.WriteLine(idadeAna);
        Console.WriteLine("tecle ENTER para fechar");
        Console.ReadLine();
    }
}
