namespace Pollux.UserInterface
{
    partial class UCClientsDe
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
            this.groupBoxClientsDe = new System.Windows.Forms.GroupBox();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxClientsDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientsDe
            // 
            this.groupBoxClientsDe.Controls.Add(this.comboBoxAgents);
            this.groupBoxClientsDe.Controls.Add(this.listBoxClients);
            this.groupBoxClientsDe.Controls.Add(this.label11);
            this.groupBoxClientsDe.Controls.Add(this.button1);
            this.groupBoxClientsDe.Controls.Add(this.button2);
            this.groupBoxClientsDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClientsDe.Location = new System.Drawing.Point(0, 30);
            this.groupBoxClientsDe.Name = "groupBoxClientsDe";
            this.groupBoxClientsDe.Size = new System.Drawing.Size(664, 277);
            this.groupBoxClientsDe.TabIndex = 8;
            this.groupBoxClientsDe.TabStop = false;
            this.groupBoxClientsDe.Text = "Afficher les clients de...";
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(59, 20);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(301, 21);
            this.comboBoxAgents.TabIndex = 9;
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(15, 55);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(461, 147);
            this.listBoxClients.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Agent :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ajouter une visite";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UCClientsDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxClientsDe);
            this.Name = "UCClientsDe";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(664, 307);
            this.groupBoxClientsDe.ResumeLayout(false);
            this.groupBoxClientsDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientsDe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxAgents;
    }
}
