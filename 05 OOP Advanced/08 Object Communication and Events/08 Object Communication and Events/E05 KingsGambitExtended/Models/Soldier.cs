namespace E05_ingsGambitExtended.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void SoldierDeathEventHandler(object sender, SoldierDeathEventArgs args);

    public abstract class Soldier
    {
        public event SoldierDeathEventHandler SoldierDeath;

        public Soldier(string name, int hitsLeft)
        {
            this.Name = name;
            this.HitsLeft = hitsLeft;
        }

        public string Name { get; private set; }

        public int HitsLeft { get; set; }

        public abstract void KingUnderAttack(object sender, EventArgs args);

        public void RespondToAttack()
        {
            this.HitsLeft--;
            if (this.HitsLeft == 0)
            {
                OnSoldierDeath(new SoldierDeathEventArgs(this.Name, KingUnderAttack));
            }
        }

        private void OnSoldierDeath(SoldierDeathEventArgs args)
        {
            if (SoldierDeath != null)
            {
                SoldierDeath(this, args);
            }
        }
    }
}
