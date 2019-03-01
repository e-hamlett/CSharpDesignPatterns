using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SpeedMonitor : ISpeedchanged
    {
        public const int SpeedToAlert = 30;

        public SpeedMonitor(Speedometer speed)
        {
            speed.VChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeed = (Speedometer)sender;
            if (mySpeed.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine(" **ALERT** **SLOW IT DOWN BUDDY** (" + mySpeed.CurrentSpeed + ") ");
                Console.WriteLine(" **YA MOVING A LITTLE TOO FAST FOR ME** ");
            }
            else
            {
                Console.WriteLine("Nice and Steady . . . (" + mySpeed.CurrentSpeed + ") ");
            }

        }
    }
}
