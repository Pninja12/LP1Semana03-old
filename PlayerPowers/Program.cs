using System;

namespace PlayerPowers
{
    class Program
    {
        [Flags]
            enum Power
            {
                Fly = 1 << 0 , // 1
                XRayVision = 1 << 1 , // 2
                SuperStrength = 1 << 2, // 4
            }
        static void Main(string[] args)
        {
            Power mypower;
            
            Console.Write("Quantos jogadores são: ");
            string str = Console.ReadLine();
            Console.WriteLine("");
            
            int njogadores = int.Parse(str);
            Power [] jogadores = new Power[njogadores];

            for(int i = 0; i < njogadores; i++)
            {
                Console.WriteLine("Lista de poderes:\nFly = 'f'\nXRayVision = 'x'\nSuperStrength = 's'");
                Console.Write($"Que poderes tem o jogador {i+1}: ");
                string answer = Console.ReadLine();    
                
                mypower = 0;

                foreach(char s in answer)//carácter por carácter da lista de "answer"
                {
                    if (s == 'f')
                    {
                        mypower ^= Power.Fly;
                    }
                    else if (s == 'x')
                    {
                        mypower ^= Power.XRayVision;
                    }
                    else if (s == 's')
                    {
                        mypower ^= Power.SuperStrength;
                    }
                }

                jogadores[i] = mypower;
                Console.WriteLine("");
            }

            for(int i = 0; i < jogadores.Length; i++)
            {
                Console.Write($"O {i+1}º jogador tem os poderes {jogadores[i]}");

                if((jogadores[i] & Power.SuperStrength) == Power.SuperStrength && (jogadores[i] & Power.Fly) == Power.Fly)
                {
                    Console.WriteLine(", Flying Radiation!");
                }
                else
                {
                    Console.WriteLine("!");
                }

                Console.WriteLine("");
            }



        }
    }
}
