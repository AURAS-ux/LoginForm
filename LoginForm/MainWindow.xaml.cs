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
using System.Xml;
using System.Diagnostics;

namespace LoginForm
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
           this.WindowState = WindowState.Minimized;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            login();
        }
        
        void login()
        {
            //XmlWriter xmlWrite = XmlWriter.Create("test.xml");
            //xmlWrite.WriteStartDocument();
            //xmlWrite.WriteStartElement("user");
            //xmlWrite.WriteAttributeString("username", usernameField.Text);
            //xmlWrite.WriteAttributeString("password", passwordField.Password);
            //xmlWrite.WriteEndElement();
            //xmlWrite.WriteEndDocument();
            //xmlWrite.Close();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("D:\\c#\\LoginForm\\LoginForm\\ImpFiles\\test.xml");
            XmlNodeList usernameList = xmlDocument.GetElementsByTagName("username");
            XmlNodeList passwordList = xmlDocument.GetElementsByTagName("password"); 
            foreach(XmlNode username in usernameList)
            {
                if (username.InnerText == usernameField.Text)
                {
                    MessageBox.Show("Logged it");
                    break;
                }
                else
                {
                    erroeLabel.Text = "Username or password incorrect!";
                    usernameField.Clear();
                    passwordField.Clear();
                    break;
                }
            }
        }

        private void facebookContact_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.facebook.com/RickAstley") { UseShellExecute = true});
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
