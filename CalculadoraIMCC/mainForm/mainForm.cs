
using CalculadoraIMC;


namespace mainForm
{


    public partial class mainForm : Form


    {
        private IMC imcCalculator;

        public mainForm()
        {
            InitializeComponent();
            imcCalculator = new IMC();
            imcCalculator.OnResultCalculated += ImcCalculator_OnResultCalculated;
            imcCalculator.OnErrorOccurred += ImcCalculator_OnErrorOccurred;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(weightTextBox.Text, out double weight) &&
                double.TryParse(tallTextBox.Text, out double height))
            {
                imcCalculator.CalculateIMC(weight, height);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
            }
        }

        private void ImcCalculator_OnResultCalculated(object sender, IMCResultEventArgs e)
        {
            ImccResultForm resultForm = new ImccResultForm(e.IMC);
            resultForm.Show();
        }
        private void ImcCalculator_OnErrorOccurred(object sender, string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

    }

}
