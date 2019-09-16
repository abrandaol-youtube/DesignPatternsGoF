using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Domain
{
    using ValueObject;

    public class Borda
    {
        public BordaType BordaType  { get; set; }
        public BordaSize BordaSize { get; set; }
    }
}
