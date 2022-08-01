namespace Exercise6
{
    public class Dog
    {
        private readonly string _name;
        private string _sex;
        public Dog Father;
        public Dog Mother;
        
        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public string FathersName()
        {
            return Father == null ? "Unknown" : Father._name;
        }

        public bool HasSameMotherAs(Dog dog)
        {
            if (Mother == dog.Mother && Mother != null)
            {
                return true;
            }

            return false;
        }
    }
}