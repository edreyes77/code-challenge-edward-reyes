using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCR.Model
{
    public class Dice : ModelBase
    {

        private int _toss;
        public int Toss
        {
            set
            {
                if (value != _toss)
                {
                    _toss = value;
                    OnPropertyChanged(nameof(Toss));
                }
            }

            get => _toss;
        }
    }
}
