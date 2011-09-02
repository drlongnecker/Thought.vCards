<%@ Page
    Language="C#"
    MasterPageFile="~/Main.Master"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="WebBuilder.DefaultPage"
    Theme="Default" %>

<asp:Content
    ID="headContent"
    ContentPlaceHolderID="headContentHolder"
    runat="server">
</asp:Content>

<asp:Content
    ID="mainContent"
    ContentPlaceHolderID="mainContentHolder"
    runat="server">
    <asp:Label
        ID="nameHeading"
        runat="server"
        CssClass="formHeading"
        EnableViewState="false"
        Text="Name"></asp:Label>

    <asp:Panel
        ID="nameSection"
        runat="server"
        CssClass="formSection">
        
        <asp:Label
            ID="formattedNameHelp"
            runat="server"
            AssociatedControlID="formattedNameBox"
            CssClass="formHelp">
            
            <b>Formatted Name (FN)</b>: The formatted name (FN) is the full name of the
            person as it should be written.  Normally a vCard application will construct
            the full name of a person by concatenating his/her first and last names.
            However, such an algorithm may not account for regional or personal differences.
            The formatted name option allows you to override any automatic algorithms.
        </asp:Label>
                    
        <asp:Label
            ID="formattedNameLabel"
            runat="server"
            AssociatedControlID="formattedNameBox"
            CssClass="formLabel"
            Text="Formatted/Display Name:"></asp:Label>

        <asp:TextBox
            ID="formattedNameBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>

        <asp:Label
            ID="nameHelp"
            runat="server"
            AssociatedControlID="givenNameBox"
            CssClass="formHelp"
            EnableViewState="false">
            
            <b>Name (N):</b> The vCard name (N) element has several components.  The
            first and last names of the person are identified as the given and
            family names (to reflect the international nature of the standard).  Middle
            names are called additional names and can be separated by commas or 
            spaces.
           
        </asp:Label>
        
        <asp:Label
            ID="givenNameLabel"
            runat="server"
            AssociatedControlID="givenNameBox"
            CssClass="formLabel"
            Text="Given (first) name:"></asp:Label>

        <asp:TextBox
            ID="givenNameBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>

        <asp:RequiredFieldValidator
            ID="givenNameRequired"
            runat="server"
            ControlToValidate="givenNameBox"
            ErrorMessage="A given (first) name is required."></asp:RequiredFieldValidator>

        <asp:Label
            ID="familyNameLabel"
            runat="server"
            AssociatedControlID="familyNameBox"
            CssClass="formLabel"
            Text="Family (last) name:"></asp:Label>

        <asp:TextBox
            ID="familyNameBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>

        <asp:RequiredFieldValidator
            ID="lastNameRequired"
            runat="server"
            ControlToValidate="familyNameBox"
            ErrorMessage="A family (last) name is required."></asp:RequiredFieldValidator>

        <asp:Label
            ID="nicknamesHelp"
            runat="server"
            AssociatedControlID="nicknamesBox"
            CssClass="formHelp"
            EnableViewState="false">
            
            <b>Nicknames (NICKNAME):</b> The NICKNAME element specifies one or more
            nicknames of the person, such as Dave instead of David or Kitty instead of
            Catherine.  The vCard specification allows multiple nicknames to be
            separated by commas.  However, many vCard applications will simply assume
            the entire string (including commas) is a single nickname.  For safety
            you should only write one nickname.
          
        </asp:Label>
        
        <asp:Label
            ID="nicknamesLabel"
            runat="server"
            AssociatedControlID="nicknamesBox"
            CssClass="formLabel"
            Text="Nicknames:"></asp:Label>

        <asp:TextBox
            ID="nicknamesBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>
                    
    </asp:Panel>

    <asp:Label
        ID="employmentHeading"
        runat="server"
        CssClass="formHeading"
        Text="Employment"></asp:Label>

    <asp:Panel
        ID="employmentSection"
        runat="server"
        CssClass="formSection">
        
        <asp:Label
            ID="organizationLabel"
            runat="server"
            AssociatedControlID="organizationTextBox"
            CssClass="formLabel"
            Text="Organization:"></asp:Label>

        <asp:TextBox
            ID="organizationTextBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>
                    
        <asp:Label
            ID="titleLabel"
            runat="server"
            AssociatedControlID="titleTextBox"
            CssClass="formLabel"
            Text="Job Title:"></asp:Label>

        <asp:TextBox
            ID="titleTextBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>

        <asp:Label
            ID="workPhoneLabel"
            runat="server"
            AssociatedControlID="workPhoneBox"
            CssClass="formLabel"
            Text="Work telephone:"></asp:Label>

        <asp:TextBox
            ID="workPhoneBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>
                                
    </asp:Panel>

    <asp:Panel
        ID="emailSection"
        runat="server"
        CssClass="formSection">
        
        <asp:Label
            ID="emailHelp"
            runat="server"
            AssociatedControlID="workEmailBox"
            CssClass="formHelp"
            EnableViewState="false">

            <b>Email (EMAIL):</b>  The vCard specification allows any number of
            email entries and further supports a variety of different email types
            such as Internet, CompuServe, and X400.  In practice most vCard applications
            support a limited number of addresses (generally under four) and recognize
            only Internet email address types.
        </asp:Label>
                
        <asp:Label
            ID="workEmailLabel"
            runat="server"
            AssociatedControlID="workEmailBox"
            CssClass="formLabel"
            Text="Work email:"></asp:Label>

        <asp:TextBox
            ID="workEmailBox"
            runat="server"
            CssClass="formTextBox"></asp:TextBox>
                    
    </asp:Panel>
    
    <asp:Button
        ID="createButton"
        runat="server"
        
        Text="Create vCard" 
        onclick="createButton_Click" />
</asp:Content>

