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
    public partial class ProjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProjectDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectDetailsmodels projectmodel = new ProjectDetailsmodels()
                {
                    EmployeeID = EmployeeIDDropDownList.SelectedValue.ToString(),
                    ProjectName = ProjectNameTextBox.Text,
                    ClientName = ClientNameTextBox.Text,
                    Location = LocationTextBox.Text,
                    Role = RoleTextBox.Text,
                };
                ProjectDataAccess projectdata = new ProjectDataAccess();
                string pjdata = projectdata.SaveProject(projectmodel);
                if (pjdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void ProjectDetailsClear_Click(object sender, EventArgs e)
        {
            {
                ProjectNameTextBox.Text = string.Empty;
                ClientNameTextBox.Text = string.Empty;
                LocationTextBox.Text = string.Empty;
                RoleTextBox.Text = string.Empty;
            }
        }

        protected void ProjectDetailsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectDetailsmodels pmodels = new ProjectDetailsmodels()
                {
                    EmployeeID = (EmployeeIDDropDownList.SelectedValue),
                    ProjectName = ProjectNameTextBox.Text,
                    ClientName = ClientNameTextBox.Text,
                    Location = LocationTextBox.Text,
                    Role = RoleTextBox.Text,
                };
                ProjectDataAccess prdata = new ProjectDataAccess();
                string pdata = prdata.EditProject(pmodels);
                if (pdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }
    }
}
   
