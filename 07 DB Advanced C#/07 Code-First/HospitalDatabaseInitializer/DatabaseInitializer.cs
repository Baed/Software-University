namespace HospitalDatabase.Initializer
{
    using System;
    //using System.IO;

    using Microsoft.EntityFrameworkCore;

    using E01HospitalDB.Data;
   // using E01HospitalDB.Generators;

    public class DatabaseInitializer
    {
        private static Random rnd = new Random();

        public static void ResetDatabase()
        {
            using (var context = new HospitalDbContext())
            {
                context.Database.EnsureDeleted();

                context.Database.Migrate();

                InitialSeed(context);
            }
        }

        public static void InitialSeed(HospitalDbContext context)
        {
            SeedMedicaments(context);

            SeedPatients(context, 200);

            SeedPrescriptions(context);
        }

        private static void SeedMedicaments(HospitalDbContext context)
        {
            MedicamentGenerator.InitialMedicamentSeed(context);
        }

        public static void SeedPatients(HospitalDbContext context, int count)
        {
            for (int i = 0; i < count; i++)
            {
                context.Patients.Add(PatientGenerator.NewPatient(context));
            }

            context.SaveChanges();
        }

        private static void SeedPrescriptions(HospitalDbContext context)
        {
            PrescriptionGenerator.InitialPrescriptionSeed(context);
        }
    }
}
