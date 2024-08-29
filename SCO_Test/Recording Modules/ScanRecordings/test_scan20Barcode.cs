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

namespace SCO_Test.Recording_Modules.ScanRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The test_scan20Barcode recording.
    /// </summary>
    [TestModule("c01aa7dc-2514-447f-b041-169f1f67057e", ModuleType.Recording, 1)]
    public partial class test_scan20Barcode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static test_scan20Barcode instance = new test_scan20Barcode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public test_scan20Barcode()
        {
            BarCodeMessage = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static test_scan20Barcode Instance
        {
            get { return instance; }
        }

#region Variables

        string _BarCodeMessage;

        /// <summary>
        /// Gets or sets the value of variable BarCodeMessage.
        /// </summary>
        [TestVariable("dde08f1f-8005-473c-a417-1081b94b0612")]
        public string BarCodeMessage
        {
            get { return _BarCodeMessage; }
            set { _BarCodeMessage = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FmMain.TxIpAddress' at 535;7.", repo.FmMain.TxIpAddressInfo, new RecordItemIndex(2));
            repo.FmMain.TxIpAddress.Click("535;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(3));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$BarCodeMessage' on item 'FmMain.Text'.", repo.FmMain.TextInfo, new RecordItemIndex(4));
            repo.FmMain.Text.Element.SetAttributeValue("Text", BarCodeMessage);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FmMain.BtSend' at Center.", repo.FmMain.BtSendInfo, new RecordItemIndex(6));
            repo.FmMain.BtSend.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(7));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='BRIE CHEESE') on item 'NCRNEXTGENUI2.ItemDescription'.", repo.NCRNEXTGENUI2.ItemDescriptionInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.ItemDescriptionInfo, "Text", "BRIE CHEESE");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PayButton' at Center.", repo.NCRNEXTGENUI2.PayButtonInfo, new RecordItemIndex(10));
            repo.NCRNEXTGENUI2.PayButton.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(11));
            //Delay.Duration(300, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.List2Button' at Center.", repo.NCRNEXTGENUI2.List2ButtonInfo, new RecordItemIndex(12));
            //repo.NCRNEXTGENUI2.List2Button.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(13));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.Tender4' at Center.", repo.NCRNEXTGENUI2.Tender4Info, new RecordItemIndex(14));
            repo.NCRNEXTGENUI2.Tender4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(15));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Thanks for shopping with us.') on item 'NCRNEXTGENUI2.HeaderText'.", repo.NCRNEXTGENUI2.HeaderTextInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.HeaderTextInfo, "Text", "Thanks for shopping with us.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(17));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Press Here or           Scan Item') on item 'NCRNEXTGENUI2.PressHereOrScanItem'.", repo.NCRNEXTGENUI2.PressHereOrScanItemInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.PressHereOrScanItemInfo, "Text", "Press Here or           Scan Item");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
