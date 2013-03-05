using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thought.vCards;
using System.IO;

namespace Tests.Samples
{
    /// <summary>
    /// Summary description for IntegrationTest
    /// </summary>
    [TestClass]
    public class IntegrationTest
    {
        public IntegrationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SamplevCardReadAndWriteTestWithEmailTypeFormat()
        {

            vCard card = new vCard();

            card.EmailAddresses.Add(new vCardEmailAddress() { Address = "john@email.com", EmailType = vCardEmailAddressType.Internet, IsPreferred = true, ItemType = ItemType.WORK });


            card.UniqueId = Guid.NewGuid().ToString("N");

            string text = card.ToString();

            vCardStandardWriter writer = new vCardStandardWriter();

            using (StringWriter sw = new StringWriter())
            {

                writer.Write(card, sw);

                sw.Flush();
                text = sw.ToString();
                sw.Close();
            }


            Assert.IsNotNull(text);


            vCardStandardReader reader = new vCardStandardReader();

            using (StringReader sr = new StringReader(text))
            {

                vCard cardFromReader = reader.Read(sr);

                Assert.AreEqual(1, cardFromReader.EmailAddresses.Count);

                var email = cardFromReader.EmailAddresses.First();
                Assert.AreEqual(true, email.IsPreferred);
                Assert.AreEqual(ItemType.WORK, email.ItemType);
                Assert.AreEqual(vCardEmailAddressType.Internet, email.EmailType);
                Assert.AreEqual("john@email.com", email.Address);
            }

        }

        [TestMethod]
        public void SamlevCardReadAndWriteTestWithContentFromWikipedia()
        {

            string text = @"BEGIN:VCARD
VERSION:3.0
N:Gump;Forrest
FN:Forrest Gump
ORG:Bubba Gump Shrimp Co.
TITLE:Shrimp Man
PHOTO;VALUE=URL;TYPE=GIF:http://www.example.com/dir_photos/my_photo.gif
TEL;TYPE=WORK,VOICE:(111) 555-1212
TEL;TYPE=HOME,VOICE:(404) 555-1212
ADR;TYPE=WORK:;;100 Waters Edge;Baytown;LA;30314;United States of America
LABEL;TYPE=WORK:100 Waters Edge\nBaytown, LA 30314\nUnited States of America
ADR;TYPE=HOME:;;42 Plantation St.;Baytown;LA;30314;United States of America
LABEL;TYPE=HOME:42 Plantation St.\nBaytown, LA 30314\nUnited States of America
EMAIL;TYPE=PREF,INTERNET:forrestgump@example.com
REV:2008-04-24T19:52:43Z
END:VCARD";

            vCardStandardReader reader = new vCardStandardReader();

            using (StringReader sr = new StringReader(text))
            {

                vCard cardFromReader = reader.Read(sr);

                Assert.AreEqual(1, cardFromReader.EmailAddresses.Count);

                var email = cardFromReader.EmailAddresses.First();
                Assert.AreEqual(true, email.IsPreferred);
                Assert.AreEqual(ItemType.UNSPECIFIED, email.ItemType);
                Assert.AreEqual(vCardEmailAddressType.Internet, email.EmailType);
                Assert.AreEqual("forrestgump@example.com", email.Address);


                Assert.AreEqual("Shrimp Man", cardFromReader.Title);
                Assert.AreEqual("Forrest", cardFromReader.GivenName);
                Assert.AreEqual("Gump", cardFromReader.FamilyName);


                Assert.AreEqual(2, cardFromReader.Phones.Count);

                var phone404 = cardFromReader.Phones.FirstOrDefault(x => x.FullNumber == "(404) 555-1212");
                var phone111 = cardFromReader.Phones.FirstOrDefault(x => x.FullNumber == "(111) 555-1212");

                Assert.IsNotNull(phone111);
                Assert.IsNotNull(phone404);

                Assert.IsTrue(phone111.IsWork);
                Assert.IsTrue(phone111.IsVoice);

                Assert.IsTrue(phone404.IsVoice);
                Assert.IsTrue(phone404.IsHome);


            }


            //need to add social Profile types as property to the vCard object and reader/writer
            //need to try and add a bunch of properties in my ipad NAB and email me a .vcf file
            //then generate via my parser and try and import the VCF into my ipad
            //look at creating nuGet package for deploying the bin / dll


        }

