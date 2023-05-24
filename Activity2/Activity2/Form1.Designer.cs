namespace Activity2
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
            this.btn_Sub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtSubject1 = new System.Windows.Forms.TextBox();
            this.txt_Subject2 = new System.Windows.Forms.TextBox();
            this.txtAvarage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Sub
            // 
            this.btn_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sub.Location = new System.Drawing.Point(314, 283);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(101, 50);
            this.btn_Sub.TabIndex = 0;
            this.btn_Sub.Text = "Submit";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject 1*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject 2*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Avarage";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(577, 180);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 20);
            this.label.TabIndex = 4;
            this.label.Text = "label";
            // 
            // txtSubject1
            // 
            this.txtSubject1.Location = new System.Drawing.Point(285, 71);
            this.txtSubject1.Name = "txtSubject1";
            this.txtSubject1.Size = new System.Drawing.Size(195, 26);
            this.txtSubject1.TabIndex = 5;
            this.txtSubject1.Text = "0";
            this.txtSubject1.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubject1_Validating);
            // 
            // txt_Subject2
            // 
            this.txt_Subject2.Location = new System.Drawing.Point(285, 123);
            this.txt_Subject2.Name = "txt_Subject2";
            this.txt_Subject2.Size = new System.Drawing.Size(195, 26);
            this.txt_Subject2.TabIndex = 6;
            this.txt_Subject2.Text = "0";
            this.txt_Subject2.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Subject2_Validating);
            // 
            // txtAvarage
            // 
            this.txtAvarage.Location = new System.Drawing.Point(285, 177);
            this.txtAvarage.Name = "txtAvarage";
            this.txtAvarage.Size = new System.Drawing.Size(195, 26);
            this.txtAvarage.TabIndex = 7;
            this.txtAvarage.Text = "0";
            this.txtAvarage.Validating += new System.ComponentModel.CancelEventHandler(this.txtAvarage_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAvarage);
            this.Controls.Add(this.txt_Subject2);
            this.Controls.Add(this.txtSubject1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sub);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtSubject1;
        private System.Windows.Forms.TextBox txt_Subject2;
        private System.Windows.Forms.TextBox txtAvarage;
    }
}

