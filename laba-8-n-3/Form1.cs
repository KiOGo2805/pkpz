namespace laba_8_n_3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string Developer, int Year, string Models)> carDatabase;

        public Form1()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            carDatabase = CarData.GetData();

            cmbBrands.Items.Add("--- Оберіть марку ---");
            foreach (var brand in carDatabase.Keys)
            {
                cmbBrands.Items.Add(brand);
            }
            cmbBrands.SelectedIndex = 0;

            btnContinue.Visible = false;
            btnExit.Visible = false;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string selectedBrand = cmbBrands.SelectedItem.ToString();
            string output;
            switch (selectedBrand)
            {
                case "BMW":
                case "Mazda":
                case "Mercedes-Benz":
                case "Opel":
                case "Skoda":
                case "Toyota":
                case "Volkswagen":
                    var (Developer, Year, Models) = carDatabase[selectedBrand];
                    output = $"Розробник: {Developer}{Environment.NewLine}" +
                             $"Рік заснування: {Year}{Environment.NewLine}" +
                             $"Моделі: {Models}";
                    break;

                default:
                    output = "Будь ласка, оберіть коректну марку зі списку.";
                    break;
            }

            txtOutput.Text = output;

            btnContinue.Visible = true;
            btnExit.Visible = true;
            btnGetInfo.Enabled = false;
            cmbBrands.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            cmbBrands.SelectedIndex = 0;

            btnContinue.Visible = false;
            btnExit.Visible = false;
            btnGetInfo.Enabled = true;
            cmbBrands.Enabled = true;
            cmbBrands.DroppedDown = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}