        [TestMethod]
        public void ShouldReadvCardWithAllCBFieldsFilledOutFromiPhoneNAB()
        {
            string text = @"BEGIN:VCARDVERSION:3.0PRODID:-//Apple Inc.//iOS 6.0.1//ENN:iOS;Nic;;;FN:Nic iOSORG:Ibm;TITLE:Sales Guyitem1.EMAIL;type=INTERNET;type=pref:nic.schlueter@dublabs.comEMAIL;type=INTERNET;type=WORK:nic@work.comEMAIL;type=INTERNET;type=WORK:nic2@work.comEMAIL;type=INTERNET;type=HOME:h@h.comEMAIL;type=INTERNET;type=HOME:y@y.comTEL;type=CELL;type=VOICE;type=pref:(202) 333-4555TEL;type=IPHONE;type=CELL;type=VOICE:(202) 333-4444TEL;type=HOME;type=VOICE:(333) 222-2222TEL;type=WORK;type=VOICE:(809) 555-6666 x444TEL;type=MAIN:(609) 888-7777TEL;type=HOME;type=FAX:(555) 444-4443TEL;type=WORK;type=FAX:33322222222item2.TEL:(999) 777-7999item2.X-ABLabel:personalitem3.ADR;type=HOME;type=pref:;;8230 Boone Blvd;Vinna;VA;22182;United Statesitem3.X-ABADR:usitem4.URL;type=pref:http://facebook.com/max.solenderitem4.X-ABLabel:Profileitem5.URL:www.ibm.comitem5.X-ABLabel:_$!<HomePage>!$_item6.X-MSN:msnnameitem6.X-ABLabel:_$!<Other>!$_item7.X-AIM:aolnameitem7.X-ABLabel:_$!<Other>!$_item8.X-YAHOO:yahoonameitem8.X-ABLabel:_$!<Other>!$_item9.X-JABBER:jabbernameitem9.X-ABLabel:_$!<Other>!$_IMPP;X-SERVICE-TYPE=Skype;type=HOME;type=pref:skype:skypeusernameeeIMPP;X-SERVICE-TYPE=Skype;type=WORK:skype:worksyokeusernameitem10.IMPP;X-SERVICE-TYPE=MSN:msnim:msnnameitem10.X-ABLabel:_$!<Other>!$_item11.IMPP;X-SERVICE-TYPE=AIM:aim:aolnameitem11.X-ABLabel:_$!<Other>!$_item12.IMPP;X-SERVICE-TYPE=GoogleTalk:xmpp:gtalknameitem12.X-ABLabel:_$!<Other>!$_item13.IMPP;X-SERVICE-TYPE=Yahoo:ymsgr:yahoonameitem13.X-ABLabel:_$!<Other>!$_item14.IMPP;X-SERVICE-TYPE=Facebook:xmpp:fbchatnameitem14.X-ABLabel:_$!<Other>!$_item15.IMPP;X-SERVICE-TYPE=Jabber:xmpp:jabbernameitem15.X-ABLabel:_$!<Other>!$_X-SOCIALPROFILE;type=linkedin;x-user=nicatlinkedin:http://www.linkedin.com/in/nicatlinkedinX-SOCIALPROFILE;type=twitter;x-user=tiffanystone:http://twitter.com/tiffanystoneX-SOCIALPROFILE;type=facebook;x-user=tiffatfacebook:http://www.facebook.com/tiffatfacebookX-SOCIALPROFILE;type=twitter;x-user=gregabedard:http://twitter.com/gregabedardEND:VCARD";

            vCardStandardReader reader = new vCardStandardReader();
            using (StringReader sr = new StringReader(text))
            {

                vCard c = reader.Read(sr);

                Assert.AreEqual(5, c.EmailAddresses.Count);

                CheckEmail(c.EmailAddresses, "nic.schlueter@dublabs.com", ItemType.UNSPECIFIED, vCardEmailAddressType.Internet, true);
                CheckEmail(c.EmailAddresses, "nic@work.com", ItemType.WORK, vCardEmailAddressType.Internet, false);
                CheckEmail(c.EmailAddresses, "nic2@work.com", ItemType.WORK, vCardEmailAddressType.Internet, false);
                CheckEmail(c.EmailAddresses, "h@h.com", ItemType.HOME, vCardEmailAddressType.Internet, false);
                CheckEmail(c.EmailAddresses, "y@y.com", ItemType.HOME, vCardEmailAddressType.Internet, false);




                Assert.AreEqual("Sales Guy", c.Title);
                Assert.AreEqual("Ibm", c.Organization);
                Assert.AreEqual("Nic", c.GivenName);
                Assert.AreEqual("iOS", c.FamilyName);

    

                Assert.AreEqual(8, c.Phones.Count);

                CheckPhone(c.Phones, "(202) 333-4555", vCardPhoneTypes.Preferred | vCardPhoneTypes.Cellular | vCardPhoneTypes.Voice, true);
                CheckPhone(c.Phones, "(202) 333-4444", vCardPhoneTypes.IPhone | vCardPhoneTypes.Cellular | vCardPhoneTypes.Voice, false);
                CheckPhone(c.Phones, "(333) 222-2222", vCardPhoneTypes.Home | vCardPhoneTypes.Voice, false);
                CheckPhone(c.Phones, "(809) 555-6666 x444", vCardPhoneTypes.Work | vCardPhoneTypes.Voice, false);
                CheckPhone(c.Phones, "(609) 888-7777", vCardPhoneTypes.Main, false);
                CheckPhone(c.Phones, "(555) 444-4443", vCardPhoneTypes.Home | vCardPhoneTypes.Fax, false);
                CheckPhone(c.Phones, "33322222222", vCardPhoneTypes.Work | vCardPhoneTypes.Fax, false);
                CheckPhone(c.Phones, "(999) 777-7999", vCardPhoneTypes.Default, false);


                //phones and emails are good
                //need to check the physical address parsing and on down

                CheckAddress(c.DeliveryAddresses, "8230 Boone Blvd", "Vinna", "VA", "22182", "United States", vCardDeliveryAddressTypes.Home | vCardDeliveryAddressTypes.Preferred, true);

                CheckIM(c.IMs, "skypeusernameee", IMServiceType.Skype, ItemType.HOME, true);
                CheckIM(c.IMs, "worksyokeusername", IMServiceType.Skype, ItemType.WORK, false);
                CheckIM(c.IMs, "msnname", IMServiceType.MSN, ItemType.UNSPECIFIED, false);
                CheckIM(c.IMs, "aolname", IMServiceType.AIM, ItemType.UNSPECIFIED, false);
                CheckIM(c.IMs, "gtalkname", IMServiceType.GoogleTalk, ItemType.UNSPECIFIED, false);
                CheckIM(c.IMs, "yahooname", IMServiceType.Yahoo, ItemType.UNSPECIFIED, false);
                CheckIM(c.IMs, "fbchatname", IMServiceType.Facebook, ItemType.UNSPECIFIED, false);
                CheckIM(c.IMs, "jabbername", IMServiceType.Jabber, ItemType.UNSPECIFIED, false);

                Assert.AreEqual(4, c.SocialProfiles.Count);
                CheckSocialProfile(c.SocialProfiles, "nicatlinkedin", "http://www.linkedin.com/in/nicatlinkedin", SocialProfileServiceType.LinkedIn);
                CheckSocialProfile(c.SocialProfiles, "tiffanystone", "http://twitter.com/tiffanystone", SocialProfileServiceType.Twitter);
                CheckSocialProfile(c.SocialProfiles, "tiffatfacebook", "http://www.facebook.com/tiffatfacebook", SocialProfileServiceType.Facebook);
                CheckSocialProfile(c.SocialProfiles, "gregabedard", "http://twitter.com/gregabedard", SocialProfileServiceType.Twitter);



                //temp quickly
              vCardStandardWriter writer = new vCardStandardWriter();

                using (StringWriter sw = new StringWriter())
                {

                    writer.Write(c, sw);

                    sw.Flush();
                    text = sw.ToString();
                    sw.Close();
                }


                Assert.IsNotNull(text);
              

            }



        }

