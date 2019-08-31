using System;


namespace EstudoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //tente executar a divisao
            try { 
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;
            Console.WriteLine(result);
            }//se a divisao for por zero mostrar a mensagem abaixo
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Nao pode ser dividido por zero");
            }//se a pessoa digitar uma letra mostrar a mensagem abaixo
            catch (FormatException e)
            {
                Console.WriteLine("Nao pode utilizar letras");
            }

            Console.Read();

        }
    }
}
