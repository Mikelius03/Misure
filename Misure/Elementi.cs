using Misure.Conversioni;

namespace Misure
{
    namespace Conversioni
    {
        public class Elementi
        {
            // Grandezze presenti nella dll
            public static string[] Text = { "Temperatura", "Pressione","Distanza","Lunghezza" };

            public static int count = Text.Length;

            public static IMisure Scelta(int val)
            {
                switch (val)
                {
                    case 0:
                        return new Temperature();
                    case 1:
                        return new Pressione();
                    case 2:
                        return new Distanza();
                    case 3:
                        return new Lunghezza();
                    default:
                        // return new Dist(); ;
                        return null;
                }
            }

        }
    }
}
