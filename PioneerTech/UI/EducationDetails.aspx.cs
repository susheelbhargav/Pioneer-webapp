using PioneerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

namespace PioneerTech.UI
{
    public partial class EducationDetails : System.Web.UI.Page
    {
        private EducationalDetailsmodels educationmodel;
        private object access;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EducationalDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                EducationDetailsModel education = new EducationDetailsModel()
                {
                    CourseType = CourseTypeTextBox.Text,
                    CourseSpecialisation = CourseTypeTextBox.Text,
                    YearOfPass = Convert.ToInt32(YearOfPassTextBox.Text),
                };
                EducationDataAccess educationdata = new EducationDataAccess();
                string edsave = educationdata.SaveEducation(educationmodel);
                if (edsave.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter the values: " + ex.Message);
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void EducationalDetailsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EducationDetailsModel edmodels = new EducationDetailsModel()
                {

                    CourseType = CourseTypeTextBox.Text,
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    CourseSpecialisation = CourseSpecializationTextBox.Text,
                    YearOfPass = Convert.ToInt32(YearOfPassTextBox.Text),
                };
                EducationDataAccess cmpaccess = new EducationDataAccess();
                string ededit = cmpaccess.Editeducation(edmodels);
                if (ededit.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter the values: " + ex.Message);
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void EducationalDetailsClear_Click(object sender, EventArgs e)
        {
            {
                CourseTypeTextBox.Text = String.Empty;
                CourseSpecializationTextBox.Text = string.Empty;
                YearOfPassTextBox.Text = string.Empty;
            }
        }
    }

}
    


