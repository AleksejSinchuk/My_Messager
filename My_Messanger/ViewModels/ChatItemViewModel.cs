using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Messanger.ViewModels
{
    class ChatItemViewModel : Base.ViewModel
    {
        public string PhotoUser { get; set; }
        public string ChatText { get; set; }
        public string ChatDateTime { get; set; }
        public string BackColor { get; set; }
        public ChatItemViewModel()
        {

        }
    }
}
