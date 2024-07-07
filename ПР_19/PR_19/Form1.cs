namespace PR_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculate()
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                double fourXY = 4 * x * y;
                double powerValue = Math.Pow(4, fourXY);
                double sinValue = Math.Sin(powerValue);
                double sinPowerValue = Math.Pow(sinValue, 0.4);
                double denominator = y - 0.8;
                double fraction = x / denominator;
                double innerExpression = y - fraction;
                double sqrtValue = Math.Sqrt(innerExpression);
                double logValue = Math.Log10(sqrtValue);
                double z = sinPowerValue + logValue;
                textBoxZ.Text = z.ToString();

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ошибка! Введите корректное значение! " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Введите корректное значение!" + ex.Message);
            }
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCalculate_Click(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxX.Clear();
            textBoxZ.Clear();
            textBoxY.Clear();
            labelArea1.Text = "";
            labelArea2.Text = "";
        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCalculate_Click(sender, e);
        }

        private void оСправкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
