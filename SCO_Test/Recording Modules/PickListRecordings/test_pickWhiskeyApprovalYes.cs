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

namespace SCO_Test.Recording_Modules.PickListRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The test_pickWhiskeyApprovalYes recording.
    /// </summary>
    [TestModule("b79bd21d-7fbe-4897-97c5-7516cecc10f2", ModuleType.Recording, 1)]
    public partial class test_pickWhiskeyApprovalYes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static test_pickWhiskeyApprovalYes instance = new test_pickWhiskeyApprovalYes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public test_pickWhiskeyApprovalYes()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static test_pickWhiskeyApprovalYes Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SearchOrKeyInItem1' at Center.", repo.NCRNEXTGENUI2.SearchOrKeyInItem1Info, new RecordItemIndex(0));
            repo.NCRNEXTGENUI2.SearchOrKeyInItem1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem8' at Center.", repo.NCRNEXTGENUI2.SomeListItem8Info, new RecordItemIndex(2));
            repo.NCRNEXTGENUI2.SomeListItem8.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem12' at Center.", repo.NCRNEXTGENUI2.SomeListItem12Info, new RecordItemIndex(4));
            repo.NCRNEXTGENUI2.SomeListItem12.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Restricted Item') on item 'NCRNEXTGENUI2.RestrictedTextBlock'.", repo.NCRNEXTGENUI2.RestrictedTextBlockInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.RestrictedTextBlockInfo, "Text", "Restricted Item");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Assistance is coming, please continue.') on item 'NCRNEXTGENUI2.ScanItemTextBlock'.", repo.NCRNEXTGENUI2.ScanItemTextBlockInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.ScanItemTextBlockInfo, "Text", "Assistance is coming, please continue.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PayButton' at Center.", repo.NCRNEXTGENUI2.PayButtonInfo, new RecordItemIndex(8));
            repo.NCRNEXTGENUI2.PayButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Wait for store approval.\nApproval needed for:\n* Restricted Items') on item 'NCRNEXTGENUI2.SomeContainer.Instructions'.", repo.NCRNEXTGENUI2.SomeContainer.InstructionsInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.SomeContainer.InstructionsInfo, "Text", "Wait for store approval.\nApproval needed for:\n* Restricted Items");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SearchOrKeyInItem' at Center.", repo.NCRNEXTGENUI2.SearchOrKeyInItemInfo, new RecordItemIndex(11));
            repo.NCRNEXTGENUI2.SearchOrKeyInItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.Text9' at Center.", repo.NCRNEXTGENUI2.SomeContainer.Text9Info, new RecordItemIndex(13));
            repo.NCRNEXTGENUI2.SomeContainer.Text9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.OKButton' at Center.", repo.NCRNEXTGENUI2.SomeContainer.OKButtonInfo, new RecordItemIndex(15));
            repo.NCRNEXTGENUI2.SomeContainer.OKButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.Text9' at Center.", repo.NCRNEXTGENUI2.SomeContainer.Text9Info, new RecordItemIndex(17));
            repo.NCRNEXTGENUI2.SomeContainer.Text9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(18));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.OKButton' at Center.", repo.NCRNEXTGENUI2.SomeContainer.OKButtonInfo, new RecordItemIndex(19));
            repo.NCRNEXTGENUI2.SomeContainer.OKButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(20));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Store Authorisation') on item 'NCRNEXTGENUI2.StoreModeScreenTitle1'.", repo.NCRNEXTGENUI2.StoreModeScreenTitle1Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.StoreModeScreenTitle1Info, "Text", "Store Authorisation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.Approve' at Center.", repo.NCRNEXTGENUI2.ApproveInfo, new RecordItemIndex(22));
            repo.NCRNEXTGENUI2.Approve.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(23));
            //Delay.Duration(100, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.List2Button' at Center.", repo.NCRNEXTGENUI2.List2ButtonInfo, new RecordItemIndex(24));
            //repo.NCRNEXTGENUI2.List2Button.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(25));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.Tender4' at Center.", repo.NCRNEXTGENUI2.Tender4Info, new RecordItemIndex(26));
            repo.NCRNEXTGENUI2.Tender4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(27));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Please take your items and receipt.') on item 'NCRNEXTGENUI2.InstructionTextArea1'.", repo.NCRNEXTGENUI2.InstructionTextArea1Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.InstructionTextArea1Info, "Text", "Please take your items and receipt.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
