using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace laba_9_n_1
{
    public partial class Form1 : Form
    {
        private const string FileL1_Input = "L1.txt";
        private const string FileL2_Input = "L2.txt";
        private const string FileL1_Output = "L1_modified.txt";

        public Form1()
        {
            InitializeComponent();
            btnShowSavedFile.Enabled = false;
        }

        private void btnProcessAndSave_Click(object sender, EventArgs e)
        {
            try
            {
                string inputL1 = txtInputL1.Text.Trim();
                string inputL2 = txtInputL2.Text.Trim();

                if (string.IsNullOrEmpty(inputL1) || string.IsNullOrEmpty(inputL2))
                {
                    MessageBox.Show("Обидва списки (L1 та L2) мають бути заповнені.", "Порожні дані");
                    return;
                }

                File.WriteAllText(FileL1_Input, inputL1);
                File.WriteAllText(FileL2_Input, inputL2);

                List<string> list1 = File.ReadAllLines(FileL1_Input).ToList();
                List<string> list2 = File.ReadAllLines(FileL2_Input).ToList();

                var wordsInL2 = new HashSet<string>(list2);
                List<string> modifiedList1 = list1
                    .Where(word => !wordsInL2.Contains(word))
                    .ToList();

                //DisplayList(lstResult, modifiedList1, "Результат (L1 Модифікований)");

                SaveResultToFile(modifiedList1);

                MessageBox.Show($"Дані оброблено та результат збережено у файл '{FileL1_Output}'.", "Успіх");
                btnShowSavedFile.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася непередбачена помилка: {ex.Message}", "Помилка");
            }
        }

        private void btnShowSavedFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FileL1_Output))
                {
                    MessageBox.Show($"Файл '{FileL1_Output}' ще не створено.", "Помилка");
                    return;
                }

                string fileContent = File.ReadAllText(FileL1_Output);

                lstResult.Items.Clear();
                lstResult.Items.Add($"--- Вміст файлу '{FileL1_Output}' ---");
                lstResult.Items.AddRange(fileContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося прочитати файл: {ex.Message}", "Помилка читання");
            }
        }

        private void SaveResultToFile(List<string> listToSave)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listToSave.Count; i++)
            {
                sb.Append(listToSave[i] + " ");
                if ((i + 1) % 4 == 0)
                {
                    sb.AppendLine();
                }
            }
            File.WriteAllText(FileL1_Output, sb.ToString().Trim());
        }

        private void DisplayList(ListBox listBox, List<string> list, string title)
        {
            listBox.Items.Clear();
            listBox.Items.Add($"--- {title} ({list.Count} шт.) ---");
            if (list.Count == 0)
            {
                listBox.Items.Add("Список порожній.");
            }
            foreach (var item in list)
            {
                listBox.Items.Add(item);
            }
        }
    }
}