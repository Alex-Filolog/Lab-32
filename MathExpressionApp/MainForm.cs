using System;
using System.Windows.Forms;

namespace MathExpressionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ResultLabel.Text = "Результат:";
            DescriptionLabel.Text = "Формула: y = (√(x + 3) / z) + log_a(b)\n" +
                                    "где:\n" +
                                    "x - первое входное число (x+3 должно быть не отрицательным)\n" +
                                    "z - второе входное число (должно быть > 0)\n" +
                                    "a - основание логарифма (должно быть > 0 и не = 1)\n" +
                                    "b - число для логарифма (должно быть >0)";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Проверка на заполненность полей
                if (string.IsNullOrWhiteSpace(XTextBox.Text) ||
                    string.IsNullOrWhiteSpace(ZTextBox.Text) ||
                    string.IsNullOrWhiteSpace(ATextBox.Text) ||
                    string.IsNullOrWhiteSpace(BTextBox.Text))
                {
                    throw new ArgumentException("Все поля должны быть заполнены.");
                }
                //Проверка на корректность чисел
                if (!double.TryParse(XTextBox.Text, out double x) ||
                    !double.TryParse(ZTextBox.Text, out double z) ||
                    !double.TryParse(ATextBox.Text, out double a) ||
                    !double.TryParse(BTextBox.Text, out double b))
                {
                    throw new FormatException("Введите корректные числа.");
                }
                //Проверка значений входных параметров
                if (x + 3 < 0)
                    throw new ArgumentOutOfRangeException("x", "x + 3 должно быть не отрицательным.");
                if (z <= 0)
                    throw new ArgumentOutOfRangeException("z", "z должно быть больше 0.");
                if (a <= 0 || a == 1)
                    throw new ArgumentOutOfRangeException("a", "a должно быть больше 0 и не равно 1.");
                if (b <= 0)
                    throw new ArgumentOutOfRangeException("b", "b должно быть больше 0.");

                double sqrtPart = Math.Sqrt(x + 3); //Метод
                double logPart = Math.Log(b, a);
                double y = (sqrtPart / z) + logPart;

                ResultLabel.Text = $"Результат: {y}";

                CalculationDetailLabel.Text = $"Шаги вычисления:\n" +
                                               $"√(x + 3) = √({x} + 3) = {sqrtPart}\n" +
                                               $"log_a(b) = log_{a}({b}) = {logPart}\n" +
                                               $"y = ({sqrtPart} / {z}) + {logPart} = {y}";
            }
            catch (FormatException ex) //Попытка преобразования текста из полей ввода в числовые значения (символы, которые не являются числами)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex) //Проверка значений, которые выходят за допустимые границы
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex) //Не заполнено одно или несколько полей ввода
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) //Непредвиденные ошибки
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}