using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CSharpFrameworkExample.Ui.Utils;

public static class WebDriverOptions
{
    public static ChromeOptions GetChromeOptions()
    {
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        return options;
    }

    public static FirefoxOptions GetFirefoxOptions()
    {
        var options = new FirefoxOptions();
        options.AddArgument("--start-maximized");
        return options;
    }

    public static EdgeOptions GetEdgeOptions()
    {
        var options = new EdgeOptions();
        return options;
    }
}