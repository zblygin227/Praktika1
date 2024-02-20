using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для RedSupplies.xaml
    /// </summary>
    public partial class RedSupplies : Window
    {
        AgencyEntities db = AgencyEntities.GetContext();
        supplies p1 = new supplies();
        public RedSupplies()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.supplies.Load();
            db.objects.Load();
            AggentIdCB.ItemsSource = db.supplies.Local.ToBindingList();
            AggentIdCB.DisplayMemberPath = "Aggentid";
            ClientIdCB.ItemsSource = db.supplies.Local.ToBindingList();
            ClientIdCB.DisplayMemberPath = "Clientid";
            ObjectCB.ItemsSource = db.objects.Local.ToBindingList();
            ObjectCB.DisplayMemberPath = "Id";
            p1 = db.supplies.Find(Data.Id);
            PriceTB.Text = Convert.ToString(p1.Price);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(PriceTB.Text, out int price); int.TryParse(AggentIdCB.Text, out int aggentId); int.TryParse(ClientIdCB.Text, out int cliendId); int.TryParse(ObjectCB.Text, out int objectId);
                if (price > 0 && aggentId > 0 && cliendId > 0 && objectId > 0)
                {
                    db.RedacteSupplies(Data.Id,price, aggentId, cliendId, objectId);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка данных, заполните все поля и попробуйте снова");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка данных, заполните все поля и попробуйте снова");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
