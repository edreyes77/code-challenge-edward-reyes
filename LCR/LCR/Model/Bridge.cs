using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCR.Model
{
    public class Bridge : ModelBase
    {
        public Bridge()
        {

        }


        private Settings _settings = new Settings();
        public Settings Settings
        {
            set
            {
                if (value != _settings)
                {
                    _settings = value;
                    OnPropertyChanged(nameof(Settings));
                }
            }

            get => _settings;
        }
    }
}
