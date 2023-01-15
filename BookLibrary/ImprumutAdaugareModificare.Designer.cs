namespace BookLibrary
{
    partial class ImprumutAdaugareModificare
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
            this.dataStart = new System.Windows.Forms.DateTimePicker();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.Titlu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataStart
            // 
            this.dataStart.Location = new System.Drawing.Point(252, 178);
            this.dataStart.Name = "dataStart";
            this.dataStart.Size = new System.Drawing.Size(261, 20);
            this.dataStart.TabIndex = 0;
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(252, 247);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.Size = new System.Drawing.Size(261, 20);
            this.dataEnd.TabIndex = 1;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(252, 115);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(261, 20);
            this.txtNume.TabIndex = 2;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(252, 315);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(261, 20);
            this.txtPret.TabIndex = 3;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(194, 361);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(120, 41);
            this.btnSalvare.TabIndex = 4;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(431, 361);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(120, 41);
            this.btnAnulare.TabIndex = 5;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // Titlu
            // 
            this.Titlu.AutoSize = true;
            this.Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlu.Location = new System.Drawing.Point(246, 40);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(282, 33);
            this.Titlu.TabIndex = 6;
            this.Titlu.Text = "Modificare Imprumut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(278, 86);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(0, 16);
            this.IDlbl.TabIndex = 8;
            // 
            // ImprumutAdaugareModificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.dataEnd);
            this.Controls.Add(this.dataStart);
            this.Name = "ImprumutAdaugareModificare";
            this.Text = "ImprumutAdaugareModificare";
            this.Load += new System.EventHandler(this.ImprumutAdaugareModificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataStart;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Label Titlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDlbl;
    }
}