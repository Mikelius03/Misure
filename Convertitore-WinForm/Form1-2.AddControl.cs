using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertitoreMisure
{
    public partial class Form1 : Form
    {
        public Label AddLabel(string Nome, Point Coordinate, Size Dimensioni, string testo, ContentAlignment AlingTesto)
        {
            Label lbl = new Label();
            lbl.Name = Nome;
            lbl.Text = testo;
            lbl.Font = new Font("Century Schoolbook", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl.TextAlign = AlingTesto;

            lbl.Location = Coordinate;
            lbl.Size = Dimensioni;
            lbl.Anchor = 0;
            lbl.MouseClick += new MouseEventHandler(MyEventHandler2);

            lbl.MouseDoubleClick += new MouseEventHandler(MyEventHandler);
            return lbl;
        }
        public TextBox AddTextBox(string Nome, Point Coordinate, Size Dimensioni, string testo)
        {
            TextBox TxtB = new TextBox();
            TxtB.Name = Nome;
            TxtB.Text = testo;
            TxtB.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            TxtB.TextAlign = HorizontalAlignment.Right;

            TxtB.Location = Coordinate;
            TxtB.Size = Dimensioni;
            TxtB.Anchor = 0;
            TxtB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(MyEventHandler2);

            return TxtB;
        }


        /// <summary>
        /// Gestore per l'evento click sul simbolo dell'unità
        /// </summary>
        private void MyEventHandler(object sender, MouseEventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                int index = Array.IndexOf(ObjMisure.UnitSymbol, clickedLabel.Text);
                if (index >= 0)
                {
                    Clipboard.SetText(result[index].ToString() + " " + clickedLabel.Text);
                }
            }

        }
        private void MyEventHandler2(object sender, MouseEventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                int index = Array.IndexOf(ObjMisure.UnitSymbol, clickedLabel.Text);
                if (index >= 0)
                {
                    Clipboard.SetText(result[index].ToString() + " " + clickedLabel.Text);
                }
            }
        }


        private void CopiaTesto(Control controls)
        {
            Clipboard.SetText(controls.Text);

            if (controls is TextBox clickedTextBox)
            {
                clickedTextBox.SelectAll();
            }
        }

    }
}
