namespace MatrizesDeListas
{
    partial class FormCriarMatriz
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
            this.numLinhas = new System.Windows.Forms.NumericUpDown();
            this.numColunas = new System.Windows.Forms.NumericUpDown();
            this.btnLerDeArquivo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dlgLerDeArquivo = new System.Windows.Forms.OpenFileDialog();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linhas:";
            this.tooltip.SetToolTip(this.label1, "Número de linhas que deve ter a matriz. É usado mesmo que a matriz seja lida de u" +
        "m arquivo.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colunas:";
            this.tooltip.SetToolTip(this.label2, "Número de colunas que deve ter a matriz. É usado mesmo que a matriz seja lida de " +
        "um arquivo.");
            // 
            // numLinhas
            // 
            this.numLinhas.Location = new System.Drawing.Point(68, 11);
            this.numLinhas.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLinhas.Name = "numLinhas";
            this.numLinhas.Size = new System.Drawing.Size(184, 20);
            this.numLinhas.TabIndex = 2;
            this.numLinhas.ThousandsSeparator = true;
            this.tooltip.SetToolTip(this.numLinhas, "Número de linhas que deve ter a matriz. É usado mesmo que a matriz seja lida de u" +
        "m arquivo.");
            this.numLinhas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numColunas
            // 
            this.numColunas.Location = new System.Drawing.Point(68, 38);
            this.numColunas.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColunas.Name = "numColunas";
            this.numColunas.Size = new System.Drawing.Size(184, 20);
            this.numColunas.TabIndex = 3;
            this.numColunas.ThousandsSeparator = true;
            this.tooltip.SetToolTip(this.numColunas, "Número de colunas que deve ter a matriz. É usado mesmo que a matriz seja lida de " +
        "um arquivo.");
            this.numColunas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLerDeArquivo
            // 
            this.btnLerDeArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLerDeArquivo.Location = new System.Drawing.Point(58, 74);
            this.btnLerDeArquivo.Name = "btnLerDeArquivo";
            this.btnLerDeArquivo.Size = new System.Drawing.Size(86, 23);
            this.btnLerDeArquivo.TabIndex = 4;
            this.btnLerDeArquivo.Text = "Ler de Arquivo";
            this.tooltip.SetToolTip(this.btnLerDeArquivo, "Lê um arquivo XML de matriz e cria uma nova matriz com as dimensões especificadas" +
        " e os valores lidos");
            this.btnLerDeArquivo.UseVisualStyleBackColor = true;
            this.btnLerDeArquivo.Click += new System.EventHandler(this.btnLerDeArquivo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(231, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(150, 74);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dlgLerDeArquivo
            // 
            this.dlgLerDeArquivo.DefaultExt = "xml";
            this.dlgLerDeArquivo.Filter = "XML files|*.xml|All files|*.*";
            // 
            // FormCriarMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 106);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLerDeArquivo);
            this.Controls.Add(this.numColunas);
            this.Controls.Add(this.numLinhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCriarMatriz";
            this.Text = "Criar Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLinhas;
        private System.Windows.Forms.NumericUpDown numColunas;
        private System.Windows.Forms.Button btnLerDeArquivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog dlgLerDeArquivo;
        private System.Windows.Forms.ToolTip tooltip;
    }
}