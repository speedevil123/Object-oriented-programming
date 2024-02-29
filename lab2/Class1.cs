using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Class1
    {
        class Room
        {

            float footage;
            float ceilingHeight;
            int windowsAmount;

            public Room()
            {
                footage = 0f;
                ceilingHeight = 0f;
                windowsAmount = 0;
            }

            public Room(float footage, float ceilingHeight, int windowsAmount)
            {
                if( footage < 0f || ceilingHeight < 0f || windowsAmount < 0 )
                {
                    throw new ArgumentException("Значение должно быть неотрицательным");
                }
                this.footage = footage;
                this.ceilingHeight = ceilingHeight;
                this.windowsAmount = windowsAmount;


            }

            public float footageProperty
            {
                set
                {
                    if (value < 0f)
                        throw new ArgumentException("Значение должно быть неотрицательным");
                    else
                        footage = value;
                }
                get { return footage; }
            }
            public float ceilingHeightProperty
            {
                set
                {
                    if (value < 0f)
                        throw new ArgumentException("Значение должно быть неотрицательным");
                    else
                        ceilingHeight = value;
                }
                get { return ceilingHeight; }
            }

            public int windowsAmountProperty
            {
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Значение должно быть неотрицательным");
                    else
                        windowsAmount = value;
                }
                get { return windowsAmount; }
            }

            public float CalculateArea()
            {
                return footage;
            }

            public float CalculateVolume()
            {
                return footage * ceilingHeight;
            }

        }



        static void Main()
        {
            Room room1 = new Room(15,2.5f, 2);
            
            Console.WriteLine("Area: " + room1.CalculateArea() + " m." + " Volume: " + room1.CalculateVolume());

        }
    }
}
