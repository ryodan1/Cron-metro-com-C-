using System;
using System.Threading;

    namespace  StopWatch
{
    class Program
   {
    static void Main(string[] args)
    {
        Menu();
        
 
    }
    static void Menu(){
        Console.Clear();
        Console.WriteLine("Bem vindo(a) ao Cronômetro (⌐■_■)");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("S = SEGUNDOS");
        Console.WriteLine("M = Minutos");
        Console.WriteLine("0 = sair");
        Console.WriteLine("Quanto tempo deseja contar?");
        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0 , data.Length - 1));
        int multiplier = 1;
        

        if(type == 'm')
        multiplier = 60;

        if (time == 0)
        
        Environment.Exit(0);
        
        
        PreStart(time * multiplier);   }
    
    static void PreStart( int time ){
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("GO!");
        Thread.Sleep(2500);

        Start(time);

    }
    static void Start(int time)
        {
        int currentTime = 0;
        while(currentTime != time)
        {
            Console.Clear();
           currentTime++;
           Console.WriteLine(currentTime);
           Thread.Sleep(1000);
               
         }
         Console.Clear();
         Console.WriteLine("Crônometro finalizado");
         Thread.Sleep(2500);
         Final();
         
    }
    static void Final(){
        Console.WriteLine("Você deseja realizar um novo cronômetro? Se sim = S, Se não = N");
       char resp = char.Parse(Console.ReadLine().ToLower());

        switch(resp){
            case 's':
            
        Console.WriteLine("É pra já!! Iniciando outro cronômetro.");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
        break;

        case 'n':
        Console.WriteLine("Muito obrigado por participar! \n Fechando o sistema...");
        Thread.Sleep(1000);

        Environment.Exit(0);
        break;

        }
        

        

    }
  }
}

