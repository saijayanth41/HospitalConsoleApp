namespace HospitalConsoleApp
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Patient(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
