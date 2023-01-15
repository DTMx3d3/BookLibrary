namespace BookLibrary
{
    partial class MainWind
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareImprumuturiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biblioteca ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartiToolStripMenuItem,
            this.administrareImprumuturiToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cartiToolStripMenuItem
            // 
            this.cartiToolStripMenuItem.Name = "cartiToolStripMenuItem";
            this.cartiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cartiToolStripMenuItem.Text = "Carti";
            this.cartiToolStripMenuItem.Click += new System.EventHandler(this.cartiToolStripMenuItem_Click);
            // 
            // administrareImprumuturiToolStripMenuItem1
            // 
            this.administrareImprumuturiToolStripMenuItem1.Name = "administrareImprumuturiToolStripMenuItem1";
            this.administrareImprumuturiToolStripMenuItem1.Size = new System.Drawing.Size(158, 20);
            this.administrareImprumuturiToolStripMenuItem1.Text = "Administrare Imprumuturi";
            this.administrareImprumuturiToolStripMenuItem1.Click += new System.EventHandler(this.administrareImprumuturiToolStripMenuItem1_Click_1);
            // 
            // MainWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principala";
            this.Load += new System.EventHandler(this.MainWind_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrareImprumuturiToolStripMenuItem1;
    }
}