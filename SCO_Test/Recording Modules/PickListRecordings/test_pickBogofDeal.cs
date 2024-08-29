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
    ///The test_pickBogofDeal recording.
    /// </summary>
    [TestModule("77fffafe-3088-4d61-ae4b-39ef8c47d411", ModuleType.Recording, 1)]
    public partial class test_pickBogofDeal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SCO_Test.SCO_TestRepository repository.
        /// </summary>
        public static global::SCO_Test.SCO_TestRepository repo = global::SCO_Test.SCO_TestRepository.Instance;

        static test_pickBogofDeal instance = new test_pickBogofDeal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public test_pickBogofDeal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static test_pickBogofDeal Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem11' at Center.", repo.NCRNEXTGENUI2.SomeListItem11Info, new RecordItemIndex(2));
            repo.NCRNEXTGENUI2.SomeListItem11.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem' at Center.", repo.NCRNEXTGENUI2.SomeListItemInfo, new RecordItemIndex(4));
            repo.NCRNEXTGENUI2.SomeListItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SearchOrKeyInItem' at Center.", repo.NCRNEXTGENUI2.SearchOrKeyInItemInfo, new RecordItemIndex(6));
            repo.NCRNEXTGENUI2.SearchOrKeyInItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem11' at Center.", repo.NCRNEXTGENUI2.SomeListItem11Info, new RecordItemIndex(8));
            repo.NCRNEXTGENUI2.SomeListItem11.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.SomeListItem' at Center.", repo.NCRNEXTGENUI2.SomeListItemInfo, new RecordItemIndex(10));
            repo.NCRNEXTGENUI2.SomeListItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(11));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Fanta Dark Orange 1.75l') on item 'NCRNEXTGENUI2.ItemDescription'.", repo.NCRNEXTGENUI2.ItemDescriptionInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.ItemDescriptionInfo, "Text", "Fanta Dark Orange 1.75l");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='    DISCOUNT') on item 'NCRNEXTGENUI2.CartControl.ItemDescription'.", repo.NCRNEXTGENUI2.CartControl.ItemDescriptionInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.ItemDescriptionInfo, "Text", "    DISCOUNT");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Fanta Dark Orange 1.75l') on item 'NCRNEXTGENUI2.CartControl.ItemDescription8'.", repo.NCRNEXTGENUI2.CartControl.ItemDescription8Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.ItemDescription8Info, "Text", "Fanta Dark Orange 1.75l");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='€1.25') on item 'NCRNEXTGENUI2.CartControl.TotalAmountValue'.", repo.NCRNEXTGENUI2.CartControl.TotalAmountValueInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.CartControl.TotalAmountValueInfo, "Text", "€1.25");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.PayButton' at Center.", repo.NCRNEXTGENUI2.PayButtonInfo, new RecordItemIndex(17));
            repo.NCRNEXTGENUI2.PayButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(18));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NCRNEXTGENUI2.Tender4' at Center.", repo.NCRNEXTGENUI2.Tender4Info, new RecordItemIndex(19));
            repo.NCRNEXTGENUI2.Tender4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(20));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Thanks for shopping with us.') on item 'NCRNEXTGENUI2.HeaderText'.", repo.NCRNEXTGENUI2.HeaderTextInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.HeaderTextInfo, "Text", "Thanks for shopping with us.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(22));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Press Here or           Scan Item') on item 'NCRNEXTGENUI2.PressHereOrScanItem'.", repo.NCRNEXTGENUI2.PressHereOrScanItemInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.NCRNEXTGENUI2.PressHereOrScanItemInfo, "Text", "Press Here or           Scan Item");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}