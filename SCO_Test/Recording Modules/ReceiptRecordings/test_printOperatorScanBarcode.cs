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

namespace SCO_Test.Recording_Modules.ReceiptRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The test_printOperatorScanBarcode recording.
    /// </summary>
    [TestModule("ea5e7366-79e5-4730-bcf6-ab7045964061", ModuleType.Recording, 1)]
    public partial class test_printOperatorScanBarcode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static test_printOperatorScanBarcode instance = new test_printOperatorScanBarcode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public test_printOperatorScanBarcode()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static test_printOperatorScanBarcode Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.AssistanceButton' at Center.", repo.NCRNEXTGENUI2.AssistanceButtonInfo, new RecordItemIndex(0));
            repo.NCRNEXTGENUI2.AssistanceButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.StoreLogIn1' at Center.", repo.NCRNEXTGENUI2.SomeContainer.StoreLogIn1Info, new RecordItemIndex(1));
            repo.NCRNEXTGENUI2.SomeContainer.StoreLogIn1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.Text9' at Center.", repo.NCRNEXTGENUI2.SomeContainer.Text9Info, new RecordItemIndex(2));
            repo.NCRNEXTGENUI2.SomeContainer.Text9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.TextOK' at Center.", repo.NCRNEXTGENUI2.SomeContainer.TextOKInfo, new RecordItemIndex(3));
            repo.NCRNEXTGENUI2.SomeContainer.TextOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.Text9' at Center.", repo.NCRNEXTGENUI2.SomeContainer.Text9Info, new RecordItemIndex(4));
            repo.NCRNEXTGENUI2.SomeContainer.Text9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.TextOK' at Center.", repo.NCRNEXTGENUI2.SomeContainer.TextOKInfo, new RecordItemIndex(5));
            repo.NCRNEXTGENUI2.SomeContainer.TextOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SystemFunctions' at Center.", repo.NCRNEXTGENUI2.SystemFunctionsInfo, new RecordItemIndex(6));
            repo.NCRNEXTGENUI2.SystemFunctions.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PrintOperatorScanBarcode' at Center.", repo.NCRNEXTGENUI2.PrintOperatorScanBarcodeInfo, new RecordItemIndex(7));
            repo.NCRNEXTGENUI2.PrintOperatorScanBarcode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(8));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='    Media Level Normal') on item 'NCRNEXTGENUI2.CartControl.ItemDescription2'.", repo.NCRNEXTGENUI2.CartControl.ItemDescription2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.ItemDescription2Info, "Text", "    Media Level Normal");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.GoBack' at Center.", repo.NCRNEXTGENUI2.GoBackInfo, new RecordItemIndex(10));
            repo.NCRNEXTGENUI2.GoBack.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.GoBack' at Center.", repo.NCRNEXTGENUI2.GoBackInfo, new RecordItemIndex(12));
            repo.NCRNEXTGENUI2.GoBack.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
