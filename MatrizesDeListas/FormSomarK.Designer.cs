namespace MatrizesDeListas
{
    partial class FormSomarK
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numColuna = new System.Windows.Forms.NumericUpDown();
            this.numK = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numColuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coluna:";
            this.tooltip.SetToolTip(this.label1, "Número da coluna onde somar a constante");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            this.tooltip.SetToolTip(this.label2, "Constante a ser somada");
            // 
            // numColuna
            // 
            this.numColuna.Location = new System.Drawing.Point(62, 11);
            this.numColuna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColuna.Name = "numColuna";
            this.numColuna.Size = new System.Drawing.Size(120, 20);
            this.numColuna.TabIndex = 2;
            this.tooltip.SetToolTip(this.numColuna, "Número da coluna onde somar a constante");
            this.numColuna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numK
            // 
            this.numK.DecimalPlaces = 3;
            this.numK.Location = new System.Drawing.Point(62, 34);
            this.numK.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numK.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.numK.Name = "numK";
            this.numK.Size = new System.Drawing.Size(120, 20);
            this.numK.TabIndex = 3;
            this.tooltip.SetToolTip(this.numK, "Constante a ser somada");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(90, 61);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormSomarK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 96);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numK);
            this.Controls.Add(this.numColuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSomarK";
            this.Text = "Somar constante";
            ((System.ComponentModel.ISupportInitialize)(this.numColuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numColuna;
        private System.Windows.Forms.NumericUpDown numK;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip tooltip;
    }
}