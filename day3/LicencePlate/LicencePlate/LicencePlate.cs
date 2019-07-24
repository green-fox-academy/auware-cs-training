using System.Text.RegularExpressions;

namespace LicencePlate
{
    class LicencePlate
    {
        private string _licence;
        private static Regex licenceCheckerRegex = new Regex("^[A-Z]{3}-\\d{3}$", RegexOptions.Compiled);

        public string Licence
        {
            get => _licence;
            set
            {
                _licence = value;
                IsValid = licenceCheckerRegex.IsMatch(_licence);
            }
        }
        public bool IsValid { get; private set; }
    }
}
