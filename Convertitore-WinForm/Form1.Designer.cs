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
            this.panelOutput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblValueMisura = new System.Windows.Forms.Label();
            this.LblConversione = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labComboIn = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.ComboBoxInT = new System.Windows.Forms.ComboBox();
            this.CmbSelMisure = new System.Windows.Forms.ComboBox();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOutput
            // 
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutput.Enabled = false;
            this.panelOutput.Location = new System.Drawing.Point(415, 136);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(500, 539);
            this.panelOutput.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabella Conversione";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(35, 575);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 100);
            this.button1.TabIndex = 39;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.lblValueMisura);
            this.panelInput.Controls.Add(this.LblConversione);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.labComboIn);
            this.panelInput.Controls.Add(this.valueInput);
            this.panelInput.Controls.Add(this.ComboBoxInT);
            this.panelInput.Enabled = false;
            this.panelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(37, 136);
            this.panelInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(348, 413);
            this.panelInput.TabIndex = 40;
            // 
            // lblValueMisura
            // 
            this.lblValueMisura.Enabled = false;
            this.lblValueMisura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueMisura.Location = new System.Drawing.Point(3, 200);
            this.lblValueMisura.Name = "lblValueMisura";
            this.lblValueMisura.Size = new System.Drawing.Size(340, 29);
            this.lblValueMisura.TabIndex = 12;
            this.lblValueMisura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblConversione
            // 
            this.LblConversione.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConversione.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblConversione.Location = new System.Drawing.Point(2, 331);
            this.LblConversione.Name = "LblConversione";
            this.LblConversione.Size = new System.Drawing.Size(341, 62);
            this.LblConversione.TabIndex = 11;
            this.LblConversione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Il Valore convertito sarà: ";
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
            this.labComboIn.Size = new System.Drawing.Size(171, 29);
            this.labComboIn.TabIndex = 8;
            this.labComboIn.Text = "Scala di Input";
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
            this.ComboBoxInT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxInT.ForeColor = System.Drawing.Color.DarkRed;
            this.ComboBoxInT.FormattingEnabled = true;
            this.ComboBoxInT.Location = new System.Drawing.Point(35, 65);
            this.ComboBoxInT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxInT.Name = "ComboBoxInT";
            this.ComboBoxInT.Size = new System.Drawing.Size(253, 37);
            this.ComboBoxInT.TabIndex = 0;
            // 
            // CmbSelMisure
            // 
            this.CmbSelMisure.Font = new System.Drawing.Font("Constantia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSelMisure.ForeColor = System.Drawing.Color.Maroon;
            this.CmbSelMisure.FormattingEnabled = true;
            this.CmbSelMisure.Items.AddRange(new object[] {
            "Temperatura",
            "Pressione",
            "Distanza"});
            this.CmbSelMisure.Location = new System.Drawing.Point(35, 35);
            this.CmbSelMisure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbSelMisure.Name = "CmbSelMisure";
            this.CmbSelMisure.Size = new System.Drawing.Size(349, 57);
            this.CmbSelMisure.TabIndex = 42;
            this.CmbSelMisure.SelectedIndexChanged += new System.EventHandler(this.CmbSelMisure1_IndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSelMisure);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertitore 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label LblConversione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labComboIn;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.ComboBox ComboBoxInT;
        private System.Windows.Forms.ComboBox CmbSelMisure;
        private System.Windows.Forms.Label lblValueMisura;
    }
}
