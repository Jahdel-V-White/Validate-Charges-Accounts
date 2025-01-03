namespace White_Ch7._3
{
    partial class ChargeAccValidation
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
            this.label1 = new System.Windows.Forms.Label();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the 7 digit number of the Charge Account you are seaching for in the Box be" +
    "low.\r\n";
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(325, 408);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(162, 54);
            this.ValidateBtn.TabIndex = 4;
            this.ValidateBtn.Text = "Click to Validate Account #";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(733, 408);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(162, 54);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(512, 315);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(191, 26);
            this.UserInput.TabIndex = 6;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            this.UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Charge Account Validator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 326);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
          //  this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChargeAccValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.label1);
            this.Name = "ChargeAccValidation";
            this.Text = "Charge Account Validation";
            this.Load += new System.EventHandler(this.ChargeAccValidation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

