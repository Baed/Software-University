namespace E05_ingsGambitExtended.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Footman : Soldier
    {
        private const int FootmanHits = 2;

        public Footman(string name) 
            : base(name, FootmanHits)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
