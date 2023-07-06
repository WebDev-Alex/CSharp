// ------------------------------------------------------------------------------------------------------------------
// <copyright file="IStudentController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Adina Nicoara</author>
// ------------------------------------------------------------------------------------------------------------------

namespace CSharpIntroduction.Logic.Interfaces
{
  public interface IStudentController
  {
    void GenerateRandomData();
    void SearchPerson(string cnp);
    void ShowAllData();
    List<string> GetStudentsName();
    void DeleteStudent(string cnp);
  }
}
