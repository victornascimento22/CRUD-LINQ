using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterface
{
    public class Caminhao 
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public override string ToString()
        {
            return $"Descrição: {Id}, Marca: {Modelo}, Valor: {Placa}";
        }

        

      

    }
}
