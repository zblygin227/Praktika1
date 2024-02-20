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
    /// Логика взаимодействия для AddSupplies.xaml
    /// </summary>
    public partial class AddSupplies : Window
    {
        AgencyEntities db = AgencyEntities.GetContext();

        public AddSupplies()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.supplies.Load();
            db.agents.Load();
            db.clients.Load();
            db.objects.Load();
            AggentIdCB.ItemsSource = db.agents.Local.ToBindingList();
            AggentIdCB.DisplayMemberPath = "Id";
            ClientIdCB.ItemsSource = db.clients.Local.ToBindingList();
            ClientIdCB.DisplayMemberPath = "id";
            ObjectCB.ItemsSource = db.objects.Local.ToBindingList();
            ObjectCB.DisplayMemberPath = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int.TryParse(PriceTB.Text, out int price); int.TryParse(AggentIdCB.Text, out int aggentId); int.TryParse(ClientIdCB.Text, out int cliendId); int.TryParse(ObjectCB.Text, out int objectId);
                if (price > 0 && aggentId > 0 && cliendId > 0 && objectId > 0)
                {
                    db.AddSupplies(price, aggentId, cliendId,objectId);
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
    }
}
