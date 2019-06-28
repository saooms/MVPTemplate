using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPTemplate.Models;
using MVPTemplate.Views.Contracts;

namespace MVPTemplate.Presenters
{
    public class HelloWorldPresenter
    { 
        IHelloWorld view;
        public HelloWorldPresenter(IHelloWorld _view)
        {
            //set the view
            view = _view;

            //listen to calls
            view.LoadText += View_LoadText;
            view.ChangeText += View_ChangeText;
        }

        void View_LoadText(object sender, EventArgs e)
        {
            //get the data from the model and sent it back to the method(s) you want to execute
            view.SetText(HelloWorldModel.DBData() + " It sure is a nice day.");
        }

        void View_ChangeText(object sender, EventArgs e)
        {
            view.SetText("diffrent text");
        }
    }
}
