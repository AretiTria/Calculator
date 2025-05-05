using System.Buffers;
using System.DirectoryServices;

namespace calculator
{
    public partial class Calculator : Form
    {

        Double resultValue = 0;
        String operations = "";
        Boolean operationPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Textbox.Text == "0") || operationPressed) { 
                Textbox.Clear();
            }
            operationPressed = false;

            Button button = (Button)sender;
            Textbox.Text += button.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operations = button.Text;
            resultValue = Double.Parse(Textbox.Text);
            operationPressed = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operations)
            {
                case "+":
                    Textbox.Text = (resultValue + Double.Parse(Textbox.Text)).ToString();
                    break;

                case "-":
                    Textbox.Text = (resultValue - Double.Parse(Textbox.Text)).ToString();
                    break;

                case "*":
                    Textbox.Text = (resultValue * Double.Parse(Textbox.Text)).ToString();
                    break;

                case "/":
                    Textbox.Text = (resultValue / Double.Parse(Textbox.Text)).ToString();
                    break;




            }
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            Textbox.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (Textbox.TextLength > 0)
            {
                Textbox.Text = Textbox.Text.Remove(Textbox.TextLength -1);
            }
        }
    }
}
