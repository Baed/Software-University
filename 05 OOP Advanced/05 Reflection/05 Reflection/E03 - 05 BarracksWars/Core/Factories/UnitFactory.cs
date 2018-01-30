namespace E03___05_BarracksWars.Core.Factories
{
    using E03___05_BarracksWars.Contracts;
    using System;

    public class UnitFactory : IUnitFactory
    {
        private const string unitNamespace = "E03___05_BarracksWars.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            var typeOfUnit = Type.GetType($"{unitNamespace}{unitType}"); // type fullname (incl. namaspace)

            return (IUnit)Activator.CreateInstance(typeOfUnit);
        }
    }
}