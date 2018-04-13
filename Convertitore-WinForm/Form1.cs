using Misure.Conversioni;
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

        private int i = 0;
        private int selected = 0;
        IMisure ObjMisure;

        #region MetodiDellaForm
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region MetodiDeiPanel
        private void InizializzaPanel2()
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

        private void EnabePanel(Panel MyPanel)
        {
            MyPanel.Enabled = true;
            foreach (Control item in MyPanel.Controls)
            {
                item.Enabled = true;
            }
        }

        private void SvuotaPanel2(Panel MyPanel)
        {
            foreach (Control controllo in MyPanel.Controls)
            {
                if ((controllo is Label) || (controllo is TextBox))
                {
                    MyPanel.Controls.Clear();
                }
            }
        }
        #endregion

        private void CmbSelMisure1_IndexChanged(object sender, EventArgs e)
        {
            selected = CmbSelMisure.SelectedIndex;
            ObjMisure = Scelta(selected);
            ComboBoxInT.Items.Clear();

            ComboBoxInT.Items.AddRange(ObjMisure.NameUnitTemp);
            ComboBoxInT.Text = ObjMisure.NameUnitTemp[0].ToString();

            EnabePanel(panelInput);

            lblValueMisura.Text = "Valore " + CmbSelMisure.Text.ToString();
            ScriviLblConversione();


            SvuotaPanel2(panelOutput);
        }

        private void ScriviLblConversione()
        {
            LblConversione.Text = valueInput.Text.ToString() + " " +
                ObjMisure.SimbolUnitTemp[ComboBoxInT.SelectedIndex].ToString();
        }

        private void ComboBoxInT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriviLblConversione();
        }



        /// <summary>Checks the input value</summary>
        /// <param name="TextNumeric">Testo che rappresenta il valore numerico da verificare</param>
        private void CheckInputValue(string TextNumeric)
        {
            contenuto = TextNumeric.Replace('.', ',');

            //Verifico che il dato nella TextBox sia un double
            if (!Double.TryParse(contenuto, out temperatura))
            {
                valueInput.Clear();
                valueInput.Text = "ERRORE";
            }

        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputScale();
                CheckInputValue(valueInput.Text.ToString());
            }
            catch
            {
                MessageBox.Show("eRRORI");
            }

            Temperature Obj = new Temperature();


            Obj.Value = temperatura;

            if (!Obj.ValidateValue(UnitTempIn, temperatura))
            {
                MessageBox.Show("Valore fuori scala");
                return;
            }
            else { MessageBox.Show("Valore in scala:::"+Obj.ToString());
            }

            result = new double[8];
            i = 0;
            foreach (string simbol in Obj.SimbolUnitTemp)
            {
                if (i < 8)
                {
                    result[i++] = Math.Round((Obj).ValueMisureToMisure(simbol), 3);

                }
            }

            MessageBox.Show("nono"+result[2].ToString());
        }

        void fer()
        {
            SvuotaPanel2(panelOutput);
            InizializzaPanel2();
            EnabePanel(panelOutput);


            // Verifico che il umero duble sia maggiore
            // della temperatura assoluta della relativa scala termometrica


            // Instanzio un oggetto Temperature
            //   IMisure value = Scelta(CmbSelMisure.SelectedIndex);





            i = 0;
            foreach (Control txb in panelOutput.Controls)
            {
                if ((txb is TextBox) && i < 8)
                    txb.Text = result[i++].ToString();
            }
        }
    }
}