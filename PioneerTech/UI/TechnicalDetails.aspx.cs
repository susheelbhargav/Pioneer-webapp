using Models;
using PioneerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PioneerTech.UI
{
    public partial class TechnicalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TechnicalDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalDetailsmodels technicalmodel = new TechnicalDetailsmodels()
                {
                    UI = UITextBox.Text,
                    ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                    OrmTechnologies = ORMTechnologiesTextBox.Text,
                    Databases = DatabasesTextBox.Text,
                };
                TechnicalDataAccess technicaldata = new TechnicalDataAccess();
                string techdata = technicaldata.SaveTechnical(technicalmodel);
                if (techdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void TechnicalDetailsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalDetailsmodels tmodel = new TechnicalDetailsmodels()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    UI = UITextBox.Text,
                    ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                    OrmTechnologies = ORMTechnologiesTextBox.Text,
                    Databases = DatabasesTextBox.Text,
                };
                TechnicalDataAccess taccess = new TechnicalDataAccess();
                string tdata = taccess.EditTechnical(tmodel);
                if (tdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void TechnicalDetailsClear_Click(object sender, EventArgs e)
        {

            UITextBox.Text = string.Empty;
            ProgrammingLanguageTextBox.Text = string.Empty;
            ORMTechnologiesTextBox.Text = string.Empty;
            DatabasesTextBox.Text = string.Empty;
        }
    }
}

