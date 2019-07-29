using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ArenaBall
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Logik logik = new Logik();
        bool selected1 = false;
        bool selected2 = false;
        DragonballCharacter char1;
        DragonballCharacter char2;
        public GameWindow()
        {
            InitializeComponent();
            string[] names = logik.DbzArray();
            foreach (string item in names)
            {
                boxContainer.Items.Add(item);
                boxContainer2.Items.Add(item);
            }
            
        }

        private void BoxContainer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Player 1 info
            char1 = logik.CreateDragonballChar(boxContainer.SelectedValue.ToString());
            labelName.Content = "Name: " + char1.CharName;
            labelPowerLevel.Content = "Power Level: " + char1.PowerLevel;
            labelHealth.Content = "Health: " + char1.Health;
            labelEnergy.Content = "Energy: " + char1.Energy;

            // Set the Image with the Bitmap
            labelmg.Source = logik.ConvertByteArrayToBitmap(char1.Img);
            selected1 = true;

        }

        private void BoxContainer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Player 2 info
            char2 = logik.CreateDragonballChar(boxContainer2.SelectedValue.ToString());
            labelName2.Content = "Name: " + char2.CharName;
            labelPowerLevel2.Content = "Power Level: " + char2.PowerLevel;
            labelHealth2.Content = "Health: " + char2.Health;
            labelEnergy2.Content = "Energy: " + char2.Energy;

            labelmg2.Source = logik.ConvertByteArrayToBitmap(char2.Img);
            selected2 = true;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (selected1 && selected2 == true)
            {
                if (logik.ConfirmSelection(checkBox.IsChecked, checkBox2.IsChecked) == true)
                {
                    logik.PlayerSelection(char1.CharName, char2.CharName);
                    this.Close();
                }
            }
        }
    }
}
