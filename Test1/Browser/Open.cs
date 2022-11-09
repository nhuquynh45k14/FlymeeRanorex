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

namespace Test1.Browser
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Open recording.
    /// </summary>
    [TestModule("baba2d1e-c61e-4ef3-aae7-f7f2cab7d14e", ModuleType.Recording, 1)]
    public partial class Open : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Test1.Test1Repository repository.
        /// </summary>
        public static global::Test1.Test1Repository repo = global::Test1.Test1Repository.Instance;

        static Open instance = new Open();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open()
        {
            BrowserName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Open Instance
        {
            get { return instance; }
        }

#region Variables

        string _BrowserName;

        /// <summary>
        /// Gets or sets the value of variable BrowserName.
        /// </summary>
        [TestVariable("49aa9ac0-e1ef-4548-bedd-888bf5c5b6e2")]
        public string BrowserName
        {
            get { return _BrowserName; }
            set { _BrowserName = value; }
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

            //Open_Open_browser("https://flymee.jp/", BrowserName);
            //Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Website", "(Optional Action)\r\nOpening web site 'https://flymee.jp/' with browser 'Chrome' in maximized mode.", new RecordItemIndex(1));
                Host.Current.OpenBrowser("https://flymee.jp/", "Chrome", "", false, true, false, false, false, true, false, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
