namespace Misure
{
    namespace Conversioni
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
            public double ValueFromMisure(string Simb)
            {
                switch (Simb)
                {
                    case "k":
                        return  _value;

                    case "°C":
                        return  _value - 273.15;

                    case "°F":
                        return  _value * (9.0 / 5.0) - 459.67;

                    case "°R":
                        return  _value * (9.0 / 5.0);

                    case "°De":
                        return  (373.15 - _value) * (3.0 / 2.0);
            
                    case "°N":
                        return  (_value - 273.15) * (33.0 / 100.0);
                
                    case "°r":
                        return  (_value - 273.15) * (4.0 / 5.0);
              
                    case "°Rø":
                        return  (_value - 273.15) * (21.0 / 40.0) + 7.5;
           
                    default:
                        return  _value;
                }
            }

            /// <summary>
            /// Converte l'oggetto instanziato in gradi Kelvin
            /// </summary>
            /// <returns>Nuova instanza in gradi Kelvin</returns>
            public double ValueToMisure()
            {
                switch (_unitSymbol)
                {
                    case "k":
                        return _value;

                    case "°C":
                        return _value + 273.15;

                    case "°F":
                        return (_value + 459.67) * (5.0 / 9.0);

                    case "°R":
                        return _value * (5.0 / 9.0);

                    case "°De":
                        return 373.15 - (_value * (2.0 / 3.0));

                    case "°N":
                        return _value * (100.0 / 33.0) + 273.15;

                    case "°r":
                        return (_value * (5.0 / 4.0)) + 273.15;

                    case "°Rø":
                        return ((_value - 7.5) * (40.0 / 21.0)) + 273.15;

                    default:
                        return UnitAbsValue[0];
                }
            }

            /// <summary>
            /// Converte l'instanza in gradi Kelvin
            /// </summary>
            /// <returns>Nuova Instanza in gradi "Simb"</returns>
            public object ObjectFromMisure(string Simb)
            {
                return new Temperature(Simb, ValueFromMisure(Simb));
            }

            /// <summary>
            /// Converte l'oggetto instanziato in gradi Kelvin
            /// </summary>
            /// <returns>Nuova instanza in gradi Kelvin</returns>
            public object ObjectToMisure()
            {
                return new Temperature(ValueToMisure());
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
                Temperature temp = new Temperature("k", ValueToMisure());
                this.Unit_Value  = temp.ValueFromMisure(SimbOut) ;
                this.Unit_Symbol = SimbOut;
              
                return Unit_Value;
            }

            public void ImpostaObject(string a,double b)
            {
                if (VerificaMisure(a) && ValidateValue(a, b))
                {
                    _value = b;
                    _unitSymbol = a;
                }
                else
                    ;
            }
        }
    }
}