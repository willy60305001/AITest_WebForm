using FileUploadInASP.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.UI.WebControls;
using Label = System.Web.UI.WebControls.Label;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void show_message_updates_status_label()
        {
            // Arrange
            var page = new SimpleFileUpload();
            string expectedMessage = "Test Message";

            // Act
            page.ShowMessage(expectedMessage);

            // Assert
            Assert.AreEqual(expectedMessage, "");
        }

    }
}
