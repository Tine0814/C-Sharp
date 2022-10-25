namespace ConverstionAgeToDays
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_age = new System.Windows.Forms.Button();
            this.btn_days = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // btn_age
            // 
            this.btn_age.Location = new System.Drawing.Point(315, 48);
            this.btn_age.Name = "btn_age";
            this.btn_age.Size = new System.Drawing.Size(77, 23);
            this.btn_age.TabIndex = 1;
            this.btn_age.Text = "Enter";
            this.btn_age.UseVisualStyleBackColor = true;
            this.btn_age.Click += new System.EventHandler(this.btn_age_Click);
            // 
            // btn_days
            // 
            this.btn_days.Location = new System.Drawing.Point(315, 132);
            this.btn_days.Name = "btn_days";
            this.btn_days.Size = new System.Drawing.Size(77, 23);
            this.btn_days.TabIndex = 1;
            this.btn_days.Text = "Enter";
            this.btn_days.UseVisualStyleBackColor = true;
            this.btn_days.Click += new System.EventHandler(this.btn_days_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Days";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(117, 48);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(168, 23);
            this.txt_age.TabIndex = 2;
            // 
            // txt_days
            // 
            this.txt_days.Location = new System.Drawing.Point(117, 132);
            this.txt_days.Name = "txt_days";
            this.txt_days.Size = new System.Drawing.Size(168, 23);
            this.txt_days.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 289);
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.btn_days);
            this.Controls.Add(this.btn_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_age;
        private Button btn_days;
        private Label label2;
        private TextBox txt_age;
        private TextBox txt_days;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}