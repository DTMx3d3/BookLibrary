namespace BookLibrary
{
    partial class AdministrareImprumuturi
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
            this.TabelImprumuturi = new System.Windows.Forms.DataGridView();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnIntarzieri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelImprumuturi)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelImprumuturi
            // 
            this.TabelImprumuturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelImprumuturi.Location = new System.Drawing.Point(12, 110);
            this.TabelImprumuturi.Name = "TabelImprumuturi";
            this.TabelImprumuturi.Size = new System.Drawing.Size(776, 163);
            this.TabelImprumuturi.TabIndex = 0;
            this.TabelImprumuturi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelImprumuturi_CellContentClick);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(28, 307);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(129, 36);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(190, 307);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(129, 36);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(344, 307);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(129, 36);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(640, 307);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnIntarzieri
            // 
            this.btnIntarzieri.Location = new System.Drawing.Point(492, 307);
            this.btnIntarzieri.Name = "btnIntarzieri";
            this.btnIntarzieri.Size = new System.Drawing.Size(129, 36);
            this.btnIntarzieri.TabIndex = 5;
            this.btnIntarzieri.Text = "Intarzieri";
            this.btnIntarzieri.UseVisualStyleBackColor = true;
            this.btnIntarzieri.Click += new System.EventHandler(this.btnIntarzieri_Click);
            // 
            // AdministrareImprumuturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIntarzieri);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.TabelImprumuturi);
            this.Name = "AdministrareImprumuturi";
            this.Text = "Administrare Imprumuturi";
            this.Load += new System.EventHandler(this.AdministrareImprumuturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelImprumuturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelImprumuturi;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnIntarzieri;
    }
}