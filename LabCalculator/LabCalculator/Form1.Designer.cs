
namespace LabCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDC = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonDR = new System.Windows.Forms.Button();
            this.buttonAR = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDC);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAC);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDR);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAR);
            this.splitContainer1.Panel2.Controls.Add(this.textBox);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCalculate);
            this.splitContainer1.Size = new System.Drawing.Size(800, 66);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(179, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 42);
            this.button8.TabIndex = 2;
            this.button8.Text = "Help";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Columns";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rows";
            // 
            // buttonDC
            // 
            this.buttonDC.Location = new System.Drawing.Point(141, 31);
            this.buttonDC.Name = "buttonDC";
            this.buttonDC.Size = new System.Drawing.Size(26, 24);
            this.buttonDC.TabIndex = 5;
            this.buttonDC.Text = "-";
            this.buttonDC.UseVisualStyleBackColor = true;
            this.buttonDC.Click += new System.EventHandler(this.buttonDC_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.Location = new System.Drawing.Point(109, 31);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(26, 23);
            this.buttonAC.TabIndex = 4;
            this.buttonAC.Text = "+";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonDR
            // 
            this.buttonDR.Location = new System.Drawing.Point(49, 32);
            this.buttonDR.Name = "buttonDR";
            this.buttonDR.Size = new System.Drawing.Size(26, 23);
            this.buttonDR.TabIndex = 3;
            this.buttonDR.Text = "-";
            this.buttonDR.UseVisualStyleBackColor = true;
            this.buttonDR.Click += new System.EventHandler(this.buttonDR_Click);
            // 
            // buttonAR
            // 
            this.buttonAR.Location = new System.Drawing.Point(17, 32);
            this.buttonAR.Name = "buttonAR";
            this.buttonAR.Size = new System.Drawing.Size(26, 23);
            this.buttonAR.TabIndex = 2;
            this.buttonAR.Text = "+";
            this.buttonAR.UseVisualStyleBackColor = true;
            this.buttonAR.Click += new System.EventHandler(this.buttonAR_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(258, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(179, 23);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(443, 22);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(802, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonDR;
        private System.Windows.Forms.Button buttonAR;
        private System.Windows.Forms.Button buttonDC;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

