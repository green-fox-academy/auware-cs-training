using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;

namespace LicencePlate
{
    class LicencePlate : INotifyPropertyChanged
    {
        private string _licence;
        private static Regex licenceCheckerRegex = new Regex("^[A-Z]{3}-\\d{3}$", RegexOptions.Compiled);

        public event PropertyChangedEventHandler PropertyChanged;

        public string Licence
        {
            get => _licence;
            set
            {
                _licence = value;
                IsValid = licenceCheckerRegex.IsMatch(_licence);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Licence)));
            }
        }
        public bool IsValid { get; private set; }

        public string ValidText
        {
            get
            {
                return IsValid ? "valid" : "invalid";
            }
        }

        public Color Color { get => IsValid ? Color.Green : Color.Red; }

        internal LicencePlate Clone()
        {
            return new LicencePlate { Licence = this.Licence };
        }

        //public override string ToString()
        //{
        //    return Licence;
        //}
    }
}
