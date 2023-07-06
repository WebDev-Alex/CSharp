namespace CSharpIntroduction.DataType
{
    using CSharpIntroduction.DataType.Enums;
    using CSharpIntroduction.DataType.Interfaces;

    public class Teacher : IPerson
    {
        public Guid ID { get; private set; }

        public string Name { get; private set; }

        public string CNP { get; private set; }

        public string Specialization { get; set; }

        public int YearOfStudy { get; set; }

        public EGender Gender { get; private set; }

        public Teacher()
        {
        }

        public Teacher(string name, string cnp, EGender gender)
        {
            this.ID = Guid.NewGuid();
            this.Name = name;
            this.CNP = cnp;
            this.Gender = gender;
        }

        public virtual string GetPersonName()
        {
            return this.Name;
        }
    }
}
