using System;

namespace UsoDeOperadorImplicito
{
    class Program
    {
        public static void Main()
        {
            Moeda libra = new Moeda { Sinal = "£", Valor = 100 };
            Print(libra);

            Moeda real = 200;
            Print(real);

            Moeda pmoeda = "P$";
            Print(pmoeda);

            Console.ReadKey();
        }

        public static void Print(Moeda m) =>
            Console.WriteLine($"{m.Sinal} {m.Valor}");
    }

    public class Moeda
    {
        public string Sinal { get; set; }
        public decimal Valor { get; set; }

        public static implicit operator Moeda(decimal valor) =>
            new Moeda { Sinal = "R$", Valor = valor };

        public static implicit operator Moeda(string sinal) =>
            new Moeda { Sinal = sinal, Valor = 1 };
    }
}
