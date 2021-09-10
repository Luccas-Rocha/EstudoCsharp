using System;

namespace projetos
{
    class program
    {
        static void Main(string[] args)
        {
        
        string escolha;
        double quantia, gasosaprec, alcoolprec, calculo;
        System.Console.WriteLine("Alcool ou Gasolina? [A/G]: ");
        escolha = Console.ReadLine();
        System.Console.WriteLine("Quantos litros?: ");
        quantia = double.Parse(Console.ReadLine());
        gasosaprec = 2.70;
        alcoolprec = 1.90;
        
        if(escolha == "A")
        {
            if(quantia <= 25)
            {  
                calculo = (alcoolprec* 0.98) * quantia;
                System.Console.WriteLine("deu exatos $"+calculo);
            }
            if(quantia > 25)
            {
                calculo = (alcoolprec * 0.96) * quantia;
                System.Console.WriteLine("deu exatos $"+Math.Round(calculo));
            }
        }
        if(escolha == "G")
        {
            if(quantia <= 25)
            {  
                calculo = (gasosaprec* 0.97) * quantia;
                System.Console.WriteLine("deu exatos $"+Math.Round(calculo));
            }
            if(quantia > 25)
            {
                calculo = (gasosaprec * 0.95) * quantia;
                System.Console.WriteLine("deu exatos $"+calculo);
            }
        }
    
    
        }


    }
}


