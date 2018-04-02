namespace ConvertitoreMisure
{

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
            this.panelInput = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labComboIn = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.ComboBoxInT = new System.Windows.Forms.ComboBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.tabVol = new System.Windows.Forms.TabPage();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.labComboIn);
            this.panelInput.Controls.Add(this.valueInput);
            this.panelInput.Controls.Add(this.ComboBoxInT);
            this.panelInput.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(28, 35);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(340, 330);
            this.panelInput.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(-1, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 63);
            this.label4.TabIndex = 11;
            this.label4.Text = "0 k";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Il Valore convertito sarà: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valore temperatura";
            // 
            // labComboIn
            // 
            this.labComboIn.AutoSize = true;
            this.labComboIn.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComboIn.Location = new System.Drawing.Point(57, 32);
            this.labComboIn.Name = "labComboIn";
            this.labComboIn.Size = new System.Drawing.Size(188, 30);
            this.labComboIn.TabIndex = 8;
            this.labComboIn.Text = "Scala di Input";
            // 
            // valueInput
            // 
            this.valueInput.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInput.Location = new System.Drawing.Point(62, 165);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(183, 36);
            this.valueInput.TabIndex = 4;
            this.valueInput.Text = "0";
            this.valueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueInput.Click += new System.EventHandler(this.Clear);
            this.valueInput.TextChanged += new System.EventHandler(this.valueInput_TextChanged);
            // 
            // ComboBoxInT
            // 
            this.ComboBoxInT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxInT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxInT.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxInT.ForeColor = System.Drawing.Color.DarkRed;
            this.ComboBoxInT.FormattingEnabled = true;
            this.ComboBoxInT.Location = new System.Drawing.Point(62, 65);
            this.ComboBoxInT.Name = "ComboBoxInT";
            this.ComboBoxInT.Size = new System.Drawing.Size(183, 38);
            this.ComboBoxInT.TabIndex = 0;
            this.ComboBoxInT.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInT_SelectedIndexChanged);
            // 
            // panelOutput
            // 
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutput.Controls.Add(this.label1);
            this.panelOutput.Location = new System.Drawing.Point(398, 35);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(471, 504);
            this.panelOutput.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversione";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(28, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 154);
            this.button1.TabIndex = 7;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTemp);
            this.tabControl1.Controls.Add(this.tabVol);
            this.tabControl1.Location = new System.Drawing.Point(22, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 609);
            this.tabControl1.TabIndex = 38;
            // 
            // tabTemp
            // 
            this.tabTemp.Controls.Add(this.panelOutput);
            this.tabTemp.Controls.Add(this.button1);
            this.tabTemp.Controls.Add(this.panelInput);
            this.tabTemp.Location = new System.Drawing.Point(4, 29);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(913, 576);
            this.tabTemp.TabIndex = 0;
            this.tabTemp.Text = "TEMPERATURE";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // tabVol
            // 
            this.tabVol.Location = new System.Drawing.Point(4, 29);
            this.tabVol.Name = "tabVol";
            this.tabVol.Padding = new System.Windows.Forms.Padding(3);
            this.tabVol.Size = new System.Drawing.Size(913, 576);
            this.tabVol.TabIndex = 1;
            this.tabVol.Text = "PRESSIONE";
            this.tabVol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(955, 694);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertitore 1.0";
            this.Load += new System.EventHandler(this.LoadingForm);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTemp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.ComboBox ComboBoxInT;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labComboIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabVol;
    }
}
