using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBuilder
{
    public partial class DefaultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {


            vCard card = new vCard();

            // Simple properties

            //card.AdditionalNames = AdditionalNames.Text;
            card.FamilyName = this.familyNameBox.Text;
            card.FormattedName = this.formattedNameBox.Text;
            card.GivenName = this.givenNameBox.Text;
            //card.NamePrefix = NamePrefix.Text;
            //card.NameSuffix = NameSuffix.Text;
            card.Organization = this.organizationTextBox.Text;
            //card.Role = Role.Text;
            card.Title = this.titleTextBox.Text;

            // ---------------------------------------------------------------
            // Email Addresses
            // ---------------------------------------------------------------
            // A vCard supports any number of email addresses.

            if (!string.IsNullOrEmpty(this.workEmailBox.Text))
            {
                card.EmailAddresses.Add(
                    new vCardEmailAddress(this.workEmailBox.Text));
            }

            // ---------------------------------------------------------------
            // Nicknames
            // ---------------------------------------------------------------

            string[] nicklist = this.nicknamesBox.Text.Split(new char[] { ',' });
            foreach (string nick in nicklist)
            {
                if (nick.Length > 0)
                    card.Nicknames.Add(nick);
            }


            // ---------------------------------------------------------------
            // Notes
            // ---------------------------------------------------------------
            // The vCard specification allows for multiple notes, although
            // most applications seem to support a maximum of one note.

            //if (Note.Text.Length > 0)
            //{
            //    card.Notes.Add(new vCardNote(Note.Text));
            //}


            // ---------------------------------------------------------------
            // Phones
            // ---------------------------------------------------------------
            //
            // A vCard supports any number of telephones.  Each telephone can
            // have a different type (such as a video phone or a fax) and a
            // purpose (e.g. a home number or a work number).

            //if (!string.IsNullOrEmpty(WorkPhone.Text))
            //{
            //    card.Phones.Add(
            //        new vCardPhone(WorkPhone.Text, vCardPhoneTypes.WorkVoice));
            //}

            //if (!string.IsNullOrEmpty(WorkFax.Text))
            //{
            //    card.Phones.Add(
            //        new vCardPhone(WorkFax.Text, vCardPhoneTypes.WorkFax));
            //}


            // ---------------------------------------------------------------
            // Web Sites
            // ---------------------------------------------------------------

            //if (WorkWebSite.Text.Length > 0)
            //{
            //    card.Websites.Add(
            //        new vCardWebsite(WorkWebSite.Text, vCardWebsiteTypes.Work));
            //}


            // The vCard object has been populated.  The rest of
            // the code generates the vCard file format and exports
            // it to the response stream.

            Response.ContentType = "text/x-vcard";

            // The "content-disposition" is a special HTTP header
            // that tells the web browser how to interpreted the
            // output.  In this case, the browser is informed the
            // content should be treated as an attachment with
            // a default filename.  This should cause the browser
            // to display a dialog box to save the vCard (instead
            // of displaying the vCard as inline text).

            Response.AppendHeader(
                "content-disposition", "attachment;filename=vCard.vcf");

            vCardStandardWriter writer = new vCardStandardWriter();

            writer.EmbedInternetImages = false;
            writer.EmbedLocalImages = true;
            writer.Options = vCardStandardWriterOptions.IgnoreCommas;

            writer.Write(card, Response.Output);
            Response.End();

        }
    }
}
