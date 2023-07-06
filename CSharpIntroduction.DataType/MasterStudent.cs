

namespace CSharpIntroduction.DataType
{
  public class MasterStudent : Student
  {
    public string GraduatedUniversityName { get; set; }

    public double GraduationNote { get; set; }

    public Teacher Supervisor { get; set; }

    public MasterStudent(string name, string cnp, Enums.EGender gender, string graduationUniversity, double graduationNote)
      : base(name, cnp, gender)
    {
      this.GraduatedUniversityName = graduationUniversity;
      this.GraduationNote = graduationNote;
    }

    public override string GetPersonName()
    {
      return $"Master Student Name is: {this.Name}";
      //return "Master Student Name is:" + this.Name; 
    }
  }
}
