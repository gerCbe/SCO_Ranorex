/*
 * Created by Ranorex
 * User: SCOT
 * Date: 31/05/2024
 * Time: 09:44
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace SCO_Test.CodeModules
{
    /// <summary>
    /// Description of MainTestModule.
    /// </summary>
    [TestModule("3A1ECF46-8E59-4066-934D-20CA4B887DA0", ModuleType.UserCode, 1)]
    public class MainTestModule : ITestModule
    {
    	
    	genCode genC = new genCode();
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MainTestModule()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
          
           	
             basicOrder();
             //enterPluTransaction();
               
        	//cancelTransaction();
        	
        }
       
        
        public void basicOrder(){
        	       	
        	genC.clickSearchItem();
        	 
        	genC.clickItemBtn(0);
        
        	string total = genC.verifyTotal();
        	 
        	genC.clickPayBtn();
        	 
        	genC.clickFakeCashTenderBtn();
        	 
        	genC.verifyAmountPaid(total);
        	 
        	List<string> latestTLog = genC.getLatestTLogTransaction();
        	 
        	
        }
        
        public void enterPluTransaction(){
        	 genC.clickSearchItem();
        	 
        	 genC.clickKeyPadNum("0000054491472");
        	 
        	 string total = genC.verifyTotal();
        	 
        	 genC.clickPayBtn();
        	 
        	 genC.clickFakeCashTenderBtn();
        	 
        	 genC.verifyAmountPaid(total);
        	 List<string> latestTLog = genC.getLatestTLogTransaction();
        }
        
        public void cancelTransaction(){
        	 genC.clickSearchItem();
        	 
        	 genC.clickItemBtn(0);
        	 
        	 genC.clickEditBasket();
        	 genC.removeAllItemsFromBasket();
        }
    }
}
