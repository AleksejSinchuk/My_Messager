using My_Messanger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Messanger.ViewModels
{
    class MainWindowViewModel:Base.ViewModel
    {
        public Command EnterCommand { get; set; }
        string _chatText;
        public string ChatText
        {
            get
            {
                return _chatText;
            }
            set
            {
                _chatText = value;
                ChatListItems.Add(new ChatItemViewModel { ChatText = value, ChatDateTime = DateTime.Now.ToShortTimeString(), BackColor = "Red" });
            }
        }
        public ObservableCollection<ChatItemViewModel> ChatListItems { get; set; }
        public ObservableCollection<User> UsersListItems { get; set; }
        public MainWindowViewModel()
        {
            EnterCommand = new Command(() =>
            {
                string s = _chatText;
                OnPropertyChanged(nameof(ChatText));
                _chatText = "";
                OnPropertyChanged(nameof(ChatText));
            });
            ChatListItems = new ObservableCollection<ChatItemViewModel>();
            ChatListItems.Add(new ChatItemViewModel { ChatText = "Hello", ChatDateTime = "01.01.01", BackColor = "Red" });
            ChatListItems.Add(new ChatItemViewModel { ChatText = "World", ChatDateTime = "01.03.01", BackColor = "Blue" });
            ChatListItems.Add(new ChatItemViewModel { ChatText = "Hello1", ChatDateTime = "01.01.023", BackColor = "Red" });
            ChatListItems.Add(new ChatItemViewModel { ChatText = "Hello12", ChatDateTime = "01.01.23", BackColor = "Blue" });

            UsersListItems = new ObservableCollection<User>();
            UsersListItems.Add(new User { PhotoUser = "red", NameUser = "Bill" });


        }
    }
}

