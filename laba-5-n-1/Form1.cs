using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace laba_5_n_1
{
    public partial class Form1 : Form
    {
        private Building building;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            building = new Building
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Floors = int.Parse(txtFloors.Text),
                Height = double.Parse(txtHeight.Text),
                YearBuilt = int.Parse(txtYearBuilt.Text),
                Purpose = txtPurpose.Text,
                HasParking = chkParking.Checked
            };

            MessageBox.Show("�ᒺ�� ��������!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (building != null)
                txtOutput.Text = building.GetBuildingInfo();
            else
                MessageBox.Show("�������� ������� ������!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (building != null)
            {
                building.SaveToFile("BuildingInfo.txt");
                MessageBox.Show("��� ��������� � BuildingInfo.txt");
            }
            else
                MessageBox.Show("�������� ������� ������!");
        }
    }
}
