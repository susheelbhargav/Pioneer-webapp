<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneerTech.UI.ProjectDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="ProjectDetails">
        <tr>
           <th>ProjectDetails</th>
        </tr>
        <tr id="EmployeeIDRow">
            <td>
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="EmployeeID"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexchanged"></asp:DropDownList>   
            </td>
        </tr>
        <tr id="Project_NameRow">
            <td>
                <asp:Label ID="ProjectNameLabel" runat="server" Text="ProjectName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ProjectNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Client_NameRow">
            <td>
                <asp:Label ID="ClientNameLabel" runat="server" Text="ClientName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ClientNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="Client_NameRequiredFieldValidator" runat="server" ErrorMessage="Please enter client name" ControlToValidate="Client_NameTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="LocationRow">
            <td style="height: 26px">
                <asp:Label ID="LocationLabel" runat="server" Text="Location"></asp:Label>
            </td>
            <td style="height: 26px">
                <asp:TextBox ID="LocationTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="RolesRow">
            <td>
                Role</td>
            <td>
                <asp:TextBox ID="RoleTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ProjectDetailsSave" runat="server" Text="Save" OnClick="ProjectDetailsSave_Click" />
            </td>
            <td>
                <asp:Button ID="ProjectDetailsEdit" runat="server" Text="Edit" OnClick="ProjectDetailsEdit_Click" />
            </td>
            <td>
                <asp:Button ID="ProjectDetailsClear" runat="server" Text="Clear" OnClick="ProjectDetailsClear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
