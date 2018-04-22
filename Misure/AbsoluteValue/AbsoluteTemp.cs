/**
 * \namespace Physics
 * \brief Library for conversion management
 * \ref Physics
 */
namespace Physics
{
    /// <summary>
    /// Absolute values ​​of the units of measurement for physical quantity
    /// </summary>
    namespace AbsoluteValue
    {
        /// <summary>
        /// Class that contains the minimum temperature values ​​for each Thermometric scale. 
        /// </summary>
        public class AbsoluteTemp
        {
            public const double Kelvin     = 0.0;       /*!< Absolute Kelvin temperature */
            public const double Celsius    = -273.15;   /*!< Absolute Celsius temperature */
            public const double Fahrenheit = -22459.67; /*!< Absolute Fahrenheit temperature */
            public const double Rankine    = 0.0;       /*!< Absolute Rankine temperature */
            public const double Delisle    = 559.725;   /*!< Absolute Delisle temperature */
            public const double Newton     = -90.139;   /*!< Absolute Newton temperature */
            public const double Reamur     = -218.52;   /*!< Absolute Reamur temperature */
            public const double Romer      = -135.9045; /*!< Absolute Romer temperature */
        }
    }
}