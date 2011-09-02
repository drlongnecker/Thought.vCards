using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Thought.vCards;

namespace Tests
{
    [TestFixture]
    public class vCardStandardWriterOutputTests
    {
        [Test]
        public void OutputFormattingTest()
        {
            StringWriter textWriter = new StringWriter();

            vCardStandardWriter writer = new vCardStandardWriter();
            writer.Write(GenerateCard(), textWriter);
            var output = Regex.Split(textWriter.ToString(), "\r\n");

            Assert.AreEqual("BEGIN:VCARD", output[0]);
            Assert.AreEqual("VERSION:3.0", output[1]);
            Assert.AreEqual("NAME:Bob Smith", output[2]);
            Assert.AreEqual("N:Smith;Bob;;;", output[3]);
            Assert.AreEqual("FN:Bob Smith", output[4]);
            Assert.AreEqual("EMAIL;PREF;INTERNET:bsmith@widgetsareus.com", output[5]);
            Assert.AreEqual("EMAIL;INTERNET:bob.smith@home.com", output[6]);
            Assert.AreEqual("ORG:Widgets Are Us", output[7]);
            Assert.AreEqual("REV:1/1/2011 10:00:00 AM", output[8]);
            Assert.AreEqual("TEL;HOME:8005558787", output[9]);
            Assert.AreEqual("TEL;WORK:8005557878", output[10]);
            Assert.AreEqual("TEL;CELL:8005551234", output[11]);
            Assert.AreEqual("TITLE:Lead Widgeter", output[12]);
            Assert.AreEqual("END:VCARD", output[13]);
        }

        public vCard GenerateCard()
        {
            var card = new vCard();
            card.Version = vCardVersion.Version3;
            card.FamilyName = "Smith";
            card.GivenName = "Bob";
            card.FormattedName = "Bob Smith";
            card.Phones.Add(new vCardPhone("8005558787", vCardPhoneTypes.Home));
            card.Phones.Add(new vCardPhone("8005557878", vCardPhoneTypes.Work));
            card.Phones.Add(new vCardPhone("8005551234", vCardPhoneTypes.Cellular));
            card.DisplayName = "Bob Smith";
            card.Office = "Engineering";
            card.Organization = "Widgets Are Us";
            card.Department = "Widgets";
            card.RevisionDate = Convert.ToDateTime("1/1/2011 10:00 AM");
            card.Title = "Lead Widgeter";
            card.EmailAddresses.Add(new vCardEmailAddress("bsmith@widgetsareus.com", vCardEmailAddressType.Internet){IsPreferred = true});
            card.EmailAddresses.Add(new vCardEmailAddress("bob.smith@home.com", vCardEmailAddressType.Internet));
            return card;
        }
    }
}