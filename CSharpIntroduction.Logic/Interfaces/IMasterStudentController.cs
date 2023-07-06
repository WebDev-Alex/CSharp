// ------------------------------------------------------------------------------------------------------------------
// <copyright file="IMasterStudentController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Adina Nicoara</author>
// ------------------------------------------------------------------------------------------------------------------

namespace CSharpIntroduction.Logic.Interfaces
{
  public interface IMasterStudentController
  {
    void GenerateRandomData();

    void SearchPerson(string cnp);

    void ShowAllData();

    List<string> GetNames();

    void UpdateGraduationNote(string cnp);

    void DeleteMasterStudent();

    //void assignTeacher(string cnp);
  }
}
