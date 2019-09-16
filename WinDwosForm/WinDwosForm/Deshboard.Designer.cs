namespace WinDwosForm
{
    partial class Deshboard
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
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Items.AddRange(new object[] {
            "Burger",
            "Pizza",
            "Chiken"});
            this.comboBoxItem.Location = new System.Drawing.Point(145, 50);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItem.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(284, 50);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Deshboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboBoxItem);
            this.Name = "Deshboard";
            this.Text = "Deshboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Button buttonShow;
    }
}