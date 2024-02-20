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
    /// Логика взаимодействия для RedClient.xaml
    /// </summary>
    public partial class RedClient : Window
    {
        AgencyEntities db = AgencyEntities.GetContext();
        client p1 =  new client();

        public RedClient()
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
                if (MailTB.Text.Length > 0 || PhoneTB.Text.Length > 0)
                {
                    db.RedacteClient(Data.Id,NameTB.Text, FamilyTB.Text, LastNameTB.Text, PhoneTB.Text, MailTB.Text);
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
                MessageBox.Show("Ошибка хз че делать, как ты так смог");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.clients.Find(Data.Id);
            NameTB.Text = p1.FirstName;
            FamilyTB.Text = p1.MiddleName;
            LastNameTB.Text = p1.LastName;
            PhoneTB.Text = p1.Phone;
            MailTB.Text = p1.Email;
        }
    }
}
