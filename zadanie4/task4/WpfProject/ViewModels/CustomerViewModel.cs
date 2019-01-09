using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfProject.Commands;
using WpfProject.Models;

namespace WpfProject.ViewModels
{
    internal class CustomerViewModel
    {
        private Customer _Customer;

        public CustomerViewModel()
        {
            _Customer = new Customer("Lukasz");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        public bool CanUpdate
        {
            get
            {
                if(Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
        }
    }
}
