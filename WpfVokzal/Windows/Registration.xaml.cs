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
using WebVokzal.WebModels;
using WpfVokzal.Tools;

namespace WpfVokzal.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();           
        }

        private async void Save(object sender, RoutedEventArgs e)
        {
            
                var json = await HttpApi.Post("Users", "save", new User
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    PatronomycName = Patronomyc.Text,
                    Phone = long.Parse(PhoneNum.Text),                    
                    Login = Login.Text,
                    Password = Pass.Text,
                    RoleId = 4
                });
                User result = HttpApi.Deserialize<User>(json);
                
                
                    MessageBox.Show("Вы успешно зарегистрировались!");

                    MainWindow m = new MainWindow();
                    m.Show();
                   this.Close();
                
                       
        }
    }
}

