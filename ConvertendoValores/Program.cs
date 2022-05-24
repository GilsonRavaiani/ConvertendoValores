using System;

namespace ConvertendoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            int idade = 0;
            double salario = 0;              // 8 Bytes
            float salarioBase = 1000f;      // 4 Bytes **Valor fixo**

            Console.WriteLine("Digite seu nome: ");

            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());                            //converte string para inteiro

            Console.WriteLine("Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());                     //converte string para double


            Console.WriteLine("Seu nome é.....: " + nome);                //imprimindo concatenando com nome
            Console.WriteLine("Sua idade é....:" + idade + " Anos");      //imprimindo concatenando com idade
            Console.WriteLine("Seu salário é..:{0,15:c}",salario);            //imprimindo concatenando com salario
            Console.WriteLine("Salário base é.:{0,15:c}",salarioBase);       //**Colocar em formato moeda*
            Console.ReadLine();

            //Testando atualização github 24/05/2022 19:21
            

        }
    }
}
