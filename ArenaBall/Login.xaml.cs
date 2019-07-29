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
using System.Data;
using System.Data.SqlClient;

namespace ArenaBall
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Logik b = new Logik();
        
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                bool login = b.Login(Username.Text, Password.Password);
                if (login == true)
                {
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong Login");
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

    }
}
