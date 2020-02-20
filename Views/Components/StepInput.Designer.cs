namespace NoAutocar.Views.Components
{
    partial class StepInput
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
            this.cityInput = new System.Windows.Forms.TextBox();
            this.timeInput = new System.Windows.Forms.NumericUpDown();
            this.costInput = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costInput)).BeginInit();
            this.SuspendLayout();
            // 
            // cityInput
            // 
            this.cityInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cityInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cityInput.Location = new System.Drawing.Point(6, 7);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(156, 20);
            this.cityInput.TabIndex = 0;
            this.cityInput.TextChanged += new System.EventHandler(this.CityInput_TextChanged);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(168, 7);
            this.timeInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(71, 20);
            this.timeInput.TabIndex = 1;
            this.timeInput.ValueChanged += new System.EventHandler(this.TimeInput_ValueChanged);
            // 
            // costInput
            // 
            this.costInput.DecimalPlaces = 2;
            this.costInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.costInput.Location = new System.Drawing.Point(245, 7);
            this.costInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(68, 20);
            this.costInput.TabIndex = 2;
            this.costInput.ValueChanged += new System.EventHandler(this.CostInput_ValueChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(373, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(24, 24);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "x";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StepInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.cityInput);
            this.Name = "StepInput";
            this.Size = new System.Drawing.Size(400, 30);
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.NumericUpDown timeInput;
        private System.Windows.Forms.NumericUpDown costInput;
        private System.Windows.Forms.Button deleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
