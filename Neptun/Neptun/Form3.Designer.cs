namespace Neptun
{
    partial class Form3
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
            this.nev = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Action_text = new System.Windows.Forms.Label();
            this.leiras = new System.Windows.Forms.Label();
            this.hely = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.errorbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nev.Location = new System.Drawing.Point(26, 76);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(132, 25);
            this.nev.TabIndex = 0;
            this.nev.Text = "Tárgy neve: ";
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kod.Location = new System.Drawing.Point(26, 116);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(137, 25);
            this.kod.TabIndex = 1;
            this.kod.Text = "Tárgy kódja: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Felvétel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "Leadás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Action_text
            // 
            this.Action_text.AutoSize = true;
            this.Action_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Action_text.ForeColor = System.Drawing.Color.Red;
            this.Action_text.Location = new System.Drawing.Point(317, 267);
            this.Action_text.Name = "Action_text";
            this.Action_text.Size = new System.Drawing.Size(0, 18);
            this.Action_text.TabIndex = 4;
            // 
            // leiras
            // 
            this.leiras.AutoSize = true;
            this.leiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leiras.Location = new System.Drawing.Point(30, 193);
            this.leiras.Name = "leiras";
            this.leiras.Size = new System.Drawing.Size(50, 16);
            this.leiras.TabIndex = 5;
            this.leiras.Text = "Leírás: ";
            // 
            // hely
            // 
            this.hely.AutoSize = true;
            this.hely.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hely.Location = new System.Drawing.Point(606, 76);
            this.hely.Name = "hely";
            this.hely.Size = new System.Drawing.Size(78, 20);
            this.hely.TabIndex = 6;
            this.hely.Text = "Férőhely: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Vissza";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorbox
            // 
            this.errorbox.AutoSize = true;
            this.errorbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorbox.Location = new System.Drawing.Point(301, 261);
            this.errorbox.Name = "errorbox";
            this.errorbox.Size = new System.Drawing.Size(0, 16);
            this.errorbox.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hely);
            this.Controls.Add(this.leiras);
            this.Controls.Add(this.Action_text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.nev);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label kod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Action_text;
        private System.Windows.Forms.Label leiras;
        private System.Windows.Forms.Label hely;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label errorbox;
    }
}