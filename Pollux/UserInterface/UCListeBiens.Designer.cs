namespace Pollux
{
    partial class UCListeBiens
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxBiens = new System.Windows.Forms.ListBox();
            this.groupBoxBiens = new System.Windows.Forms.GroupBox();
            this.groupBoxBiens.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ajouter une visite";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBoxBiens
            // 
            this.listBoxBiens.FormattingEnabled = true;
            this.listBoxBiens.Location = new System.Drawing.Point(16, 19);
            this.listBoxBiens.Name = "listBoxBiens";
            this.listBoxBiens.Size = new System.Drawing.Size(461, 186);
            this.listBoxBiens.TabIndex = 8;
            // 
            // groupBoxBiens
            // 
            this.groupBoxBiens.Controls.Add(this.listBoxBiens);
            this.groupBoxBiens.Controls.Add(this.button2);
            this.groupBoxBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBiens.Location = new System.Drawing.Point(0, 30);
            this.groupBoxBiens.Name = "groupBoxBiens";
            this.groupBoxBiens.Size = new System.Drawing.Size(507, 296);
            this.groupBoxBiens.TabIndex = 9;
            this.groupBoxBiens.TabStop = false;
            this.groupBoxBiens.Text = "Afficher les biens";
            // 
            // UCListeBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBiens);
            this.Name = "UCListeBiens";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(507, 326);
            this.groupBoxBiens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxBiens;
        private System.Windows.Forms.GroupBox groupBoxBiens;
    }
}
