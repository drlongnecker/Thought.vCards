
using System;
using NUnit.Framework;
using Thought.vCards;

namespace Tests
{
    [TestFixture]
    public class vCardDeliveryAddressTests
    {

        #region [ Constructor ]

        [Test]
        public void Constructor()
        {

            // Tests the default values of the address constructor.

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            Assert.IsEmpty(
                address.City,
                "The City property should default to String.Empty.");

            Assert.IsEmpty(
                address.Country,
                "The Country property should default to String.Empty.");

            Assert.IsEmpty(
                address.PostalCode,
                "The PostalCode property should default to String.Empty.");

            Assert.IsEmpty(
                address.Region,
                "The Region property should default to String.Empty.");

            Assert.IsEmpty(
                address.Street,
                "The Street property should default to String.Empty.");

        }

        #endregion

        #region [ EmptyString_City ]

        [Test]
        public void EmptyString_City()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            Assert.IsEmpty(
                address.City,
                "The City property should default to String.Empty.");

            address.City = null;

            Assert.IsEmpty(
                address.City,
                "The City property should return String.Empty instead of null.");

        }

        #endregion

        #region [ EmptyString_Country ]

        [Test]
        public void EmptyString_Country()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            Assert.IsEmpty(
                address.Country,
                "The Country property should default to String.Empty.");

            address.Country = null;

            Assert.IsEmpty(
                address.Country,
                "The Country property should return String.Empty instead of null.");

        }

        #endregion

        #region [ EmptyString_PostalCode ]

        [Test]
        public void EmptyString_PostalCode()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            Assert.IsEmpty(
                address.PostalCode,
                "The PostalCode property should default to String.Empty.");

            address.PostalCode = null;

            Assert.IsEmpty(
                address.PostalCode,
                "The PostalCode property should return String.Empty instead of null.");

        }

        #endregion

        #region [ EmptyString_Region ]

        [Test]
        public void EmptyString_Region()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            Assert.IsEmpty(
                address.Region,
                "The Region property should default to String.Empty.");

            address.Region = null;

            Assert.IsEmpty(
                address.Region,
                "The Region property should return String.Empty instead of null.");

        }

        #endregion

        #region [ EmptyString_Street ]

        [Test]
        public void EmptyString_Street()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            Assert.IsEmpty(
                address.Street,
                "The Street property should default to String.Empty.");

            address.Street = null;

            Assert.IsEmpty(
                address.Street,
                "The Street property should return String.Empty instead of null.");

        }

        #endregion

        #region [ ReadWriteProperty_AddressType ]

        [Test]
        public void ReadWriteProperty_AddressType()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.AddressType = vCardDeliveryAddressTypes.Domestic;
            Assert.AreEqual(
                vCardDeliveryAddressTypes.Domestic,
                address.AddressType,
                "The AddressType property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_City ]

        [Test]
        public void ReadWriteProperty_City()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.City = "Warroad";
            Assert.AreEqual(
                "Warroad",
                address.City,
                "The City property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Country ]

        [Test]
        public void ReadWriteProperty_Country()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.Country = "Jordan";
            Assert.AreEqual(
                "Jordan",
                address.Country,
                "The Country property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_IsDomestic ]

        [Test]
        public void ReadWriteProperty_IsDomestic()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();
            address.IsDomestic = true;
            Assert.IsTrue(
                address.IsDomestic,
                "IsDomestic should have been set to true.");

            address.IsDomestic = false;
            Assert.IsFalse(
                address.IsDomestic,
                "IsDomestic should have been set to false.");
        }

        #endregion

        #region [ ReadWriteProperty_IsHome ]

        [Test]
        public void ReadWriteProperty_IsHome()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();
            address.IsHome = true;
            Assert.IsTrue(
                address.IsHome,
                "IsHome should have been set to true.");

            address.IsHome = false;
            Assert.IsFalse(
                address.IsHome,
                "IsHome should have been set to false.");
        }

        #endregion

        #region [ ReadWriteProperty_IsInternational ]

        [Test]
        public void ReadWriteProperty_IsInternational()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();
            address.IsInternational = true;
            Assert.IsTrue(
                address.IsInternational,
                "IsInternational should have been set to true.");

            address.IsInternational = false;
            Assert.IsFalse(
                address.IsInternational,
                "IsInternational should have been set to false.");
        }

        #endregion

        #region [ ReadWriteProperty_IsParcel ]

        [Test]
        public void ReadWriteProperty_IsParcel()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();
            address.IsParcel = true;
            Assert.IsTrue(
                address.IsParcel,
                "IsParcel should have been set to true.");

            address.IsParcel = false;
            Assert.IsFalse(
                address.IsParcel,
                "IsParcel should have been set to false.");
        }

        #endregion

        #region [ ReadWriteProperty_IsPostal ]

        [Test]
        public void ReadWriteProperty_IsPostal()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();
            address.IsPostal = true;
            Assert.IsTrue(
                address.IsPostal,
                "IsPostal should have been set to true.");

            address.IsPostal = false;
            Assert.IsFalse(
                address.IsPostal,
                "IsPostal should have been set to false.");
        }

        #endregion

        #region [ ReadWriteProperty_IsWork ]

        [Test]
        public void ReadWriteProperty_IsWork()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();
            address.IsWork = true;
            Assert.IsTrue(
                address.IsWork,
                "IsWork should have been set to true.");

            address.IsWork = false;
            Assert.IsFalse(
                address.IsWork,
                "IsWork should have been set to false.");
        }

        #endregion

        #region [ ReadWriteProperty_PostalCode ]

        [Test]
        public void ReadWriteProperty_PostalCode()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.PostalCode = "55109";
            Assert.AreEqual(
                "55109",
                address.PostalCode,
                "The PostalCode property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Region ]

        [Test]
        public void ReadWriteProperty_Region()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.Region = "North Pole";
            Assert.AreEqual(
                "North Pole",
                address.Region,
                "The Region property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Street ]

        [Test]
        public void ReadWriteProperty_Street()
        {

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.Street = "1490 Lark Avenue";
            Assert.AreEqual(
                "1490 Lark Avenue",
                address.Street,
                "The Street property is not working.");
        }

        #endregion

    }
}
