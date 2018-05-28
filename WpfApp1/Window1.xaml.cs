
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
using System.Windows.Shapes;

namespace WpfApp1
{
    
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Stack<string> ms = new Stack<string>();
        public Window1(Stack<string> mss)
        {
            InitializeComponent();
            ms = mss;
        }
        private void Button1_Click(object sender, EventArgs e)
        {


            txtEditor.Text = ms.Pop();

        }
    }
}
