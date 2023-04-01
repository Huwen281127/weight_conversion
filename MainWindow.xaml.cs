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

namespace weight_conversion
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput; 
        double douOutput;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void caculateAnswer(int _kind, double _value)
        {
            
            if (_kind != 0)
                txtmg.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtgram.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtkilogram.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 3)
                txtmt.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 4)
                txtounce.Text = string.Format("{0:0.##########}", _value / 28349.523);
            if (_kind != 5)
                txtpound.Text = string.Format("{0:0.##########}", _value / 453592.37);
        }
        private void txtmg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtmg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput); // 事先將公尺轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtmg.Text = "";
            }
        }

        private void txtgram_TextChanged(object sender, TextChangedEventArgs e)
        {
            strInput = txtgram.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 1000); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtgram.Text = "";
            }
        }

        private void txtkilogram_TextChanged(object sender, TextChangedEventArgs e)
        {
            strInput = txtkilogram.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000000); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtkilogram.Text = "";
            }
        }

        private void txtmt_TextChanged(object sender, TextChangedEventArgs e)
        {
            strInput = txtmt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 1000000000); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtmt.Text = "";
            }
        }

        private void txtounce_TextChanged(object sender, TextChangedEventArgs e)
        {
            strInput = txtounce.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 28349.523); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtounce.Text = "";
            }
        }

        private void txtpound_TextChanged(object sender, TextChangedEventArgs e)
        {
            strInput = txtpound.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 453592.37); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtpound.Text = "";
            }
        }

        private void btnAllClear1_Click(object sender, RoutedEventArgs e)
        {
            txtmg.Text = "";
            txtgram.Text = "";
            txtkilogram.Text = "";
            txtmt.Text = "";
            txtounce.Text = "";
            txtpound.Text = "";
        }
    }
}
