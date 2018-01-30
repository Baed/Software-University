namespace E09_Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TrafficLight
    {
        private Lights colorState;

        public TrafficLight(Lights colorState)
        {
            this.colorState = colorState;
        }

        public void ChangeState()
        {
            this.colorState = (Lights)(((int)this.colorState + 1) % Enum.GetNames(typeof(Lights)).Length);
        }

        public override string ToString()
        {
            return this.colorState.ToString();
        }
    }
}
