using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantsForm newForm = new RestaurantsForm();
            newForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string help = "View Rastaurants - вікриває список каталогів." +
                " В ньому реалізована можливіть додавання каталогу(Create new Restsaurant) та перегляд меню (View Menu).\n" +
                "View menu - показує список страв. Дані можна сортувати за різними полями, натиснувши на заголовок колонкию\n" +
                "Add dish - додавання страви. Вікриває діалог з полями для вводу. Поля валідуються за допомогою подій.\n" +
                "File Menu -  організовує роботу з файлами. Open File - вікриває файл. Read - зчитує дані з відкритого файлу (неактивна коли немає відкритого файлу)" +
                "Save - записує всі дані з таблиці ц вікритий файл. Save As - створює файл і записує з нього дані з таблиці\n" +
                "Filters - фільтрують дані. Search - викликає подію, що робить пошук за назвою страви. Cold - показує вибірку холодних страв(з температурою <= 20)." +
                "Heavy - показує вибірку важких страв(маса >= 300). Minimum price - слайдер, що встановлює мінімальну ціну.\n" +
                "Apply Discount - знижує на 20% ціну на усі гарячі страви(з температурою >= 40)";
            MessageBox.Show(help);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дюг Христина\nПМІ-23");
        }
    }
}
