namespace E03___05_BarracksWars.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Attributes;

    public class RetireCommand : Command
    {
        [Inject]
        IRepository repository;

        public RetireCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            this.repository.RemoveUnit(Data[1]);
            return $"{this.Data[1]} retired!";
        }
    }
}
