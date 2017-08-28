﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EducationDetails.aspx.cs" Inherits="PioneerTech.UI.EducationDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table id="EducationDetails">
        <tr>
           <th>EducationDetails</th>
        </tr>
         <tr id="EmployeeIDRow">
            <td>
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="EmployeeID"></asp:Label>   
            </td>
            <td style="width: 223px">
                 <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged"></asp:DropDownList>

            </td>
        </tr>
        <tr id="CourseTypeRow">
            <td>
                <asp:Label ID="CourseTypeLabel" runat="server" Text="CourseType"></asp:Label>
            </td>
            <td style="width: 223px">
                <asp:TextBox ID="CourseTypeTextBox" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="CourseTypeRequiredFieldValidator" runat="server" ErrorMessage="Please enter the CourseType" ControlToValidate="CourseTypeTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="CourseSpecialisationRow">
            <td>
                <asp:Label ID="CourseSpecializationLabel" runat="server" Text="Coursespecialization"></asp:Label>
            </td>
            <td style="width: 223px">
                <asp:TextBox ID="CourseSpecializationTextBox" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="CourseSpecialisationRequiredFieldValidator" runat="server" ErrorMessage="Please enter the CourseSpecialisation" ControlToValidate="CourseSpecialisationTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="YearOfPassRow">
            <td>
                <asp:Label ID="YearOfPassLabel" runat="server" Text="YearOfPass"></asp:Label>
            </td>
            <td style="width: 223px">
                <asp:TextBox ID="YearOfPassTextBox" runat="server"></asp:TextBox>
                </td>
            <%--<td>
                <asp:RequiredFieldValidator ID="YearOfPassRequiredFieldValidator" runat="server" ErrorMessage="Please enter the YearOfPass" ControlToValidate="YearOfPassTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>--%>
        </tr>
        <tr>
            <td>
                <asp:Button ID="EducationalDetailsSave" runat="server" Text="Save" OnClick="EducationalDetailsSave_Click" />
            </td>
            <td style="width: 223px">
                <asp:Button ID="EducationalDetailsEdit" runat="server" Text="Edit" OnClick="EducationalDetailsEdit_Click" />
            </td>
            <td>
                <asp:Button ID="EducationalDetailsClear" runat="server" Text="Clear" OnClick="EducationalDetailsClear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
