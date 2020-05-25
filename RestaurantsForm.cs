using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class RestaurantsForm : Form
    {
        DishContext db;
        public int curId = 0;
        public RestaurantsForm()
        {
            InitializeComponent();

            db = new DishContext();
            db.Restaurants.Load();

            dataGridView1.DataSource = db.Restaurants.Local.ToBindingList();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(OnCellClick);
           
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
            }
            
        }

        void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            curId = 0;
            EditButton.Enabled = false;
        }

        private void RestaurantsForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private static string Dialog(string val = "")
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Create new restaurant",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Name: " };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 , Text = val};
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Dialog();
            if(!string.IsNullOrEmpty(name))
            {
                Restaurant r = new Restaurant(name);
                db.Restaurants.Add(r);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DishForm newForm = new DishForm(curId);
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
