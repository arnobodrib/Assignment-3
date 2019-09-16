namespace WinDwosForm
{
    partial class Coffee
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
            this.richTextBoxShow = new System.Windows.Forms.RichTextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxShow
            // 
            this.richTextBoxShow.BackColor = System.Drawing.Color.White;
            this.richTextBoxShow.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxShow.Location = new System.Drawing.Point(407, 43);
            this.richTextBoxShow.Name = "richTextBoxShow";
            this.richTextBoxShow.Size = new System.Drawing.Size(281, 298);
            this.richTextBoxShow.TabIndex = 1;
            this.richTextBoxShow.Text = "";
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCustomer.Controls.Add(this.label5);
            this.groupBoxCustomer.Controls.Add(this.label4);
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Controls.Add(this.buttonSave);
            this.groupBoxCustomer.Controls.Add(this.comboBoxItem);
            this.groupBoxCustomer.Controls.Add(this.quantityTextBox);
            this.groupBoxCustomer.Controls.Add(this.addressTextBox);
            this.groupBoxCustomer.Controls.Add(this.contactTextBox);
            this.groupBoxCustomer.Controls.Add(this.nameTextBox);
            this.groupBoxCustomer.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxCustomer.Location = new System.Drawing.Point(56, 32);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(294, 309);
            this.groupBoxCustomer.TabIndex = 2;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(59, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(71, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(60, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contract No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(156, 253);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Items.AddRange(new object[] {
            "Black ",
            "Regular",
            "Hot",
            "Cold"});
            this.comboBoxItem.Location = new System.Drawing.Point(110, 172);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItem.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(110, 210);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(110, 127);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(110, 92);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinDwosForm.Properties.Resources.coffee_coffee_beans_macro_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 400);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.richTextBoxShow);
            this.Name = "Coffee";
            this.Text = "Coffee Shop";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxShow;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}