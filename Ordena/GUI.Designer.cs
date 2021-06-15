namespace Ordena
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.lstOrigem = new System.Windows.Forms.ListBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.nudCasos = new System.Windows.Forms.NumericUpDown();
            this.btnOrdena = new System.Windows.Forms.Button();
            this.cbMethods = new System.Windows.Forms.ComboBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(17, 16);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(170, 58);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "&Sortear";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lstOrigem
            // 
            this.lstOrigem.FormattingEnabled = true;
            this.lstOrigem.ItemHeight = 29;
            this.lstOrigem.Location = new System.Drawing.Point(17, 137);
            this.lstOrigem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstOrigem.Name = "lstOrigem";
            this.lstOrigem.Size = new System.Drawing.Size(170, 323);
            this.lstOrigem.TabIndex = 1;
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.ItemHeight = 29;
            this.lstOrdenada.Location = new System.Drawing.Point(217, 135);
            this.lstOrdenada.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(168, 323);
            this.lstOrdenada.TabIndex = 2;
            // 
            // nudCasos
            // 
            this.nudCasos.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCasos.Location = new System.Drawing.Point(17, 88);
            this.nudCasos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nudCasos.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCasos.Name = "nudCasos";
            this.nudCasos.Size = new System.Drawing.Size(170, 35);
            this.nudCasos.TabIndex = 3;
            this.nudCasos.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnOrdena
            // 
            this.btnOrdena.Location = new System.Drawing.Point(217, 16);
            this.btnOrdena.Name = "btnOrdena";
            this.btnOrdena.Size = new System.Drawing.Size(168, 58);
            this.btnOrdena.TabIndex = 4;
            this.btnOrdena.Text = "&Ordenar";
            this.btnOrdena.UseVisualStyleBackColor = true;
            this.btnOrdena.Click += new System.EventHandler(this.btnOrdena_Click);
            // 
            // cbMethods
            // 
            this.cbMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Items.AddRange(new object[] {
            "Inserção",
            "Bolha",
            "Quick Sort",
            "Seleção",
            "Merge Sort"});
            this.cbMethods.Location = new System.Drawing.Point(217, 88);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(168, 37);
            this.cbMethods.TabIndex = 5;
            // 
            // cbShow
            // 
            this.cbShow.Location = new System.Drawing.Point(17, 470);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(170, 71);
            this.cbShow.TabIndex = 6;
            this.cbShow.Text = "&Mostrar Dados";
            this.cbShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tempo (ms):";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(212, 503);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(25, 27);
            this.lblTempo.TabIndex = 8;
            this.lblTempo.Text = "0";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 555);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.cbMethods);
            this.Controls.Add(this.btnOrdena);
            this.Controls.Add(this.nudCasos);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.lstOrigem);
            this.Controls.Add(this.btnGerar);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "GUI";
            this.Text = "Simulador de Ordenação";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox lstOrigem;
        private System.Windows.Forms.ListBox lstOrdenada;
        private System.Windows.Forms.NumericUpDown nudCasos;
        private System.Windows.Forms.Button btnOrdena;
        private System.Windows.Forms.ComboBox cbMethods;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTempo;
    }
}

