using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMania
{
    class Cliente
    {
        public String nome { get; set; }
        public long cpf { get; set; }
        public List<Computador> computadores { get; set; }

        public float calculaTotalCompra()
        {
            float valor = 0;
            foreach(Computador pc in computadores)
            {
                valor = valor + pc.preco;
            }
            return valor;
        }
    }
}
