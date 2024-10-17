using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadInASP.NET
{
    public partial class SimpleFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                string filename = Path.GetFileName(FileUploadControl.FileName);
                FileUploadControl.SaveAs(Server.MapPath("~/Uploaded_Files/") + filename);

                ShowMessage("Upload status: File uploaded!");

            }
            else
            {
                ShowMessage("Upload status: File upload fail !");
            }
        }

        public void ShowMessage(string strMsg)
        {
            StatusLabel.Text = strMsg;
        }
    }
}