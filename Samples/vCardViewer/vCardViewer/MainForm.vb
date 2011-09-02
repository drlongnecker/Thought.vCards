
Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Windows.Forms
Imports Thought.vCards

' ========================================================================
' MainForm
' ------------------------------------------------------------------------
' This is the main form of the vCard viewer sample.
' ========================================================================

Public Class MainForm

    ' ====================================================================
    ' HandleFormLoad
    ' --------------------------------------------------------------------
    ' Executed when the form is loaded.
    ' ====================================================================

    Private Sub HandleFormLoad( _
          ByVal sender As Object, _
          ByVal e As EventArgs) Handles Me.Load

        ' Popup a dialog box and ask the user to select a file.
        ' The SelectCardFile function is a private method
        ' in this cass (see below).

        Dim filename As String = SelectCardFile()

        ' Exit the application if no file was selected.  This means
        ' the user clicked the cancel button.

        If filename Is Nothing Then

            Me.Close()

        Else

            ' Create a new vCard object and populate the form.

            Dim card As New vCard(filename)
            Populate(card)

        End If

    End Sub

    ' ====================================================================
    ' SelectCardFile
    ' --------------------------------------------------------------------
    ' Opens a dialog box for selecting a vCard file.  A null string is
    ' returned if the user hits cancel or closes the dialog box without
    ' selecting a file.
    ' ====================================================================

    Public Function SelectCardFile() As String

        Dim dialog As New OpenFileDialog()

        With dialog

            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "vCard Files (*.VCF)|*.VCF|All Files (*.*)|*.*"
            .FilterIndex = 0

#If DEBUG Then
            .InitialDirectory = Path.Combine(Application.StartupPath, "..\..\..\")
#End If

            .ShowReadOnly = False

            Dim result As DialogResult = .ShowDialog(Me)

            If result = DialogResult.Cancel Then
                Return Nothing
            Else
                Return dialog.FileName
            End If

        End With

    End Function

    ' ====================================================================
    ' Populate
    ' --------------------------------------------------------------------
    ' Populates the form with information from the specified vCard.
    ' ====================================================================

    Public Sub Populate(ByVal card As vCard)

        If card Is Nothing Then
            Throw New ArgumentNullException("card")
        End If

        With card

            Me.Text = .ToString()

            ' Cellular Phone

            SetSummaryValue( _
                CellularPhoneValue, _
                .Phones.GetFirstChoice(vCardPhoneTypes.Cellular))

            ' Department

            SetSummaryValue( _
                DepartmentValue, _
                .Department)

            ' Email Address 

            SetSummaryValue( _
                EmailAddressValue, _
                .EmailAddresses.GetFirstChoice(vCardEmailAddressType.Internet))

            ' Formatted Name

            SetSummaryValue( _
                FormattedNameValue, _
                .FormattedName)

            ' Home Phone

            SetSummaryValue( _
                HomePhoneValue, _
                .Phones.GetFirstChoice(vCardPhoneTypes.HomeVoice))

            ' Job Title

            SetSummaryValue( _
                JobTitleValue, _
                .Title)

            ' Office

            SetSummaryValue( _
                OfficeValue, _
                .Office)

            ' Organization

            SetSummaryValue( _
                OrganizationValue, _
                .Organization)

            ' Pager

            SetSummaryValue( _
                PagerValue, _
                .Phones.GetFirstChoice(vCardPhoneTypes.Pager))

            ' Personal Home Page

            SetSummaryValue( _
                PersonalWebSiteValue, _
                .Websites.GetFirstChoice(vCardWebsiteTypes.Personal))

            ' Photo

            If .Photos.Count > 0 Then

                With .Photos(0)

                    Try

                        ' Get the bytes of the photo if it has
                        ' not already been loaded.

                        If Not .IsLoaded Then
                            .Fetch()
                        End If

                        PhotoBox.Image = .GetBitmap()

                    Catch

                        ' Ignore this error.
                        ' A later version of the viewer should show
                        ' a broken image icon (like IE) instead.


                    End Try

                End With

            End If

            ' Work Fax

            SetSummaryValue( _
                WorkFaxValue, _
                .Phones.GetFirstChoice(vCardPhoneTypes.Fax))

            ' Work Phone

            SetSummaryValue( _
                WorkPhoneValue, _
                .Phones.GetFirstChoice(vCardPhoneTypes.WorkVoice))

            ' Work Web Site

            SetSummaryValue( _
                WorkWebSiteValue, _
                .Websites.GetFirstChoice(vCardWebsiteTypes.Work))

        End With

    End Sub

    ' ====================================================================
    ' SetSummaryValue(label, vCardEmailAddress)
    ' ====================================================================

    Private Sub SetSummaryValue( _
          ByVal valueLabel As Label, _
          ByVal email As vCardEmailAddress)

        If email IsNot Nothing Then
            SetSummaryValue(valueLabel, email.Address)
        End If

    End Sub

    ' ====================================================================
    ' SetSummaryValue(label, vCardPhone)
    ' ====================================================================

    Private Sub SetSummaryValue( _
          ByVal valueLabel As Label, _
          ByVal phone As vCardPhone)

        If phone IsNot Nothing Then
            SetSummaryValue(valueLabel, phone.FullNumber)
        End If

    End Sub

    ' ====================================================================
    ' SetSummaryValue(label, vCardWebSite)
    ' ====================================================================

    Private Sub SetSummaryValue( _
          ByVal valueLabel As Label, _
          ByVal webSite As vCardWebSite)

        If webSite IsNot Nothing Then
            SetSummaryValue(valueLabel, webSite.Url.ToString)
        End If

    End Sub

    ' ====================================================================
    ' SetSummaryValue(label, string)
    ' ====================================================================

    Private Sub SetSummaryValue( _
          ByVal valueLabel As Label, _
          ByVal value As String)

        If valueLabel Is Nothing Then
            Throw New ArgumentNullException("valueLabel")
        End If

        If String.IsNullOrEmpty(value) Then

        Else
            valueLabel.Text = value
        End If

    End Sub

End Class
