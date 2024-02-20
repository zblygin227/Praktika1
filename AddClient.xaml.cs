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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        AgencyEntities db = AgencyEntities.GetContext();

        public AddClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if(MailTB.Text.Length > 0 || PhoneTB.Text.Length>0) 
                {
                    db.AddClient(NameTB.Text, FamilyTB.Text, LastNameTB.Text, PhoneTB.Text, MailTB.Text);
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
