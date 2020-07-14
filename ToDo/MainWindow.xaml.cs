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

namespace ToDo
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
            var firstName = ((TextBox)this.FindName("txtFirstName")).Text;
            MessageBox.Show("Hello " + firstName);
        }
    }
    //update main window so that you can put in a title of your ToDO (USERINPUT take in), what you want to do (take in description), 
    //a submit button and when you click that button it gives you a pop-up "Created "title you had for it" "Created" + Title
    // enter title enter description then press button and button sends back what userinput was
    //push this up to git look up stuff about wpf 
}
