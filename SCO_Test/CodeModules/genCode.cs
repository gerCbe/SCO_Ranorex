/*
 * Created by Ranorex
 * User: SCOT
 * Date: 31/05/2024
 * Time: 14:32
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Linq;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SCO_Test.CodeModules
{
    /// <summary>
    /// Description of genCode.
    /// </summary>
    [TestModule("81C6E623-9230-4952-9F19-9F2C2626635F", ModuleType.UserCode, 1)]
    public class genCode : ITestModule
    {
    	SCO_TestRepository repo1 = SCO_TestRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public genCode()
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
        }
        
        public List<Ranorex.Text> getRecieptPrices(){
        	
        	var cartReceipt = repo1.NCRNEXTGENUI.CartReceipt;
			var cartReceiptInfo = repo1.NCRNEXTGENUI.CartReceiptInfo;
			cartReceiptInfo.WaitForAttributeEqual(cartReceiptInfo.SearchTimeout,"Visible", "True");
        	IList<Ranorex.Text> ListItems = cartReceipt.FindDescendants<Ranorex.Text>();
        	
        	List<Ranorex.Text> itemPrices = new List<Ranorex.Text>();
        	
        	foreach (var element in ListItems) {
        		if (element.GetAttributeValue<string>("AutomationId") == "ItemPrice" && element.SelectionText != "") {
        			itemPrices.Add(element);
        		}
        	}
        	  	return itemPrices;
        }
        
        public void compareReceiptSum(List<Ranorex.Text> prices){
        	List<float> itemPrices = new List<float>();
        	float sum = 0;
        	foreach (var price in prices) {
			sum += float.Parse(price.SelectionText.Substring(1));
        	}
        	
        	Validate.AreEqual(sum,float.Parse(repo1.NCRNEXTGENUI.TotalAmountValue.TextValue.Substring(1))); 
        }
        
        public void clickSearchItem(){
    		 
        	var repo = SCO_TestRepository.Instance;
        	var searchKeyInItemButton = repo.NCRNEXTGENUI.SearchKeyInItemButton;
        	var searchKeyInItemButtonInfo = repo.NCRNEXTGENUI.SearchKeyInItemButtonInfo;
        	
        	searchKeyInItemButtonInfo.WaitForExists(searchKeyInItemButtonInfo.SearchTimeout);
        	searchKeyInItemButton.Click();
        
        
        }
        
        public void clickItemBtn(int index){
        	
        	var repo = SCO_TestRepository.Instance;
        	var pluItemBTN1 = repo.NCRNEXTGENUI.pluItemBTN1;
        	var pluItemBtn1Info = repo.NCRNEXTGENUI.pluItemBTN1Info;
        	

        	
        	pluItemBtn1Info.WaitForExists(pluItemBtn1Info.SearchTimeout);
        	pluItemBTN1.Click();    
     	
        }
        
        public string verifyTotal(){
        	var repo = SCO_TestRepository.Instance;
        	var totalAmountValue = repo.NCRNEXTGENUI.TotalAmountValue;
        	var payAmountValue = repo.NCRNEXTGENUI.PayAmountValue;
        	var payAmountInfo = repo.NCRNEXTGENUI.PayAmountValueInfo;
        	
        	payAmountInfo.WaitForAttributeNotEqual(payAmountInfo.SearchTimeout,"Text", "€0.00" );
        	Validate.AreEqual(totalAmountValue.TextValue,payAmountValue.TextValue);
        	
			return payAmountValue.TextValue;
        }
        
        public void clickPayBtn(){

        	var repo = SCO_TestRepository.Instance;
        	var payButton = repo.NCRNEXTGENUI.PayButton;
        	var payBtnInfo = repo.NCRNEXTGENUI.PayButtonInfo;
        	payBtnInfo.WaitForAttributeEqual(payBtnInfo.SearchTimeout,"Visible", "True");
        	payButton.Click();
        	
        	var clubcardNoBtn = repo.NCRNEXTGENUI.clubcardNoBtn;
        	var clubcardNoBtnInfo = repo.NCRNEXTGENUI.clubcardNoBtnInfo;
        	clubcardNoBtnInfo.WaitForExists(clubcardNoBtnInfo.SearchTimeout);
        	clubcardNoBtn.Click();
        	
        }
        
        public void clickFakeCashTenderBtn(){
        	
        	var repo = SCO_TestRepository.Instance;
        	var fakeCashBtn = repo.NCRNEXTGENUI.fakeCashBtn;
     		var fakeCashBtnInfo = repo.NCRNEXTGENUI.fakeCashBtnInfo;
     		
     		fakeCashBtnInfo.WaitForExists(fakeCashBtnInfo.SearchTimeout);
        	fakeCashBtn.Click();

        }
        
        public void verifyAmountPaid(string total){
        	
        	var repo = SCO_TestRepository.Instance;
        	var amountPaid = repo.NCRNEXTGENUI.AmountPaid;
        	var amountPaidInfo = repo.NCRNEXTGENUI.AmountPaidInfo;
        	amountPaidInfo.WaitForAttributeEqual(amountPaidInfo.SearchTimeout, "Visible", "True");
        	Validate.AreEqual(total, amountPaid.TextValue);
        }
        
        public void clickSearchScanItem(){
        	var repo = SCO_TestRepository.Instance;
        	var scanItemSearchKeyInItem = repo.NCRNEXTGENUI.ScanItemSearchKeyInItem;
			var scanItemSearchKeyInItemInfo = repo.NCRNEXTGENUI.SearchKeyInItemButtonInfo;
			
			scanItemSearchKeyInItem.Click();
        }
          
        public void clickKeyPadNum(string pluNum){
        	
        	List<Ranorex.Button> KeypadBtns = new List<Ranorex.Button>();
        
        	var repo = SCO_TestRepository.Instance;
        	var keypad1 = repo.NCRNEXTGENUI.keypad1;
        	var keypad2 = repo.NCRNEXTGENUI.SomeContainer.keypad2;
        	var keypad3 = repo.NCRNEXTGENUI.SomeContainer.keypad3;
        	var keypad4 = repo.NCRNEXTGENUI.SomeContainer.keypad4;
        	var keypad5 = repo.NCRNEXTGENUI.SomeContainer.keypad5;
        	var keypad6 = repo.NCRNEXTGENUI.SomeContainer.keypad6;
        	var keypad7 = repo.NCRNEXTGENUI.SomeContainer.keypad7;
        	var keypad8 = repo.NCRNEXTGENUI.SomeContainer.keypad8;
        	var keypad9 = repo.NCRNEXTGENUI.SomeContainer.keypad9;
        	var keypad0 = repo.NCRNEXTGENUI.SomeContainer.keypad0;
        	var enterButton = repo.NCRNEXTGENUI.SomeContainer.EnterButton;

        	KeypadBtns.Add(keypad1);
			KeypadBtns.Add(keypad2);
			KeypadBtns.Add(keypad3);
			KeypadBtns.Add(keypad4);
			KeypadBtns.Add(keypad5);
			KeypadBtns.Add(keypad6);
			KeypadBtns.Add(keypad7);
			KeypadBtns.Add(keypad8);
			KeypadBtns.Add(keypad9);
			KeypadBtns.Add(keypad0);
			
			
			foreach (char digit in pluNum) {
				foreach (Ranorex.Button btn in KeypadBtns) {
					if (digit.ToString() == btn.Text) {
						btn.Click();
						break;
					}
				}
			}        	
        	
			enterButton.Click();
        }
        
        public void clickEditBasket(){
        	var repo = SCO_TestRepository.Instance;
        	var editCartBtn = repo.NCRNEXTGENUI.EditCartBtn;
			var editCartBtnInfo = repo.NCRNEXTGENUI.EditCartBtnInfo;
			
			editCartBtnInfo.WaitForAttributeEqual(editCartBtnInfo.SearchTimeout, "Visible", "True");
			editCartBtn.Click();
        	
        }
        
        public void removeAllItemsFromBasket(){
        	var repo = SCO_TestRepository.Instance;
        	var cancelAllBtn = repo.NCRNEXTGENUI.CancelAllBtn;
			var cancelAllBtnInfo = repo.NCRNEXTGENUI.CancelAllBtnInfo;
			
			cancelAllBtnInfo.WaitForAttributeEqual(cancelAllBtnInfo.SearchTimeout, "Visible", "True");
			cancelAllBtn.Click();
			
			var yesEmptyCartBtn = repo.NCRNEXTGENUI.yesEmptyCartBtn;
			var yesEmptyCartBtnInfo = repo.NCRNEXTGENUI.yesEmptyCartBtnInfo;
			
			yesEmptyCartBtnInfo.WaitForAttributeEqual(yesEmptyCartBtnInfo.SearchTimeout, "Visible", "True");
			yesEmptyCartBtn.Click();
			
			logIn();
			
			var yesCancelAllItemsBtn = repo.NCRNEXTGENUI.yesCancelAllItemsBtn;
			var yesCancelAllItemsBtnInfo = repo.NCRNEXTGENUI.yesCancelAllItemsBtnInfo;
			
			yesCancelAllItemsBtnInfo.WaitForAttributeEqual(yesCancelAllItemsBtnInfo.SearchTimeout, "Visible", "True");
			yesCancelAllItemsBtn.Click();
			Delay.Seconds(2);
			yesCancelAllItemsBtn.Click();
			
			verifyAmountPaid("€0.00");
        }
        
        public void waitForElement(Ranorex.Adapter element){
        	int counter = 0;
        	Report.Info("Waiting for " + element);
        	while (!element.Visible) {
        		if (counter <= 60) {
        			counter++;
        			Delay.Seconds(0.25);
        		} 
        		else{
        			Report.Failure("Error time out occured");
        			Validate.Fail();
        		}
        		
        	}
        	Report.Info("Finished waiting for " + element);
        }
              
        public List<string> getLatestTLogTransaction(){
			string translogPath = "C:\\EPOS\\JOURNALS\\translog.051";
			string lineOfText = "";
			var filestream = new System.IO.FileStream(translogPath,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
			var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
			
						
			List<string> latestTransaction = new List<string>();
			
			
			while ((lineOfText = file.ReadLine()) != null)
			{
				latestTransaction.Add(lineOfText);				
				
				if (lineOfText.Substring(0,3) == "EOT" && file.Peek() != -1) {
					latestTransaction.Clear();
				}
			}
				
        	 foreach (var element in latestTransaction) {
        	 	Report.Info(element);
        	 }
			return latestTransaction;
		}
        
        public void logIn(){
        	var repo = SCO_TestRepository.Instance;
        	var storeLogIn = repo.NCRNEXTGENUI.SomeContainer.StoreLogIn;
			var storeLoginInfo = repo.NCRNEXTGENUI.SomeContainer.StoreLogInInfo;
			
			storeLoginInfo.WaitForAttributeEqual(storeLoginInfo.SearchTimeout, "Visible", "True");
			storeLogIn.Click();
			
			var storeLoginKeypad9 = repo.NCRNEXTGENUI.SomeContainer.storeLoginKeypad9;
			var storeLoginKeypad9Info = repo.NCRNEXTGENUI.SomeContainer.storeLoginKeypad9Info;
			
			storeLoginKeypad9Info.WaitForAttributeEqual(storeLoginKeypad9Info.SearchTimeout, "Visible", "True");
			storeLoginKeypad9.Click();
			
			var storeLoginOkBtn = repo.NCRNEXTGENUI.SomeContainer.storeLoginOkBtn;
			storeLoginOkBtn.Click();
			storeLoginKeypad9.Click();
			storeLoginOkBtn.Click();
			
        }
    }
}
