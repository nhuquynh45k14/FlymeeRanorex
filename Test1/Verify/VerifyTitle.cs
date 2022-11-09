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

namespace Test1.Verify
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyTitle recording.
    /// </summary>
    [TestModule("89f3a2e1-8c8d-496a-a3df-873e0c90b8e8", ModuleType.Recording, 1)]
    public partial class VerifyTitle : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Test1.Test1Repository repository.
        /// </summary>
        public static global::Test1.Test1Repository repo = global::Test1.Test1Repository.Instance;

        static VerifyTitle instance = new VerifyTitle();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyTitle()
        {
            Title = "";
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyTitle Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Title.
        /// </summary>
        [TestVariable("f9824897-2d82-4e15-b7a7-0d01b0105b1b")]
        public string Title
        {
            get { return repo.title; }
            set { repo.title = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("b36fc045-0f29-4d34-aad5-2624b7af387a")]
        public string Text
        {
            get { return repo.text; }
            set { repo.text = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+2' Press with focus on 'WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー'.", repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.SelfInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.Self);
            Keyboard.Press(System.Windows.Forms.Keys.D2 | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.TitleReturn'.", repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.TitleReturnInfo, new RecordItemIndex(2));
            repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.TitleReturn.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Title) on item 'WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.TitleReturn'.", repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.TitleReturnInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.TitleReturnInfo, "InnerText", Title);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$Text) on item 'WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.Content'.", repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.ContentInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.UserGuidePageUI.ContentInfo, "InnerText", Text);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}