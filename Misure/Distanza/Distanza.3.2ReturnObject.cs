
using System;

namespace Misure
{
    namespace Conversioni
    {
        /**
         * \class Distanza 
         * \brief Classe che regola la conversione di Distanza
         */
        public partial class Distanza : IMisure
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
                        return new Distanza("k", _value);

                    case "C":
                        return new Distanza("°C", _value - 273.15);

                    case "F":
                        return new Distanza("°F", _value * (9.0 / 5.0) - 459.67);

                    case "R":
                        return new Distanza("°R", _value * (9.0 / 5.0));

                    case "De":
                        return new Distanza("°De", (373.15 - _value) * (3.0 / 2.0));

                    case "N":
                        return new Distanza("°N", (_value - 273.15) * (33.0 / 100.0));

                    case "r":
                        return new Distanza("°r", (_value - 273.15) * (4.0 / 5.0));

                    case "Rø":
                        return new Distanza("°Rø", (_value - 273.15) * (21.0 / 40.0) + 7.5);

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
                switch (_unitSymbol)
                {
                    case "k":
                        return new Distanza("k", _value);

                    case "°C":
                        return new Distanza("k", _value + 273.15);

                    case "°F":
                        return new Distanza("k", (_value + 459.67) * (5.0 / 9.0));

                    case "°R":
                        return new Distanza("k", _value * (5.0 / 9.0));

                    case "°De":
                        return new Distanza("k", 373.15 - (_value * (2.0 / 3.0)));

                    case "°N":
                        return new Distanza("k", _value * (100.0 / 33.0) + 273.15);

                    case "°r":
                        return new Distanza("k", (_value * (5.0 / 4.0)) + 273.15);

                    case "°Rø":
                        return new Distanza("k", ((_value - 7.5) * (40.0 / 21.0)) + 273.15);

                    default:
                        return new Distanza("k", UnitAbsValue[0]);
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
                        return  _value;
                        break;

                    case "°C":
                        return  _value - 273.15;
                        break;

                    case "°F":
                        return  _value * (9.0 / 5.0) - 459.67;
                        break;

                    case "°R":
                        return  _value * (9.0 / 5.0);
                        break;

                    case "°De":
                        return  (373.15 - _value) * (3.0 / 2.0);
                        break;

                    case "°N":
                        return  (_value - 273.15) * (33.0 / 100.0);
                        break;

                    case "°r":
                        return  (_value - 273.15) * (4.0 / 5.0);
                        break;

                    case "°Rø":
                        return  (_value - 273.15) * (21.0 / 40.0) + 7.5;
                        break;

                    default:
                        return  _value;
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
                switch (_unitSymbol)
                {
                    case "k":
                        return  _value;
                        break;
                    case "°C":
                        return  _value + 273.15;
                        break;
                    case "°F":
                        return  (_value + 459.67) * (5.0 / 9.0);
                        break;
                    case "°R":
                        return  _value * (5.0 / 9.0);
                        break;
                    case "°De":
                        return  373.15 - (_value * (2.0 / 3.0));
                        break;
                    case "°N":
                        return  _value * (100.0 / 33.0) + 273.15;
                        break;
                    case "°r":
                        return  (_value * (5.0 / 4.0)) + 273.15;
                        break;
                    case "°Rø":
                        return  ((_value - 7.5) * (40.0 / 21.0)) + 273.15;
                        break;
                    default:
                        return  UnitAbsValue[0];
                        break;
                }
                return ValueConvert;
            }

            /// <summary>
            /// Converte un oggetto Distanza nella scala termometrica scelta
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
                Distanza temp = new Distanza("k", ValueToMisure());
                this.Unit_Value  = temp.ValueFromMisure(SimbOut) ;
                this.Unit_Symbol = SimbOut;
              
                return Unit_Value;
            }

            public void ImpostaObject(string a,double b)
            {
                if ( VerificaMisure(a) && ValidateValue(a, b) )
                {
                    _value = b;
                    _unitSymbol = a;
                }
                else
                    throw new NotImplementedException("Non e' possibile");
            }
        }
    }
}