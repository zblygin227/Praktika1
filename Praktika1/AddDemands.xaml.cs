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
    /// Логика взаимодействия для AddDemands.xaml
    /// </summary>
    public partial class AddDemands : Window
    {
        AgentyEntities db = AgentyEntities.GetContext();
        public AddDemands()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(AggentIdCB.Text, out int aggentId); int.TryParse(ClientIdCB.Text, out int cliendId); int.TryParse(ObjectCB.Text, out int objectId); int.TryParse(MinPriceTB.Text, out int minprice); int.TryParse(MaxPriceTB.Text, out int maxprice);
                if (aggentId > 0 && cliendId > 0 && objectId > 0 && CityTB.Text.Length > 0 && StreetTB.Text.Length > 0 && HouseTB.Text.Length > 0 && NumberTB.Text.Length > 0 && minprice >= 0 && maxprice > minprice)
                {
                    db.AddDemands(cliendId, aggentId, objectId, CityTB.Text, StreetTB.Text, HouseTB.Text, NumberTB.Text, minprice, maxprice);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Сначала заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Сначала заполните все поля!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.demands.Load();

            db.clients.Load();
            db.type_objects.Load();
            AggentIdCB.ItemsSource = db.agents.Local.ToBindingList();
            AggentIdCB.DisplayMemberPath = "Id";
            ClientIdCB.ItemsSource = db.clients.Local.ToBindingList();
            ClientIdCB.DisplayMemberPath = "id";
            ObjectCB.ItemsSource = db.type_objects.Local.ToBindingList();
            ObjectCB.DisplayMemberPath = "Id";
        }
    }
}

    

