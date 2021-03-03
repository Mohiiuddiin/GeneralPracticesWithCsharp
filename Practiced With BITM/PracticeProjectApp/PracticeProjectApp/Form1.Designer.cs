namespace PracticeProjectApp
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
            this.javaCheckBox = new System.Windows.Forms.CheckBox();
            this.cSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.pythonCheckBox = new System.Windows.Forms.CheckBox();
            this.clickMeButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // javaCheckBox
            // 
            this.javaCheckBox.AutoSize = true;
            this.javaCheckBox.Location = new System.Drawing.Point(12, 12);
            this.javaCheckBox.Name = "javaCheckBox";
            this.javaCheckBox.Size = new System.Drawing.Size(49, 17);
            this.javaCheckBox.TabIndex = 0;
            this.javaCheckBox.Text = "Java";
            this.javaCheckBox.UseVisualStyleBackColor = true;
            // 
            // cSharpCheckBox
            // 
            this.cSharpCheckBox.AutoSize = true;
            this.cSharpCheckBox.Location = new System.Drawing.Point(108, 12);
            this.cSharpCheckBox.Name = "cSharpCheckBox";
            this.cSharpCheckBox.Size = new System.Drawing.Size(40, 17);
            this.cSharpCheckBox.TabIndex = 1;
            this.cSharpCheckBox.Text = "C#";
            this.cSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // pythonCheckBox
            // 
            this.pythonCheckBox.AutoSize = true;
            this.pythonCheckBox.Location = new System.Drawing.Point(206, 12);
            this.pythonCheckBox.Name = "pythonCheckBox";
            this.pythonCheckBox.Size = new System.Drawing.Size(59, 17);
            this.pythonCheckBox.TabIndex = 2;
            this.pythonCheckBox.Text = "Python";
            this.pythonCheckBox.UseVisualStyleBackColor = true;
            // 
            // clickMeButton
            // 
            this.clickMeButton.Location = new System.Drawing.Point(12, 57);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(96, 30);
            this.clickMeButton.TabIndex = 3;
            this.clickMeButton.Text = "Click Me";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.clickMeButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chittagong",
            "Dhaka",
            "Rajshahi"});
            this.comboBox1.Location = new System.Drawing.Point(339, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "--Select--";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(364, 57);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(96, 30);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 147);
            this.listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(119, 289);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 20);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 315);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(61, 20);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 352);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clickMeButton);
            this.Controls.Add(this.pythonCheckBox);
            this.Controls.Add(this.cSharpCheckBox);
            this.Controls.Add(this.javaCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox javaCheckBox;
        private System.Windows.Forms.CheckBox cSharpCheckBox;
        private System.Windows.Forms.CheckBox pythonCheckBox;
        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

