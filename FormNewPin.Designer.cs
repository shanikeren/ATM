namespace ATM
{
    partial class FormNewPin
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
            this.labelhead = new System.Windows.Forms.Label();
            this.textBoxNewPin = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelhead
            // 
            this.labelhead.AutoSize = true;
            this.labelhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelhead.Location = new System.Drawing.Point(131, 62);
            this.labelhead.Name = "labelhead";
            this.labelhead.Size = new System.Drawing.Size(184, 25);
            this.labelhead.TabIndex = 0;
            this.labelhead.Text = "Enter new pin code:";
            // 
            // textBoxNewPin
            // 
            this.textBoxNewPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxNewPin.Location = new System.Drawing.Point(189, 114);
            this.textBoxNewPin.MaxLength = 4;
            this.textBoxNewPin.Name = "textBoxNewPin";
            this.textBoxNewPin.Size = new System.Drawing.Size(51, 30);
            this.textBoxNewPin.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(177, 190);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormNewPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(461, 307);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNewPin);
            this.Controls.Add(this.labelhead);
            this.Name = "FormNewPin";
            this.Text = "FormNewPin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhead;
        private System.Windows.Forms.TextBox textBoxNewPin;
        private System.Windows.Forms.Button buttonSubmit;
    }
}