using Misure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertitoreMisure
{
    public partial class Form1 : Form
    {
        private double temperatura;
        private string UnitTempIn;
        private string contenuto;
        private double[] result;
        private int i;



        public Form1()
        {
            InitializeComponent();
        }

        private void LoadingForm(object sender, EventArgs e)
        {
            #region panelInput
            int i = 0;

            // Inizializa la ComboBox per la lista delle Temperature
            ComboBoxInT.Items.AddRange(Temperature.NameUnitTemp);
            #endregion

            #region panelOutput
            Point inizioLbl1 = new System.Drawing.Point(1, 50);
            Size SizeControlLbl1 = new Size(105, 26);

            Point inizioTxtB = new Point(110, 50);
            Size SizeControlTxtB = new Size(140, 26);

            Point inizioLbl2 = new Point(250, 51);
            Size SizeControlLbl2 = new Size(40, 26);

            for (int ii = 0; ii < 8; ii++)
            {
                string NameControlLbl1 = "lbl" + i.ToString() + Temperature.NameUnitTemp[ii];
                string NameControlTxt = "lbl" + i.ToString() + Temperature.NameUnitTemp[ii];
                string NameControlLbl2 = "lbl" + i.ToString() + Temperature.SimbolUnitTemp[ii];


                Label lbl1 = AddLabel(NameControlLbl1, inizioLbl1, SizeControlLbl1, Temperature.NameUnitTemp[ii], ContentAlignment.MiddleRight);
                TextBox tex = AddTextBox(NameControlTxt, inizioTxtB, SizeControlTxtB, "");
                Label lbl2 = AddLabel(NameControlLbl2, inizioLbl2, SizeControlLbl2, Temperature.SimbolUnitTemp[ii], ContentAlignment.MiddleLeft);
                this.panelOutput.Controls.Add(lbl1);
                this.panelOutput.Controls.Add(tex);
                this.panelOutput.Controls.Add(lbl2);
                inizioLbl1.Offset(0, 35);
                inizioTxtB.Offset(0, 35);
                inizioLbl2.Offset(0, 35);
            }
            #endregion
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Verifico la scelta della scala termometrica
            if (ComboBoxInT.SelectedIndex == -1)
            {
                MessageBox.Show("Scegliere Le unita'di Misura");
                return;
            }
            else
            {
                // Memorizzo l'indice relativo alla scala termometrica
                UnitTempIn = Temperature.Simboli[ComboBoxInT.SelectedIndex];
            }

            contenuto = (valueInput.Text.ToString()).Replace('.', ',');


            //Verifico che il dato nella TextBox sia un double
            if (!Double.TryParse(contenuto, out temperatura))
            {
                valueInput.Clear();
                valueInput.Text = "ERRORE";
                return;
            }

            // Verifico che il umero duble sia maggiore
            // della temperatura assoluta della relativa scala termometrica
            if (!Temperature.ValiateTemp(UnitTempIn, temperatura))
            {
                MessageBox.Show("Valore fuori scala");
                return;
            };

            // Instanzio un oggetto Temperature
            Temperature value = new Temperature(UnitTempIn, temperatura);



            result = new double[8];
            i = 0;
            foreach (string simbol in Temperature.Simboli)
            {
                if (i < 8)
                {
                    result[i++] = Math.Round(value.ConvertValueTemp(simbol), 3);
                }
            }

            i = 0;
            foreach (Control txb in panelOutput.Controls)
            {
                if ((txb is TextBox) && i < 8)
                    txb.Text = result[i++].ToString();
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            valueInput.Clear();
            valueInput.BackColor = Color.White;
        }

        private void ComboBoxInT_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteLabel();
        }

        private void WriteLabel()
        {
            string valore = valueInput.Text.ToString() + " " +
                Temperature.SimbolUnitTemp[ComboBoxInT.SelectedIndex].ToString();
            label4.Text = valore;

        }
        /*
        private void CopiaValue(int index, string simboloScala)
        {
            int count = 0;
            foreach (Control item in panelOutput.Controls)
            {
                if (item is TextBox)
                {
                    if (count == index)
                    {
                        Clipboard.SetText(item.ToString() + " " + simboloScala);
                        return;
                    }
                    count++;
                }
            }
        }
        */
        private void valueInput_TextChanged(object sender, EventArgs e)
        {
            WriteLabel();
        }
    }
}