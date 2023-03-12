using System;
class Program{
    static void Main(string[] args){
        int num;
        int fatorial=1;
        for(num=1;num<=10;num++){
            fatorial=1;
            for(int i=1;i<=num;i++){
                fatorial=fatorial*i;
            }
            Console.WriteLine("Fatorial de "+num+" é "+fatorial);
        }
    }
}
