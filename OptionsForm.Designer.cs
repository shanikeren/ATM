namespace ATM
{
    partial class OptionsForm
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
            this.button20 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.buttonOther = new System.Windows.Forms.Button();
            this.buttonNewPin = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelHey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(45, 100);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(148, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "20$";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button100
            // 
            this.button100.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button100.Location = new System.Drawing.Point(45, 299);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(148, 23);
            this.button100.TabIndex = 1;
            this.button100.Text = "100$";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button50
            // 
            this.button50.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button50.Location = new System.Drawing.Point(45, 196);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(148, 23);
            this.button50.TabIndex = 2;
            this.button50.Text = "50$";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // buttonOther
            // 
            this.buttonOther.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOther.Location = new System.Drawing.Point(527, 100);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(215, 23);
            this.buttonOther.TabIndex = 3;
            this.buttonOther.Text = "Other amount";
            this.buttonOther.UseVisualStyleBackColor = true;
            this.buttonOther.Click += new System.EventHandler(this.buttonOther_Click);
            // 
            // buttonNewPin
            // 
            this.buttonNewPin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewPin.Location = new System.Drawing.Point(527, 299);
            this.buttonNewPin.Name = "buttonNewPin";
            this.buttonNewPin.Size = new System.Drawing.Size(215, 23);
            this.buttonNewPin.TabIndex = 4;
            this.buttonNewPin.Text = "Update pin code";
            this.buttonNewPin.UseVisualStyleBackColor = true;
            this.buttonNewPin.Click += new System.EventHandler(this.buttonNewPin_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalance.Location = new System.Drawing.Point(527, 196);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(215, 23);
            this.buttonBalance.TabIndex = 5;
            this.buttonBalance.Text = "Cash availability";
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExit.Location = new System.Drawing.Point(693, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelHey
            // 
            this.labelHey.AutoSize = true;
            this.labelHey.BackColor = System.Drawing.Color.MistyRose;
            this.labelHey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHey.ForeColor = System.Drawing.Color.LightCoral;
            this.labelHey.Location = new System.Drawing.Point(343, 35);
            this.labelHey.Name = "labelHey";
            this.labelHey.Size = new System.Drawing.Size(47, 25);
            this.labelHey.TabIndex = 7;
            this.labelHey.Text = "hey";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHey);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.buttonNewPin);
            this.Controls.Add(this.buttonOther);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button100);
            this.Controls.Add(this.button20);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button buttonOther;
        private System.Windows.Forms.Button buttonNewPin;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelHey;
    }
}