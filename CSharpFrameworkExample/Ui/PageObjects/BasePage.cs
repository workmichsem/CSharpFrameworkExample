using Allure.NUnit.Attributes;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CSharpFrameworkExample.Ui.PageObjects;

public class BasePage
{
    protected IWebDriver Driver;
    protected Logger Logger;
    protected string PageUrl = "";

    public BasePage(IWebDriver driver, Logger logger)
    {
        this.Driver = driver;
        this.Logger = logger;
    }

    [AllureStep("Go to page URL")]
    protected internal void OpenPage()
    {
        Driver.Navigate().GoToUrl(PageUrl);
    }

    [AllureStep("Click")]
    protected internal void Click(By locator)
    {
        Logger.Info($"Click on locator ({locator.Criteria})");
        try
        {
            Driver.FindElement(locator).Click();
        }
        catch (StaleElementReferenceException)
        {
            Driver.FindElement(locator).Click();
        }
    }

    [AllureStep("Type text {text}")]
    protected internal void Type(By locator, string text)
    {
        Logger.Info($"Click on locator ({locator.Criteria})");
        IWebElement element;
        try
        {
            element = Driver.FindElement(locator);
        }
        catch (Exception e)
        {
            Logger.Error(e);
            throw;
        }

        element.SendKeys(text);
    }

    [AllureStep("Clear text")]
    protected internal void Clear(By locator)
    {
        Logger.Info($"Clear text in locator ({locator.Criteria})");
        IWebElement element;
        try
        {
            element = Driver.FindElement(locator);
        }
        catch (Exception e)
        {
            Logger.Error(e);
            throw;
        }

        element.Clear();
    }

    [AllureStep("Wait for element visible")]
    protected internal void WaitForVisible(By locator, int timeout = 5)
    {
        Logger.Info($"Wait for visibility ({locator.Criteria})");
        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
        wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }

    [AllureStep("Wait for element invisible")]
    protected internal void WaitForElementInvisible(By locator, int timeout = 5)
    {
        Logger.Info($"Wait for invisibility ({locator.Criteria})");
        var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
        wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
    }
}