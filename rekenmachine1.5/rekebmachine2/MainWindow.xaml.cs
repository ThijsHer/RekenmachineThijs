using System.Windows;

namespace rekebmachine2
{
    <summary>
    Interaction logic for MainWindow.xaml
    </summary>
    public partial class MainWindow : Window
    {
        //getal 1 en 2 en de som
        long number1 = 0;
        long number2 = 0;
        string som = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        //knoppen
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 1;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                scherm.Text = number2.ToString();
            }
        }
       
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 2;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                number2 = (number2 * 10) + 2;
                scherm.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 3;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                scherm.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 4;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                scherm.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 5;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                scherm.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 6;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                scherm.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 7;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                scherm.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 8;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                scherm.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10) + 9;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                scherm.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 * 10);
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                scherm.Text = number2.ToString();
            }
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            som = "+";
            scherm.Text = "0";
        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            som = "-";
            scherm.Text = "0";
        }

        private void btnkeer_Click(object sender, RoutedEventArgs e)
        {
            som = "*";
            scherm.Text = "0";
        }

        private void btndeel_Click(object sender, RoutedEventArgs e)
        {
            som = "/";
            scherm.Text = "0";
        }

        private void btnis_Click(object sender, RoutedEventArgs e)
        {

            switch (som)
            {
                case "+":
                    scherm.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    scherm.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    scherm.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    scherm.Text = (number1 / number2).ToString();
                    break;
            }

        }

        private void btnce_Click(object sender, RoutedEventArgs e)
        {

            if (som == "")
            {
                number1 = 0;

            }
            else
            {
                number2 = 0;
            }
            scherm.Text = "0";
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            som = "";
            scherm.Text = "0";
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 = (number1 / 10);
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                scherm.Text = number2.ToString();
            }
        }

        private void btnplusmin_Click(object sender, RoutedEventArgs e)
        {
            if (som == "")
            {
                number1 *= -1;
                scherm.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                scherm.Text = number2.ToString();
            }
        }
    }
}
