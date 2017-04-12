namespace MatrizesDeListas
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnCriarMatrizA = new System.Windows.Forms.Button();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.btnLiberarMatrizA = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarA = new System.Windows.Forms.Button();
            this.btnSomarKColunaA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvarB = new System.Windows.Forms.Button();
            this.btnSomarKColunaB = new System.Windows.Forms.Button();
            this.btnCriarMatrizB = new System.Windows.Forms.Button();
            this.btnLiberarMatrizB = new System.Windows.Forms.Button();
            this.gridB = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvarResultado = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gridResultado = new System.Windows.Forms.DataGridView();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarMatrizA
            // 
            this.btnCriarMatrizA.Location = new System.Drawing.Point(3, 3);
            this.btnCriarMatrizA.Name = "btnCriarMatrizA";
            this.btnCriarMatrizA.Size = new System.Drawing.Size(71, 23);
            this.btnCriarMatrizA.TabIndex = 0;
            this.btnCriarMatrizA.Text = "Criar Matriz";
            this.tooltip.SetToolTip(this.btnCriarMatrizA, "Cria uma nova matriz");
            this.btnCriarMatrizA.UseVisualStyleBackColor = true;
            this.btnCriarMatrizA.Click += new System.EventHandler(this.btnCriarMatrizA_Click);
            // 
            // gridA
            // 
            this.gridA.AllowUserToAddRows = false;
            this.gridA.AllowUserToDeleteRows = false;
            this.gridA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridA.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridA.Location = new System.Drawing.Point(3, 32);
            this.gridA.Name = "gridA";
            this.gridA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridA.RowHeadersVisible = false;
            this.gridA.Size = new System.Drawing.Size(514, 119);
            this.gridA.TabIndex = 1;
            this.gridA.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
            this.gridA.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_ColumnAdded);
            this.gridA.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grid_RowsAdded);
            // 
            // btnLiberarMatrizA
            // 
            this.btnLiberarMatrizA.Enabled = false;
            this.btnLiberarMatrizA.Location = new System.Drawing.Point(80, 3);
            this.btnLiberarMatrizA.Name = "btnLiberarMatrizA";
            this.btnLiberarMatrizA.Size = new System.Drawing.Size(80, 23);
            this.btnLiberarMatrizA.TabIndex = 3;
            this.btnLiberarMatrizA.Text = "Liberar Matriz";
            this.tooltip.SetToolTip(this.btnLiberarMatrizA, "Apaga a matriz");
            this.btnLiberarMatrizA.UseVisualStyleBackColor = true;
            this.btnLiberarMatrizA.Click += new System.EventHandler(this.btnLiberarMatrizA_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(528, 525);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(528, 336);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalvarA);
            this.panel1.Controls.Add(this.btnSomarKColunaA);
            this.panel1.Controls.Add(this.btnCriarMatrizA);
            this.panel1.Controls.Add(this.btnLiberarMatrizA);
            this.panel1.Controls.Add(this.gridA);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 156);
            this.panel1.TabIndex = 4;
            // 
            // btnSalvarA
            // 
            this.btnSalvarA.Enabled = false;
            this.btnSalvarA.Location = new System.Drawing.Point(166, 3);
            this.btnSalvarA.Name = "btnSalvarA";
            this.btnSalvarA.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarA.TabIndex = 5;
            this.btnSalvarA.Text = "Salvar";
            this.tooltip.SetToolTip(this.btnSalvarA, "Salva a matriz para um arquivo");
            this.btnSalvarA.UseVisualStyleBackColor = true;
            this.btnSalvarA.Click += new System.EventHandler(this.btnSalvarA_Click);
            // 
            // btnSomarKColunaA
            // 
            this.btnSomarKColunaA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSomarKColunaA.Enabled = false;
            this.btnSomarKColunaA.Location = new System.Drawing.Point(403, 3);
            this.btnSomarKColunaA.Name = "btnSomarKColunaA";
            this.btnSomarKColunaA.Size = new System.Drawing.Size(114, 23);
            this.btnSomarKColunaA.TabIndex = 4;
            this.btnSomarKColunaA.Text = "Somar K na coluna...";
            this.tooltip.SetToolTip(this.btnSomarKColunaA, "Soma uma constante K em uma determinada coluna da matriz");
            this.btnSomarKColunaA.UseVisualStyleBackColor = true;
            this.btnSomarKColunaA.Click += new System.EventHandler(this.btnSomarKColunaA_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalvarB);
            this.panel2.Controls.Add(this.btnSomarKColunaB);
            this.panel2.Controls.Add(this.btnCriarMatrizB);
            this.panel2.Controls.Add(this.btnLiberarMatrizB);
            this.panel2.Controls.Add(this.gridB);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 163);
            this.panel2.TabIndex = 5;
            // 
            // btnSalvarB
            // 
            this.btnSalvarB.Enabled = false;
            this.btnSalvarB.Location = new System.Drawing.Point(166, 3);
            this.btnSalvarB.Name = "btnSalvarB";
            this.btnSalvarB.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarB.TabIndex = 6;
            this.btnSalvarB.Text = "Salvar";
            this.tooltip.SetToolTip(this.btnSalvarB, "Salva a matriz para um arquivo");
            this.btnSalvarB.UseVisualStyleBackColor = true;
            this.btnSalvarB.Click += new System.EventHandler(this.btnSalvarB_Click);
            // 
            // btnSomarKColunaB
            // 
            this.btnSomarKColunaB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSomarKColunaB.Enabled = false;
            this.btnSomarKColunaB.Location = new System.Drawing.Point(403, 3);
            this.btnSomarKColunaB.Name = "btnSomarKColunaB";
            this.btnSomarKColunaB.Size = new System.Drawing.Size(114, 23);
            this.btnSomarKColunaB.TabIndex = 5;
            this.btnSomarKColunaB.Text = "Somar K na coluna...";
            this.tooltip.SetToolTip(this.btnSomarKColunaB, "Soma uma constante K em uma determinada coluna da matriz");
            this.btnSomarKColunaB.UseVisualStyleBackColor = true;
            this.btnSomarKColunaB.Click += new System.EventHandler(this.btnSomarKColunaB_Click);
            // 
            // btnCriarMatrizB
            // 
            this.btnCriarMatrizB.Location = new System.Drawing.Point(3, 3);
            this.btnCriarMatrizB.Name = "btnCriarMatrizB";
            this.btnCriarMatrizB.Size = new System.Drawing.Size(71, 23);
            this.btnCriarMatrizB.TabIndex = 0;
            this.btnCriarMatrizB.Text = "Criar Matriz";
            this.tooltip.SetToolTip(this.btnCriarMatrizB, "Cria uma nova matriz");
            this.btnCriarMatrizB.UseVisualStyleBackColor = true;
            this.btnCriarMatrizB.Click += new System.EventHandler(this.btnCriarMatrizB_Click);
            // 
            // btnLiberarMatrizB
            // 
            this.btnLiberarMatrizB.Enabled = false;
            this.btnLiberarMatrizB.Location = new System.Drawing.Point(80, 3);
            this.btnLiberarMatrizB.Name = "btnLiberarMatrizB";
            this.btnLiberarMatrizB.Size = new System.Drawing.Size(80, 23);
            this.btnLiberarMatrizB.TabIndex = 3;
            this.btnLiberarMatrizB.Text = "Liberar Matriz";
            this.tooltip.SetToolTip(this.btnLiberarMatrizB, "Apaga a matriz");
            this.btnLiberarMatrizB.UseVisualStyleBackColor = true;
            // 
            // gridB
            // 
            this.gridB.AllowUserToAddRows = false;
            this.gridB.AllowUserToDeleteRows = false;
            this.gridB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridB.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridB.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridB.Location = new System.Drawing.Point(3, 32);
            this.gridB.Name = "gridB";
            this.gridB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridB.RowHeadersVisible = false;
            this.gridB.Size = new System.Drawing.Size(514, 126);
            this.gridB.TabIndex = 1;
            this.gridB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
            this.gridB.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_ColumnAdded);
            this.gridB.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grid_RowsAdded);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSalvarResultado);
            this.panel3.Controls.Add(this.btnMultiplicar);
            this.panel3.Controls.Add(this.btnSomar);
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Controls.Add(this.gridResultado);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 179);
            this.panel3.TabIndex = 5;
            // 
            // btnSalvarResultado
            // 
            this.btnSalvarResultado.Enabled = false;
            this.btnSalvarResultado.Location = new System.Drawing.Point(166, 3);
            this.btnSalvarResultado.Name = "btnSalvarResultado";
            this.btnSalvarResultado.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarResultado.TabIndex = 5;
            this.btnSalvarResultado.Text = "Salvar";
            this.tooltip.SetToolTip(this.btnSalvarResultado, "Salva a matriz para um arquivo");
            this.btnSalvarResultado.UseVisualStyleBackColor = true;
            this.btnSalvarResultado.Click += new System.EventHandler(this.btnSalvarResultado_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.Location = new System.Drawing.Point(84, 3);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(76, 23);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "Multiplicar";
            this.tooltip.SetToolTip(this.btnMultiplicar, "Multiplica as matrizes e mostra o resultado");
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Enabled = false;
            this.btnSomar.Location = new System.Drawing.Point(3, 3);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 3;
            this.btnSomar.Text = "Somar";
            this.tooltip.SetToolTip(this.btnSomar, "Soma as matrizes e mostra o resultado");
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 29);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // gridResultado
            // 
            this.gridResultado.AllowUserToAddRows = false;
            this.gridResultado.AllowUserToDeleteRows = false;
            this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultado.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResultado.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridResultado.Location = new System.Drawing.Point(3, 45);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.ReadOnly = true;
            this.gridResultado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridResultado.RowHeadersVisible = false;
            this.gridResultado.Size = new System.Drawing.Size(514, 129);
            this.gridResultado.TabIndex = 1;
            this.gridResultado.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_ColumnAdded);
            this.gridResultado.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grid_RowsAdded);
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.Filter = "XML files|*.xml|All files|*.*";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(552, 543);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(397, 378);
            this.Name = "FormPrincipal";
            this.Text = "Matrizes";
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarMatrizA;
        private System.Windows.Forms.DataGridView gridA;
        private System.Windows.Forms.Button btnLiberarMatrizA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCriarMatrizB;
        private System.Windows.Forms.Button btnLiberarMatrizB;
        private System.Windows.Forms.DataGridView gridB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSomarKColunaA;
        private System.Windows.Forms.Button btnSomarKColunaB;
        private System.Windows.Forms.Button btnSalvarA;
        private System.Windows.Forms.Button btnSalvarB;
        private System.Windows.Forms.Button btnSalvarResultado;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

