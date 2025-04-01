using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialCalculator
{
    public partial class Form1 : Form
    {
        private delegate double MaterialCalculationDelegate(double length, double width, double height, double materialSize);
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(LengthRoom.Text) ||
                string.IsNullOrWhiteSpace(WidthRoom.Text) ||
                string.IsNullOrWhiteSpace(HieghtRoom.Text) ||
                string.IsNullOrWhiteSpace(MaterialSize.Text) )
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return false;
            }

            if (!double.TryParse(LengthRoom.Text, out _) ||
                !double.TryParse(WidthRoom.Text, out _) ||
                !double.TryParse(HieghtRoom.Text, out _) ||
                !double.TryParse(MaterialSize.Text, out _))
            {
                MessageBox.Show("Введите корректные числовые значения.");
                return false;
            }

            return true;
        }

        private void metr_Click(object sender, EventArgs e)
        {
                try
                {
                    double length = double.Parse(LengthRoom.Text);
                    double width = double.Parse(WidthRoom.Text);
                    double height = double.Parse(HieghtRoom.Text);
                    double materialSize = double.Parse(MaterialSize.Text);

                    string materialType = comboBoxMatirial.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(materialType))
                    {
                        MessageBox.Show("Пожалуйста, выберите тип материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    IMaterialCalculator calculator = MaterialCalculatorFactory.GetCalculator(materialType);

                    if (calculator != null)
                    {
                        MaterialCalculationDelegate calculationDelegate = calculator.CalculateMaterial;
                        double materialsNeeded = calculationDelegate(length, width, height, materialSize);

                        result.Text = $"{materialsNeeded}";
                    }
                }
            catch
            {
                MessageBox.Show("Новая ошибка", "Error", MessageBoxButtons.OK);
            }
            }


        private void feet_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isLengthValid = double.TryParse(LengthRoom.Text, out double length);
                bool isWidthValid = double.TryParse(WidthRoom.Text, out double width);
                bool isHeightValid = double.TryParse(HieghtRoom.Text, out double height);
                bool isMaterialSizeValid = double.TryParse(MaterialSize.Text, out double materialSize);

                if (!isLengthValid || !isWidthValid || !isHeightValid || !isMaterialSizeValid)
                {
                    MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string materialType = comboBoxMatirial.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(materialType))
                {
                    MessageBox.Show("Пожалуйста, выберите тип материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IMaterialCalculator calculator = MaterialCalculatorFactory.GetCalculator(materialType);

                if (calculator == null)
                {
                    MessageBox.Show("Неизвестный тип материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double materialsNeeded = calculator.CalculateMaterial(length, width, height, materialSize);

                double lengthFeet = length;
                double widthFeet = width;
                double heightFeet = height;
                double materialSizeFeet = materialSize;

                double materialsNeededFeet = calculator.CalculateMaterial(lengthFeet, widthFeet, heightFeet, materialSizeFeet);

                result.Text = $"{materialsNeededFeet * 10.764}";
            }
        }



        private void Lengthtxt_Click(object sender, EventArgs e)
        {

        }

        private void LengthRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WidthRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hieght_Click(object sender, EventArgs e)
        {

        }

        private void HieghtRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMatirial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
