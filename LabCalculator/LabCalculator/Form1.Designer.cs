namespace TableEditor
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelCol = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.buttonDC = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonDR = new System.Windows.Forms.Button();
            this.buttonAR = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 750);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Lavender;
            this.buttonCalculate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(304, 18);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(85, 43);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lavender;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(80, 18);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 43);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Lavender;
            this.buttonOpen.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpen.Location = new System.Drawing.Point(10, 18);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(65, 43);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox.Location = new System.Drawing.Point(36, 23);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(255, 26);
            this.textBox.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonHelp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpen);
            this.splitContainer1.Panel1.Controls.Add(this.labelCol);
            this.splitContainer1.Panel1.Controls.Add(this.labelRow);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDC);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAC);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDR);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCalculate);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(922, 84);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 7;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Lavender;
            this.buttonHelp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.Location = new System.Drawing.Point(377, 18);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(58, 51);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelCol
            // 
            this.labelCol.AutoSize = true;
            this.labelCol.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCol.Location = new System.Drawing.Point(295, 15);
            this.labelCol.Name = "labelCol";
            this.labelCol.Size = new System.Drawing.Size(59, 20);
            this.labelCol.TabIndex = 7;
            this.labelCol.Text = "Columns";
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRow.Location = new System.Drawing.Point(194, 15);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(40, 20);
            this.labelRow.TabIndex = 6;
            this.labelRow.Text = "Rows";
            // 
            // buttonDC
            // 
            this.buttonDC.BackColor = System.Drawing.Color.Lavender;
            this.buttonDC.Location = new System.Drawing.Point(325, 39);
            this.buttonDC.Name = "buttonDC";
            this.buttonDC.Size = new System.Drawing.Size(23, 22);
            this.buttonDC.TabIndex = 5;
            this.buttonDC.Text = "-";
            this.buttonDC.UseVisualStyleBackColor = false;
            this.buttonDC.Click += new System.EventHandler(this.buttonDC_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.Color.Lavender;
            this.buttonAC.Location = new System.Drawing.Point(295, 39);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(24, 22);
            this.buttonAC.TabIndex = 4;
            this.buttonAC.Text = "+";
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonDR
            // 
            this.buttonDR.BackColor = System.Drawing.Color.Lavender;
            this.buttonDR.Location = new System.Drawing.Point(222, 39);
            this.buttonDR.Name = "buttonDR";
            this.buttonDR.Size = new System.Drawing.Size(23, 22);
            this.buttonDR.TabIndex = 3;
            this.buttonDR.Text = "-";
            this.buttonDR.UseVisualStyleBackColor = false;
            this.buttonDR.Click += new System.EventHandler(this.buttonDR_Click);
            // 
            // buttonAR
            // 
            this.buttonAR.BackColor = System.Drawing.Color.Lavender;
            this.buttonAR.Location = new System.Drawing.Point(194, 39);
            this.buttonAR.Name = "buttonAR";
            this.buttonAR.Size = new System.Drawing.Size(23, 22);
            this.buttonAR.TabIndex = 2;
            this.buttonAR.Text = "+";
            this.buttonAR.UseVisualStyleBackColor = false;
            this.buttonAR.Click += new System.EventHandler(this.buttonAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 472);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Table Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelCol;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Button buttonDC;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonDR;
        private System.Windows.Forms.Button buttonAR;
        private System.Windows.Forms.Button buttonHelp;
    }
}

