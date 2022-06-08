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
using System.IO;
using Microsoft.Win32;

namespace Lab5EX1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Вытерите txt файл";
            dlg.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.ShowDialog();
            string file_name = dlg.FileName;
            if (!string.IsNullOrEmpty(file_name))
            {
                MessageBox.Show(file_name);
                string content = File.ReadAllText(file_name);
                this.textbox1.Text +=content;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Выберите txt файл";
            saveFileDialog.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, textbox1.Text);
        }
    }
}
