using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using TextBox = System.Windows.Controls.TextBox;
using WinForms = System.Windows.Forms;

namespace directory_scan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        WinForms.FolderBrowserDialog fbd = new WinForms.FolderBrowserDialog();
        
        string s_pathCatalogy;
        string s_nameFile;
        public MainWindow()
        {
            InitializeComponent();
            btn_Scan.IsEnabled = false;// Диактивация кнопки при старте приложения

        }

        public void ReadFileName()//Берем данные из текстбокс txtBox_FileName (имя файла) присваиваем  s_nameFile
        {
            if(txtBox_FileName.Text == "")
            {
                btn_Scan.IsEnabled = false;
            }
            else
            {     
                 s_nameFile = txtBox_FileName.Text;
            }
        }

        public void GetPath()//Берем данные о указанном каталоге и присваиваем s_pathCatalogy
        {
            var folderBrowser = new FolderBrowserDialog();

            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowser.SelectedPath);
                s_pathCatalogy = folderBrowser.SelectedPath;
            }
        }


        private void Scaning()//Сканирование каталога, берем все файлы которые там есть и сравниваем с названием файла который у нас в текстбоксе 
        {
            //string pathCatalogy = "D:\\Test";  
            //string nameFile = "test1";
            string nameFileinCatalogy = ("*" + s_nameFile + "*.*"); // "*test1*"; 

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(s_pathCatalogy);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(nameFileinCatalogy);         //("*" + filename + "*.*");

            foreach (FileInfo foundFile in filesInDir)
            {
                string fileName = foundFile.Name;
                
                string s_ExtensionFile = foundFile.Extension;

                if (foundFile.Name != null)
                {
                    if (fileName == s_nameFile + s_ExtensionFile)
                    {

                        txt_pathView.Foreground = Brushes.GreenYellow;

                        txt_pathView.Text = (fileName) + "\nFound successfully!";
                    }
                    else
                    {
                        txt_pathView.Foreground = Brushes.LightYellow;
                        txt_pathView.Text = "Not found \n search is in progress...";
                    }

                }
                else
                {
                    txt_pathView.Foreground = Brushes.LightYellow;
                    txt_pathView.Text = "Not found \n search is in progress...";
                }

            }
        }


        private void btn_Scan_Click(object sender, RoutedEventArgs e)//Нажатие на кнопку выполняются методы

        {
            ReadFileName();
            GetPath();
            Scaning();

        }
           
        private void txtBox_FileName_TextChanged(object sender, TextChangedEventArgs e)//Если в текстбокс (txtBox_FileName) нету значений кнопка(btn_Scan) не активна, иначе кнопка работает
        {
            if (txtBox_FileName.Text.Length>0)
            {
                btn_Scan.IsEnabled = true;
            }
            else
            {
                btn_Scan.IsEnabled = false;
            }
        }
    }
}
