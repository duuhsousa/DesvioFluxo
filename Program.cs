using System;
using System.Text.RegularExpressions;
namespace DesvioFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            Regex rgx = new Regex(@"^[a-zA-Z]{3}[\d]{4}$");
            do
            {
            Console.WriteLine("Verifica placa rodízio");
            Console.Write("Digite sua placa (somente letras e números): ");
            placa = Console.ReadLine();
            }
            while(!rgx.IsMatch(placa));
            int i = placa.Length-1;

            /*if(placa.Substring(i) == "1" || placa.Substring(i) =="2")
            {
                Console.WriteLine("Seu rodízio é Segunda-Feira");
            }
            else if(placa.Substring(i) == "3" || placa.Substring(i) == "4")
            {
                Console.WriteLine("Seu rodízio é Terça-Feira");
            }
            else if(placa.Substring(i) == "5" || placa.Substring(i) == "6")
            {
                Console.WriteLine("Seu rodízio é Quarta-Feira");
            }
            else if(placa.Substring(i) == "7" || placa.Substring(i) == "8")
            {
                Console.WriteLine("Seu rodízio é Quinta-Feira");
            }
            else if(placa.Substring(i) == "9" || placa.Substring(i) == "0")
            {
                Console.WriteLine("Seu rodízio é Sexta-Feira");
            }
            else
                Console.WriteLine("Placa Inválida");
                */
            
            switch(placa.Substring(i))
            {
                case "1":case "2":Console.WriteLine("Segunda-Feira");break;
                case "3":case "4":Console.WriteLine("Terça-Feira");break;
                case "5":case "6":Console.WriteLine("Quarta-Feira");break;
                case "7":case "8":Console.WriteLine("Quinta-Feira");break;
                case "9":case "0":Console.WriteLine("Sexta-Feira");break;
            }
        }
    }
}
