using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataBindingMVVM
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.LabelResultVisible = false;
        }

        private string myMessage;
        public string MyMessage
        {
            get { return myMessage; }
            set 
            {
                if (myMessage != value)
                {
                    myMessage = value; 
                    OnPropertyChanged("MyMessage");
                }
            }
        }

        private bool labelResultVisible;
        public bool LabelResultVisible
        {
            get { return labelResultVisible; }
            set 
            {
                if (labelResultVisible != value)
                {
                    labelResultVisible = value;
                    OnPropertyChanged("LabelResultVisible");
                }
            }
        }

        public void SetVisibility_LabelResult(bool visibility)
        {
            LabelResultVisible = visibility;
        }

    }
}
