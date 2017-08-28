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
    public partial class CompanyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompanyDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyDetailsmodels companymodel = new CompanyDetailsmodels()
                {
                    EmployeeName = EmployeeNameTextBox.Text,
                    ContactNumber = Convert.ToInt64(ContactNumberTextBox.Text),
                    Location = LocationTextBox.Text,
                    Website = WebsiteTextBox.Text,
                };
                CompanyDataAccess companydata = new CompanyDataAccess();
                string cmpdata = companydata.SaveCompany(companymodel);
                if (cmpdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void CompanyDetailsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyDetailsmodels model = new CompanyDetailsmodels()
                {

                    EmployeeName = EmployeeNameTextBox.Text,
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    ContactNumber = Convert.ToInt64(ContactNumberTextBox.Text),
                    Location = LocationTextBox.Text,
                    Website = WebsiteTextBox.Text,
                };
                CompanyDataAccess access = new CompanyDataAccess();
                string cmpaccess = access.EditCompany(model);
                if (cmpaccess.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }
        }

        protected void CompanyDetailsClear_Click(object sender, EventArgs e)
        {
            {
                EmployeeNameTextBox.Text = string.Empty;
                ContactNumberTextBox.Text = string.Empty;
                LocationTextBox.Text = string.Empty;
                WebsiteTextBox.Text = string.Empty;
            }
        }
    }
}