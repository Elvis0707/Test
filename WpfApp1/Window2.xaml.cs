using System;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Hinzufuegen(object sender, System.EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter("datei.txt");
            sw.WriteLine(cm.Text + ";" + preis.Text);
            sw.Close();

        }
        private void Zurueck(object sender, System.EventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();

        }
    }
}
