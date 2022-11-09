﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Test1.Navigate
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GotoPageByLinkText recording.
    /// </summary>
    [TestModule("6e463c4c-f6b0-46a5-87f7-0e91512d3c84", ModuleType.Recording, 1)]
    public partial class GotoPageByLinkText : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Test1.Test1Repository repository.
        /// </summary>
        public static global::Test1.Test1Repository repo = global::Test1.Test1Repository.Instance;

        static GotoPageByLinkText instance = new GotoPageByLinkText();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GotoPageByLinkText()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GotoPageByLinkText Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable linkText.
        /// </summary>
        [TestVariable("89eb4cf1-aa4b-4f75-9f16-996097e08fbe")]
        public string linkText
        {
            get { return repo.linkText; }
            set { repo.linkText = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.ProductPageUI.LinkText' at Center.", repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.ProductPageUI.LinkTextInfo, new RecordItemIndex(0));
            repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.ProductPageUI.LinkText.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}