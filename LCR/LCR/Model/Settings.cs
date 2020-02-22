using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCR.Model
{
    public class Settings : ModelBase
    {

        private ObservableCollection<int> _numberOfSelections = new ObservableCollection<int>() { 1, 2, 3, 4, 5, 6 };

        public ObservableCollection<int> NumberOfSelections
        {
            set
            {
           
                if (value != _numberOfSelections)
                {
                    _numberOfSelections = value;
                    OnPropertyChanged(nameof(NumberOfSelections));
                }
            }
        }
    }
}
