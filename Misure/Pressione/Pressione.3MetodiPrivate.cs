using System;

namespace Misure
{
    public partial class Pressione : IMisure
    {
        public bool ValidateValue()
        {
            if (SimbolTemp.Equals("De"))
            {
                if (AbsValueTemp[Array.IndexOf(Simboli, SimbolTemp)] < _value)
                    return false;
                else
                    return true;
            }
            else
            {
                if (AbsValueTemp[Array.IndexOf(Simboli, SimbolTemp)] > _value)
                    return false;

                return true;
            }

        }

        /// <summary>
        /// Converte l'instanza in gradi Kelvin
        /// </summary>
        /// <returns>Nuova Instanza in gradi "Simb"</returns>
        public object ObjectFromMisure(string Simb)
        {
            switch (Simb)
            {
                case "k":
                    return new Pressione("k", _value);

                case "C":
                    return new Pressione("C", _value - 273.15);

                case "F":
                    return new Pressione("F", _value * (9.0 / 5.0) - 459.67);

                case "R":
                    return new Pressione("R", _value * (9.0 / 5.0));

                case "De":
                    return new Pressione("De", (373.15 - _value) * (3.0 / 2.0));

                case "N":
                    return new Pressione("N", (_value - 273.15) * (33.0 / 100.0));

                case "r":
                    return new Pressione("r", (_value - 273.15) * (4.0 / 5.0));

                case "Rø":
                    return new Pressione("Rø", (_value - 273.15) * (21.0 / 40.0) + 7.5);

                default:
                    return this;
            }
        }

        /// <summary>
        /// Converte l'oggetto instanziato in gradi Kelvin
        /// </summary>
        /// <returns>Nuova instanza in gradi Kelvin</returns>
        public object ObjectToMisure()
        {
            switch (SimbolTemp)
            {
                case "k":
                    return new Pressione("K", _value);

                case "C":
                    return new Pressione("K", _value + 273.15);

                case "F":
                    return new Pressione("K", (_value + 459.67) * (5.0 / 9.0));

                case "R":
                    return new Pressione("K", _value * (5.0 / 9.0));

                case "De":
                    return new Pressione("K", 373.15 - (_value * (2.0 / 3.0)));

                case "N":
                    return new Pressione("K", _value * (100.0 / 33.0) + 273.15);

                case "r":
                    return new Pressione("K", (_value * (5.0 / 4.0)) + 273.15);

                case "Rø":
                    return new Pressione("K", ((_value - 7.5) * (40.0 / 21.0)) + 273.15);

                default:
                    return new Pressione("K", AbsValueTemp[0]);
            }
        }


        /// <summary>
        /// Converte l'instanza in gradi Kelvin
        /// </summary>
        /// <returns>Nuova Instanza in gradi "Simb"</returns>
        public double ValueFromMisure(string Simb)
        {
            double ValueConvert;
            switch (Simb)
            {
                case "k":
                    ValueConvert = _value;
                    break;

                case "C":
                    ValueConvert = _value - 273.15;
                    break;

                case "F":
                    ValueConvert = _value * (9.0 / 5.0) - 459.67;
                    break;

                case "R":
                    ValueConvert = _value * (9.0 / 5.0);
                    break;

                case "De":
                    ValueConvert = (373.15 - _value) * (3.0 / 2.0);
                    break;

                case "N":
                    ValueConvert = (_value - 273.15) * (33.0 / 100.0);
                    break;

                case "r":
                    ValueConvert = (_value - 273.15) * (4.0 / 5.0);
                    break;

                case "Rø":
                    ValueConvert = (_value - 273.15) * (21.0 / 40.0) + 7.5;
                    break;

                default:
                    ValueConvert = _value;
                    break;
            }

            return ValueConvert;
        }

        /// <summary>
        /// Converte l'oggetto instanziato in gradi Kelvin
        /// </summary>
        /// <returns>Nuova instanza in gradi Kelvin</returns>
        public double ValueToMisure()
        {
            double ValueConvert;
            switch (SimbolTemp)
            {

                case "k":
                    ValueConvert = _value;
                    break;

                case "C":
                    ValueConvert = _value + 273.15;
                    break;
                case "F":
                    ValueConvert = (_value + 459.67) * (5.0 / 9.0);
                    break;
                case "R":
                    ValueConvert = _value * (5.0 / 9.0);
                    break;
                case "De":
                    ValueConvert = 373.15 - (_value * (2.0 / 3.0));
                    break;
                case "N":
                    ValueConvert = _value * (100.0 / 33.0) + 273.15;
                    break;
                case "r":
                    ValueConvert = (_value * (5.0 / 4.0)) + 273.15;
                    break;
                case "Rø":
                    ValueConvert = ((_value - 7.5) * (40.0 / 21.0)) + 273.15;
                    break;
                default:
                    ValueConvert = AbsValueTemp[0];
                    break;
            }
            return ValueConvert;
        }

    }
}