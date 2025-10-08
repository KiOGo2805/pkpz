using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba_4_n_3
{
    public partial class Form1 : Form
    {
        private double num1, num2, result;
        private string operation = "";
        private readonly string inputFile = "InputData.txt";
        private readonly string outputFile = "OutputData.txt";
        private readonly string logFile = "SessionLog.txt";

        public Form1()
        {
            InitializeComponent();
            LogAction("Application started");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputFile))
                    throw new FileNotFoundException("Input file not found.");

                string content = File.ReadAllText(inputFile).Trim();
                if (string.IsNullOrEmpty(content))
                    throw new Exception("Input file is empty. Please enter data.");

                string[] parts = content.Split(';');
                if (parts.Length != 2)
                    throw new Exception("Invalid input format. Must be: num1;num2");

                num1 = double.Parse(parts[0]);
                num2 = double.Parse(parts[1]);

                txtNum1.Text = num1.ToString();
                txtNum2.Text = num2.ToString();

                LogAction("Imported input data");
                MessageBox.Show("Data imported successfully!", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LogAction($"Error during import: {ex.Message}");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = 0;

                if (rbAdd.Checked)
                    result = num1 + num2;
                else if (rbSub.Checked)
                    result = num1 - num2;
                else if (rbMul.Checked)
                    result = num1 * num2;
                else if (rbDiv.Checked)
                {
                    if (num2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    result = num1 / num2;
                }
                else if (rbPow.Checked)
                    result = Math.Pow(num1, num2);
                else
                {
                    MessageBox.Show("Please select an operation first.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string line = $"{num1} {operation} {num2}, Result: {result}";
                File.WriteAllText(outputFile, line);
                LogAction("Exported result to file");
                MessageBox.Show("Result saved to OutputData.txt", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LogAction($"Error during export: {ex.Message}");
            }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                operation = rb.Text;
                LogAction($"Selected operation '{operation}'");
            }
        }

        private void LogAction(string action)
        {
            File.AppendAllText(logFile, $"Action {DateTime.Now:HH:mm:ss}: {action}\n");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LogAction("Application closed");
            base.OnFormClosed(e);
        }
    }
}
