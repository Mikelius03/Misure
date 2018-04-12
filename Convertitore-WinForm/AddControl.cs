using Misure;
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
            lbl.Enabled = false;

            return lbl;
        }


        TextBox AddTextBox(string Nome, Point Coordinate, Size Dimensioni, string testo)
        {
            TextBox TxtB = new TextBox();
            TxtB.Name = Nome;
            TxtB.Text = testo;
            TxtB.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            TxtB.TextAlign = HorizontalAlignment.Right;

            TxtB.Location = Coordinate;
            TxtB.Size = Dimensioni;
            TxtB.Anchor = 0;
            TxtB.Enabled = false;

            return TxtB;
        }
    }
}
