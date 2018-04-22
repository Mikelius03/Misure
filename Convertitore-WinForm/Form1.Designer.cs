using System.ComponentModel;

namespace ConvertitoreMisure
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblValueMisura = new System.Windows.Forms.Label();
            this.LblConversione = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labComboIn = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.ComboBoxInT = new System.Windows.Forms.ComboBox();
            this.CmbSelMisure = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ScalaToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GrandezzaToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErroreToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipMeasureIn = new System.Windows.Forms.ToolTip(this.components);
            this.lblUnitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtBConvToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.simbConvToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOutput
            // 
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutput.Enabled = false;
            this.panelOutput.Location = new System.Drawing.Point(415, 136);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(662, 539);
            this.panelOutput.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabella Conversione";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Maroon;
            this.btnConvert.Location = new System.Drawing.Point(47, 436);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(241, 82);
            this.btnConvert.TabIndex = 39;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.btnConvert);
            this.panelInput.Controls.Add(this.lblValueMisura);
            this.panelInput.Controls.Add(this.LblConversione);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.labComboIn);
            this.panelInput.Controls.Add(this.valueInput);
            this.panelInput.Controls.Add(this.ComboBoxInT);
            this.panelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(37, 136);
            this.panelInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(348, 539);
            this.panelInput.TabIndex = 40;
            // 
            // lblValueMisura
            // 
            this.lblValueMisura.Enabled = false;
            this.lblValueMisura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueMisura.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValueMisura.Location = new System.Drawing.Point(3, 200);
            this.lblValueMisura.Name = "lblValueMisura";
            this.lblValueMisura.Size = new System.Drawing.Size(340, 29);
            this.lblValueMisura.TabIndex = 12;
            this.lblValueMisura.Text = "Valore da convertire";
            this.lblValueMisura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblConversione
            // 
            this.LblConversione.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConversione.ForeColor = System.Drawing.Color.Maroon;
            this.LblConversione.Location = new System.Drawing.Point(47, 332);
            this.LblConversione.Name = "LblConversione";
            this.LblConversione.Size = new System.Drawing.Size(251, 57);
            this.LblConversione.TabIndex = 11;
            this.LblConversione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblConversione.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseoubleClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sara\' convertito il valore di:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 9;
            // 
            // labComboIn
            // 
            this.labComboIn.AutoSize = true;
            this.labComboIn.Enabled = false;
            this.labComboIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComboIn.Location = new System.Drawing.Point(83, 31);
            this.labComboIn.Name = "labComboIn";
            this.labComboIn.Size = new System.Drawing.Size(166, 29);
            this.labComboIn.TabIndex = 8;
            this.labComboIn.Text = "Unità di Input";
            // 
            // valueInput
            // 
            this.valueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInput.Location = new System.Drawing.Point(73, 231);
            this.valueInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(183, 35);
            this.valueInput.TabIndex = 4;
            this.valueInput.Text = "0";
            this.valueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComboBoxInT
            // 
            this.ComboBoxInT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxInT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxInT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxInT.ForeColor = System.Drawing.Color.DarkRed;
            this.ComboBoxInT.FormattingEnabled = true;
            this.ComboBoxInT.Location = new System.Drawing.Point(35, 65);
            this.ComboBoxInT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxInT.Name = "ComboBoxInT";
            this.ComboBoxInT.Size = new System.Drawing.Size(253, 37);
            this.ComboBoxInT.TabIndex = 0;
            this.ComboBoxInT.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInT_SelectedIndexChanged);
            // 
            // CmbSelMisure
            // 
            this.CmbSelMisure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSelMisure.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbSelMisure.Font = new System.Drawing.Font("Constantia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSelMisure.ForeColor = System.Drawing.Color.Maroon;
            this.CmbSelMisure.FormattingEnabled = true;
            this.CmbSelMisure.Location = new System.Drawing.Point(37, 59);
            this.CmbSelMisure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbSelMisure.MaxDropDownItems = 16;
            this.CmbSelMisure.Name = "CmbSelMisure";
            this.CmbSelMisure.Size = new System.Drawing.Size(349, 57);
            this.CmbSelMisure.TabIndex = 42;
            this.CmbSelMisure.SelectedIndexChanged += new System.EventHandler(this.CmbSelMisure1_IndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Grandezza fisica:";
            // 
            // ValueToolTip
            // 
            this.ValueToolTip.AutomaticDelay = 300;
            this.ValueToolTip.AutoPopDelay = 1500;
            this.ValueToolTip.InitialDelay = 350;
            this.ValueToolTip.IsBalloon = true;
            this.ValueToolTip.ReshowDelay = 60;
            this.ValueToolTip.ToolTipTitle = "2";
            this.ValueToolTip.UseAnimation = false;
            this.ValueToolTip.UseFading = false;
            // 
            // ScalaToolTip
            // 
            this.ScalaToolTip.AutomaticDelay = 100;
            this.ScalaToolTip.AutoPopDelay = 2000;
            this.ScalaToolTip.InitialDelay = 350;
            this.ScalaToolTip.IsBalloon = true;
            this.ScalaToolTip.ReshowDelay = 20;
            // 
            // GrandezzaToolTip
            // 
            this.GrandezzaToolTip.AutomaticDelay = 100;
            this.GrandezzaToolTip.AutoPopDelay = 2000;
            this.GrandezzaToolTip.InitialDelay = 1000;
            this.GrandezzaToolTip.IsBalloon = true;
            this.GrandezzaToolTip.ReshowDelay = 20;
            // 
            // ErroreToolTip
            // 
            this.ErroreToolTip.AutomaticDelay = 100;
            this.ErroreToolTip.AutoPopDelay = 2000;
            this.ErroreToolTip.InitialDelay = 10;
            this.ErroreToolTip.IsBalloon = true;
            this.ErroreToolTip.ReshowDelay = 100;
            // 
            // ToolTipMeasureIn
            // 
            this.ToolTipMeasureIn.AutomaticDelay = 300;
            this.ToolTipMeasureIn.IsBalloon = true;
            // 
            // lblUnitToolTip
            // 
            this.lblUnitToolTip.AutomaticDelay = 300;
            this.lblUnitToolTip.AutoPopDelay = 3000;
            this.lblUnitToolTip.InitialDelay = 350;
            this.lblUnitToolTip.ReshowDelay = 60;
            // 
            // txtBConvToolTip
            // 
            this.txtBConvToolTip.AutomaticDelay = 300;
            this.txtBConvToolTip.AutoPopDelay = 1500;
            this.txtBConvToolTip.InitialDelay = 300;
            this.txtBConvToolTip.IsBalloon = true;
            this.txtBConvToolTip.ReshowDelay = 60;
            // 
            // simbConvToolTip
            // 
            this.simbConvToolTip.AutomaticDelay = 300;
            this.simbConvToolTip.AutoPopDelay = 1500;
            this.simbConvToolTip.InitialDelay = 300;
            this.simbConvToolTip.IsBalloon = true;
            this.simbConvToolTip.ReshowDelay = 60;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 43;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1018, 12);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown2.TabIndex = 44;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Numeri Cifre Decimali (0-15)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 716);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSelMisure);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertitore 2.0";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.ComboBox ComboBoxInT;
        private System.Windows.Forms.ComboBox CmbSelMisure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblConversione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labComboIn;
        private System.Windows.Forms.Label lblValueMisura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.ToolTip ValueToolTip;
        private System.Windows.Forms.ToolTip ScalaToolTip;
        private System.Windows.Forms.ToolTip GrandezzaToolTip;
        private System.Windows.Forms.ToolTip ErroreToolTip;
        private System.Windows.Forms.ToolTip ToolTipMeasureIn;
        private System.Windows.Forms.ToolTip lblUnitToolTip;
        private System.Windows.Forms.ToolTip txtBConvToolTip;
        private System.Windows.Forms.ToolTip simbConvToolTip;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
    }
}
