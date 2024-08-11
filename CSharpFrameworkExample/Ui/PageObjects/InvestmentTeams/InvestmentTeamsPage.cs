using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.InvestmentTeams.InvestmentTeamsMap;

namespace CSharpFrameworkExample.Ui.PageObjects.InvestmentTeams;

public class InvestmentTeamsPage: BasePage
{
    public InvestmentTeamsPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }
    
    private string PageUrl = PageUrls.InvestmentTeamsPage;
    
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