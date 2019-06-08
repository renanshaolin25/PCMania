using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMania
{
    class Computador
    {
        public String marca { get; set; }
        public float preco { get; set; }
        public MemoriaUSB memoriaUSB { get; set; }
        public SistemaOperacional so { get; set; }
        public List<HardwareBasico> hardwares { get; set; }
        public Computador ()
        {
            this.so = new SistemaOperacional();
            this.hardwares = new List<HardwareBasico>();
        }
        public void mostraPCConfigs()
        {
            int countHW = 1;
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Sistema Operacional: " + so.nome);
            Console.WriteLine("Tipo de Sistema: " + so.tipo);
            foreach(HardwareBasico hw in hardwares)
            {
                Console.WriteLine("Nome do Hardware " + countHW + ": " + hw.nome);
                Console.WriteLine("Capacidade do Hardware " + countHW + ": " + hw.capacidade);
                countHW++;
            }
            if(memoriaUSB != null)
            {
                Console.WriteLine("Nome da memoria: " + memoriaUSB.nome);
                Console.WriteLine("Capacidade da memoria: " + memoriaUSB.capacidade);
            }
            
        }
        public void addMemoriaUSB(MemoriaUSB memoria)
        {
            memoriaUSB = memoria;
        }
    }
}
