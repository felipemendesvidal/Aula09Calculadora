using System;
using static System.Console;
namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\n==========Calculadora SIMPLES===========");
            WriteLine("\n");
            //new object 
                //criando apenas com o media, porque alem de herdar, é nele que esta os metodos que farão os calculos...
            Media calc = new Media();
            Console.WriteLine("Faça um cálculo abaixo \n Utilize: \n + para soma, - para subtração, x para multiplicação e / para divisão");
            //string que sera analisada e particionada
            string calculo = ReadLine();
            calc.ManipularCalculos(calculo);

            //mostrando resultados
            WriteLine("Resultado: "+calc.resultado);
            calc.resultado = 0;

            System.Console.WriteLine("Digite números separados por vírgula:");
            calc.calcMedia( Console.ReadLine() );
            System.Console.WriteLine("Média: "+calc.resultado);



            
        
            

        }
    }
}
