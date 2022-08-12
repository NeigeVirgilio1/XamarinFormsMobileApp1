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
    public partial class ChatsPage : ContentPage
    {

        private List<Chat> _chats = new List<Chat>();


        /*
         * 
         *   <ListView.ItemsSource>
                    <x:Array Type="{x:Type local:Chat}">
                        <local:Chat Name=" Sino" Seen ="16:00"/>
                        <local:Chat Name=" Allen" Seen ="17:59"/>
                        <local:Chat Name=" Zinzi" Seen ="06:00"/>
                        <local:Chat Name=" Milady" Seen ="15:00"/>
                        <local:Chat Name=" Andiswa" Seen ="16:00"/>
                        <local:Chat Name=" Kayla" Seen ="17:59"/>
                        <local:Chat Name=" Zimkhila" Seen ="01:00"/>
                        <local:Chat Name=" Luke" Seen ="05:40"/>
                        <local:Chat Name=" Sam" Seen ="16:00"/>
                        <local:Chat Name=" Jetta" Seen ="11:59"/>
                        <local:Chat Name=" Sean" Seen ="06:00"/>
                        <local:Chat Name=" Rahdee" Seen ="15:00"/>
                        <local:Chat Name=" Samntha" Seen ="16:00"/>
                        <local:Chat Name=" Justina" Seen ="17:59"/>
                        <local:Chat Name=" Micheal" Seen ="01:00"/>
                    </x:Array>
                </ListView.ItemsSource>
         */

        public List<Chat> Chats
        {
            get { return _chats; }
            set { _chats = value; }
        }


        public ChatsPage()
        {
            InitializeComponent();


            CreateChats();

            BindingContext = this;
        }

        private void CreateChats()
        {
            Chat chat = new Chat();
            chat.Name = "Sino";
            chat.Seen = "He said he is gonna send it late";
            chat.Image = "defaultpic.jpeg";
            chat.Time = "17:02";

            Chats.Add(chat);

            chat = new Chat();
            chat.Name = "Allen";
            chat.Seen = "Check your slack";
            chat.Image = "allan.png";
            chat.Time = "17:00";
            Chats.Add(chat);



            /*

                                       < local:Chat Name = " Allen" Seen = "17:59" />

                                          < local:Chat Name = " Zinzi" Seen = "06:00" />

                                             < local:Chat Name = " Milady" Seen = "15:00" />

                                                < local:Chat Name = " Andiswa" Seen = "16:00" />

                                                   < local:Chat Name = " Kayla" Seen = "17:59" />

                                                      < local:Chat Name = " Zimkhila" Seen = "01:00" />

                                                         < local:Chat Name = " Luke" Seen = "05:40" />

                                                            < local:Chat Name = " Sam" Seen = "16:00" />

                                                               < local:Chat Name = " Jetta" Seen = "11:59" />

                                                                  < local:Chat Name = " Sean" Seen = "06:00" />

                                                                     < local:Chat Name = " Rahdee" Seen = "15:00" />

                                                                        < local:Chat Name = " Samntha" Seen = "16:00" />

                                                                           < local:Chat Name = " Justina" Seen = "17:59" />

                                                                              < local:Chat Name = " Micheal" Seen = "01:00" />*/
        }

    }
}