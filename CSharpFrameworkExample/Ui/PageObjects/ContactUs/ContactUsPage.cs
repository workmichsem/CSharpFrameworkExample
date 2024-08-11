using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.ContactUs.ContactUsMap;

namespace CSharpFrameworkExample.Ui.PageObjects.ContactUs;

public class ContactUsPage : BasePage
{
    public ContactUsPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }
    
    private string PageUrl = PageUrls.ContactUsPage;

    [AllureStep("Check for opened page")]
    public bool IsPageOpened()
    {
        try
        {
            WaitForVisible(PageBanner);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}