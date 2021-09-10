using System;

namespace projetos
{
    class program
    {
        static void Main(string[] args)
        {
		int total = 0,nulos = 0,branco = 0,c1=0,c2 = 0,c3 = 0 ,c4 = 0,voto,soma=0 ;
		double perc;
		do{
			System.Console.WriteLine("em quem deseja votar? [5 nulo, 6 branco]: ");
			System.Console.WriteLine("digite [-2] para parar");
			voto = int.Parse(Console.ReadLine());
			
			if(voto == 1)
			{
				c1++;
				total++;
			}
			if(voto == 2)
			{
				c2++;
				total++;
			}
			if(voto == 3)
			{
				c3++;
				total++;
			}
			if(voto == 4)
			{
				c4++;
				total++;
			}
			if(voto == 5)
			{
				nulos++;
				total++;
			}
			if(voto == 6)
			{
				branco++;
				total++;
			}

		}while(voto != -2);
		soma = branco + nulos;
		perc = (soma*100)/total;
		System.Console.WriteLine("o total de votos para o c1 foi de: "+c1);
		System.Console.WriteLine("o total de votos para o c2 foi de: "+c2);
		System.Console.WriteLine("o total de votos para o c3 foi de: "+c3);
		System.Console.WriteLine("o total de votos para o c4 foi de: "+c4);
		System.Console.WriteLine("o total de votos em branco foi foi de: "+branco);
		System.Console.WriteLine("o total de votos nulos foi de: "+nulos);
		System.Console.WriteLine("o total de branco e nulos foi de "+perc+"%");

	
		

	

		}
	}
}
        
     