using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.Newsroom.NewsroomMap;

namespace CSharpFrameworkExample.Ui.PageObjects.Newsroom;

public class NewsroomPage: BasePage
{
    public NewsroomPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }
    
    private string PageUrl = PageUrls.NewsroomPage;
    
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