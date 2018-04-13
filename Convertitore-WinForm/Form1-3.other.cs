using Misure.Conversioni;
using System.Windows.Forms;

namespace ConvertitoreMisure
{
    public partial class Form1 : Form
    {
        public IMisure Scelta(int val)
        {
            switch (val)
            {
                case 0:
                    return new Temperature();
                case 1:
                    return new Pressione();
                default:
                    // return new Dist(); ;
                    return null;
            }
        }
    

    /// <summary>Convalida la checkBox per la scelta della scala da convertire</summary>
    private void CheckInputScale()
    {
        if (ComboBoxInT.SelectedIndex == -1)
        {
            MessageBox.Show("Scegliere Le unita'di Misura");
            return;
        }
        else
        {
            // Memorizzo l'indice relativo alla scala termometrica
            UnitTempIn = ObjMisure.SimbolUnitTemp[ComboBoxInT.SelectedIndex];
        }
    }}
}