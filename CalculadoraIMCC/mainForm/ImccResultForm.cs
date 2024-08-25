using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm
{
    public partial class ImccResultForm : Form
    {
        public ImccResultForm(double imc)
        {
            InitializeComponent();
            DisplayIMCResult(imc);
        }

        private void DisplayIMCResult(double imc)
        {
            resultLabel.Text = $"IMC: {imc:F1} - Estado: {GetIMCStatus(imc)}";
        }


        private string GetIMCStatus(double imc)
        {
            if (imc < 18.5) return "Bajo peso";
            if (imc < 24.9) return "Normal";
            if (imc < 29.9) return "Sobrepeso";
            return "Obesidad";
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}


