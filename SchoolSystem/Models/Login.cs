using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    class Login: INotifyPropertyChanged
    {
        //the event handler
        public event PropertyChangedEventHandler PropertyChanged;
        private string Type;
        private string Username;
        private string Password;
        //public 
        private void OnPropertyChanged(string property)
        {
            //when an event is raised or changed
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
