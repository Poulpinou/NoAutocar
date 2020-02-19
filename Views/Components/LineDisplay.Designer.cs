namespace NoAutocar.Views.Components
{
    partial class LineDisplay
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
            this.lineNameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.oneWayLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.stepsContainer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lineNameLabel
            // 
            this.lineNameLabel.AutoSize = true;
            this.lineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNameLabel.Location = new System.Drawing.Point(3, 0);
            this.lineNameLabel.Name = "lineNameLabel";
            this.lineNameLabel.Size = new System.Drawing.Size(93, 26);
            this.lineNameLabel.TabIndex = 0;
            this.lineNameLabel.Text = "Line #X";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(88, 69);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(40, 13);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "42.00€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coût initial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Durée initiale :";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(224, 69);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(38, 13);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "52 min";
            // 
            // oneWayLabel
            // 
            this.oneWayLabel.AutoSize = true;
            this.oneWayLabel.Location = new System.Drawing.Point(422, 13);
            this.oneWayLabel.Name = "oneWayLabel";
            this.oneWayLabel.Size = new System.Drawing.Size(21, 13);
            this.oneWayLabel.TabIndex = 9;
            this.oneWayLabel.Text = "oui";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aller simple : ";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(368, 64);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(287, 64);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Editer";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // stepsContainer
            // 
            this.stepsContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsContainer.Location = new System.Drawing.Point(3, 32);
            this.stepsContainer.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.stepsContainer.Name = "stepsContainer";
            this.stepsContainer.Size = new System.Drawing.Size(444, 26);
            this.stepsContainer.TabIndex = 14;
            this.stepsContainer.TabStop = false;
            this.stepsContainer.Visible = false;
            // 
            // LineDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stepsContainer);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.oneWayLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.lineNameLabel);
            this.Name = "LineDisplay";
            this.Size = new System.Drawing.Size(450, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lineNameLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label oneWayLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox stepsContainer;
    }
}
