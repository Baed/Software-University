using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Oldest_Family_Member.Models
{
    public class Family
    {
        private IList<Person> _family; 

        public Family()
        {
            this._family = new List<Person>();
        }

        public IList<Person> FamilyList
        {
            get
            {
                return this._family;
            }
            protected set
            {
                this._family = value;
            }
        }

        public void AddMember(Person person)
        {
            this.FamilyList.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.FamilyList.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
