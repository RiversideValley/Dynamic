using Riverside.Scripting;
using Riverside.Scripting.Hosting;
using NUnit.Framework;
using System;
using System.Text;
using System.Diagnostics;

namespace HostingTest {
    public partial class ScriptRuntimeSetupTest : HAPITestBase {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        internal string GetTempConfigFile(LangSetup[] langs) {
            string xmlPrefix = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
"<configuration>" +
  "<configSections>"+
    "<section name=\"Riverside.Scripting\" type=\"Riverside.Scripting.Hosting.Configuration.Section, Riverside.Scripting, Version=1.1.0.30, Culture=neutral, PublicKeyToken=31bf3856ad364e35\" requirePermission=\"false\" />"+
  "</configSections>"+

  "<Riverside.Scripting>"+
    "<languages>";

            string xmlSuffix ="</languages>"+
  "</Riverside.Scripting>"+
"</configuration>";

            StringBuilder ret = new StringBuilder();
            Array.ForEach(langs, lang => ret.AppendLine(lang.ToString()));

            string contents = xmlPrefix + ret.ToString() + xmlSuffix;

            return TestHelpers.CreateTempSourceFile( contents, ".config");
        }
    }
}
