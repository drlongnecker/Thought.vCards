
using System;
using System.Drawing;
using System.IO;
using NUnit.Framework;
using Thought.vCards;

namespace Thought.vCards.UnitTests
{
    [TestFixture]
    public class vCardPhotoTests
    {

        /// <summary>
        ///     The URL of an image that is under control of the author
        ///     and is sufficiently small to allow quick download.  If you
        ///     use the vCard library internally w/ extensive unit tests,
        ///     please be considerate and change to an image on your
        ///     local network.  This will save bandwidth costs for the author.
        /// </summary>
        private const string TestPhotoUrl =
            "https://en.gravatar.com/userimage/5706801/e459ccda7c6b32bb4e14da3725cf7db4.jpeg";

        /// <summary>
        ///     The height of the test image in pixels.
        /// </summary>
        private const int TestPhotoHeight = 80;

        /// <summary>
        ///     The size (in bytes) of the test image.
        /// </summary>
        private const int TestPhotoSize = 2400;

        /// <summary>
        ///     The width of the test photo in pixels.
        /// </summary>
        private const int TestPhotoWidth = 80;

        // 

        #region [ Constructor_String ]

        [Test]
        public void Constructor_String()
        {

            // If a filename (string) is passed to the constructor, then
            // the scheme of the URI should be set as file.

            vCardPhoto photo = new vCardPhoto("c:\\fake-picture.gif");

            Assert.IsTrue(
                photo.Url.IsFile);

        }

        #endregion

        #region [ Constructor_String_Empty ]

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_String_Empty()
        {
            vCardPhoto photo = new vCardPhoto(string.Empty);
        }

        #endregion

        #region [ Constructor_String_Null ]

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_String_Null()
        {
            vCardPhoto photo = new vCardPhoto((string)null);
        }

        #endregion

        #region [ Constructor_Uri_Null ]

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Uri_Null()
        {
            new vCardPhoto((Uri)null);

            // The following expression is nicer but seems
            // to not work nice in VS2008 depending on
            // debugging/exception settings.

            //Assert.Throws<ArgumentNullException>(
            //    () => new vCardPhoto((Uri)null)
            //);
        }

        #endregion

        #region [ Fetch_Good ]

        [Test]
        public void Fetch_Good()
        {

            // You may wish to ignore this test if you run
            // extensive unit tests and your Internet connection
            // is slow.

            vCardPhoto photo = new vCardPhoto(TestPhotoUrl);

            Assert.IsFalse(
                photo.IsLoaded,
                "The photo has not been loaded yet.");

            photo.Fetch();

            Assert.IsTrue(
                photo.IsLoaded,
                "The photo should have been loaded.");

            // Get the bytes of the image.

            byte[] data = photo.GetBytes();

            Assert.AreEqual(
                TestPhotoSize,
                data.Length,
                "The length of the photo is unexpected.");

            using (Bitmap bitmap = photo.GetBitmap())
            {

                Assert.AreEqual(
                    TestPhotoHeight,
                    bitmap.Size.Height,
                    "The photo height is unexpected.");

                Assert.AreEqual(
                    TestPhotoWidth,
                    bitmap.Size.Width,
                    "The photo width is unexpected.");

            }


        }

        #endregion

    }
}
