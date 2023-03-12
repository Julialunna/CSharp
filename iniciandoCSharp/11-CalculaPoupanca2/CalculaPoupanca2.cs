using System;
class CalculaPoupanca{
    static void Main(string[]args){

        Console.WriteLine("Executando projeto 10 - Calcula Poupança");

        double investimento=1000;
        int mes=1;
        //rendimento de 0.5% (0.005) ao mês
        /*
        while(mes<=12){
            investimento=investimento+investimento*0.005;
            Console.WriteLine("No mês "+mes+" você tem R$" +investimento);
            mes++;
        }*/
        for(mes=1;mes<=12;mes++){
            investimento*=1.005;
            Console.WriteLine("No mês "+mes+" você tem R$" +investimento);
        }
    }
}
