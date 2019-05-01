using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Controllers;
using JobBoard.Models;

namespace JobBoard.Tests
{
  [TestClass]
    public class OpeningsControllerTest
    {
      [TestMethod]
      public void Index_HasCorrectModelType_JobOpeningsList()
      {
        //Arrange
        ViewResult indexView = new OpeningsController().Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<JobOpening>));
      }

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
          //Arrange
          OpeningsController controller = new OpeningsController();

          //Act
          IActionResult view = controller.Create(" ", " ", " ");

          //Assert
          Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
          //Arrange
          OpeningsController controller = new OpeningsController();
          RedirectToActionResult actionResult = controller.Create(" ", " ", " ") as RedirectToActionResult;

          //Act
          string result = actionResult.ActionName;

          //Assert
          Assert.AreEqual(result, "Index");
      }
    }
}
