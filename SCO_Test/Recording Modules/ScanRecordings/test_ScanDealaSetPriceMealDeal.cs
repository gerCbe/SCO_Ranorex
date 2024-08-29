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
    ///The test_ScanDealaSetPriceMealDeal recording.
    /// </summary>
    [TestModule("e6726edd-646d-40d6-8cf6-95ecfcc0452f", ModuleType.Recording, 1)]
    public partial class test_ScanDealaSetPriceMealDeal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static test_ScanDealaSetPriceMealDeal instance = new test_ScanDealaSetPriceMealDeal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public test_ScanDealaSetPriceMealDeal()
        {
            BarCodeMessage = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static test_ScanDealaSetPriceMealDeal Instance
        {
            get { return instance; }
        }

#region Variables

        string _BarCodeMessage;

        /// <summary>
        /// Gets or sets the value of variable BarCodeMessage.
        /// </summary>
        [TestVariable("4b86c045-d107-4443-a749-32a0d7b0a7b3")]
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='CHICKEN BAGUETTE') on item 'NCRNEXTGENUI2.ItemDescription'.", repo.NCRNEXTGENUI2.ItemDescriptionInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.ItemDescriptionInfo, "Text", "CHICKEN BAGUETTE");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='    DELI MEAL DEAL') on item 'NCRNEXTGENUI2.CartControl.ItemDescription'.", repo.NCRNEXTGENUI2.CartControl.ItemDescriptionInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.ItemDescriptionInfo, "Text", "    DELI MEAL DEAL");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='COKE ZERO') on item 'NCRNEXTGENUI2.CartControl.ItemDescription8'.", repo.NCRNEXTGENUI2.CartControl.ItemDescription8Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.ItemDescription8Info, "Text", "COKE ZERO");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='    DELI MEAL DEAL') on item 'NCRNEXTGENUI2.CartControl.ItemDescription1'.", repo.NCRNEXTGENUI2.CartControl.ItemDescription1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.ItemDescription1Info, "Text", "    DELI MEAL DEAL");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PayButton' at Center.", repo.NCRNEXTGENUI2.PayButtonInfo, new RecordItemIndex(13));
            repo.NCRNEXTGENUI2.PayButton.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            //Delay.Duration(300, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.List2Button' at Center.", repo.NCRNEXTGENUI2.List2ButtonInfo, new RecordItemIndex(15));
            //repo.NCRNEXTGENUI2.List2Button.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(16));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.Tender4' at Center.", repo.NCRNEXTGENUI2.Tender4Info, new RecordItemIndex(17));
            repo.NCRNEXTGENUI2.Tender4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(18));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(19));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Press Here or           Scan Item') on item 'NCRNEXTGENUI2.PressHereOrScanItem'.", repo.NCRNEXTGENUI2.PressHereOrScanItemInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.PressHereOrScanItemInfo, "Text", "Press Here or           Scan Item");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
