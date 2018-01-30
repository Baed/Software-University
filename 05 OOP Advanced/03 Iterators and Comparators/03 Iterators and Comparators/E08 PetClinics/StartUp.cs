namespace E08_PetClinics
{
    using E08_PetClinics.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        private static Dictionary<string, Pet> allPets = new Dictionary<string, Pet>();
        private static Dictionary<string, Clinic> allClinics = new Dictionary<string, Clinic>();

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string commandType = commandTokens[0];
                commandTokens.RemoveAt(0);

                switch (commandType)
                {
                    case "Create":
                        CreateEntity(commandTokens); // all input, without first(0);
                        break;
                    case "Add":
                        AddPetToClinic(commandTokens[0], commandTokens[1]); // using class clining and build a class RoomsRegister
                        break;
                    case "Release":
                        ReleasePetFromClinic(commandTokens[0]);
                        break;
                    case "HasEmptyRooms":
                        CheckForEmptyRooms(commandTokens[0]);
                        break;
                    case "Print":
                        PrintInfo(commandTokens);
                        break;
                }
            }
        }

        private static void PrintInfo(List<string> commandTokens)
        {
            Clinic currentClinic = allClinics[commandTokens[0]];

            string result = null;

            if (commandTokens.Count == 1)
            {
                result = currentClinic.Print();
            }
            else
            {
                int roomIndex = int.Parse(commandTokens[1]) - 1;

                result = currentClinic.Print(roomIndex);
            }

            Console.WriteLine(result);
        }

        private static void CheckForEmptyRooms(string clinicName)
        {
            Clinic currentClinic = allClinics[clinicName];

            Console.WriteLine(currentClinic.HasEmptyRooms()); //output: true or false
        }

        private static void ReleasePetFromClinic(string clinicName)
        {
            Clinic currentClinic = allClinics[clinicName];

            Console.WriteLine(currentClinic.TryReleasePet());
        }

        private static void AddPetToClinic(string petName, string clinicName)
        {
            Pet currentPet = allPets[petName];
            Clinic currentClinic = allClinics[clinicName];

            bool success = currentClinic.TryAddPet(currentPet); // create metod in Clinic class to adding an pets
            if (success)
            {
                Console.WriteLine(true);
                allPets.Remove(petName);
                return;
            }

            Console.WriteLine(false);
        }

        private static void CreateEntity(List<string> commandTokens)
        {
            string entityType = commandTokens[0];

            if (entityType == "Pet")
            {
                string name = commandTokens[1];
                int age = int.Parse(commandTokens[2]);
                string kind = commandTokens[3];

                allPets.Add(name, new Pet(name, age, kind));
            }
            else if (entityType == "Clinic")
            {
                string name = commandTokens[1];
                int roomsNumber = int.Parse(commandTokens[2]);

                try
                {
                    allClinics.Add(name, new Clinic(name, roomsNumber));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
