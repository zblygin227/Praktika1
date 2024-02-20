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
    /// Логика взаимодействия для RedDemands.xaml
    /// </summary>
    public partial class RedDemands : Window
    {
        AgencyEntities db = AgencyEntities.GetContext();
        demands p1 = new demands();
        public RedDemands()
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
                    db.RedDemands(Data.Id,cliendId, aggentId, objectId, CityTB.Text, StreetTB.Text, HouseTB.Text, NumberTB.Text, minprice, maxprice);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.demands.Load();
            db.objects.Load();
            db.clients.Load();
            db.objects.Load();
            AggentIdCB.ItemsSource = db.agents.Local.ToBindingList();
            AggentIdCB.DisplayMemberPath = "Id";
            ClientIdCB.ItemsSource = db.clients.Local.ToBindingList();
            ClientIdCB.DisplayMemberPath = "id";
            ObjectCB.ItemsSource = db.objects.Local.ToBindingList();
            ObjectCB.DisplayMemberPath = "Id";
            p1 = db.demands.Find(Data.Id);
            CityTB.Text = p1.Address_City.ToString();
            StreetTB.Text = p1.Address_Street.ToString();
            HouseTB.Text = p1.Address_House.ToString();
            NumberTB.Text = p1.Address_Number.ToString();   
            MinPriceTB.Text = p1.MinPrice.ToString();
            MaxPriceTB.Text = p1.MaxPrice.ToString();

        }
    }
}
