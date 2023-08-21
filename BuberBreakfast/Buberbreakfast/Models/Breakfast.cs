namespace BuberBreakfast.Models
{
    public class Breakfast
    {
        public Guid Id;
        public string Name {get;}
        public string Description {get;}
        public DateTime StartDateTime {get;}
        public DateTime EndDateTime {get;}
        public List<string> Savory {get;}

        public List<string> Sweet {get;}
    }
}