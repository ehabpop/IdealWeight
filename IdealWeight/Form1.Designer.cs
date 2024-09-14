
namespace IdealWeight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numericUpDownAge = new NumericUpDown();
            label2 = new Label();
            comboBoxGender = new ComboBox();
            label3 = new Label();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownWeight = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            textBoxBMI = new TextBox();
            label6 = new Label();
            comboBoxPhysicalActivityLevel = new ComboBox();
            buttonStart = new Button();
            textBoxPredict = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Age:";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownAge.Location = new Point(42, 40);
            numericUpDownAge.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(309, 33);
            numericUpDownAge.TabIndex = 1;
            numericUpDownAge.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(42, 79);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 0;
            label2.Text = "Gender:";
            label2.Click += label2_Click;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Segoe UI", 14F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(42, 110);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(309, 33);
            comboBoxGender.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(42, 149);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 0;
            label3.Text = "Height (cm):";
            label3.Click += label2_Click;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownHeight.Location = new Point(42, 180);
            numericUpDownHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(309, 33);
            numericUpDownHeight.TabIndex = 1;
            numericUpDownHeight.Value = new decimal(new int[] { 175, 0, 0, 0 });
            numericUpDownHeight.ValueChanged += numericUpDownHeight_ValueChanged;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownWeight.Location = new Point(42, 250);
            numericUpDownWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(309, 33);
            numericUpDownWeight.TabIndex = 1;
            numericUpDownWeight.Value = new decimal(new int[] { 75, 0, 0, 0 });
            numericUpDownWeight.ValueChanged += numericUpDownWeight_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(42, 219);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 0;
            label4.Text = "Weight (Kg):";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(42, 289);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 0;
            label5.Text = "BMI";
            label5.Click += label2_Click;
            // 
            // textBoxBMI
            // 
            textBoxBMI.Font = new Font("Segoe UI", 14F);
            textBoxBMI.Location = new Point(42, 320);
            textBoxBMI.Name = "textBoxBMI";
            textBoxBMI.ReadOnly = true;
            textBoxBMI.Size = new Size(309, 32);
            textBoxBMI.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(42, 358);
            label6.Name = "label6";
            label6.Size = new Size(243, 25);
            label6.TabIndex = 0;
            label6.Text = "Physical Activity Level (1-4):";
            label6.Click += label2_Click;
            // 
            // comboBoxPhysicalActivityLevel
            // 
            comboBoxPhysicalActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhysicalActivityLevel.Font = new Font("Segoe UI", 14F);
            comboBoxPhysicalActivityLevel.FormattingEnabled = true;
            comboBoxPhysicalActivityLevel.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxPhysicalActivityLevel.Location = new Point(42, 389);
            comboBoxPhysicalActivityLevel.Name = "comboBoxPhysicalActivityLevel";
            comboBoxPhysicalActivityLevel.Size = new Size(309, 33);
            comboBoxPhysicalActivityLevel.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonStart.Location = new Point(42, 428);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(308, 50);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxPredict
            // 
            textBoxPredict.Font = new Font("Segoe UI", 24F);
            textBoxPredict.ForeColor = SystemColors.Highlight;
            textBoxPredict.Location = new Point(42, 484);
            textBoxPredict.Name = "textBoxPredict";
            textBoxPredict.ReadOnly = true;
            textBoxPredict.Size = new Size(309, 50);
            textBoxPredict.TabIndex = 3;
            textBoxPredict.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 543);
            Controls.Add(buttonStart);
            Controls.Add(textBoxPredict);
            Controls.Add(textBoxBMI);
            Controls.Add(comboBoxPhysicalActivityLevel);
            Controls.Add(comboBoxGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDownWeight);
            Controls.Add(numericUpDownHeight);
            Controls.Add(label6);
            Controls.Add(numericUpDownAge);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ideal Weight";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownAge;
        private Label label2;
        private ComboBox comboBoxGender;
        private Label label3;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownWeight;
        private Label label4;
        private Label label5;
        private TextBox textBoxBMI;
        private Label label6;
        private ComboBox comboBoxPhysicalActivityLevel;
        private Button buttonStart;
        private TextBox textBoxPredict;
    }
}
