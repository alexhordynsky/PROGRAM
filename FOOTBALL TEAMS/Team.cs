using System;
using System.Collections.Generic;
using System.Text;

namespace FOOTBALL_TEAMS
{
    class Team
    {
        public void Defence()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 30 )
            {
                Console.WriteLine("Team has bad defense!");

            }
            else if (a < 80)
            {
                Console.WriteLine("Team have average defence!");
            }
            else if (a > 80)
            {
                Console.WriteLine("Team has great defense!");
            }
        }
        public void Backup()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 30)
            {
                Console.WriteLine("Team has low ball possesion!");

            }
            else if (a < 80)
            {
                Console.WriteLine("Team has average ball possesion!");
            }
            else if (a > 80)
            {
                Console.WriteLine("Team has great ball possesion!");
            }

        }
        public void Attack()
        {
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a <= 30)
                {
                    Console.WriteLine("Team doesn´t score much goals!");

                }
                else if (a < 80)
                {
                    Console.WriteLine("Team scores average goals");
                }
                else if (a > 80)
                {
                    Console.WriteLine("Team scores much goals!");
                }
            }
        }
    }
}
