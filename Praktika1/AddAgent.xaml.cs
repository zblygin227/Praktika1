using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для AddAgent.xaml
    /// </summary>
    public partial class AddAgent : Window
    {
        AgentyEntities db = AgentyEntities.GetContext();
        public AddAgent()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(ComissionTB.Text, out int comission);
                if ((NameTB.Text.Length > 0 && FamilyTB.Text.Length > 0 && LastNameTB.Text.Length > 0) && (comission >= 0 && comission < 101))
                {
                    db.AddAgent(NameTB.Text, FamilyTB.Text, LastNameTB.Text, comission);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Поле почта или телефон должны быть заполнены");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка !");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    

