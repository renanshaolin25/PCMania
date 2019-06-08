using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMania
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Renan Ribeiro";
            cliente.cpf = 093838382378787;

            //Computador 1
            Computador computador1 = new Computador();
            computador1.marca = "Dell";
            computador1.preco = 2000;
            computador1.so.nome = "Ubuntu 16";
            computador1.so.tipo = 1;

            //Memoria USB Computador 1
            MemoriaUSB memoria = new MemoriaUSB();
            memoria.nome = "Micro SD Ultra";
            memoria.capacidade = 32;

            //Hardwares Computador 1
            HardwareBasico hardwareBasico1 = new HardwareBasico();
            hardwareBasico1.nome = "HD Sansung";
            hardwareBasico1.capacidade = 500;

            HardwareBasico hardwareBasico2 = new HardwareBasico();
            hardwareBasico2.nome = "Placa de Video GForce";
            hardwareBasico2.capacidade = 1000;

            //Computador 2
            Computador computador2 = new Computador();
            computador2.marca = "HP";
            computador2.preco = 3500;
            computador2.so.nome = "Windows 10";
            computador2.so.tipo = 2;

            //Hardwares Computador 2
            HardwareBasico hardwareBasico3 = new HardwareBasico();
            hardwareBasico3.nome = "HD Sansung";
            hardwareBasico3.capacidade = 2000;

            HardwareBasico hardwareBasico4 = new HardwareBasico();
            hardwareBasico4.nome = "Placa de Video NVidia";
            hardwareBasico4.capacidade = 3000;

            //Relacionando entidades
            computador1.addMemoriaUSB(memoria);
            computador1.hardwares.Add(hardwareBasico1);
            computador1.hardwares.Add(hardwareBasico2);

            computador2.hardwares.Add(hardwareBasico3);
            computador2.hardwares.Add(hardwareBasico4);
            cliente.computadores = new List<Computador>();
            cliente.computadores.Add(computador1);
            cliente.computadores.Add(computador2);

            //Exibindo informações
            foreach(Computador computador in cliente.computadores)
            {
                computador.mostraPCConfigs();
                Console.WriteLine("");
            }
            Console.WriteLine("O valor da compra é: " + cliente.calculaTotalCompra());
            Console.Read();
        }
    }
}
