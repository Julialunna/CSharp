using System;
class EncadeandoFor{
    static void Main(string[] args){
        Console.WriteLine("Executando o projeto 13 - Encadeando For ");

        for(int contadorLinhas=0;contadorLinhas<10;contadorLinhas++){
            for(int contadorColuna=0;contadorColuna<10;contadorColuna++){
                Console.Write("*");
                if(contadorColuna>=contadorLinhas){
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
