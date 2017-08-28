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
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsmodels employee = new EmployeeDetailsmodels()
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    EmailId = EmailIdTextBox.Text,
                    MobileNumber = Convert.ToInt64(MobileNumberTextBox.Text),
                    AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                    Address1 = Address1TextBox.Text,
                    Address2 = Address2TextBox.Text,
                    CurrentCountry = CurrentCountryTextBox.Text,
                    HomeCountry = HomeCountryTextBox.Text,
                    ZipCode = Convert.ToInt64(ZipCodeTextBox.Text),
                };
                EmployeeDataAccess employeedata = new EmployeeDataAccess();
                string emdata = employeedata.SaveEmployee(employee);
                if (emdata.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully!');</script>");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter the values: " +ex.Message);
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsmodels empeditmodels = new EmployeeDetailsmodels()
                {
                    EmployeeId = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    EmailId = EmailIdTextBox.Text,
                    MobileNumber = Convert.ToInt64(MobileNumberTextBox.Text),
                    AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                    Address1 = Address1TextBox.Text,
                    Address2 = Address2TextBox.Text,
                    CurrentCountry = CurrentCountryTextBox.Text,
                    HomeCountry = HomeCountryTextBox.Text,
                    ZipCode = Convert.ToInt64(ZipCodeTextBox.Text),
                };
                EmployeeDataAccess empeditaccess = new EmployeeDataAccess();
                string emedit = empeditaccess.Editemployee(empeditmodels);
                if (emedit.Equals("success"))
                {
                    Response.Write("<script>alert('Details have been updated successfully!');</script>");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Details have been updated: " + ex.Message);
                Response.Write("<script>alert('Please enter the values!" + ex.Message + "');</script>");
            }

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            EmailIdTextBox.Text = string.Empty;
            MobileNumberTextBox.Text = string.Empty;
            AlternateMobileNumberTextBox.Text = string.Empty;
            Address1TextBox.Text = string.Empty;
            Address2TextBox.Text = string.Empty;
            CurrentCountryTextBox.Text = string.Empty;
            HomeCountryTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;
        }
    }
}

