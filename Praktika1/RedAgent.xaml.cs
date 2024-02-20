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
    /// Логика взаимодействия для RedAgent.xaml
    /// </summary>
    public partial class RedAgent : Window
    {
        AgentyEntities db = AgentyEntities.GetContext();
        agent p1 = new agent();
        public RedAgent()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(ComissionTB.Text, out int comission);
                if ((NameTB.Text.Length > 0 && FamilyTB.Text.Length > 0 && LastNameTB.Text.Length > 0) && (comission >= 0 && comission < 101))
                {
                    db.RedacteAgent(Data.Id, NameTB.Text, FamilyTB.Text, LastNameTB.Text, comission);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Поля Имя, Фамилия, Отчество должны быть заполненым, комиссия должна быть указана в диапозоне от 0 до 100");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка !");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.agents.Find(Data.Id);
            NameTB.Text = p1.FirstName;
            FamilyTB.Text = p1.MiddleName;
            LastNameTB.Text = p1.LastName;
            ComissionTB.Text = Convert.ToString(p1.DealShare);
        }
    }
}

    
    

