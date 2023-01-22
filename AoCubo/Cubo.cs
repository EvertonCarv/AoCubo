using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AoCubo
{
    public interface IOperacaoMatematica
    {
        int Calcular(int numero);
    }

    public abstract class OperacaoMatematica : IOperacaoMatematica
    {
        public int Calcular(int numero) => numero;
    }
    
    public class Cubo : IOperacaoMatematica
    {
       public int Calcular(int numero) => numero * numero * numero;
    }

    public class Quadrado : OperacaoMatematica
    {
    }

    public class ObjectoDeNegocio
    {
        private readonly IOperacaoMatematica _operacaoMatematica1;

        public ObjectoDeNegocio(IOperacaoMatematica operacaoMatematica1)
        {
            _operacaoMatematica1 = operacaoMatematica1;
        }

        public int Calcular(int numero) => _operacaoMatematica1.Calcular(numero);
    }
}
