namespace NoAutocar.Views
{
    partial class FindTab
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
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxTimeInput = new System.Windows.Forms.NumericUpDown();
            this.maxCostInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.findBW = new System.ComponentModel.BackgroundWorker();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.resultsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.maxTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCostInput)).BeginInit();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromInput
            // 
            this.fromInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fromInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.fromInput.Location = new System.Drawing.Point(14, 182);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(100, 20);
            this.fromInput.TabIndex = 0;
            this.fromInput.Tag = "input";
            // 
            // toInput
            // 
            this.toInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toInput.Location = new System.Drawing.Point(120, 182);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(100, 20);
            this.toInput.TabIndex = 1;
            this.toInput.Tag = "input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Depuis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jusqu\'à";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temps max (min)";
            // 
            // maxTimeInput
            // 
            this.maxTimeInput.Location = new System.Drawing.Point(226, 182);
            this.maxTimeInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxTimeInput.Name = "maxTimeInput";
            this.maxTimeInput.Size = new System.Drawing.Size(99, 20);
            this.maxTimeInput.TabIndex = 6;
            this.maxTimeInput.Tag = "input";
            // 
            // maxCostInput
            // 
            this.maxCostInput.Location = new System.Drawing.Point(331, 182);
            this.maxCostInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxCostInput.Name = "maxCostInput";
            this.maxCostInput.Size = new System.Drawing.Size(78, 20);
            this.maxCostInput.TabIndex = 7;
            this.maxCostInput.Tag = "input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Coût max (€)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vos contraintes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nos solutions";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(415, 180);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Tag = "input";
            this.confirmButton.Text = "Go!";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // findBW
            // 
            this.findBW.WorkerReportsProgress = true;
            this.findBW.WorkerSupportsCancellation = true;
            this.findBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FindBW_DoWork);
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.resultsPanel);
            this.resultsBox.Location = new System.Drawing.Point(14, 252);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(470, 209);
            this.resultsBox.TabIndex = 13;
            this.resultsBox.TabStop = false;
            // 
            // resultsPanel
            // 
            this.resultsPanel.AutoScroll = true;
            this.resultsPanel.Location = new System.Drawing.Point(6, 13);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(458, 190);
            this.resultsPanel.TabIndex = 0;
            // 
            // FindTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxCostInput);
            this.Controls.Add(this.maxTimeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindTab";
            this.Text = "FindTab";
            ((System.ComponentModel.ISupportInitialize)(this.maxTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCostInput)).EndInit();
            this.resultsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxTimeInput;
        private System.Windows.Forms.NumericUpDown maxCostInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirmButton;
        private System.ComponentModel.BackgroundWorker findBW;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Panel resultsPanel;
    }
}