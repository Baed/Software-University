namespace E08_PetClinics.Entities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RoomsRegister : IEnumerable<int>
    {
        private readonly IList<Pet> rooms;
        private readonly int centerRoomIndex;

        public RoomsRegister(int roomsNumber)
        {
            this.centerRoomIndex = roomsNumber / 2; // because roomsNumber is always a odd number
            this.rooms = new List<Pet>(new Pet[roomsNumber]); // null with count = roomsNumber

            // for (int i = 0; i < roomsNumber; i++)
            // {
            //     this.rooms.Add(null);
            // }
        }

        public Pet this[int index] // indexator
        {
            get
            {
                return this.rooms[index];
            }
            set
            {
                this.rooms[index] = value;
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            int step = 1;
            yield return this.centerRoomIndex;

            while (step <= this.centerRoomIndex)
            {
                yield return this.centerRoomIndex - step;

                yield return this.centerRoomIndex + step++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
