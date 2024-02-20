using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AgentyEntities db = AgentyEntities.GetContext();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.clients.Load();
            db.agents.Load();
            db.supplies.Load();
            db.demands.Load();
            db.AgentsAlls.Load();
            db.ClientAlls.Load();
            ContentDG.ItemsSource = db.clients.Local.ToBindingList();
            ContentDG1.ItemsSource = db.agents.Local.ToBindingList();
            SuppliesDG.ItemsSource = db.supplies.Local.ToBindingList();
            DemandsDG.ItemsSource = db.demands.Local.ToBindingList();
            AgentsDG.ItemsSource = db.AgentsAlls.Local.ToBindingList();
            ClientsDG.ItemsSource = db.ClientAlls.Local.ToBindingList();
        }





        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddClient f = new AddClient();
            f.ShowDialog();
            ContentDG.Items.Refresh();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            int indexRow = ContentDG.SelectedIndex;
            if (ContentDG.SelectedIndex >= 0)
            {
                client row = (client)ContentDG.Items[indexRow];
                Data.Id = row.id;
                RedClient f = new RedClient();
                f.ShowDialog();
                ContentDG.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            int indexRow = ContentDG.SelectedIndex;
            if (ContentDG.SelectedIndex >= 0)
            {
                client row = (client)ContentDG.Items[indexRow];
                db.DelClient(row.id);
                MessageBox.Show("Запись  удалена!");
                ContentDG.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            AddAgent f = new AddAgent();
            f.ShowDialog();
            ContentDG1.Items.Refresh();

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            int indexRow = ContentDG1.SelectedIndex;
            if (ContentDG1.SelectedIndex >= 0)
            {
                agent row = (agent)ContentDG1.Items[indexRow];
                Data.Id = row.Id;
                RedAgent f = new RedAgent();
                f.ShowDialog();
                ContentDG1.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            int indexRow = ContentDG1.SelectedIndex;
            if (ContentDG1.SelectedIndex >= 0)
            {
                agent row = (agent)ContentDG1.Items[indexRow];
                db.DelAgent(row.Id);
                MessageBox.Show("Запись удалена!");
                ContentDG1.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
        }

        private void TabItem_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < ContentDG1.Items.Count; i++)
                {
                    var row = (agent)ContentDG1.Items[i];
                    string find = row.FirstName;
                    if (find.Contains(FamFinderTB.Text))
                    {
                        object item = ContentDG1.Items[i];
                        ContentDG1.SelectedItem = item;

                        break;
                    }
                }
            }
            catch
            {

            }
        }

        private void ContentDG1_MouseEnter(object sender, MouseEventArgs e)
        {

            db.agents.Load();
            ContentDG1.ItemsSource = db.agents.Local.ToBindingList();
            ContentDG1.Items.Refresh();
        }

        private void ContentDG_MouseEnter(object sender, MouseEventArgs e)
        {
            db.clients.Load();
            ContentDG.ItemsSource = db.clients.Local.ToBindingList();
            ContentDG.Items.Refresh();
        }

        private void FamilyFinderTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < ContentDG.Items.Count; i++)
                {
                    var row = (client)ContentDG.Items[i];
                    string find = row.FirstName;
                    if (find.Contains(FamilyFinderTB.Text))
                    {
                        object item = ContentDG.Items[i];
                        ContentDG.SelectedItem = item;

                        break;
                    }
                }
            }
            catch
            {

            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < ContentDG.Items.Count; i++)
                {
                    var row = (client)ContentDG.Items[i];
                    string find = row.Phone;
                    if (find.Contains(PhoneFinderTB.Text))
                    {
                        object item = ContentDG.Items[i];
                        ContentDG.SelectedItem = item;

                        break;
                    }
                }
            }
            catch
            {

            }
        }

        private void MailFinder_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < ContentDG.Items.Count; i++)
                {
                    var row = (client)ContentDG.Items[i];
                    string find = row.Email;
                    if (find.Contains(MailFinder.Text))
                    {
                        object item = ContentDG.Items[i];
                        ContentDG.SelectedItem = item;

                        break;
                    }
                }
            }
            catch
            {

            }
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            AddSupplies f = new AddSupplies();
            f.ShowDialog();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            int indexRow = SuppliesDG.SelectedIndex;
            if (SuppliesDG.SelectedIndex >= 0)
            {
                supply row = (supply)SuppliesDG.Items[indexRow];
                Data.Id = row.Id;
                RedSupplies f = new RedSupplies();
                f.ShowDialog();
                SuppliesDG.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            int indexRow = SuppliesDG.SelectedIndex;
            if (SuppliesDG.SelectedIndex >= 0)
            {
                supply row = (supply)SuppliesDG.Items[indexRow];
                db.DelSupplies(row.Id);
                MessageBox.Show("Запись  удалена!");
                ContentDG1.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            AddDemands f = new AddDemands();
            f.ShowDialog();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            int indexRow = DemandsDG.SelectedIndex;
            if (DemandsDG.SelectedIndex >= 0)
            {
                demand row = (demand)DemandsDG.Items[indexRow];
                Data.Id = row.Id;
                RedDemands f = new RedDemands();
                f.ShowDialog();


            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            int indexRow = DemandsDG.SelectedIndex;
            if (DemandsDG.SelectedIndex >= 0)
            {
                demand row = (demand)DemandsDG.Items[indexRow];
                db.DelDemands(row.Id);
                MessageBox.Show("Запись  удалена!");
                ContentDG1.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
        }
    }
}
    

