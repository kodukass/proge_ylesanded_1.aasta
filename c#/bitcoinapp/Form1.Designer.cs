namespace bitcoinapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btmGetRates = new System.Windows.Forms.Button();
            this.amountofcoinbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyCombo.Location = new System.Drawing.Point(39, 51);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(137, 24);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            // 
            // btmGetRates
            // 
            this.btmGetRates.Location = new System.Drawing.Point(39, 192);
            this.btmGetRates.Name = "btmGetRates";
            this.btmGetRates.Size = new System.Drawing.Size(137, 23);
            this.btmGetRates.TabIndex = 1;
            this.btmGetRates.Text = "Get Rates";
            this.btmGetRates.UseVisualStyleBackColor = true;
            this.btmGetRates.Click += new System.EventHandler(this.btmGetRates_Click);
            // 
            // amountofcoinbox
            // 
            this.amountofcoinbox.Location = new System.Drawing.Point(39, 137);
            this.amountofcoinbox.Name = "amountofcoinbox";
            this.amountofcoinbox.Size = new System.Drawing.Size(100, 22);
            this.amountofcoinbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of BitCoins";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.BackColor = System.Drawing.Color.Transparent;
            this.resultLable.Location = new System.Drawing.Point(687, 192);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(45, 16);
            this.resultLable.TabIndex = 4;
            this.resultLable.Text = "Result";
            this.resultLable.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(662, 223);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 22);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountofcoinbox);
            this.Controls.Add(this.btmGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btmGetRates;
        private System.Windows.Forms.TextBox amountofcoinbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

