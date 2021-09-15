namespace HomeWork.Models
{
    public abstract class Sweets
    {
        private int _inPackage = 1;
        public int Weight { get; set; }
        public Taste Taste { get; set; }

        public int InPackage
        {
            get => _inPackage;
            set => _inPackage = value;
        }
    }
}