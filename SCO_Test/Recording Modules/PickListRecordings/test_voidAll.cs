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
    ///The test_voidAll recording.
    /// </summary>
    [TestModule("634220d3-14bb-42f7-98f7-75016d357405", ModuleType.Recording, 1)]
    public partial class Test_voidAll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static Test_voidAll instance = new Test_voidAll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Test_voidAll()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Test_voidAll Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.InstructionBox' at Center.", repo.NCRNEXTGENUI2.InstructionBoxInfo, new RecordItemIndex(0));
            repo.NCRNEXTGENUI2.InstructionBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(1));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SearchOrKeyInItem' at Center.", repo.NCRNEXTGENUI2.SearchOrKeyInItemInfo, new RecordItemIndex(2));
            repo.NCRNEXTGENUI2.SearchOrKeyInItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(3));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem' at Center.", repo.NCRNEXTGENUI2.SomeListItemInfo, new RecordItemIndex(4));
            repo.NCRNEXTGENUI2.SomeListItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(5));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.ScanItemSearchKeyInItem' at Center.", repo.NCRNEXTGENUI2.ScanItemSearchKeyInItemInfo, new RecordItemIndex(6));
            repo.NCRNEXTGENUI2.ScanItemSearchKeyInItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(7));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem5' at Center.", repo.NCRNEXTGENUI2.SomeListItem5Info, new RecordItemIndex(8));
            repo.NCRNEXTGENUI2.SomeListItem5.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(9));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.EditCartBtn' at Center.", repo.NCRNEXTGENUI2.EditCartBtnInfo, new RecordItemIndex(10));
            repo.NCRNEXTGENUI2.EditCartBtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(11));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cancel Items') on item 'NCRNEXTGENUI2.SomeContainer.PopupTitle'.", repo.NCRNEXTGENUI2.SomeContainer.PopupTitleInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.SomeContainer.PopupTitleInfo, "Text", "Cancel Items");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Scan unwanted items, or tap\r\n\"Remove\" on the receipt.') on item 'NCRNEXTGENUI2.SomeContainer.Instructions'.", repo.NCRNEXTGENUI2.SomeContainer.InstructionsInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.SomeContainer.InstructionsInfo, "Text", "Scan unwanted items, or tap\r\n\"Remove\" on the receipt.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.CancelAllBtn' at Center.", repo.NCRNEXTGENUI2.CancelAllBtnInfo, new RecordItemIndex(14));
            repo.NCRNEXTGENUI2.CancelAllBtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(15));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.YesButton' at Center.", repo.NCRNEXTGENUI2.YesButtonInfo, new RecordItemIndex(16));
            repo.NCRNEXTGENUI2.YesButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(17));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.StoreLogIn' at Center.", repo.NCRNEXTGENUI2.SomeContainer.StoreLogInInfo, new RecordItemIndex(18));
            repo.NCRNEXTGENUI2.SomeContainer.StoreLogIn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(19));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.Text9' at Center.", repo.NCRNEXTGENUI2.SomeContainer.Text9Info, new RecordItemIndex(20));
            repo.NCRNEXTGENUI2.SomeContainer.Text9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(21));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.TextOK' at Center.", repo.NCRNEXTGENUI2.SomeContainer.TextOKInfo, new RecordItemIndex(22));
            repo.NCRNEXTGENUI2.SomeContainer.TextOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(23));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.Text9' at Center.", repo.NCRNEXTGENUI2.SomeContainer.Text9Info, new RecordItemIndex(24));
            repo.NCRNEXTGENUI2.SomeContainer.Text9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(25));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeContainer.TextOK' at Center.", repo.NCRNEXTGENUI2.SomeContainer.TextOKInfo, new RecordItemIndex(26));
            repo.NCRNEXTGENUI2.SomeContainer.TextOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(27));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.StoreButton1' at Center.", repo.NCRNEXTGENUI2.StoreButton1Info, new RecordItemIndex(28));
            repo.NCRNEXTGENUI2.StoreButton1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Transaction cancelled. Remove\r\nitems from this checkstand.') on item 'NCRNEXTGENUI2.SMLineText'.", repo.NCRNEXTGENUI2.SMLineTextInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.SMLineTextInfo, "Text", "Transaction cancelled. Remove\r\nitems from this checkstand.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(30));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.StoreButton1' at Center.", repo.NCRNEXTGENUI2.StoreButton1Info, new RecordItemIndex(31));
            repo.NCRNEXTGENUI2.StoreButton1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5s.", new RecordItemIndex(32));
            Delay.Duration(1500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Entire purchase cancelled. Put all items aside.') on item 'NCRNEXTGENUI2.InstructionTextArea1'.", repo.NCRNEXTGENUI2.InstructionTextArea1Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.InstructionTextArea1Info, "Text", "Entire purchase cancelled. Put all items aside.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
