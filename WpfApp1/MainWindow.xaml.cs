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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.Windows.Controls.Primitives;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        
        public MainWindow()
        {
            InitializeComponent();
        }
            
        private void Hinzufuegen(object sender, System.EventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
            this.Close();
            
        }
        private void Suchen(object sender, System.EventArgs e)
        {
            double cmv = double.Parse(cmvon.Text);
            double cmb = double.Parse(cmbis.Text);
            double pv = double.Parse(pvon.Text);
            double pb = double.Parse(pbis.Text);

            int counter = 0;
            StreamReader sr = new StreamReader("datei.txt");
            while (sr.ReadLine() != null)
            {
                counter++;
            }
            sr.Close();
            string[] sa = new string[counter];
            StreamReader ss = new StreamReader("datei.txt");
            for (int i = 0; i < counter; i++)
            {
                sa[i] = ss.ReadLine();
            }
            ss.Close();
            string[] st = new string[2];
            Stack<string> ms = new Stack<string>();
            for (int i = 0; i < sa.Length; i++)
            {


                st = sa[i].Split(';');
                double cm = double.Parse(st[0]);
                if (cm > cmv)
                {
                    if (cm < cmb)
                    {
                        double preis = double.Parse(st[1]);
                        if (preis > pv)
                        {
                            if (preis < pb)
                            {
                                ms.Push(sa[i]);
                            }
                        }
                    }
                }
                Stack<string> mss = ms;
                Window1 win1 = new Window1(mss);
                win1.Show();
                this.Close();



            }
        }
    }
}
