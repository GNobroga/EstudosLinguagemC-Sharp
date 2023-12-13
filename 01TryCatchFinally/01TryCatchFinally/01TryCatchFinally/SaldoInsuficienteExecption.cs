using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _01TryCatchFinally
{
    public class SaldoInsuficienteExecption : Exception
    {
        public SaldoInsuficienteExecption(){}

        public SaldoInsuficienteExecption(string? message) : base(message)
        {}

        public SaldoInsuficienteExecption(string? message, Exception? innerException) : base(message, innerException)
        {}
    }
}
