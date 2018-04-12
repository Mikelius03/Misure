using Misure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertitoreMisure
{
    public partial class Form1 : Form
    {
        /*
        private double temperatura;
        private string UnitTempIn;
        private string contenuto;
        private double[] result;
        
        */
        private int i = 0;
        private int selected = 0;
        IMisure ObjMisure;


        public Form1()
        {
            InitializeComponent();
        }


        private void CmbSelMisure1_IndexChanged(object sender, EventArgs e)
        {
            selected = CmbSelMisure.SelectedIndex;
            ObjMisure = Scelta(selected);
            ComboBoxInT.Items.Clear();

            ComboBoxInT.Items.AddRange(ObjMisure.NameUnitTemp);
            ComboBoxInT.Text = ObjMisure.NameUnitTemp[0].ToString();

            EnabeControl();

            lblValueMisura.Text = "Valore " + CmbSelMisure.Text.ToString();
            ScriviLblConversione();


            SvuotaPanel2();
        }

        private void EnabeControl()
        {
            panelInput.Enabled = true;
            foreach (Control item in panelInput.Controls)
            {
                item.Enabled = true;

            }
        }

        private void ScriviLblConversione()
        {
            LblConversione.Text = valueInput.Text.ToString() + " " +
                ObjMisure.SimbolUnitTemp[ComboBoxInT.SelectedIndex].ToString();
        }

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






        void InizializzaPanel2()
        {

            Point inizioLbl1 = new Point(1, 32);
            Size SizeControlLbl1 = new Size(105, 26);

            Point inizioTxtB = new Point(110, 32);
            Size SizeControlTxtB = new Size(140, 26);

            Point inizioLbl2 = new Point(250, 32);
            Size SizeControlLbl2 = new Size(40, 26);
            for (int ii = 0; ii < ObjMisure.SimbolUnitTemp.Length; ii++)
            {
                string NameControlLbl1 = "lbl" + i.ToString() + ObjMisure.NameUnitTemp[ii];
                string NameControlTxt = "lbl" + i.ToString() + ObjMisure.NameUnitTemp[ii];
                string NameControlLbl2 = "lbl" + i.ToString() + ObjMisure.SimbolUnitTemp[ii];

                Label lbl1 = AddLabel(NameControlLbl1, inizioLbl1, SizeControlLbl1, ObjMisure.NameUnitTemp[ii], ContentAlignment.MiddleRight);
                TextBox tex = AddTextBox(NameControlTxt, inizioTxtB, SizeControlTxtB, "");
                Label lbl2 = AddLabel(NameControlLbl2, inizioLbl2, SizeControlLbl2, ObjMisure.SimbolUnitTemp[ii], ContentAlignment.MiddleLeft);
                this.panelOutput.Controls.Add(lbl1);
                this.panelOutput.Controls.Add(tex);
                this.panelOutput.Controls.Add(lbl2);
                inizioLbl1.Offset(0, 38);
                inizioTxtB.Offset(0, 38);
                inizioLbl2.Offset(0, 38);
            }
        }

        private void SvuotaPanel2()
        {
            foreach (Control controllo in panelOutput.Controls)
            {
                if ((controllo is Label) || (controllo is TextBox))
                {
                    panelOutput.Controls.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SvuotaPanel2();
            InizializzaPanel2();
            panelOutput.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }































        /*


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
            //  if (!Temperature. ValidateValue(UnitTempIn, temperatura))
            //  {
            MessageBox.Show("Valore fuori scala");
            return;
            //  };

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

        private void valueInput_TextChanged(object sender, EventArgs e)
        {
            WriteLabel();
        }
    */


    }
}