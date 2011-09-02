<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainTabControl = New System.Windows.Forms.TabControl
        Me.SummaryPage = New System.Windows.Forms.TabPage
        Me.SummaryGroup = New System.Windows.Forms.GroupBox
        Me.WorkWebSiteValue = New System.Windows.Forms.Label
        Me.OrganizationValue = New System.Windows.Forms.Label
        Me.OfficeValue = New System.Windows.Forms.Label
        Me.DepartmentValue = New System.Windows.Forms.Label
        Me.JobTitleValue = New System.Windows.Forms.Label
        Me.WorkFaxValue = New System.Windows.Forms.Label
        Me.WorkPhoneValue = New System.Windows.Forms.Label
        Me.PersonalWebSiteValue = New System.Windows.Forms.Label
        Me.CellularPhoneValue = New System.Windows.Forms.Label
        Me.PagerValue = New System.Windows.Forms.Label
        Me.HomePhoneValue = New System.Windows.Forms.Label
        Me.EmailAddressValue = New System.Windows.Forms.Label
        Me.FormattedNameValue = New System.Windows.Forms.Label
        Me.WorkWebSiteLabel = New System.Windows.Forms.Label
        Me.OrganizationLabel = New System.Windows.Forms.Label
        Me.OfficeLabel = New System.Windows.Forms.Label
        Me.DepartmentLabel = New System.Windows.Forms.Label
        Me.JobTitleLabel = New System.Windows.Forms.Label
        Me.BusinessFaxLabel = New System.Windows.Forms.Label
        Me.WorkPhoneLabel = New System.Windows.Forms.Label
        Me.PersonalWebSiteLabel = New System.Windows.Forms.Label
        Me.CellularPhoneLabel = New System.Windows.Forms.Label
        Me.PagerLabel = New System.Windows.Forms.Label
        Me.HomePhoneLabel = New System.Windows.Forms.Label
        Me.EmailAddressLabel = New System.Windows.Forms.Label
        Me.FormattedNameLabel = New System.Windows.Forms.Label
        Me.PhotoBox = New System.Windows.Forms.PictureBox
        Me.MainTabControl.SuspendLayout()
        Me.SummaryPage.SuspendLayout()
        Me.SummaryGroup.SuspendLayout()
        CType(Me.PhotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.SummaryPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(5, 5)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(655, 323)
        Me.MainTabControl.TabIndex = 0
        '
        'SummaryPage
        '
        Me.SummaryPage.Controls.Add(Me.SummaryGroup)
        Me.SummaryPage.Controls.Add(Me.PhotoBox)
        Me.SummaryPage.Location = New System.Drawing.Point(4, 22)
        Me.SummaryPage.Name = "SummaryPage"
        Me.SummaryPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SummaryPage.Size = New System.Drawing.Size(647, 297)
        Me.SummaryPage.TabIndex = 0
        Me.SummaryPage.Text = "Summary"
        Me.SummaryPage.UseVisualStyleBackColor = True
        '
        'SummaryGroup
        '
        Me.SummaryGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SummaryGroup.Controls.Add(Me.WorkWebSiteValue)
        Me.SummaryGroup.Controls.Add(Me.OrganizationValue)
        Me.SummaryGroup.Controls.Add(Me.OfficeValue)
        Me.SummaryGroup.Controls.Add(Me.DepartmentValue)
        Me.SummaryGroup.Controls.Add(Me.JobTitleValue)
        Me.SummaryGroup.Controls.Add(Me.WorkFaxValue)
        Me.SummaryGroup.Controls.Add(Me.WorkPhoneValue)
        Me.SummaryGroup.Controls.Add(Me.PersonalWebSiteValue)
        Me.SummaryGroup.Controls.Add(Me.CellularPhoneValue)
        Me.SummaryGroup.Controls.Add(Me.PagerValue)
        Me.SummaryGroup.Controls.Add(Me.HomePhoneValue)
        Me.SummaryGroup.Controls.Add(Me.EmailAddressValue)
        Me.SummaryGroup.Controls.Add(Me.FormattedNameValue)
        Me.SummaryGroup.Controls.Add(Me.WorkWebSiteLabel)
        Me.SummaryGroup.Controls.Add(Me.OrganizationLabel)
        Me.SummaryGroup.Controls.Add(Me.OfficeLabel)
        Me.SummaryGroup.Controls.Add(Me.DepartmentLabel)
        Me.SummaryGroup.Controls.Add(Me.JobTitleLabel)
        Me.SummaryGroup.Controls.Add(Me.BusinessFaxLabel)
        Me.SummaryGroup.Controls.Add(Me.WorkPhoneLabel)
        Me.SummaryGroup.Controls.Add(Me.PersonalWebSiteLabel)
        Me.SummaryGroup.Controls.Add(Me.CellularPhoneLabel)
        Me.SummaryGroup.Controls.Add(Me.PagerLabel)
        Me.SummaryGroup.Controls.Add(Me.HomePhoneLabel)
        Me.SummaryGroup.Controls.Add(Me.EmailAddressLabel)
        Me.SummaryGroup.Controls.Add(Me.FormattedNameLabel)
        Me.SummaryGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SummaryGroup.Location = New System.Drawing.Point(144, 14)
        Me.SummaryGroup.Name = "SummaryGroup"
        Me.SummaryGroup.Size = New System.Drawing.Size(495, 273)
        Me.SummaryGroup.TabIndex = 27
        Me.SummaryGroup.TabStop = False
        Me.SummaryGroup.Text = "Summary"
        '
        'WorkWebSiteValue
        '
        Me.WorkWebSiteValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WorkWebSiteValue.Location = New System.Drawing.Point(136, 242)
        Me.WorkWebSiteValue.Name = "WorkWebSiteValue"
        Me.WorkWebSiteValue.Size = New System.Drawing.Size(353, 19)
        Me.WorkWebSiteValue.TabIndex = 51
        Me.WorkWebSiteValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrganizationValue
        '
        Me.OrganizationValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrganizationValue.Location = New System.Drawing.Point(136, 223)
        Me.OrganizationValue.Name = "OrganizationValue"
        Me.OrganizationValue.Size = New System.Drawing.Size(353, 19)
        Me.OrganizationValue.TabIndex = 50
        Me.OrganizationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OfficeValue
        '
        Me.OfficeValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfficeValue.Location = New System.Drawing.Point(136, 204)
        Me.OfficeValue.Name = "OfficeValue"
        Me.OfficeValue.Size = New System.Drawing.Size(353, 19)
        Me.OfficeValue.TabIndex = 49
        Me.OfficeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DepartmentValue
        '
        Me.DepartmentValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DepartmentValue.Location = New System.Drawing.Point(136, 185)
        Me.DepartmentValue.Name = "DepartmentValue"
        Me.DepartmentValue.Size = New System.Drawing.Size(353, 19)
        Me.DepartmentValue.TabIndex = 48
        Me.DepartmentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JobTitleValue
        '
        Me.JobTitleValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JobTitleValue.Location = New System.Drawing.Point(136, 166)
        Me.JobTitleValue.Name = "JobTitleValue"
        Me.JobTitleValue.Size = New System.Drawing.Size(353, 19)
        Me.JobTitleValue.TabIndex = 47
        Me.JobTitleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WorkFaxValue
        '
        Me.WorkFaxValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WorkFaxValue.Location = New System.Drawing.Point(136, 147)
        Me.WorkFaxValue.Name = "WorkFaxValue"
        Me.WorkFaxValue.Size = New System.Drawing.Size(353, 19)
        Me.WorkFaxValue.TabIndex = 46
        Me.WorkFaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WorkPhoneValue
        '
        Me.WorkPhoneValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WorkPhoneValue.Location = New System.Drawing.Point(136, 128)
        Me.WorkPhoneValue.Name = "WorkPhoneValue"
        Me.WorkPhoneValue.Size = New System.Drawing.Size(353, 19)
        Me.WorkPhoneValue.TabIndex = 45
        Me.WorkPhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PersonalWebSiteValue
        '
        Me.PersonalWebSiteValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonalWebSiteValue.Location = New System.Drawing.Point(136, 109)
        Me.PersonalWebSiteValue.Name = "PersonalWebSiteValue"
        Me.PersonalWebSiteValue.Size = New System.Drawing.Size(353, 19)
        Me.PersonalWebSiteValue.TabIndex = 44
        Me.PersonalWebSiteValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CellularPhoneValue
        '
        Me.CellularPhoneValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellularPhoneValue.Location = New System.Drawing.Point(136, 90)
        Me.CellularPhoneValue.Name = "CellularPhoneValue"
        Me.CellularPhoneValue.Size = New System.Drawing.Size(353, 19)
        Me.CellularPhoneValue.TabIndex = 43
        Me.CellularPhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PagerValue
        '
        Me.PagerValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagerValue.Location = New System.Drawing.Point(136, 71)
        Me.PagerValue.Name = "PagerValue"
        Me.PagerValue.Size = New System.Drawing.Size(353, 19)
        Me.PagerValue.TabIndex = 42
        Me.PagerValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HomePhoneValue
        '
        Me.HomePhoneValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomePhoneValue.Location = New System.Drawing.Point(136, 52)
        Me.HomePhoneValue.Name = "HomePhoneValue"
        Me.HomePhoneValue.Size = New System.Drawing.Size(353, 19)
        Me.HomePhoneValue.TabIndex = 41
        Me.HomePhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailAddressValue
        '
        Me.EmailAddressValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailAddressValue.Location = New System.Drawing.Point(136, 33)
        Me.EmailAddressValue.Name = "EmailAddressValue"
        Me.EmailAddressValue.Size = New System.Drawing.Size(353, 19)
        Me.EmailAddressValue.TabIndex = 40
        Me.EmailAddressValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormattedNameValue
        '
        Me.FormattedNameValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormattedNameValue.Location = New System.Drawing.Point(136, 14)
        Me.FormattedNameValue.Name = "FormattedNameValue"
        Me.FormattedNameValue.Size = New System.Drawing.Size(353, 19)
        Me.FormattedNameValue.TabIndex = 39
        Me.FormattedNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WorkWebSiteLabel
        '
        Me.WorkWebSiteLabel.Location = New System.Drawing.Point(6, 242)
        Me.WorkWebSiteLabel.Name = "WorkWebSiteLabel"
        Me.WorkWebSiteLabel.Size = New System.Drawing.Size(124, 19)
        Me.WorkWebSiteLabel.TabIndex = 38
        Me.WorkWebSiteLabel.Text = "Business Web Page:"
        Me.WorkWebSiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OrganizationLabel
        '
        Me.OrganizationLabel.Location = New System.Drawing.Point(6, 223)
        Me.OrganizationLabel.Name = "OrganizationLabel"
        Me.OrganizationLabel.Size = New System.Drawing.Size(124, 19)
        Me.OrganizationLabel.TabIndex = 37
        Me.OrganizationLabel.Text = "Company Name:"
        Me.OrganizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OfficeLabel
        '
        Me.OfficeLabel.Location = New System.Drawing.Point(6, 204)
        Me.OfficeLabel.Name = "OfficeLabel"
        Me.OfficeLabel.Size = New System.Drawing.Size(124, 19)
        Me.OfficeLabel.TabIndex = 36
        Me.OfficeLabel.Text = "Office:"
        Me.OfficeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.Location = New System.Drawing.Point(6, 185)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(124, 19)
        Me.DepartmentLabel.TabIndex = 35
        Me.DepartmentLabel.Text = "Department:"
        Me.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JobTitleLabel
        '
        Me.JobTitleLabel.Location = New System.Drawing.Point(6, 166)
        Me.JobTitleLabel.Name = "JobTitleLabel"
        Me.JobTitleLabel.Size = New System.Drawing.Size(124, 19)
        Me.JobTitleLabel.TabIndex = 34
        Me.JobTitleLabel.Text = "Job Title:"
        Me.JobTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BusinessFaxLabel
        '
        Me.BusinessFaxLabel.Location = New System.Drawing.Point(6, 147)
        Me.BusinessFaxLabel.Name = "BusinessFaxLabel"
        Me.BusinessFaxLabel.Size = New System.Drawing.Size(124, 19)
        Me.BusinessFaxLabel.TabIndex = 33
        Me.BusinessFaxLabel.Text = "Business Fax:"
        Me.BusinessFaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WorkPhoneLabel
        '
        Me.WorkPhoneLabel.Location = New System.Drawing.Point(6, 128)
        Me.WorkPhoneLabel.Name = "WorkPhoneLabel"
        Me.WorkPhoneLabel.Size = New System.Drawing.Size(124, 19)
        Me.WorkPhoneLabel.TabIndex = 32
        Me.WorkPhoneLabel.Text = "Business Phone:"
        Me.WorkPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PersonalWebSiteLabel
        '
        Me.PersonalWebSiteLabel.Location = New System.Drawing.Point(6, 109)
        Me.PersonalWebSiteLabel.Name = "PersonalWebSiteLabel"
        Me.PersonalWebSiteLabel.Size = New System.Drawing.Size(124, 19)
        Me.PersonalWebSiteLabel.TabIndex = 31
        Me.PersonalWebSiteLabel.Text = "Personal Web Page:"
        Me.PersonalWebSiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CellularPhoneLabel
        '
        Me.CellularPhoneLabel.Location = New System.Drawing.Point(6, 90)
        Me.CellularPhoneLabel.Name = "CellularPhoneLabel"
        Me.CellularPhoneLabel.Size = New System.Drawing.Size(124, 19)
        Me.CellularPhoneLabel.TabIndex = 30
        Me.CellularPhoneLabel.Text = "Mobile:"
        Me.CellularPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PagerLabel
        '
        Me.PagerLabel.Location = New System.Drawing.Point(6, 71)
        Me.PagerLabel.Name = "PagerLabel"
        Me.PagerLabel.Size = New System.Drawing.Size(124, 19)
        Me.PagerLabel.TabIndex = 29
        Me.PagerLabel.Text = "Pager:"
        Me.PagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HomePhoneLabel
        '
        Me.HomePhoneLabel.Location = New System.Drawing.Point(6, 52)
        Me.HomePhoneLabel.Name = "HomePhoneLabel"
        Me.HomePhoneLabel.Size = New System.Drawing.Size(124, 19)
        Me.HomePhoneLabel.TabIndex = 28
        Me.HomePhoneLabel.Text = "Home Phone:"
        Me.HomePhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailAddressLabel
        '
        Me.EmailAddressLabel.Location = New System.Drawing.Point(6, 33)
        Me.EmailAddressLabel.Name = "EmailAddressLabel"
        Me.EmailAddressLabel.Size = New System.Drawing.Size(124, 19)
        Me.EmailAddressLabel.TabIndex = 27
        Me.EmailAddressLabel.Text = "Email Address:"
        Me.EmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormattedNameLabel
        '
        Me.FormattedNameLabel.Location = New System.Drawing.Point(6, 14)
        Me.FormattedNameLabel.Name = "FormattedNameLabel"
        Me.FormattedNameLabel.Size = New System.Drawing.Size(124, 19)
        Me.FormattedNameLabel.TabIndex = 26
        Me.FormattedNameLabel.Text = "Name:"
        Me.FormattedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhotoBox
        '
        Me.PhotoBox.Location = New System.Drawing.Point(10, 28)
        Me.PhotoBox.Name = "PhotoBox"
        Me.PhotoBox.Size = New System.Drawing.Size(128, 128)
        Me.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PhotoBox.TabIndex = 26
        Me.PhotoBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 333)
        Me.Controls.Add(Me.MainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.MainTabControl.ResumeLayout(False)
        Me.SummaryPage.ResumeLayout(False)
        Me.SummaryGroup.ResumeLayout(False)
        CType(Me.PhotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents SummaryPage As System.Windows.Forms.TabPage
    Friend WithEvents PhotoBox As System.Windows.Forms.PictureBox
    Friend WithEvents SummaryGroup As System.Windows.Forms.GroupBox
    Friend WithEvents WorkWebSiteValue As System.Windows.Forms.Label
    Friend WithEvents OrganizationValue As System.Windows.Forms.Label
    Friend WithEvents OfficeValue As System.Windows.Forms.Label
    Friend WithEvents DepartmentValue As System.Windows.Forms.Label
    Friend WithEvents JobTitleValue As System.Windows.Forms.Label
    Friend WithEvents WorkFaxValue As System.Windows.Forms.Label
    Friend WithEvents WorkPhoneValue As System.Windows.Forms.Label
    Friend WithEvents PersonalWebSiteValue As System.Windows.Forms.Label
    Friend WithEvents CellularPhoneValue As System.Windows.Forms.Label
    Friend WithEvents PagerValue As System.Windows.Forms.Label
    Friend WithEvents HomePhoneValue As System.Windows.Forms.Label
    Friend WithEvents EmailAddressValue As System.Windows.Forms.Label
    Friend WithEvents FormattedNameValue As System.Windows.Forms.Label
    Friend WithEvents WorkWebSiteLabel As System.Windows.Forms.Label
    Friend WithEvents OrganizationLabel As System.Windows.Forms.Label
    Friend WithEvents OfficeLabel As System.Windows.Forms.Label
    Friend WithEvents DepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents JobTitleLabel As System.Windows.Forms.Label
    Friend WithEvents BusinessFaxLabel As System.Windows.Forms.Label
    Friend WithEvents WorkPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents PersonalWebSiteLabel As System.Windows.Forms.Label
    Friend WithEvents CellularPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents PagerLabel As System.Windows.Forms.Label
    Friend WithEvents HomePhoneLabel As System.Windows.Forms.Label
    Friend WithEvents EmailAddressLabel As System.Windows.Forms.Label
    Friend WithEvents FormattedNameLabel As System.Windows.Forms.Label

End Class
