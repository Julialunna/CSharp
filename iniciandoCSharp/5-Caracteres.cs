using System;

class Programa {
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 5 - caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeraFrase = "Alura cursos de tecnologia ";
        Console.WriteLine(primeraFrase + 2023);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis 
                        - Go 
                        - C# 
                        - Python 
                        - Java";
        Console.WriteLine(cursos); 

        //não pode ter caracter vazia char vazia = ''; -> X

        Console.WriteLine("tecle ENTER para fechar");
        Console.ReadLine();
    }
}
