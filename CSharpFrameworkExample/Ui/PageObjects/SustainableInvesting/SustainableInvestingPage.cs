using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.SustainableInvesting.SustainableInvestingMap;

namespace CSharpFrameworkExample.Ui.PageObjects.SustainableInvesting;

public class SustainableInvestingPage: BasePage
{
    public SustainableInvestingPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }

    private string PageUrl = PageUrls.SustainableInvestingPage;
    
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