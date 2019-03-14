
namespace PrototypePattern2
{
    class Administrator : IEmployee
    {
        public int age;
        public string title;
        public int salary;
        public string name;

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetails()
        {
            return $"{name}-{age}-{title}-{salary}";
        }
    }
}
