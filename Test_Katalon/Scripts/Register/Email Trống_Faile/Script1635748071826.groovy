import static com.kms.katalon.core.checkpoint.CheckpointFactory.findCheckpoint
import static com.kms.katalon.core.testcase.TestCaseFactory.findTestCase
import static com.kms.katalon.core.testdata.TestDataFactory.findTestData
import static com.kms.katalon.core.testobject.ObjectRepository.findTestObject
import static com.kms.katalon.core.testobject.ObjectRepository.findWindowsObject
import com.kms.katalon.core.checkpoint.Checkpoint as Checkpoint
import com.kms.katalon.core.cucumber.keyword.CucumberBuiltinKeywords as CucumberKW
import com.kms.katalon.core.mobile.keyword.MobileBuiltInKeywords as Mobile
import com.kms.katalon.core.model.FailureHandling as FailureHandling
import com.kms.katalon.core.testcase.TestCase as TestCase
import com.kms.katalon.core.testdata.TestData as TestData
import com.kms.katalon.core.testng.keyword.TestNGBuiltinKeywords as TestNGKW
import com.kms.katalon.core.testobject.TestObject as TestObject
import com.kms.katalon.core.webservice.keyword.WSBuiltInKeywords as WS
import com.kms.katalon.core.webui.keyword.WebUiBuiltInKeywords as WebUI
import com.kms.katalon.core.windows.keyword.WindowsBuiltinKeywords as Windows
import internal.GlobalVariable as GlobalVariable
import org.openqa.selenium.Keys as Keys

WebUI.openBrowser('https://localhost:44368')

WebUI.click(findTestObject('Page_Home Page - My ASP.NET Application/a_Ti khon'))

WebUI.click(findTestObject('Page_Home Page - My ASP.NET Application/a_ng k'))

WebUI.setText(findTestObject('Page_Dangky - My ASP.NET Application/input_Username_id'), 'Had')

WebUI.setText(findTestObject('Page_Dangky - My ASP.NET Application/input_Password_password'), '123')

WebUI.setText(findTestObject('Page_Dangky - My ASP.NET Application/input_Confirm Password_confirm'), '123')

WebUI.setText(findTestObject('Page_Dangky - My ASP.NET Application/input_Fullname_fullname'), 'Hoad')

WebUI.setText(findTestObject('Page_Dangky - My ASP.NET Application/input_Email Address_email'), '')

WebUI.click(findTestObject('Page_Dangky - My ASP.NET Application/button_ng k'))

Urly = WebUI.getUrl()

WebUI.verifyMatch(Urly, 'https://localhost:44368/user/dangky', false)

WebUI.closeBrowser()

