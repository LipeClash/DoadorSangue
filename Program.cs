using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeDoadorSangue;

            Console.WriteLine("Avalie se ele pode ser doador de sangue (i.e. possui idade entre 18 e 67 anos). Informe o resultado da avaliação.\n");

            Console.Write("Qual a sua idade: ");
            idadeDoadorSangue = Convert.ToInt32(Console.ReadLine());

            if (idadeDoadorSangue > 18)
            {
                
            }
            else 
            {
                Console.WriteLine("Você não pode ser doador de sangue.");
                Environment.Exit(-1);
            }
            Console.WriteLine("Você pode ser doador de sangue.");
        
        }
    }
}