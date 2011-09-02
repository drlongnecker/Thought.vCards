
using System;
using NUnit.Framework;
using Thought.vCards;

namespace Tests
{

    [TestFixture]
    public class vCardSourceTests
    {

        #region [ Constructor ]

        [Test]
        public void Constructor()
        {

            // Tests the default values of the vCardSource
            // class when the parameterless constructor is used.

            vCardSource source = new vCardSource();

            Assert.IsEmpty(
                source.Context,
                "The Context property should default to empty.");

            Assert.IsNull(
                source.Uri,
                "The Uri property should default to null.");

        }

        #endregion

        #region [ ReadWriteProperty_Context ]

        [Test]
        public void ReadWriteProperty_Context()
        {

            vCardSource source = new vCardSource();

            source.Context = "LDAP";
            Assert.AreEqual(
                "LDAP",
                source.Context,
                "The Context property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_Uri ]

        [Test]
        public void ReadWriteProperty_Uri()
        {

            Uri testUri = new Uri("isdn:123456789");
            vCardSource source = new vCardSource();

            source.Uri = testUri;
            Assert.AreEqual(
                testUri,
                source.Uri);

            
        }

        #endregion

    }
}
