namespace E01_EventImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs @event);

    public class Dispatcher
    {
        private string name;

        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        private void OnNameChange(NameChangeEventArgs nameChangeEventArgs)
        {
            if (NameChange != null)
            {
                NameChange(this, nameChangeEventArgs);
            }
        }
    }
}
