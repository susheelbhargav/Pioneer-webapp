using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PioneerDataAccess
{
    public class EmployeeDataAccess
    {
        

        public string SaveEmployee(EmployeeDetailsmodels employee)
        {
            int result = 0;
            try
            {

                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlemployeedetails = @"INSERT INTO EmployeeDetails
                                            (FirstName,LastName,EmailId,MobileNumber,AlternateMobileNumber,Address1,Adress2,CurrentCountry,HomeCountry,ZipCode)VALUES('" + employee.FirstName + "'," + "" + "'" + employee.LastName + "'," + "" + "'" + employee.EmailId + "'," + "" + "" + employee.MobileNumber + "," + "" + employee.AlternateMobileNumber + "," + "" + "'" + employee.Address1 + "'," + "'" + employee.Address2 + "'," + "" + "" + "'" + employee.CurrentCountry + "'," + "'" + employee.HomeCountry + "'," + "" + employee.ZipCode + ")";
                SqlCommand command;
                command = new SqlCommand(sqlemployeedetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show ("asdsacsdcscdscdsc");
            }
            return" result";


        }

        public string Editemployee(EmployeeDetailsmodels empeditmodels)
        {
            throw new NotImplementedException();
        }
    }
    public class EducationDataAccess
    {
        

        public string SaveEducation(EducationalDetailsmodels education)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqleducationdetails = @"INSERT INTO EducationDetails(CourseType,CourseSpecialisation,YearOfPass)VALUES('" + education.CourseType + "'," + "'" + education.CourseSpecialization + "'," + "" + education.YearOfPass + ")";
                SqlCommand command;
                command = new SqlCommand(sqleducationdetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return "result";
        }

        public string Editeducation(object edmodels)
        {
            throw new NotImplementedException();
        }
    }
    public class TechnicalDataAccess
    {
        public string EditTechnical(TechnicalDetailsmodels tmodel)
        {
            throw new NotImplementedException();
        }

        public string SaveTechnical(TechnicalDetailsmodels technical)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqltechnicaldetails = @"INSERT INTO Technical_Details(UI,ProgrammingLanguage,ORMTechnologies,Databases)VALUES('" + technical.Ui + "'," + "'" + technical.ProgrammingLanguage + "'," + "'" + technical.OrmTechnologies + "'," + "'" + technical.Databases + "')";
                SqlCommand command;
                command = new SqlCommand(sqltechnicaldetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return "result";
        }
    }
    public class CompanyDataAccess
    {
        public string EditCompany(CompanyDetailsmodels model)
        {
            throw new NotImplementedException();
        }

        public string SaveCompany(CompanyDetailsmodels company)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlcompanydetails = @"INSERT INTO CompanyDetails(EmployerName,ContactNumber,Location,Website)VALUES('" + company.EmployeeName + "'," + "" + company.ContactNumber + "," + "'" + company.Location + "'," + "'" + company.Website + "')";
                SqlCommand command;
                command = new SqlCommand(sqlcompanydetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return "result";
        }
    }
    public class ProjectDataAccess
    {
        public string EditProject(ProjectDetailsmodels pmodels)
        {
            throw new NotImplementedException();
        }

        public string SaveProject(ProjectDetailsmodels project)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=MANCHALABHARGAV\\SQL2016;Initial Catalog=PioneerEmployeeDba;" +
                   " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlprojectdetails = @"INSERT INTO Project_Details(EmployeeID,ProjectName,ClientName,Location,Role)VALUES(" + project.EmployeeID + "," + "'" + project.ProjectName + "'," + "'" + project.ClientName + "'," + "'" + project.Location + "'," + "'" + project.Role + "')";
                SqlCommand command;
                command = new SqlCommand(sqlprojectdetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return "result";
        }
    }


}