using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public sealed class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }

        public Carro ShallowCopy()
        {
            return (Carro) this.MemberwiseClone();
        }

        public Carro DeepCopy()
        {
            return new Carro
            {
                Ano = string.Copy(this.Ano),
                Marca = string.Copy(this.Marca),
                Modelo = string.Copy(this.Modelo)
            };
        }
    }
}
