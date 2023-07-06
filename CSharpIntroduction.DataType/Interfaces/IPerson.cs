
namespace CSharpIntroduction.DataType.Interfaces
{

  using CSharpIntroduction.DataType.Enums;

  public interface IPerson
  {
    Guid ID { get; }

    string Name { get; }

    string CNP { get; }

    EGender Gender { get; }
  }
}
