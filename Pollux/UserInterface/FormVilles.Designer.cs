namespace Pollux.UserInterface
{
    partial class FormVilles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boutonAnnuler = new System.Windows.Forms.Button();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boutonAnnuler);
            this.groupBox1.Controls.Add(this.boutonAjouter);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une ville";
            // 
            // boutonAnnuler
            // 
            this.boutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonAnnuler.Location = new System.Drawing.Point(147, 89);
            this.boutonAnnuler.Name = "boutonAnnuler";
            this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.boutonAnnuler.TabIndex = 4;
            this.boutonAnnuler.Text = "Annuler";
            this.boutonAnnuler.UseVisualStyleBackColor = true;
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.Location = new System.Drawing.Point(228, 89);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(75, 23);
            this.boutonAjouter.TabIndex = 4;
            this.boutonAjouter.Text = "Ajouter";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(100, 52);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(203, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ville :";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(100, 26);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(203, 20);
            this.textBoxCP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code postal :";
            // 
            // FormVilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 123);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVilles";
            this.Text = "Villes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button boutonAjouter;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boutonAnnuler;
    }
}