
using System;
using NUnit.Framework;
using Thought.vCards;

namespace Thought.vCards.UnitTests
{
    [TestFixture]
    public class vCardSubpropertyTests
    {

        #region [ Constructor_Name ]

        [Test]
        public void Constructor_Name()
        {

            vCardSubproperty sub = new vCardSubproperty("NAME");

            Assert.AreEqual(
                "NAME",
                sub.Name,
                "The Name property was not initialized.");

            Assert.IsNull(
                sub.Value,
                "The value should be null.");

        }

        #endregion

        #region [ Constructor_Name_Value ]

        [Test]
        public void Constructor_Name_Value()
        {

            vCardSubproperty sub = new vCardSubproperty("NAME", "VALUE");

            Assert.AreEqual(
                "NAME",
                sub.Name,
                "The Name property was not initialized.");

            Assert.AreEqual(
                "VALUE",
                sub.Value,
                "The Value property was not initialized.");

        }

        #endregion

        #region [ ReadWriteProperty_Name ]

        [Test]
        public void ReadWriteProperty_Name()
        {

            vCardSubproperty sub = new vCardSubproperty("NAME");

            sub.Name = "SUBNAME";
            Assert.AreEqual(
                "SUBNAME",
                sub.Name,
                "The Name property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_Value ]

        [Test]
        public void ReadWriteProperty_Value()
        {

            vCardSubproperty sub = new vCardSubproperty("NAME");

            sub.Value = "SUBVALUE";
            Assert.AreEqual(
                "SUBVALUE",
                sub.Value,
                "The Value property is not working.");

        }

        #endregion

    }
}
