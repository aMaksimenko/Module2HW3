namespace HomeWork.Models
{
    public abstract class Candy : Sweets
    {
        public bool IsOnStick { get; set; }
        public bool IsGumInside { get; set; }
    }
}