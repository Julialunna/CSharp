using System;
class CalculaPoupanca{
    static void Main(string[]args){

        Console.WriteLine("Executando projeto 10 - Investindo a Longo Prazo");

        double fatorRendimento=1.005;
        double investimento=1000;
        for(int anos=1;anos<=5;anos++){
            for(int mes=1;mes<=12;mes++){
                investimento*=fatorRendimento;
            }
            fatorRendimento+=0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá: "+investimento);
        
    }
}
