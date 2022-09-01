using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetsv2
{
    internal class Planet:Iplanet
    {
        // valueables
        private string _planetname;
        private double _mass;
        private int _diameter;
        private int _density;
        private double _gravity;
        private double _rotationperiod;
        private double _lengthofdays;
        private double _distancefromsun;
        private double _obitalperiod;
        private double _obitalvelocity;
        private int _temperature;
        private int _numberofmoons;
        private bool _ringsystem = false;

        // interface load properties
        public string Planetname { get => _planetname; set => _planetname = value; }
        public double Mass { get => _mass; set => _mass = value; }
        public int Diameter { get => _diameter; set => _diameter = value; }
        public int Density { get => _density; set => _density = value; }
        public double Gravity { get => _gravity; set => _gravity = value; }
        public double Rotationperiod { get => _rotationperiod; set => _rotationperiod = value; }
        public double Lengthofdays { get => _lengthofdays; set => _lengthofdays = value; }
        public double Distancefromsun { get => _distancefromsun; set => _distancefromsun = value; }
        public double Obitalperiod { get => _obitalperiod; set => _obitalperiod = value; }
        public double Obitalvelocity { get => _obitalvelocity; set => _obitalvelocity = value; }
        public int Temperature { get => _temperature; set => _temperature = value; }
        public int Numberofmoons { get => _numberofmoons; set => _numberofmoons = value; }
        public bool Ringsystem { get => _ringsystem; set => _ringsystem = value; }

        // constructor
        public Planet(string planetname, double mass, int diameter, int density, double gravity, double rotationperiod, double lengthofdays, double distancefromsun, double obitalperiod, double obitalvelocity, int temperature, int numberofmoons, bool ringsystem)
        {
            _planetname = planetname;
            _mass = mass;
            _diameter = diameter;
            _density = density;
            _gravity = gravity;
            _rotationperiod = rotationperiod;
            _lengthofdays = lengthofdays;
            _distancefromsun = distancefromsun;
            _obitalperiod = obitalperiod;
            _obitalvelocity = obitalvelocity;
            _temperature = temperature;
            _numberofmoons = numberofmoons;
            _ringsystem = ringsystem;
        }

        
        // string override
        public override string ToString()
        {
            return $"\nPlanet properties\n\n" +
            $"\nPlanet Name = {Planetname}" +
            $"\nPlanet Mass = {Mass}" +
            $"\nPlanet Diameter = {Diameter}" +
            $"\nPlanet Density = {Density}" +
            $"\nPlanet Gravity = {Gravity}" +
            $"\nPlanet Rotation Period = {Rotationperiod}" +
            $"\nPlanet Day Length = {Lengthofdays}" +
            $"\nPlanet Distance from sun = {Distancefromsun}" +
            $"\nPlanet Obital Period = {Obitalperiod}" +
            $"\nPlanet Obital Velocity = {Obitalvelocity}" +
            $"\nPlanets Medi Temperature = {Temperature}" +
            $"\nNumber of moons orbiting the planet {Numberofmoons}" +
            $"\nDoes it have a ringsystem: {(Ringsystem == true ? "Yes" : "No")}";
        }

        // interface methods applications
        public bool MeanTemp()
        {
            if (Temperature < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PlanetDiameter()
        {
            if (Diameter > 10000 && Diameter < 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
