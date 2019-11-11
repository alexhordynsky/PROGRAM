using System;

namespace FOOTBALL_TEAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            var defense = new Team();
            defense.Defence();
            var backup = new Team();
            backup.Backup();
            var attack = new Team();
            attack.Attack();
        }
    }
}
