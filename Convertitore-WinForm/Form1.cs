using Misure.Conversioni;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertitoreMisure
{
    public partial class Form1 : Form
    {
        #region Variabili

        /// <summary>Nome dell' unita' di misura in Input</summary>
        private string NameUnitIn;

        /// <summary>Simbolo dell' unita' di misura in Input</summary>
        private string SimbUnitIn;

        /// <summary>Valore dell' unita' di misura</summary>
        private double ValueMeasure;

        // Oggetto per la conversione
        IMisure ObjMisure;

        /************************************************************************************/
        private string testoTextBox;
        /// <summary>Array di double contenenti tutte le conversioni</summary>
        private double[] result;

        //indice per i vari foreach
        private int i = 0;

        #endregion

        #region MetodiDellaForm

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbSelMisure.Items.AddRange(Elementi.Text);
            CmbSelMisure.SelectedIndex = 0;
            ComboBoxInT.SelectedIndex = 0;
            valueInput.Text = "0";
        }
        #endregion

        #region MetodiDeiPanel
        private void IniPanelOutput()
        {

            Point inizioLbl1 = new Point(1, 32);
            Size SizeControlLbl1 = new Size(135, 26);

            Point inizioTxtB = new Point(140, 32);
            Size SizeControlTxtB = new Size(140, 26);

            Point inizioLbl2 = new Point(285, 32);
            Size SizeControlLbl2 = new Size(100, 26);
            for (int ii = 0; ii < ObjMisure.UnitSymbol.Length; ii++)
            {
                string NameControlLbl1 = "lbl" + i.ToString() + ObjMisure.UnitName[ii];
                string NameControlTxt = "lbl" + i.ToString() + ObjMisure.UnitName[ii];
                string NameControlLbl2 = "lbl" + i.ToString() + ObjMisure.UnitSymbol[ii];

                Label lbl1 = AddLabel(NameControlLbl1, inizioLbl1, SizeControlLbl1, ObjMisure.UnitName[ii], ContentAlignment.MiddleRight);
                TextBox tex = AddTextBox(NameControlTxt, inizioTxtB, SizeControlTxtB, "");
                Label lbl2 = AddLabel(NameControlLbl2, inizioLbl2, SizeControlLbl2, ObjMisure.UnitSymbol[ii], ContentAlignment.MiddleLeft);
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
            if (MyPanel.Enabled == false)
            {
                MyPanel.Enabled = true;
                foreach (Control item in MyPanel.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                // MyPanel.Enabled = false;
            }
        }
        private void ClearPanel(Panel MyPanel)
        {
            MyPanel.Controls.Clear();
        }
        #endregion

        #region MetodiIndiciComboBox    

        /// <summary>
        /// Verifica che il testo della TextBox sia un numero
        /// </summary>
        /// <param name="TextNumeric">Testo della TextBox</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">Eccezione in CheckInputValue</exception>
        private bool CheckInputValue(string testoTextBox)
        {
            testoTextBox = testoTextBox.Replace('.', ',');
            //Verifico che il dato nella TextBox sia un double
            return Double.TryParse(testoTextBox, out ValueMeasure);
        }

        private void CmbSelMisure1_IndexChanged(object sender, EventArgs e)
        {
            ObjMisure = Elementi.Scelta(CmbSelMisure.SelectedIndex) ;

            /// Setto la ComboBoxInT
            ComboBoxInT.Items.Clear();
            ComboBoxInT.Items.AddRange(ObjMisure.UnitName);
            ComboBoxInT.Text = ComboBoxInT.Items[0].ToString();

            // Scrivo la Label per kikki
            valueInput.Text = "0";

            LblConversione.Text = "0 " + ObjMisure.UnitSymbol[0];
            // Scrivo la Label del valore da convertire
            lblValueMisura.Text = "Valore " + CmbSelMisure.Text;

            // Svuoto il panelOutpu (Nel caso fosse già stato usato)
            ClearPanel(panelOutput);
        }

        private void ComboBoxInT_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = ComboBoxInT.SelectedIndex;
            NameUnitIn = ComboBoxInT.SelectedItem.ToString();
            SimbUnitIn = ObjMisure.UnitSymbol[index];
            LblConversione.Text = valueInput.Text + " " + SimbUnitIn;

        }
        #endregion

        #region MetodiDelButton
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (!CheckInputValue(valueInput.Text))
            {
                MessageBox.Show("Input non corretto");
                valueInput.Clear();
                ComboBoxInT.Text = "";
          //      MostraConversioni(null);
                return;
            }

            // Imposto l'instanza creata con la misurazione da convertire
            ObjMisure.ImpostaObject(SimbUnitIn, ValueMeasure);

            result = new double[8];
            i = 0;

            foreach (string simbol in ObjMisure.UnitSymbol)
            {
                if (i < 8)
                {
                    result[i++] = Math.Round((ObjMisure).ValueMisureToMisure(simbol), 3);
                }
            }
            MostraConversioni(result);
        }
        #endregion

        private void MostraConversioni(double[] result)
        {

            ClearPanel(panelOutput);
            EnabePanel(panelOutput);
            IniPanelOutput();


            i = 0;
            foreach (Control txb in panelOutput.Controls)
            {
                if ((txb is TextBox) && i < 8)
                    if (!(result is null))
                    {
                        txb.Text = result[i++].ToString();
                    }
                    else
                    {
                        txb.Text = "0.0";
                    }
            }

        }





    }
}