using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsMobileApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatusPage : ContentPage
    {
        private List<Status> _status = new List<Status>();

        public StatusPage()
        {
            InitializeComponent();
            CreateStatus();
            BindingContext = this;
        }

        public List<Status> Status
        {
            get { return _status; }
            set { _status = value; }
        }



        private void CreateStatus()
        {
            Status status = new Status();
            status.Name = "Sizwe";
            status.Seen = "Now";

            Status.Add(status);


            status = new Status();
            status.Name = "Lwazi";
            status.Seen = "1 minutes ago";
            Status.Add(status);

            status = new Status();
            status.Name = "Peter";
            status.Seen = "2 minutes ago";
            Status.Add(status);


            status = new Status();
            status.Name = "Shaun";
            status.Seen = "1 hour ago";
            Status.Add(status);


            status = new Status();
            status.Name = "Timothy";
            status.Seen = "Yesterday";
            Status.Add(status);



        }
    }
}
