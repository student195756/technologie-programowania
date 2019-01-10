using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClient.ViewModels
{
    public class ElementsListViewModel : ObservableObject
    {
        private string _content;

        public string Content
        {
            get
            {
                if(string.IsNullOrEmpty(_content))
                {
                    return "";
                }

                return _content;
            }
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }
    }
}
