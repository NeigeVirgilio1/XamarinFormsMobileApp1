using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallsPage : ContentPage
    {
        private List<Call> _calls = new List<Call>();

        public CallsPage()
        {
            InitializeComponent();
            MakeCall();
            BindingContext = this;
        }

        public List<Call> Call
        {
            get { return _calls; }
            set { _calls = value; }
        }



        private void MakeCall()
        {
            Call call = new Call();
            call.Name = "Sizwe";
            call.Seen = "17:07";

            Call.Add(call);


            call = new Call();
            call.Name = "Lwazi";
            call.Seen = "16:10";
            Call.Add(call);

            call = new Call();
            call.Name = "Peter";
            call.Seen = "16:03";
            Call.Add(call);


            call = new Call();
            call.Name = "Shaun";
            call.Seen = "16:00";
            Call.Add(call);


            call = new Call();
            call.Name = "Timothy";
            call.Seen = "15:00";
            Call.Add(call);



        }
    }
}
