using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterface
{
   public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Endereço: {Endereco}";
        }
        
        public Motorista()
        {



        }
    }
}
