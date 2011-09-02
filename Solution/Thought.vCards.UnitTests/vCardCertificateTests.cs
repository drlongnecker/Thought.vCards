
using System;
using NUnit.Framework;
using Thought.vCards;

namespace Tests
{
    [TestFixture]
    public class vCardCertificateTests
    {

        [Test]
        public void EmptyString_KeyType()
        {

            vCardCertificate cert = new vCardCertificate();

            Assert.IsEmpty(
                cert.KeyType,
                "The string KeyType property should default to String.Empty.");

            cert.KeyType = null;

            Assert.IsEmpty(
                cert.KeyType,
                "The string KeyType should be String.Empty when assigned null.");

        }

    }
}
