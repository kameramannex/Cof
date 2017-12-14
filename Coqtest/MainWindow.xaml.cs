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

namespace Coqtest
{

    public class Dat
    {
        public Key[] keepkey = new Key[30];
        public int keepcount;
    }


    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string To_Tex(string str)
        {
            string texcmd = "aa";
            return texcmd;
        }

        public Dat dat;

        public string[] keepstrings = new string[1000];

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyDown(Key.Down) && e.KeyboardDevice.IsKeyDown(Key.LeftCtrl)) {
                //keepstrings = MainText.Text.Split('\n');
            }

        }
    }
}
