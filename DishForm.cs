using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class DishForm : Form
    {
        DishContext db;

        public int res_id;
        public int curId;
        private string path;
        private IEnumerable<Dish> dishes;
        private Validation Valid = new Validation();

        public DishForm(int r_id)
        {
            res_id = r_id;
            InitializeComponent();

            db = new DishContext();
            db.Dishes.Load();

            Restaurant restaurant = db.Restaurants.FirstOrDefault(r => r.Id == res_id);
            header.Text = restaurant.Name + " Menu";

            dishes = db.Dishes.Where(d => d.Restaurant_Id == res_id);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(OnCellClick);
            dataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_ColumnHeaderMouseClick);

        }

        void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cnt = 0, id = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value);
                cnt++;
            }
            if (cnt >= 1)
            {
                curId = id;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }

        }

        void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            curId = 0;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void UpdateDataGrid()
        {
            BindingSource source = new BindingSource();
            foreach (Dish d in dishes)
            {
                source.Add(d);
            }
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            string col = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            string order = " ASC";
            if (dataGridView1.Tag != null)
                order = dataGridView1.Tag.ToString().Contains(" ASC") ? " DESC" : " ASC";

            dataGridView1.Tag = col + order;

            if (order.Contains(" ASC"))
            {
                if(col == "Name") dishes = dishes.OrderBy(x => x.Name).ToList();
                if(col == "Weight") dishes = dishes.OrderBy(x => x.Weight).ToList();
                if(col == "Price") dishes = dishes.OrderBy(x => x.Price).ToList();
                if(col == "Temperature") dishes = dishes.OrderBy(x => x.Temperature).ToList();
            }
            else
            {
                if (col == "Name") dishes = dishes.OrderByDescending(x => x.Name).ToList();
                if (col == "Weight") dishes = dishes.OrderByDescending(x => x.Weight).ToList();
                if (col == "Price") dishes = dishes.OrderByDescending(x => x.Price).ToList();
                if (col == "Temperature") dishes = dishes.OrderByDescending(x => x.Temperature).ToList();
            }

            UpdateDataGrid();
        }

       

        private void DishForm_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Dish Dialog(string NameVal = "", string WeightVal = "", string TemperatureVal = "", string PriceVal = "")
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 350,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Add new dish",
                StartPosition = FormStartPosition.CenterScreen
            };

            bool okName = false, okWeight = false, okPrice = false, okTemp = false;

            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 270, Enabled = false, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            Label NameLabel = new Label() { Left = 50, Top = 30, Text = "Name: " };
            TextBox NameBox = new TextBox() { Left = 50, Top = 50, Width = 400, Text = NameVal };
            Label NameVarning = new Label() { Left = 50, Top = 70, Text = "", ForeColor = System.Drawing.Color.Red };
            NameBox.TextChanged += (sender, e) => {
                if(Valid.Name(NameBox.Text))
                {
                    okName = true;
                    if (okName & okPrice & okWeight & okTemp) confirmation.Enabled = true;
                    NameVarning.Text = "";
                }
                else
                {
                    okName = false;
                    NameVarning.Text = "Invalid Name";
                }
            };

            Label WeightLabel = new Label() { Left = 50, Top = 90, Text = "Weight: " };
            TextBox WeightBox = new TextBox() { Left = 50, Top = 110, Width = 800, Text = WeightVal };
            Label WeightVarning = new Label() { Left = 50, Top = 130, Text = "", ForeColor = System.Drawing.Color.Red };
            WeightBox.TextChanged += (sender, e) => {
                if (Valid.Number(WeightBox.Text))
                {
                    okWeight = true;
                    if (okName & okPrice & okWeight & okTemp) confirmation.Enabled = true;
                }
                else
                {
                    okWeight = false;
                    WeightVarning.Text = "Invalid Weight";
                }
            };

            Label TemperatureLabel = new Label() { Left = 50, Top = 150, Text = "Temperature: " };
            TextBox TemperatureBox = new TextBox() { Left = 50, Top = 170, Width = 800, Text = TemperatureVal };
            Label TVarning = new Label() { Left = 50, Top = 190, Text = "", ForeColor = System.Drawing.Color.Red };
            TemperatureBox.TextChanged += (sender, e) => {
                if (Valid.Number(TemperatureBox.Text))
                {
                    okTemp = true;
                    if (okName & okPrice & okWeight & okTemp) confirmation.Enabled = true;
                }
                else
                {
                    okTemp = false;
                    TVarning.Text = "Invalid Temperature";
                }
            };

            Label PriceLabel = new Label() { Left = 50, Top = 210, Text = "Price: " };
            TextBox PriceBox = new TextBox() { Left = 50, Top = 230, Width = 400, Text = PriceVal };
            Label PriceVarning = new Label() { Left = 50, Top = 250, Text = "", ForeColor = System.Drawing.Color.Red };
            PriceBox.TextChanged += (sender, e) => {
                if (Valid.Number(PriceBox.Text))
                {
                    okPrice = true;
                    if (okName & okPrice & okWeight & okTemp) confirmation.Enabled = true;
                }
                else
                {
                    okPrice = false;
                    PriceVarning.Text = "Invalid Price";
                }
            };


            prompt.Controls.Add(NameBox);
            prompt.Controls.Add(NameLabel);
            prompt.Controls.Add(NameVarning);

            prompt.Controls.Add(WeightBox);
            prompt.Controls.Add(WeightLabel);
            prompt.Controls.Add(WeightVarning);

            prompt.Controls.Add(TemperatureBox);
            prompt.Controls.Add(TemperatureLabel);
            prompt.Controls.Add(TVarning);

            prompt.Controls.Add(PriceBox);
            prompt.Controls.Add(PriceLabel);
            prompt.Controls.Add(PriceVarning);

            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;


            if(prompt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Dish d = new Dish(NameBox.Text, WeightBox.Text, TemperatureBox.Text, PriceBox.Text, res_id);
                    return d;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            
        }

        private void AddDishButton_Click(object sender, EventArgs e)
        {
            Dish d = Dialog();
            if(d == null)
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                db.Dishes.Add(d);
                db.SaveChanges();

                UpdateDataGrid();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Dish d = db.Dishes.FirstOrDefault(u => u.Id == curId);
            Dish newVal = Dialog(d.Name, d.Weight.ToString(), d.Temperature.ToString(), d.Price.ToString());
            d.Name = newVal.Name;
            d.Weight = newVal.Weight;
            d.Temperature = newVal.Temperature;
            d.Price = newVal.Price;

            db.Entry(d).State = EntityState.Modified;
            db.SaveChanges();

            UpdateDataGrid();
        }


        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Dish d = db.Dishes.FirstOrDefault(u => u.Id == curId);
                db.Dishes.Remove(d);
                db.SaveChanges();
                UpdateDataGrid();
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "C:\\Users\\christina\\source\\repos\\WindowsForms\\WindowsForms";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;

                    ReadButton.Enabled = true;
                    SaveButton.Enabled = true;
                }
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                try
                {
                    string[] lst = line.Split();
                    Dish d = new Dish(lst[0], lst[1], lst[2], lst[3], res_id);
                    db.Dishes.Add(d);
                    db.SaveChanges();
                }
                catch
                {
                    continue;
                }
            }
            UpdateDataGrid();
        }

        private string MakeRecord()
        {
            string output = "";
            IEnumerable<Dish> dishes = db.Dishes.Where(d => d.Restaurant_Id == res_id);
            foreach(Dish dish in dishes)
            {
                output += dish.ToString();
                output += '\n';
            }
            return output;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, MakeRecord());
        }

        private void SaveASButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, MakeRecord());
                
            }
        }

        private void Reset()
        {
            dishes = db.Dishes.Where(d => d.Restaurant_Id == res_id);
            UpdateDataGrid();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ColdCheck.Checked = false;
            HeavyCheck.Checked = false;
            trackBar1.Value = 0;
            Reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dishes = dishes.Where(d => d.Name.Contains(textBox1.Text));
            UpdateDataGrid();
        }

        private void ColdCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(ColdCheck.Checked)
            {
                dishes = dishes.Where(d => d.Temperature <= 20);
            }
            else
            {
                dishes = dishes.Where(d => d.Temperature <= 1000);
            }
            UpdateDataGrid();
        }

        private void HeavyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(HeavyCheck.Checked)
            {
                dishes = dishes.Where(d => d.Weight >= 300);
            }
            else
            {
                dishes = dishes.Where(d => d.Weight >= 0);
            }
            UpdateDataGrid();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            dishes = dishes.Where(d => d.Price >= trackBar1.Value);
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
            UpdateDataGrid();
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Dish> apply = db.Dishes.Where(d => d.Restaurant_Id == res_id && d.Temperature >= 40);
            foreach(Dish d in apply)
            {
                d.Price -= Convert.ToInt32(0.2 * d.Price);
                db.Entry(d).State = EntityState.Modified;
                
            }
            db.SaveChanges();
            UpdateDataGrid();
        }
    }
}
