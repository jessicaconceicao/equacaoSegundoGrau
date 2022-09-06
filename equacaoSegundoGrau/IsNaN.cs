using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equacaoSegundoGrau
{
    public class IsNaN
    {
        public double valor;

        public string VerifyNaN(double valor)
        {
            if (valor != valor)
            { return "Número não existe"; }
            else
            { return valor.ToString("F"); }
        }
    }
}
