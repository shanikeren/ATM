namespace ATM
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.labelTryAgain = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWelcome.Location = new System.Drawing.Point(326, 54);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(124, 25);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "WELCOME";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEnter.Location = new System.Drawing.Point(293, 95);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(194, 13);
            this.labelEnter.TabIndex = 1;
            this.labelEnter.Text = "ENTER CREDIT CARD NUMBER";
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Number.Location = new System.Drawing.Point(298, 155);
            this.Number.MaxLength = 16;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(181, 30);
            this.Number.TabIndex = 2;
            // 
            // labelTryAgain
            // 
            this.labelTryAgain.AutoSize = true;
            this.labelTryAgain.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTryAgain.ForeColor = System.Drawing.Color.Crimson;
            this.labelTryAgain.Location = new System.Drawing.Point(340, 312);
            this.labelTryAgain.Name = "labelTryAgain";
            this.labelTryAgain.Size = new System.Drawing.Size(89, 15);
            this.labelTryAgain.TabIndex = 3;
            this.labelTryAgain.Text = "Please try again";
            this.labelTryAgain.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSubmit.Location = new System.Drawing.Point(352, 247);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(67, 26);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = resources.GetString("buttonSubmit.Text");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelTryAgain);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.labelWelcome);
            this.Name = "WelcomeForm";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label labelTryAgain;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