        private void CheckSocialProfile(vCardSocialProfileCollection sps, string username, string url, SocialProfileServiceType serviceType)
        {
            if (sps == null || sps.Count == 0)
            {
                Assert.Fail("sps null or empty");
            }

            var sp = sps.FirstOrDefault(x => x.Username == username && x.ServiceType == serviceType);

            Assert.IsNotNull(sp, "no match for socialProfile for " + username + " for serviceType " + serviceType.ToString());


            Assert.AreEqual(url, sp.ProfileUrl);
            Assert.AreEqual(username, sp.Username);
            Assert.AreEqual(serviceType, sp.ServiceType);

        }

        private void CheckIM(vCardIMPPCollection ims, string handle, IMServiceType serviceType, ItemType itemType, bool isPreferred)
        {

            if (ims == null || ims.Count == 0)
            {
                Assert.Fail("ims null or empty");
            }

            var im = ims.FirstOrDefault(x => x.Handle == handle && x.ServiceType == serviceType);

            Assert.IsNotNull(im, "im not matched for handle " + handle + " and servicetype " + serviceType.ToString());
            Assert.AreEqual(itemType,im.ItemType);
            Assert.AreEqual(isPreferred, im.IsPreferred);


        }

        private void CheckAddress(vCardDeliveryAddressCollection addresses, string street, string city, string state, string zip, string country, vCardDeliveryAddressTypes addressTypes, bool isPreferred)
        {
            //there is no street address 2 it is just separated with \n

            if (addresses == null || addresses.Count == 0)
            {
                Assert.Fail("addresses null or empty");
            }

            var a = addresses.FirstOrDefault(x => x.Street == street && x.City == city);

            Assert.IsNotNull(a);

            Assert.AreEqual(state, a.Region);
            Assert.AreEqual(zip, a.PostalCode);
            Assert.AreEqual(country, a.Country);
            Assert.AreEqual(addressTypes, a.AddressType);
            Assert.AreEqual(isPreferred, a.IsPreferred);



        }

        private void CheckPhone(vCardPhoneCollection phones, string value, vCardPhoneTypes types, bool isPreferred)
        {

            if (phones == null || phones.Count == 0)
            {
                Assert.Fail("phones null or empty");
            }

            var p = phones.FirstOrDefault(x => x.FullNumber == value);

            if (p == null)
            {
                Assert.Fail("phone number not found for value " + value);
            }

            Assert.AreEqual(types, p.PhoneType);

            Assert.AreEqual(isPreferred, p.IsPreferred);


            //  types.HasFlag(



        }

        private void CheckEmail(vCardEmailAddressCollection emails, string value, ItemType itemType, vCardEmailAddressType type, bool isPreferred)
        {

            if (emails == null || emails.Count == 0)
            {
                Assert.Fail("emails collection is empty or null");
            }


            var email = emails.FirstOrDefault(x => x.Address.Equals(value, StringComparison.OrdinalIgnoreCase));

            if (email == null)
            {
                Assert.Fail("email value " + value + "  is not found in collection");
            }

            Assert.AreEqual(itemType, email.ItemType);
            Assert.AreEqual(isPreferred, email.IsPreferred);
            Assert.AreEqual(type, email.EmailType);



        }


    }
}
