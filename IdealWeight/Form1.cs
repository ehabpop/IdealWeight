namespace IdealWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CalBMI();
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Age = (float)numericUpDownAge.Value,
                Gender = comboBoxGender.SelectedItem.ToString(),
                Height = (float)numericUpDownHeight.Value,
                Weight = (float)numericUpDownWeight.Value,
                BMI = (float)Convert.ToDecimal(textBoxBMI.Text),
                PhysicalActivityLevel = (float)Convert.ToDecimal(comboBoxPhysicalActivityLevel.SelectedItem),
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            textBoxPredict.Text = result.PredictedLabel;
        }
        private void CalBMI()
        {
            var Weight = numericUpDownWeight.Value;
            var Height = numericUpDownHeight.Value / 100;

            textBoxBMI.Text = (Weight / (Height * Height)).ToString();
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            CalBMI();
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            CalBMI();
        }
    }
}
