using Allure.NUnit;
using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.PageObjects.Main;
using CSharpFrameworkExample.Ui.Utils;
using CSharpFrameworkExample.Utils;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;

[assembly: LevelOfParallelism(5)]
namespace CSharpFrameworkExample.Tests.Ui;


[AllureNUnit]
[AllureEpic("UI tests")]
public class BaseUiTest
{
    protected IWebDriver Driver;
    protected MainPage MainPage;
    protected Logger Log;
    
    public string? GetTestId()
    {
        return TestContext.CurrentContext.Test.ToString();
    }

    [SetUp]
    [AllureBefore("Before test")]
    public void SetUp()
    {
        Log = LogManager.GetCurrentClassLogger();
        LoggerHolder.Add(GetTestId(), Log);
        Log.Info($"START TEST: {GetTestId()}");
        Driver = WebDriverFactory.CreateDriver(Browser.Chrome);
        MainPage = new MainPage(Driver, Log);
    }

    [TearDown]
    [AllureAfter("After test")]
    public void TearDown()
    {
        Driver.Quit();
        LoggerHolder.Get(GetTestId()).Info($"FINISH TEST: {GetTestId()}");
        LoggerHolder.Remove(GetTestId());
    }
}