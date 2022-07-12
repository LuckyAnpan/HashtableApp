using System;
using System.Collections;
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

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add
            //hashtable.Add("Bow", "Pimpawan");
            //hashtable.Add("Anpan", "Wanichakul");
            //hashtable.Add("Ky", "Lucky");
            //hashtable.Add("AA", "AAAAA");

            hashtable.Add(txtKey.Text, txtValue.Text);

            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            //hashtable.Remove("AA");

            hashtable.Remove(txtKey.Text);

            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //Show
            ICollection icollection = hashtable.Keys;
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
