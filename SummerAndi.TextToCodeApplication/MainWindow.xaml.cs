using SummerAndi.TextToCodeLogic.Patterns;
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

namespace SummerAndi.TextToCodeApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IReplacePattern m_Pattern;

        public MainWindow()
        {
            InitializeComponent();
            m_Pattern = new SummerAndi.TextToCodeLogic.Patterns.TextReplaceMutliLine();
            m_Pattern.NewLinePattern = "\r";
        }

        private void tfLeft_KeyUp(object sender, KeyEventArgs e)
        {
            Referesh();
        }

        private void Referesh()
        {
            var ret = m_Pattern.Convert(tfRight.Text, tfLeft.Text);
            this.tfErgebnis.Text = ret;
        }

        private void tfRight_KeyUp(object sender, KeyEventArgs e)
        {
            Referesh();
        }
    }
}
