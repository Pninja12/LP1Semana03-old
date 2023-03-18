using System;


namespace PlayerPerks
{
    class Program
    {
        [Flags]
            enum Power
            {
                WaterBreathing = 1 << 0 , // 1
                Stealth = 1 << 1 , // 2
                AutoHeal = 1 << 2, // 4
                DoubleJump = 1 << 3 //8
            }
        static void Main(string[] args)
        {
            Power mypower;
            mypower = 0;

            Console.Write("Say the magic word: ");
            string str = Console.ReadLine();
            int error = 0;


            foreach(char s in str)//carácter por carácter da lista de "str"
            {
                if (s == 'w')
                {
                    mypower ^= Power.WaterBreathing;
                }
                else if (s == 's')
                {
                    mypower ^= Power.Stealth;
                }
                else if (s == 'a')
                {
                    mypower ^= Power.AutoHeal;
                }
                else if (s == 'd')
                {
                    mypower ^= Power.DoubleJump;
                }
                else
                {
                    error = 1;
                }
            }

            if (error == 1)
            {
                Console.WriteLine("Unknown perk!");
            }
            else
            {
                Console.WriteLine(mypower);
                if ((mypower & Power.DoubleJump) == Power.DoubleJump && (mypower & Power.Stealth) == Power.Stealth)
                {
                    Console.WriteLine("Silent jumper!");
                }
                if ((mypower & Power.AutoHeal) != Power.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
        }
    }
}
