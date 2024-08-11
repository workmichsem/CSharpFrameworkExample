using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.DiversityInclusion.DiversityInclusionMap;

namespace CSharpFrameworkExample.Ui.PageObjects.DiversityInclusion;

public class DiversityInclusionPage: BasePage
{
    public DiversityInclusionPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }
    
    private string PageUrl = PageUrls.DiversityInclusionPage;
    
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