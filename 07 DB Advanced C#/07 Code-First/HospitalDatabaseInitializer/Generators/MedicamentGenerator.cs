namespace HospitalDatabase.Initializer
{
    //using System.IO;

    using E01HospitalDB.Data;
    using E01HospitalDB.Data.Models;

    class MedicamentGenerator
    {
        internal static void InitialMedicamentSeed(HospitalDbContext context)
        {
            var medicamentNames = new string[]
            {
                "Biseptol",
                "Ciclobenzaprina",
                "Curam",
                "Diclofenaco",
                "Disflatyl",
                "Duvadilan",
                "Efedrin",
                "Flanax",
                "Fluimucil",
                "Navidoxine",
                "Nistatin",
                "Olfen",
                "Pentrexyl",
                "Primolut Nor",
                "Primperan",
                "Propoven",
                "Reglin",
                "Terramicina Oftalmica",
                "Ultran",
                "Viartril-S",
            };
            //var medicamentNames = File.ReadAllLines("<INSERT DIR HERE>");

            for (int i = 0; i < medicamentNames.Length; i++)
            {
                context.Medicaments.Add(new Medicament() { Name = medicamentNames[i] });
            }

            context.SaveChanges();
        }

        public static void Generate(string medicamentName, HospitalDbContext context)
        {
            context.Medicaments.Add(new Medicament() { Name = medicamentName });
        }
    }
}
