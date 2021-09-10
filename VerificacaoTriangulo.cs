using System;

namespace projetos
{
    class program
    {
        static void Main(string[] args)
        {
        
         int a, b, c;
         System.Console.WriteLine("digite um lado do triangulo: ");
         a = int.Parse(Console.ReadLine());
         System.Console.WriteLine("digite um lado do triangulo: ");
         b = int.Parse(Console.ReadLine());
         System.Console.WriteLine("digite um lado do triangulo: ");
         c = int.Parse(Console.ReadLine());
         if(a < b+c && b < c+a && c < b+a)
         {
             System.Console.WriteLine("você tem um triangulo");
         }
         else
         {
             System.Console.WriteLine("você não pode formar um triangulo");
             if(a == b && b == c && c == a)
             {
             System.Console.WriteLine("equilatero ainda por cima!");
             }
             if(a == b && a != c && b ==c)
             {
                 System.Console.WriteLine("isósceles ainda por cima! ");
             }
             if(a != b && a != c && b != c)
             {
                 System.Console.WriteLine("escaleno ainda por cima! ");
             }
         }


         
        }


    }
}


