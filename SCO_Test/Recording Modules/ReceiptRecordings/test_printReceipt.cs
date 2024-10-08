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
    ///The test_printReceipt recording.
    /// </summary>
    [TestModule("38af3ed0-6df5-4bf0-a660-6bab389932f3", ModuleType.Recording, 1)]
    public partial class test_printReceipt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static test_printReceipt instance = new test_printReceipt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public test_printReceipt()
        {
            N2s = "2s";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static test_printReceipt Instance
        {
            get { return instance; }
        }

#region Variables

        string _N2s;

        /// <summary>
        /// Gets or sets the value of variable N2s.
        /// </summary>
        [TestVariable("1253fc2d-5df2-4058-ac5f-c98020d9c5ec")]
        public string N2s
        {
            get { return _N2s; }
            set { _N2s = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.InstructionBox' at Center.", repo.NCRNEXTGENUI2.InstructionBoxInfo, new RecordItemIndex(0));
            repo.NCRNEXTGENUI2.InstructionBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.ScanItemSearchKeyInItem' at Center.", repo.NCRNEXTGENUI2.ScanItemSearchKeyInItemInfo, new RecordItemIndex(2));
            repo.NCRNEXTGENUI2.ScanItemSearchKeyInItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem' at Center.", repo.NCRNEXTGENUI2.SomeListItemInfo, new RecordItemIndex(4));
            repo.NCRNEXTGENUI2.SomeListItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(5));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PayButton' at Center.", repo.NCRNEXTGENUI2.PayButtonInfo, new RecordItemIndex(6));
            repo.NCRNEXTGENUI2.PayButton.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(7));
            //Delay.Duration(10000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.List2Button' at Center.", repo.NCRNEXTGENUI2.List2ButtonInfo, new RecordItemIndex(8));
            //repo.NCRNEXTGENUI2.List2Button.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(9));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.Tender4' at Center.", repo.NCRNEXTGENUI2.Tender4Info, new RecordItemIndex(10));
            repo.NCRNEXTGENUI2.Tender4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for time from variable $N2s.", new RecordItemIndex(11));
            Delay.Duration(Duration.Parse(N2s), false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Print Receipt') on item 'NCRNEXTGENUI2.PrintReceiptButton'.", repo.NCRNEXTGENUI2.PrintReceiptButtonInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.PrintReceiptButtonInfo, "Text", "Print Receipt");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            //Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PrintReceiptButton' at Center.", repo.NCRNEXTGENUI2.PrintReceiptButtonInfo, new RecordItemIndex(14));
            repo.NCRNEXTGENUI2.PrintReceiptButton.Click();
            Delay.Milliseconds(2930);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(15));
            //Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Printing receipt... please wait.') on item 'NCRNEXTGENUI2.InstructionTextArea1'.", repo.NCRNEXTGENUI2.InstructionTextArea1Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.InstructionTextArea1Info, "Text", "Printing receipt... please wait.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
