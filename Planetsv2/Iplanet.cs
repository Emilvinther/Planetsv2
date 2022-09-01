using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetsv2
{
    internal interface Iplanet
    {
        // Interface properties
        public string Planetname
        {
            get; set; 
        }

        public double Mass
        {
            get; set;
        }

        public int Diameter
        {
            get; set;
        }

        public int Density
        {
            get; set;
        }

        public double Gravity
        {
            get; set;
        }

        public double Rotationperiod
        {
            get; set;
        }

        public double Lengthofdays
        {
            get; set;
        }

        public double Distancefromsun
        {
            get; set;
        }

        public double Obitalperiod
        {
            get; set;
        }

        public double Obitalvelocity
        {
            get; set;
        }

        public int Temperature
        {
            get; set;
        }

        public int Numberofmoons
        {
            get; set;
        }

        public bool Ringsystem
        {
            get; set;
        }

        // interface methods
        bool MeanTemp();

        bool PlanetDiameter();
        
    }
}
