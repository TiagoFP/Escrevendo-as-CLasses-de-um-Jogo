using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseJogo.models
{
    public class Hero
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public int opcao { get; set; }

        public void atacar()
        {

            switch (opcao)
            {
                case 1:

                    string tipo = "Mago";
                    string ataque = "magia";
                    Console.WriteLine($"O {tipo} atacou usando {ataque}");
                    break;

                case 2:
                    tipo = "Guerreiro";
                    ataque = "espada";
                    Console.WriteLine($"O {tipo} atacou usando {ataque}");
                    break;

                case 3:
                    tipo = "Monge";
                    ataque = "artes marciais";
                    Console.WriteLine($"O {tipo} atacou usando {ataque}");
                    break;

                case 4:
                    tipo = "Ninja";
                    ataque = "shuriken";
                    Console.WriteLine($"O {tipo} atacou usando {ataque}");
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    break;
            } 
            Console.WriteLine("O sistema encerrará, pois você não digitou uma opção válida.");
        }
    }
}