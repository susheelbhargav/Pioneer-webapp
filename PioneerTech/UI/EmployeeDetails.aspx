<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.UI.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table ID="EmployeeTable" >
      <tr>
          <th>EmployeeDetails</th>
          </tr>
       <tr id="EmployeeIDRow">
            <td>
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="EmployeeID"></asp:Label>   
            </td>
            <td style="width: 255px">
                 <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
      <tr id="FirstNameRow">
        <td style="height: 26px">
            <asp:Label ID="FirstName" runat="server" Text="FirstName"></asp:Label>
        </td>
        <td style="width: 255px; height: 26px;">
            <asp:TextBox ID="FirstNameTextBox" runat="server" OnTextChanged="FirstNameTextBox_TextChanged" ></asp:TextBox>
            </td>
          <td style="height: 26px">
            <asp:RequiredFieldValidator ID="FirstNameRequiredFieldValidator" runat="server" ErrorMessage="Please enter first name" ControlToValidate="FirstNameTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="LastNameRow">
        <td>
            <asp:Label ID="LastName" runat="server" Text="LastName"></asp:Label>
        </td>
        <td style="width: 255px">
            <asp:TextBox ID="LastNameTextBox" runat="server" ></asp:TextBox>
            </td>
        <td>
            <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server" ErrorMessage="Please enter last name" ControlToValidate="LastNameTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr id="EmailRow">
            <td>
                <asp:Label ID="EmailId" runat="server" Text="EmailId"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="EmailIdTextBox" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="Please enter valid email id" ControlToValidate="EmailTextBox"
                    SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#CC0000"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr id="MobileNumberRow">
            <td>
                <asp:Label ID="MobileNumber" runat="server" Text="MobileNumber"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="MobileNumberTextBox" runat="server" OnTextChanged="MobileNumberTextBox_TextChanged"></asp:TextBox>
                </td>
            <td>
                <asp:RegularExpressionValidator ID="MobileNumberRegularExpressionValidator" runat="server" ErrorMessage="Please enter a valid mobile number" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ForeColor="#CC0000" ControlToValidate="MobileNumberTextBox"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr id="AlternateMobileNumberRow">
            <td>
                <asp:Label ID="AlternateMobileNumber" runat="server" Text="AlternateMobileNumber"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="AlternateMobileNumberTextBox" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RegularExpressionValidator ID="AlternateMobileNumberRegularExpressionValidator" runat="server" ErrorMessage="Please enter a valid mobile number" ForeColor="#CC0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ControlToValidate="AlternateMobileNumberTextBox"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr id="Address1Row">
            <td>
                <asp:Label ID="Address1" runat="server" Text="Address1"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="Address1TextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Addrees2Row">
            <td>
                <asp:Label ID="Address2" runat="server" Text="Address2"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="Address2TextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Current_CountryRow">
            <td>
                <asp:Label ID="CurrentCountry" runat="server" Text="CurrentCountry"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="CurrentCountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Home_CountryRow">
            <td style="height: 26px">
                <asp:Label ID="HomeCountry" runat="server" Text="HomeCountry"></asp:Label>
            </td>
            <td style="width: 255px; height: 26px;">
                <asp:TextBox ID="HomeCountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="ZipCodeRow">
            <td>
                <asp:Label ID="ZipCode" runat="server" Text="ZipCode"></asp:Label>
            </td>
            <td style="width: 255px">
                <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
                </td>
            
        </tr>
        <tr>
            <td>
                <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" Width="104px" />
            </td>
            <td style="width: 255px">
                <asp:Button ID="EditButton" runat="server" Text="Edit" Width="107px" OnClick="EditButton_Click" />
            </td>
            <td>
                <asp:Button ID="ClearButton" runat="server" Text="Clear" Width="93px" Height="25px" OnClick="ClearButton_Click" />
            </td>

        </tr>
        </table>     
</asp:Content>
