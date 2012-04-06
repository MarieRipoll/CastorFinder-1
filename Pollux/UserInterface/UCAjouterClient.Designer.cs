namespace Pollux.UserInterface
{
    partial class UCAjouterClient
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
            this.groupBoxAjoutClient = new System.Windows.Forms.GroupBox();
            this.comboBoxVilles = new System.Windows.Forms.ComboBox();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.radioButtonSouhait = new System.Windows.Forms.RadioButton();
            this.radioButtonBien = new System.Windows.Forms.RadioButton();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBoxAjoutClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAjoutClient
            // 
            this.groupBoxAjoutClient.Controls.Add(this.comboBoxVilles);
            this.groupBoxAjoutClient.Controls.Add(this.comboBoxAgents);
            this.groupBoxAjoutClient.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjoutClient.Controls.Add(this.buttonCreer);
            this.groupBoxAjoutClient.Controls.Add(this.radioButtonSouhait);
            this.groupBoxAjoutClient.Controls.Add(this.radioButtonBien);
            this.groupBoxAjoutClient.Controls.Add(this.textBoxTelephone);
            this.groupBoxAjoutClient.Controls.Add(this.label23);
            this.groupBoxAjoutClient.Controls.Add(this.label24);
            this.groupBoxAjoutClient.Controls.Add(this.label21);
            this.groupBoxAjoutClient.Controls.Add(this.textBoxAdresse);
            this.groupBoxAjoutClient.Controls.Add(this.label20);
            this.groupBoxAjoutClient.Controls.Add(this.textBoxNom);
            this.groupBoxAjoutClient.Controls.Add(this.label19);
            this.groupBoxAjoutClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAjoutClient.Location = new System.Drawing.Point(0, 30);
            this.groupBoxAjoutClient.Name = "groupBoxAjoutClient";
            this.groupBoxAjoutClient.Size = new System.Drawing.Size(496, 249);
            this.groupBoxAjoutClient.TabIndex = 14;
            this.groupBoxAjoutClient.TabStop = false;
            this.groupBoxAjoutClient.Text = "Ajouter un client";
            // 
            // comboBoxVilles
            // 
            this.comboBoxVilles.FormattingEnabled = true;
            this.comboBoxVilles.Items.AddRange(new object[] {
            "Ajouter une ville..."});
            this.comboBoxVilles.Location = new System.Drawing.Point(107, 79);
            this.comboBoxVilles.Name = "comboBoxVilles";
            this.comboBoxVilles.Size = new System.Drawing.Size(288, 21);
            this.comboBoxVilles.TabIndex = 5;
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(244, 181);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAgents.TabIndex = 4;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(401, 182);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(401, 209);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(75, 23);
            this.buttonCreer.TabIndex = 3;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // radioButtonSouhait
            // 
            this.radioButtonSouhait.AutoSize = true;
            this.radioButtonSouhait.Location = new System.Drawing.Point(21, 182);
            this.radioButtonSouhait.Name = "radioButtonSouhait";
            this.radioButtonSouhait.Size = new System.Drawing.Size(110, 17);
            this.radioButtonSouhait.TabIndex = 2;
            this.radioButtonSouhait.TabStop = true;
            this.radioButtonSouhait.Text = "Ajouter un souhait";
            this.radioButtonSouhait.UseVisualStyleBackColor = true;
            // 
            // radioButtonBien
            // 
            this.radioButtonBien.AutoSize = true;
            this.radioButtonBien.Checked = true;
            this.radioButtonBien.Location = new System.Drawing.Point(21, 159);
            this.radioButtonBien.Name = "radioButtonBien";
            this.radioButtonBien.Size = new System.Drawing.Size(96, 17);
            this.radioButtonBien.TabIndex = 2;
            this.radioButtonBien.TabStop = true;
            this.radioButtonBien.Text = "Ajouter un bien";
            this.radioButtonBien.UseVisualStyleBackColor = true;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(107, 106);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(288, 20);
            this.textBoxTelephone.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Téléphone";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(146, 184);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Assigner un agent";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Ville";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(107, 54);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(288, 20);
            this.textBoxAdresse.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Adresse";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(107, 28);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(288, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nom";
            // 
            // UCAjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAjoutClient);
            this.Name = "UCAjouterClient";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(496, 279);
            this.groupBoxAjoutClient.ResumeLayout(false);
            this.groupBoxAjoutClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAjoutClient;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.RadioButton radioButtonSouhait;
        private System.Windows.Forms.RadioButton radioButtonBien;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxVilles;
    }
}
