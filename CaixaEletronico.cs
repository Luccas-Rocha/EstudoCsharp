using System;

namespace projetos
{
    class program
    {
        static void Main(string[] args)
        {
            int saque, saque100,saque50,saque20,saque10,saque5,saque2,saque1,att1,att2,att3,att4,att5,att6,att7,att8;
            
            Console.WriteLine("quantos reais deseja sacar?: ");
            saque = int.Parse(Console.ReadLine());
            saque100 = saque/100;
            att1 = saque % 100;
            att2 = att1;
            saque50 =  att2 / 50;
            att2 = att1 % 50;
            att3 = att2;
            saque20 = att3 / 20;
            att3 = att2 % 20;
            att4 = att3;
            saque10 =  att4 / 10;
            att5 = att4 % 10;
            saque5 =  att5 / 5;
            att6 = att5 % 5;
            saque2 =  att6 / 2;
            att7 = att6 % 2;
            saque1 = att7 / 1;
            att8 = att7 % 1;
            Console.WriteLine(saque100+" nota(s) de $100 foram utilizadas ");
            Console.WriteLine(saque50+" nota(s)de $50 foram utilizadas ");
            Console.WriteLine(saque20+" nota(s) de $20 foram utilizadas ");
            Console.WriteLine(saque10+" nota(s) de $10 foram utilizadas ");
            Console.WriteLine(saque5+" nota(s) de $5 foram utilizadas ");
            Console.WriteLine(saque2+" nota(s) de $2 foram utilizadas ");
            Console.WriteLine(saque1+" nota(s) de $1 foram utilizadas ");    
        }
    }   
}