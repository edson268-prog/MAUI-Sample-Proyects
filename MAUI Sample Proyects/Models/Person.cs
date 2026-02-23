using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MAUI_Sample_Proyects.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string phone;
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged();
            }
        }

        private string address;
        public string Address
        {
            get => address; set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this,
                 new PropertyChangedEventArgs(propName));
        }
    }
}
