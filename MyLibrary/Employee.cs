namespace MyLibrary
{
    public class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \n experience: {Experience}";
        }

        public override bool Equals(object aOther)
        {            
            if (aOther is null || !typeof(Employee).Equals(aOther.GetType()))
            {
                return false;
            }

            Employee other = (Employee)aOther;
            return other.Name.Equals(Name) && other.Experience == Experience;
                
        }
    }
}