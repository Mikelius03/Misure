using Physics.PhysicalQuantities;
using System;
using System.ComponentModel;
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
        IPhysical ObjMisure;

        /// <summary>Array di double contenenti tutte le PhysicalQuantities</summary>
        private double[] result;

        //indice per i vari foreach
        private int i = 0;
        #endregion
        int index;

        #region MetodiDellaForm        
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbSelMisure.Items.AddRange(ItemsPQ.NameOfPQ);
            CmbSelMisure.SelectedIndex = 0;
            ComboBoxInT.SelectedIndex = 0;
            valueInput.Text = "0";

            MessageBox.Show(ObjMisure.MeasurementName);
            MessageBox.Show(ObjMisure.MeasurementSymbol);

            ValueToolTip.SetToolTip(valueInput, "Inserire valore della misura");
            ScalaToolTip.SetToolTip(ComboBoxInT, "Scegliere l'unità di misura della grandezza da misurare");
            GrandezzaToolTip.SetToolTip(CmbSelMisure, "Scegliere la grandezza fisica da convertire");
            ToolTipMeasureIn.SetToolTip(LblConversione, "Doppio Click per copiare l'elemento");

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
                lblUnitToolTip.SetToolTip(lbl1, "Clicca una volta per copiare il nome dell'unità");
                this.panelOutput.Controls.Add(lbl1);
                txtBConvToolTip.SetToolTip(tex, "DoppioClick per copiare il valore");
                this.panelOutput.Controls.Add(tex);
                simbConvToolTip.SetToolTip(lbl2, "Clik per copiare solo il simbolo \nDoppioclick per copiare valore e simbolo!");
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
        private void ClearPanel(Panel MyPanel)
        {
            MyPanel.Controls.Clear();
        }
        #endregion

        #region MetodiIndiciComboBox    

        /// <summary>
        /// Verifica che il testo della TextBox sia un numero
        /// </summary>
        /// <param name="testoTextBox">Testo della TextBox</param>
        /// <returns></returns>
        private bool CheckInputValue(string testoTextBox)
        {
            testoTextBox = testoTextBox.Replace('.', ',');
            if (Double.TryParse(testoTextBox, out ValueMeasure))
            {
                if (ValueMeasure >= ObjMisure.UnitAbsValue[ComboBoxInT.SelectedIndex])
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Handles the IndexChanged event of the CmbSelMisure1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbSelMisure1_IndexChanged(object sender, EventArgs e)
        {
            ObjMisure = ItemsPQ.ChoosePQ(CmbSelMisure.SelectedIndex);

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

            index = ComboBoxInT.SelectedIndex;
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
                ErroreToolTip.Show("Inserire un numero maggiore di "
                    + ObjMisure.UnitAbsValue[ComboBoxInT.SelectedIndex].ToString(), valueInput);
                valueInput.Clear();
                ComboBoxInT.Text = "";
                return;
            }

            // Imposto l'istanza creata con la misurazione da convertire
            ObjMisure.RedefineObject(SimbUnitIn, ValueMeasure);

            result = new double[8] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0};
            i = 0;

            foreach (string simbol in ObjMisure.UnitSymbol)
            {
                if (i <= 8)
                {
                    result[i++] = Math.Round(ObjMisure.ValueUnitToUnit(simbol),(int)numericUpDown2.Value);
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
            foreach (object tooltip in panelOutput.Controls)
            {
                if (tooltip is ToolTip MyTooltip)
                {
                    MyTooltip.AutomaticDelay = 300;
                    MyTooltip.AutoPopDelay = 1500;
                    MyTooltip.InitialDelay = 300;
                    MyTooltip.ReshowDelay = 60;
                }
            }

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

        private void MouseoubleClick(object sender, MouseEventArgs e)
        {
            if (sender is Control clickControl)
                CopiaTesto(clickControl);
        }

        private void Form1_FormClosed(Object sender, CancelEventArgs e)
        {
            const string message =
        "Sei sicuro di voler uscire dal programma?";
            const string caption = "Chiusura Programma";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
            else
            {
                Clipboard.Clear();
            }
        }
    }
}