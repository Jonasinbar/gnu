using System;
namespace B18_Ex03
{

    //object Vehicle
    public class Vehicle
    {
        public string m_modelName { get; set; }
        public string m_licenceNumber { get; set; }
        public float m_remainingEnergyPercentage { get; set; }
        public Wheel wheel;

        public Vehicle()
        {

        }
        //constructor
        public Vehicle(String i_modelName, string i_licenceNumber, float i_remainingEnergyPercentage, Wheel i_wheel)
        {
            this.m_modelName = i_modelName;
            this.m_licenceNumber = i_licenceNumber;
            this.m_remainingEnergyPercentage = i_remainingEnergyPercentage;
            this.wheel = i_wheel;
        }
    }

    public class Wheel
    {
        public string m_manufacturerName { get; set; }
        public float m_currentAirPressure { get; set; }
        public float m_maxAirPrRecomended { get; set; }


        public Wheel(string i_manufacturerName, float i_currentAirPressure, float i_maxAirPrRecomended)
        {
            this.m_manufacturerName = i_manufacturerName;
            this.m_currentAirPressure = i_currentAirPressure;
            this.m_maxAirPrRecomended = i_maxAirPrRecomended;

        }
        public void InflateAction(float i_airToAdd)
        {
            if (m_currentAirPressure + i_airToAdd <= m_maxAirPrRecomended)
            {
                this.m_currentAirPressure += i_airToAdd;
            }
            else
            {
                throw new ArgumentException("More air than the mawinum possible");
            }
        }
    }

    public class Motorcycle : Vehicle
    {
        public enum m_LicenceType { A, A1, B1, B2 };
        public int m_engineVolume { get; set; }

    }
    public class Car : Vehicle
    {
        public enum m_color { Gray, Blue, White, Black };
        public int m_numberOfDoors;
        public int m_NumberOfDoors
        {
            get
            {
                return m_numberOfDoors;
            }
            set
            {
                if (value == 2 || value == 3 || value == 4 || value == 5)
                {
                    m_numberOfDoors = value;
                }
                else throw new ArgumentException("Only 2,3,4,5 doors");
            }
        }
    }
    public class Truck : Vehicle
    {
        public bool isCooled;
        public float volumeOfCargo;
    }
    public class FuelBased : Vehicle
    {
        public enum m_fuelType { Soler, Octane95, Octane96, Octane98 }
        public float m_fuelInLiters;
        public float m_maxFuelInLiters;

        public void Refueling(float i_fuelToAdd)
        {
            if(m_maxFuelInLiters <= m_fuelInLiters+i_fuelToAdd){
                this.m_fuelInLiters += i_fuelToAdd;
            }
            else{
                throw new ArgumentException("Cannot add this amount, more than max");
            }
        }
    }
    public class ElectricBased : Vehicle{
        public float m_remainingTimeOfEngineOp;
        public float m_maxTimeOfEngineOp;

        public void Recharge(float i_hoursToAdd){
            if(m_maxTimeOfEngineOp<= m_remainingTimeOfEngineOp + i_hoursToAdd){
                m_remainingTimeOfEngineOp += i_hoursToAdd;
            }
            else{
                throw new ArgumentException("Cannot add this amount, too big");
            }
        }
    }
}


