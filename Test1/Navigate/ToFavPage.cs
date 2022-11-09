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
    ///The ToFavPage recording.
    /// </summary>
    [TestModule("231fdea5-bbfb-4a40-bb98-89fe320333d4", ModuleType.Recording, 1)]
    public partial class ToFavPage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Test1.Test1Repository repository.
        /// </summary>
        public static global::Test1.Test1Repository repo = global::Test1.Test1Repository.Instance;

        static ToFavPage instance = new ToFavPage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ToFavPage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ToFavPage Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.CollectionPageUI.btnFav' at Center.", repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.CollectionPageUI.btnFavInfo, new RecordItemIndex(0));
            repo.WebDocumentFLYMEe日本最大級の家具通販インテリア通販フライミー.CollectionPageUI.btnFav.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
