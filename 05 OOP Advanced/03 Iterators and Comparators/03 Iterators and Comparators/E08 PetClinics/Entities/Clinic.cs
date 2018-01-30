namespace E08_PetClinics.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Clinic
    {
        private int roomsNumber;
        private RoomsRegister roomsRegister;
        private int occupiedRooms;

        public Clinic(string name, int roomsNumber)
        {
            this.Name = name;
            this.RoomsNumber = roomsNumber;
            this.roomsRegister = new RoomsRegister(roomsNumber);
            this.occupiedRooms = 0;
        }

        public string Name { get; private set; }

        public int RoomsNumber
        {
            get { return this.roomsNumber; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"Invalid Operation!");
                }

                this.roomsNumber = value;
            }
        }

        public bool TryAddPet(Pet currentPet)
        {
            foreach (var roomIndex in this.roomsRegister) // for every room we registered a pet
            {
                if (this.roomsRegister[roomIndex] == null)
                {
                    this.roomsRegister[roomIndex] = currentPet; // using with helping a indexator

                    this.occupiedRooms++; // using for case HasEmptyRooms

                    return true;
                }
            }

            return false;
        }

        public bool TryReleasePet()
        {
            int centralRoomIndex = this.roomsNumber / 2;

            for (int i = 0; i < this.roomsNumber; i++)
            {
                int currentIndex = (centralRoomIndex + i) % this.roomsNumber;

                if (this.roomsRegister[currentIndex] != null)
                {
                    this.roomsRegister[currentIndex] = null;

                    this.occupiedRooms--;

                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.occupiedRooms < this.RoomsNumber;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.RoomsNumber; i++)
            {
                sb.AppendLine(this.Print(i));
            }

            return sb.ToString().TrimEnd();
        }

        public string Print(int roomIndex)
        {
            return this.roomsRegister[roomIndex]?.ToString() ?? "Room empty"; // !!!
        }
    }
}
