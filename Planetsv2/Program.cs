using System;
using System.Collections.Generic;

namespace Planetsv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creation of objects
            Iplanet mercury = new Planet("Mercury",
               0.300,
               4879,
               5427,
               3.7,
               1407.6,
               4222.6,
               57.9,
               88.0,
               47.4,
               167,
               0,
               false
               );

            Iplanet venus = new Planet("Venus",
                4.87,
                12104,
                5243,
                8.9,
                5832.5,
                2802.0,
                108.2,
                224.7,
                35.0,
                464,
                0,
                false
                );

            Iplanet earth = new Planet("Earth",
                5.97,
                12756,
                5514,
                9.8,
                23.9,
                24.0,
                149.6,
                365.2,
                29.8,
                15,
                1,
                false
                );

            Iplanet mars = new Planet("Mars",
                0.642,
                6792,
                3933,
                3.7,
                24.6,
                24.7,
                227.9,
                687.0,
                24.1,
                -65,
                2,
                false
                );

            Iplanet jupiter = new Planet("Jupiter",
                1898,
                142984,
                1326,
                23.1,
                9.9,
                9.9,
                778.6,
                4331,
                13.1,
                -110,
                67,
                true
                );

            Iplanet saturn = new Planet("Saturn",
                568,
                120536,
                687,
                9.0,
                10.7,
                10.7,
                1433.5,
                10747,
                9.7,
                -140,
                62,
                true
                );

            Iplanet uranus = new Planet("Uranus",
                86.8,
                51118,
                1271,
                8.7,
                17.2,
                17.2,
                2872.5,
                30589,
                6.8,
                -195,
                27,
                true
                );

            Iplanet neptune = new Planet("Neptune",
                102,
                49528,
                1638,
                11.0,
                16.1,
                16.1,
                4495.1,
                59.8,
                5.4,
                -200,
                14,
                true
                );

            Iplanet pluto = new Planet("Pluto",
               0.0146,
               2370,
               2095,
               0.7,
               153.3,
               153.3,
               5904.4,
               90.56,
               4.7,
               -225,
               5,
               false
               );

            // List and added opjects to list

            List<Iplanet> planets = new List<Iplanet>();
            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);
            planets.Insert(1, venus);
            planets.Remove(pluto);
            planets.Add(pluto);
            Console.WriteLine(planets.Count);

            // list print

            foreach (Planet i in planets)
            {
                Console.WriteLine(i);
            }


            // list for planets with maintemp < 0 and print
            List<Iplanet> belowzero = new List<Iplanet>();
            foreach (Iplanet i in planets)
            {
                if (i.MeanTemp() == true)
                {
                    belowzero.Add(i);
                    Console.WriteLine(i);
                }
              
            }

            // list for planet diameter withing parameters and print
            List<Iplanet> planetdia = new List<Iplanet>();
            foreach (Iplanet i in planets)
            {
                if (i.PlanetDiameter() == true)
                {
                    planetdia.Add(i);
                    Console.WriteLine(i);
                }
            }

            // list clear
            planets.Clear();
            
            
            



            Console.ReadKey();


        }
    }
}
