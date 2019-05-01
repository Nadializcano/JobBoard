using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;
using System.Collections.Generic;
using System;

namespace JobBoard.Tests
{
  [TestClass]
  public class OpeningsTest : IDisposable
  {

    public void Dispose()
    {
      JobOpening.ClearAll();
    }

    [TestMethod]
    public void JobOpeningConstructor_CreatesInstanceOfOpenings_Openings()
    {
      JobOpening newJobOpening = new JobOpening("test", "test", "test");
      Assert.AreEqual(typeof(JobOpening), newJobOpening.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Programer";
      JobOpening newJobOpening = new JobOpening(title, " ", " ");

      //Act
      string result = newJobOpening.GetTitle();

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Get to work";
      JobOpening newJobOpening = new JobOpening(" ", description, " ");

      //Act
      string result = newJobOpening.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetContact_ReturnsContact_String()
    {
      //Arrange
      string contact = "Sarah";
      JobOpening newJobOpening = new JobOpening(" ", " ", contact);

      //Act
      string result = newJobOpening.GetContact();

      //Assert
      Assert.AreEqual(contact, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Programer";
      JobOpening newJobOpening = new JobOpening(title, " ", " ");

      //Act
      string updatedTitle = "Assistant";
      newJobOpening.SetTitle(updatedTitle);
      string result = newJobOpening.GetTitle();

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Get to work.";
      JobOpening newJobOpening = new JobOpening(" ", description, " ");

      //Act
      string updatedDescription = "do some code";
      newJobOpening.SetDescription(updatedDescription);
      string result = newJobOpening.GetDescription();

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void SetContact_SetContact_String()
    {
      //Arrange
      string contact = "Sarah.";
      JobOpening newJobOpening = new JobOpening(" ", " ", contact);

      //Act
      string updatedContact = "Priscila";
      newJobOpening.SetContact(updatedContact);
      string result = newJobOpening.GetContact();

      //Assert
      Assert.AreEqual(updatedContact, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_JobOpeningList()
    // {
    //   //Arrange
    //   List<JobOpening> newList = new List<JobOpening> { };
    //
    //   //Act
    //   List<JobOpening> result = JobOpening.GetAll();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsOpenings_JobOpeningList()
    // {
    //   //Arrange
    //   string title1 = "Assistant";
    //   string title2 = "Programer";
    //   string description1 = " ";
    //   string description2 = " ";
    //   string contact1 = " ";
    //   string contact2 = " ";
    //   JobOpening newOpening1 = new JobOpening(title1);
    //   JobOpening newOpening2 = new JobOpening(title2);
    //   List<JobOpening> newList = new List<JobOpening> { newOpening1, newOpening2 };
    //
    //   //Act
    //   List<JobOpening> result = JobOpening.GetAll();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  //
    [TestMethod]
    public void GetId_OpeningsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange

      JobOpening newJobOpening = new JobOpening(" ", " ", " ");

      //Act
      int result = newJobOpening.GetId();

      //Assert
      Assert.AreEqual(10, result);
    }

  //   [TestMethod]
  // public void Find_ReturnsCorrectJobOpening_JobOpening()
  // {
  //   //Arrange
  //   string title1 = "Assistant";
  //   string title2 = "Programer";
  //   string description1 = "Get to work";
  //   string description2 = "Do some code";
  //   string contact1 = "Sarah";
  //   string contact2 = "Priscila";
  //   JobOpening newJobOpening1 = new JobOpening(title1, description1, contact1);
  //   JobOpening newJobOpening2 = new JobOpening(title2, description2, contact2);
  //
  //   //Act
  //   JobOpening result = JobOpening.Find(2);
  //
  //   //Assert
  //   Assert.AreEqual(newJobOpening2, result);
  // }

  }
}
