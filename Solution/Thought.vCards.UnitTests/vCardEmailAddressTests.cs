
using System;
using NUnit.Framework;
using Thought.vCards;

namespace Thought.vCards.UnitTests
{

    [TestFixture]
    public class vCardEmailAddressTests
    {

        private const string TestEmailAddress = "dave@thoughtproject.com";

        // The next functions test the constructor of the
        // vCardEmailAddress class.

        #region [ Constructor ]

        [Test]
        public void Constructor()
        {

            vCardEmailAddress email = new vCardEmailAddress();

            Assert.IsEmpty(
                email.Address,
                "The Address property should default to String.Empty.");

        }

        #endregion

        #region [ Constructor_String ]

        [Test]
        public void Constructor_String()
        {

            vCardEmailAddress email =
                new vCardEmailAddress(TestEmailAddress);

            Assert.AreEqual(
                TestEmailAddress,
                email.Address,
                "The EmailAddress is incorrect.");

            Assert.AreEqual(
                vCardEmailAddressType.Internet,
                email.EmailType,
                "The EmailType should default to Internet.");

        }

        #endregion

        #region [ Constructor_String_EmailType ]

        [Test]
        public void Constructor_String_EmailType()
        {

            // Create a non-Internet email address.  Note:
            // currently address formats are not validated.
            // This means any type can be designated in the
            // constructor.  However, this test may fail if
            // validation is implemented in the future.

            vCardEmailAddress email = new vCardEmailAddress(
                TestEmailAddress,
                vCardEmailAddressType.eWorld);

            Assert.AreEqual(
                TestEmailAddress,
                email.Address,
                "The EmailAddress is not correct.");

            Assert.AreEqual(
                vCardEmailAddressType.eWorld,
                email.EmailType,
                "The EmailType is not correct.");

        }

        #endregion

        // The next functions perform a read/write operation
        // of each simple property.  This is mostly intended
        // to catch accidential recursion.

        #region [ ReadWriteProperty_Address ]

        [Test]
        public void ReadWriteProperty_Address()
        {

            // Make sure the Address property reads/writes.

            vCardEmailAddress email = new vCardEmailAddress();
            email.Address = TestEmailAddress;

            Assert.AreEqual(
                TestEmailAddress,
                email.Address,
                "The Address property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_EmailType ]

        [Test]
        public void ReadWriteProperty_EmailType()
        {

            // Make sure the EmailType property reads/writes

            vCardEmailAddress email = new vCardEmailAddress();

            email.EmailType = vCardEmailAddressType.AttMail;
            Assert.AreEqual(vCardEmailAddressType.AttMail, email.EmailType);

        }

        #endregion

        #region [ ReadWriteProperty_IsPreferred ]

        [Test]
        public void ReadWriteProperty_IsPreferred()
        {

            // Make sure the EmailType property reads/writes

            vCardEmailAddress email = new vCardEmailAddress();
            email.IsPreferred = true;
            Assert.IsTrue(email.IsPreferred);

            email.IsPreferred = false;
            Assert.IsFalse(email.IsPreferred);

        }

        #endregion

    }
}
