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
using System.Windows.Shapes;

//add refrence to the interfaces(contracts) and presenters
using MVPTemplate.Views.Contracts;
using MVPTemplate.Presenters;

namespace MVPTemplate.Views
{
    /// <summary>
    /// Interaction logic for HelloWorld.xaml
    /// </summary>
    public partial class HelloWorld : Window, IHelloWorld //refrence the interface                                                                                                                          
    {
        public HelloWorld()
        {
            InitializeComponent();

            //initialize the presenter and call a function from the presenter
            Persenter = new HelloWorldPresenter(this);
            LoadText(this, EventArgs.Empty);
        }

        #region Class members
        //add the eventhandler
        public event EventHandler LoadText;
        public event EventHandler ChangeText;
        HelloWorldPresenter Persenter;
        #endregion

        public void SetText(string data)
        {
            Tim.Content = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeText(this, EventArgs.Empty);
        }
    }
}
