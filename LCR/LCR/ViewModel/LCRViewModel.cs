using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCR.ViewModel
{
    public class LCRViewModel : ViewModelBase
    {

        private Bridge _model = new Bridge();
        public Bridge Model
        {
            set
            {
                if (value != _model)
                {
                    _model = value;
                    OnPropertyChanged(nameof(Model));
                }
            }

            get =>  _model;
        }
    }
}
