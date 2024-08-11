using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CSharpFrameworkExample.Ui.Utils;

public class WebDriverFactory
{
    public static IWebDriver CreateDriver(Browser browser)
    {
        IWebDriver driver;
        switch (browser)
        {
            case Browser.Chrome:
                driver = new ChromeDriver(WebDriverOptions.GetChromeOptions());
                break;
            case Browser.Firefox:
                driver = new FirefoxDriver(WebDriverOptions.GetFirefoxOptions());
                break;
            case Browser.Edge:
                driver = new EdgeDriver(WebDriverOptions.GetEdgeOptions());
                break;
            default:
                throw new ArgumentException($"Browser '{browser}' is not supported");
        }

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

        return driver;
    }
}