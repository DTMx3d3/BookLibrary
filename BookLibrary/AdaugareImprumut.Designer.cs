namespace BookLibrary
{
    partial class AdaugareImprumut
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
            this.label2 = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nume_Carte = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pret = new System.Windows.Forms.TextBox();
            this.PretTxT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare Imprumut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume:";
            // 
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(54, 210);
            this.CustName.Margin = new System.Windows.Forms.Padding(4);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(260, 23);
            this.CustName.TabIndex = 2;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(54, 302);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(261, 23);
            this.StartDate.TabIndex = 3;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(681, 302);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(261, 23);
            this.EndDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data imprumut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data returnare:";
            // 
            // Nume_Carte
            // 
            this.Nume_Carte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nume_Carte.FormattingEnabled = true;
            this.Nume_Carte.Location = new System.Drawing.Point(53, 432);
            this.Nume_Carte.Name = "Nume_Carte";
            this.Nume_Carte.Size = new System.Drawing.Size(262, 24);
            this.Nume_Carte.TabIndex = 7;
            this.Nume_Carte.SelectedIndexChanged += new System.EventHandler(this.Nume_Carte_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numele Carte:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(714, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Imprumut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseCaptureChanged += new System.EventHandler(this.button1_MouseCaptureChanged);
            // 
            // Pret
            // 
            this.Pret.Location = new System.Drawing.Point(681, 212);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(261, 23);
            this.Pret.TabIndex = 10;
            // 
            // PretTxT
            // 
            this.PretTxT.AutoSize = true;
            this.PretTxT.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretTxT.Location = new System.Drawing.Point(676, 167);
            this.PretTxT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PretTxT.Name = "PretTxT";
            this.PretTxT.Size = new System.Drawing.Size(93, 39);
            this.PretTxT.TabIndex = 11;
            this.PretTxT.Text = "Pret:";
            // 
            // AdaugareImprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PretTxT);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nume_Carte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdaugareImprumut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare Imprumut";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Nume_Carte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Pret;
        private System.Windows.Forms.Label PretTxT;
    }
}

