using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.InvestmentProfessionals.InvestmentProfessionalsMap;

namespace CSharpFrameworkExample.Ui.PageObjects.InvestmentProfessionals;

public class InvestmentProfessionalsPage: BasePage
{
    public InvestmentProfessionalsPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }
    
    private string PageUrl = PageUrls.InvestmentProfessionalsPage;
    
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