using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba_4_n_1
{
    public partial class Form1 : Form
    {
        // Number of parameters (15)
        private const int COLS = 15;

        // Static 2D array [N,15]
        private string[,]? data;

        // List for easier filtering
        private List<Footballer> rows = [];

        // UI
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object? sender, EventArgs e)
        {
            try
            {
                var path = textBoxInput.Text.Trim();
                if (!File.Exists(path))
                {
                    MessageBox.Show($"File not found: {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var lines = File.ReadAllLines(path);
                rows = new List<Footballer>(lines.Length);

                foreach (var raw in lines)
                {
                    if (string.IsNullOrWhiteSpace(raw)) continue;
                    var parts = raw.Split(';');
                    if (parts.Length != COLS)
                        throw new InvalidDataException($"Line has {parts.Length} fields, expected {COLS}.\n\"{raw}\"");

                    rows.Add(Footballer.Parse(parts));
                }

                // Fill the static 2D array [N,15]
                data = new string[rows.Count, COLS];
                for (int i = 0; i < rows.Count; i++)
                {
                    var arr = rows[i].ToStringArray();
                    for (int j = 0; j < COLS; j++)
                        data[i, j] = arr[j];
                }

                // Show in DataGridView
                dataGridView1.DataSource = BuildDataTableFrom2D(data);
                labelStatus.Text = $"Loaded records: {rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFilter_Click(object? sender, EventArgs e)
        {
            if (rows.Count == 0)
            {
                MessageBox.Show("Please load data first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Filter: players with more than 50 games
            var filtered = rows.Where(r => r.Games > 50).ToList();

            // Update DataGridView
            var table = BuildDataTableFromList(filtered);
            dataGridView1.DataSource = table;

            // Write to file
            var outPath = textBoxOutput.Text.Trim();
            File.WriteAllLines(outPath, filtered.Select(f => string.Join(';', f.ToStringArray())));
            labelStatus.Text = $"Selected: {filtered.Count}. Written to file: {outPath}";
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.DataSource is not DataTable dt)
            {
                MessageBox.Show("No data to save.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var outPath = textBoxOutput.Text.Trim();
            var lines = new List<string>(dt.Rows.Count);

            foreach (DataRow r in dt.Rows)
            {
                var items = r.ItemArray.Select(x => x?.ToString() ?? string.Empty);
                lines.Add(string.Join(';', items));
            }

            File.WriteAllLines(outPath, lines);
            labelStatus.Text = $"Saved {lines.Count} rows to {outPath}";
        }

        // Convert static 2D array into DataTable
        private static DataTable BuildDataTableFrom2D(string[,] arr)
        {
            var dt = CreateHeader();

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                var obj = new object[cols];
                for (int j = 0; j < cols; j++)
                    obj[j] = arr[i, j];
                dt.Rows.Add(obj);
            }
            return dt;
        }

        // Build table from List
        private static DataTable BuildDataTableFromList(List<Footballer> list)
        {
            var dt = CreateHeader();
            foreach (var f in list)
                dt.Rows.Add(f.ToStringArray());
            return dt;
        }

        // Table headers
        private static DataTable CreateHeader()
        {
            var dt = new DataTable();
            dt.Columns.Add("Surname");
            dt.Columns.Add("Name");
            dt.Columns.Add("Patronymic");
            dt.Columns.Add("Nationality");
            dt.Columns.Add("Height(cm)");
            dt.Columns.Add("Weight(kg)");
            dt.Columns.Add("Year");
            dt.Columns.Add("Month");
            dt.Columns.Add("Day");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Team");
            dt.Columns.Add("No");
            dt.Columns.Add("Position");
            dt.Columns.Add("Goals");
            dt.Columns.Add("Games");
            return dt;
        }
    }

    // Footballer model
    public class Footballer
    {
        public string Surname { get; set; } = "";
        public string Name { get; set; } = "";
        public string Patronymic { get; set; } = "";
        public string Nationality { get; set; } = "";
        public int HeightCm { get; set; }
        public int WeightKg { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public string Phone { get; set; } = "";
        public string Team { get; set; } = "";
        public int Number { get; set; }
        public string Position { get; set; } = "";
        public int Goals { get; set; }
        public int Games { get; set; }

        public static Footballer Parse(string[] p)
        {
            return new Footballer
            {
                Surname = p[0].Trim(),
                Name = p[1].Trim(),
                Patronymic = p[2].Trim(),
                Nationality = p[3].Trim(),
                HeightCm = int.Parse(p[4], CultureInfo.InvariantCulture),
                WeightKg = int.Parse(p[5], CultureInfo.InvariantCulture),
                BirthYear = int.Parse(p[6], CultureInfo.InvariantCulture),
                BirthMonth = int.Parse(p[7], CultureInfo.InvariantCulture),
                BirthDay = int.Parse(p[8], CultureInfo.InvariantCulture),
                Phone = p[9].Trim(),
                Team = p[10].Trim(),
                Number = int.Parse(p[11], CultureInfo.InvariantCulture),
                Position = p[12].Trim(),
                Goals = int.Parse(p[13], CultureInfo.InvariantCulture),
                Games = int.Parse(p[14], CultureInfo.InvariantCulture)
            };
        }

        public string[] ToStringArray() =>
        [
            Surname, Name, Patronymic, Nationality,
            HeightCm.ToString(CultureInfo.InvariantCulture),
            WeightKg.ToString(CultureInfo.InvariantCulture),
            BirthYear.ToString(CultureInfo.InvariantCulture),
            BirthMonth.ToString(CultureInfo.InvariantCulture),
            BirthDay.ToString(CultureInfo.InvariantCulture),
            Phone, Team,
            Number.ToString(CultureInfo.InvariantCulture),
            Position,
            Goals.ToString(CultureInfo.InvariantCulture),
            Games.ToString(CultureInfo.InvariantCulture)
        ];
    }
}
