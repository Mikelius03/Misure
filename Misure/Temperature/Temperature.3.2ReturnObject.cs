namespace Misure
{
    /**
     * \class Temperature 
     * \brief Classe che regola la conversione di temperature
     */
    public partial class Temperature : IMisure
    {
        /// <summary>
        /// Converte l'instanza in gradi Kelvin
        /// </summary>
        /// <returns>Nuova Instanza in gradi "Simb"</returns>
        public object ObjectFromMisure(string Simb)
        {
            switch (Simb)
            {
                case "k":
                    return new Temperature("k", _value);

                case "C":
                    return new Temperature("C", _value - 273.15);

                case "F":
                    return new Temperature("F", _value * (9.0 / 5.0) - 459.67);

                case "R":
                    return new Temperature("R", _value * (9.0 / 5.0));

                case "De":
                    return new Temperature("De", (373.15 - _value) * (3.0 / 2.0));

                case "N":
                    return new Temperature("N", (_value - 273.15) * (33.0 / 100.0));

                case "r":
                    return new Temperature("r", (_value - 273.15) * (4.0 / 5.0));

                case "Rø":
                    return new Temperature("Rø", (_value - 273.15) * (21.0 / 40.0) + 7.5);

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
                    return new Temperature("K", _value);

                case "C":
                    return new Temperature("K", _value + 273.15);

                case "F":
                    return new Temperature("K", (_value + 459.67) * (5.0 / 9.0));

                case "R":
                    return new Temperature("K", _value * (5.0 / 9.0));

                case "De":
                    return new Temperature("K", 373.15 - (_value * (2.0 / 3.0)));

                case "N":
                    return new Temperature("K", _value * (100.0 / 33.0) + 273.15);

                case "r":
                    return new Temperature("K", (_value * (5.0 / 4.0)) + 273.15);

                case "Rø":
                    return new Temperature("K", ((_value - 7.5) * (40.0 / 21.0)) + 273.15);

                default:
                    return new Temperature("K", AbsValueTemp[0]);
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

        /// <summary>
        /// Converte un oggetto Temperature nella scala termometrica scelta
        /// </summary>
        /// <param name="SimbOut">Simbolo della scala termometrica di Output</param>
        /// <returns></returns>
        public object ObjectMisureToMisure(string SimbOut)
        {
            // Prima Conversione
            // Converte il valore dell'oggetto in gradi Kelvin
            IMisure Temporaneo = (IMisure)ObjectToMisure();

            return Temporaneo.ObjectFromMisure(SimbOut);
        }

        public double ValueMisureToMisure(string SimbOut)
        {
            // Creo una 2° instanza per evitare modicfiche alla 1°

            Temperature temp = new Temperature();
            temp.Value = this.ValueToMisure();
            temp.Value = temp.ValueFromMisure(SimbOut);
            return temp.Value;
        }
    }
}