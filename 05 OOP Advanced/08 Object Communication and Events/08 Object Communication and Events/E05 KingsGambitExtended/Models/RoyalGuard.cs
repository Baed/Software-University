namespace E05_ingsGambitExtended.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RoyalGuard : Soldier
    {
        private const int RoyalGuardHits = 3;

        public RoyalGuard(string name)
            : base(name, RoyalGuardHits)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
