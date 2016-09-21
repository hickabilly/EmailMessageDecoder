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
using Microsoft.Win32;

using MsgReader;

namespace EmailMessageDecoder
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

        private void menu_Click(object sender,RoutedEventArgs e)
        {
            if (sender == menuExit)
            {
                MessageBoxResult messageboxExit = MessageBox.Show("Are you sure?", "Question", MessageBoxButton.OKCancel);
                if (messageboxExit == MessageBoxResult.OK)
                    Application.Current.Shutdown();
            }
            else if (sender == menuDisplaySource)
            {

            }
            else if (sender == menuDisplayAttachments)
            {

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           if (sender == buttonFileSelector)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "MSG|*.msg|EMAIL|*.eml|All files|*.*";
                if (fileDialog.ShowDialog() == true)
                {
                    textboxFilename.Text = fileDialog.FileName;
                    Uri uriFile = new Uri(fileDialog.FileName);
                    textboxFilename.Text = uriFile.ToString();                    
                }
            }
            else if (sender == buttonLoad)
            {

            }
        }       
    }
}
