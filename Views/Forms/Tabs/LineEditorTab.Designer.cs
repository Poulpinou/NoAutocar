namespace NoAutocar.Views
{
    partial class LineEditorTab
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
            this.components = new System.ComponentModel.Container();
            this.lineNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startCityInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endCityInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.baseTimeInput = new System.Windows.Forms.NumericUpDown();
            this.baseCostInput = new System.Windows.Forms.NumericUpDown();
            this.oneWayInput = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepsPanel = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newStepButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baseTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCostInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineNameInput
            // 
            this.lineNameInput.Location = new System.Drawing.Point(16, 32);
            this.lineNameInput.Name = "lineNameInput";
            this.lineNameInput.Size = new System.Drawing.Size(364, 20);
            this.lineNameInput.TabIndex = 1;
            this.lineNameInput.TextChanged += new System.EventHandler(this.LineNameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de la ligne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ville de départ";
            // 
            // startCityInput
            // 
            this.startCityInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startCityInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.startCityInput.Location = new System.Drawing.Point(16, 77);
            this.startCityInput.Name = "startCityInput";
            this.startCityInput.Size = new System.Drawing.Size(214, 20);
            this.startCityInput.TabIndex = 3;
            this.startCityInput.TextChanged += new System.EventHandler(this.StartCityInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville d\'arrivée";
            // 
            // endCityInput
            // 
            this.endCityInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.endCityInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.endCityInput.Location = new System.Drawing.Point(249, 77);
            this.endCityInput.Name = "endCityInput";
            this.endCityInput.Size = new System.Drawing.Size(218, 20);
            this.endCityInput.TabIndex = 5;
            this.endCityInput.TextChanged += new System.EventHandler(this.EndCityInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temps de trajet (min)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Coût du trajet (€)";
            // 
            // baseTimeInput
            // 
            this.baseTimeInput.Location = new System.Drawing.Point(17, 123);
            this.baseTimeInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.baseTimeInput.Name = "baseTimeInput";
            this.baseTimeInput.Size = new System.Drawing.Size(213, 20);
            this.baseTimeInput.TabIndex = 9;
            this.baseTimeInput.ValueChanged += new System.EventHandler(this.BaseTimeInput_ValueChanged);
            // 
            // baseCostInput
            // 
            this.baseCostInput.DecimalPlaces = 2;
            this.baseCostInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.baseCostInput.Location = new System.Drawing.Point(249, 123);
            this.baseCostInput.Name = "baseCostInput";
            this.baseCostInput.Size = new System.Drawing.Size(218, 20);
            this.baseCostInput.TabIndex = 10;
            this.baseCostInput.ValueChanged += new System.EventHandler(this.BaseCostInput_ValueChanged);
            // 
            // oneWayInput
            // 
            this.oneWayInput.AutoSize = true;
            this.oneWayInput.Location = new System.Drawing.Point(386, 34);
            this.oneWayInput.Name = "oneWayInput";
            this.oneWayInput.Size = new System.Drawing.Size(84, 17);
            this.oneWayInput.TabIndex = 11;
            this.oneWayInput.Text = "Aller simple?";
            this.oneWayInput.UseVisualStyleBackColor = true;
            this.oneWayInput.CheckedChanged += new System.EventHandler(this.OneWayInput_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Etapes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepsPanel);
            this.groupBox1.Location = new System.Drawing.Point(18, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 224);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // stepsPanel
            // 
            this.stepsPanel.AutoScroll = true;
            this.stepsPanel.Location = new System.Drawing.Point(6, 13);
            this.stepsPanel.Name = "stepsPanel";
            this.stepsPanel.Size = new System.Drawing.Size(438, 205);
            this.stepsPanel.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(363, 399);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(99, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Créer";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(258, 399);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Réinitialiser";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // newStepButton
            // 
            this.newStepButton.Location = new System.Drawing.Point(18, 399);
            this.newStepButton.Name = "newStepButton";
            this.newStepButton.Size = new System.Drawing.Size(128, 23);
            this.newStepButton.TabIndex = 15;
            this.newStepButton.Text = "Nouvelle étape";
            this.newStepButton.UseVisualStyleBackColor = true;
            this.newStepButton.Click += new System.EventHandler(this.NewStepButton_Click);
            // 
            // LineEditorTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 434);
            this.Controls.Add(this.newStepButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oneWayInput);
            this.Controls.Add(this.baseCostInput);
            this.Controls.Add(this.baseTimeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endCityInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startCityInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LineEditorTab";
            this.Text = "NewLineTab";
            ((System.ComponentModel.ISupportInitialize)(this.baseTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCostInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lineNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startCityInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endCityInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown baseTimeInput;
        private System.Windows.Forms.NumericUpDown baseCostInput;
        private System.Windows.Forms.CheckBox oneWayInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel stepsPanel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button newStepButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}