using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    public sealed class Nota
    {
        public string Nome { get; }
        public decimal Frequencia { get; }
        public string Info => $"{Nome} - {Frequencia:n2} Hz";

        public Nota(string nome, decimal frequencia)
        {
            Nome = nome;
            Frequencia = frequencia;
        }


    }
}
