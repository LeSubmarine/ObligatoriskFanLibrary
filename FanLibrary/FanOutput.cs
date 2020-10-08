using System;

namespace FanLibrary
{
    public class FanOutput
    {
        private string _name = "";
        private double _temperature;
        private double _humidity; 

        /// <summary>
        /// Class FanOutput is for keeping track of a given fan.
        /// </summary>
        /// <param name="id">
        ///     id is the given id of the fan.
        /// </param>
        /// <param name="name">
        ///     name is the given name of the fan.
        ///     The name parameter must be a string of at least to characters.
        /// </param>
        /// <param name="temperature">
        ///     temperature is the current temperature of the fan.
        ///     The temperature parameter is given in celsius, and must greater or equal than 15 and less or equal to 25.
        /// </param>
        /// <param name="humidity">
        ///     humidity is the current humidity of the fan.
        ///     The humidity parameter is given in relative humidity, and must greater or equal than 30 and less or equal to 80.
        /// </param>
        public FanOutput(int id, string name, double temperature, double humidity)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            Humidity = humidity;
        }
        /// <summary>
        ///     Empty Contructor for json use etc.
        /// </summary>
        public FanOutput()
        {
            
        }
        /// <summary>
        ///     Id is the given id of the fan.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Name is the given name of the fan.
        ///     The Name property must be a string of at least to characters.
        /// </summary>
        public string Name
        {
            get { if (_name.Length >= 2) { return _name; } else { throw new FormatException("The Name property is not initialized"); } }
            set { if(value.Length >= 2){_name = value;} else {throw new FormatException($"The value {value} is not a valid value for the Name property.\nThe Name property must be a string of at least to characters.");} }
        }
        /// <summary>
        ///     Temperature is the current temperature of the fan.
        ///     The Temperature property is given in celsius, and must greater or equal than 15 and less or equal to 25.   
        /// </summary>
        public double Temperature
        {
            get { if (_temperature >= 15 && _temperature <= 25) {return _temperature;} else{ throw new FormatException("The Temperature property is not initialized");} }
            set { if (value >= 15 && value <= 25) { _temperature = value; } else { throw new FormatException($"The value {value} is not a valid value for the Temperature property.\nThe Temperature property is given in celsius, and must greater or equal than 15 and less or equal to 25."); } }
        }

        /// <summary>
        ///     Humidity is the current humidity of the fan.
        ///     The Humidity property is given in relative humidity, and must greater or equal than 30 and less or equal to 80.
        /// </summary>
        public double Humidity
        {
            get { if (_humidity >= 30 && _humidity <= 80) { return _humidity; } else { throw new FormatException("The Humidity property is not initialized"); } }
            set { if (value >= 30 && value <= 80) { _humidity = value; } else { throw new FormatException($"The value {value} is not a valid value for the Humidity property.\nThe Humidity property is given in relative humidity, and must greater or equal than 30 and less or equal to 80."); } }
        }
    }
}
