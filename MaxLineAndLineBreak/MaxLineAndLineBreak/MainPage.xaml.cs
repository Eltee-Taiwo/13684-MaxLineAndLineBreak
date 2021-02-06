using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaxLineAndLineBreak
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new List<string>
            {
                "Short Text",
                "This is some medium text on the page",
                "This is extremely long text on the page. I don't know why I'm typing this out when I could just copy some dummy text from somewhere."
            };
        }
    }
}
