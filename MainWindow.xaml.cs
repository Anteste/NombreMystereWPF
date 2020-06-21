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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NombreMystereWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            int pickedNum = PickANumber();
            //YouWin();
        }

        private void BtnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
  
        }

        void YouWin()
        {
            texteBlockInfo.Text = "Bravo !! Tu as gagné. ";
        }

        void NouvellePartie()
        {
            int randomed = GenereNombreAleatoire();

        }


         int PickANumber()
        {
            string picked = TextBoxEssai.Text;

            int pickedNum;
           bool isNumeric = int.TryParse(picked, out pickedNum);

            if (isNumeric == false)
            {
                texteBlockInfo.Text = "Oops Il ne s'agit pas d'un nombre. Essaie encore.";
            }
            else
            {
                texteBlockInfo.Text = String.Empty;
            }
            return pickedNum;


        }
    }
}
