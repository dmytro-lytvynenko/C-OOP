namespace OOp_lab2
{
    partial class Archive_Search
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Author = new System.Windows.Forms.CheckBox();
            this.Material = new System.Windows.Forms.CheckBox();
            this.Faculty = new System.Windows.Forms.CheckBox();
            this.Cathedry = new System.Windows.Forms.CheckBox();
            this.Material_Type = new System.Windows.Forms.CheckBox();
            this.Pages = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.CheckBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(43, 352);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(52, 19);
            this.LINQ.TabIndex = 0;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(132, 352);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(53, 19);
            this.DOM.TabIndex = 1;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(223, 352);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(46, 19);
            this.SAX.TabIndex = 2;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(382, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(281, 341);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.SystemColors.Control;
            this.Author.Location = new System.Drawing.Point(43, 54);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(63, 19);
            this.Author.TabIndex = 4;
            this.Author.Text = "Author";
            this.Author.UseVisualStyleBackColor = false;
            this.Author.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(43, 82);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(69, 19);
            this.Material.TabIndex = 5;
            this.Material.Text = "Material";
            this.Material.UseVisualStyleBackColor = true;
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Location = new System.Drawing.Point(43, 112);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(64, 19);
            this.Faculty.TabIndex = 6;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = true;
            // 
            // Cathedry
            // 
            this.Cathedry.AutoSize = true;
            this.Cathedry.Location = new System.Drawing.Point(43, 141);
            this.Cathedry.Name = "Cathedry";
            this.Cathedry.Size = new System.Drawing.Size(74, 19);
            this.Cathedry.TabIndex = 7;
            this.Cathedry.Text = "Cathedry";
            this.Cathedry.UseVisualStyleBackColor = true;
            // 
            // Material_Type
            // 
            this.Material_Type.AutoSize = true;
            this.Material_Type.Location = new System.Drawing.Point(43, 170);
            this.Material_Type.Name = "Material_Type";
            this.Material_Type.Size = new System.Drawing.Size(98, 19);
            this.Material_Type.TabIndex = 8;
            this.Material_Type.Text = "Material Type";
            this.Material_Type.UseVisualStyleBackColor = true;
            // 
            // Pages
            // 
            this.Pages.AutoSize = true;
            this.Pages.Location = new System.Drawing.Point(43, 199);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(57, 19);
            this.Pages.TabIndex = 9;
            this.Pages.Text = "Pages";
            this.Pages.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 23);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(168, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(106, 23);
            this.comboBox3.TabIndex = 12;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(168, 141);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 23);
            this.comboBox4.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(168, 170);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(106, 23);
            this.comboBox5.TabIndex = 14;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(168, 199);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(106, 23);
            this.comboBox6.TabIndex = 15;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(43, 228);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(50, 19);
            this.Date.TabIndex = 16;
            this.Date.Text = "Date";
            this.Date.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(168, 228);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(106, 23);
            this.comboBox7.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(43, 303);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 28);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(192, 303);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(81, 28);
            this.buttonTransform.TabIndex = 22;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(113, 303);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(73, 28);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Archive_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.Material_Type);
            this.Controls.Add(this.Cathedry);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.LINQ);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Archive_Search";
            this.Text = "Archive Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Archive_Search_FormClosing);
            this.Load += new System.EventHandler(this.Archive_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox Author;
        private System.Windows.Forms.CheckBox Material;
        private System.Windows.Forms.CheckBox Faculty;
        private System.Windows.Forms.CheckBox Cathedry;
        private System.Windows.Forms.CheckBox Material_Type;
        private System.Windows.Forms.CheckBox Pages;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.CheckBox Date;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button buttonSearch;
    }
}