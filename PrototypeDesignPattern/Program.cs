using System;
using System.Runtime.InteropServices;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new Carro {Ano = "2001", Marca = "Fiat", Modelo = "Uno"};

            var carro2 = carro1;
            var carro3 = carro1.ShallowCopy();
            var carro4 = carro1.DeepCopy();

            Console.WriteLine($"{carro1.Modelo} | {carro1.Marca} | {carro1.Ano}");

            carro2.Ano = "2015";
            carro3.Modelo = "GOL";

            Console.WriteLine($"{carro1.Modelo} | {carro1.Marca} | {carro1.Ano}");

            Console.WriteLine("------");
        }


    }
}
