using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino
{
    class Function
    {
        public string Set_led_control(int value)
        {
            string mode="NULL";

            switch (value)
            {
                case -1:
                    break;
                case 0:
                    mode = "H"; //LED ON
                    break;
                case 1:
                    mode = "L"; //LED OFF
                    break;
                case 2:
                    mode = "T"; //lflick x
                    break;
                case 3:
                    mode = "M"; //hello world
                    break;
                case 4:
                    mode = "C"; //温度
                    break;
                default:
                    break;
            }
            return mode;
        }
    }
}
