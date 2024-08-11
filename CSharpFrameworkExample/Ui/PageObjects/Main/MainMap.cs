using OpenQA.Selenium;

namespace CSharpFrameworkExample.Ui.PageObjects.Main;

public static class MainMap
{
    public static By ProductsAndPerformanceDropdown =
        By.XPath("//a[@class='dropdown-toggle' and @aria-label='Products & Performance']");

    public static By StrategiesDropdown = By.XPath("//a[@class='dropdown-toggle' and @aria-label='Strategies']");

    public static By InvestmentIdeasDropdown =
        By.XPath("//a[@class='dropdown-toggle' and @aria-label='Investment Ideas']");

    public static By InsightsDropdown = By.XPath("//a[@class='dropdown-toggle' and @aria-label='Insights']");

    public static By ResourcesDropdown = By.XPath("//a[@class='dropdown-toggle' and @aria-label='Resources']");

    public static By AboutUsDropdown = By.XPath("//a[@class='dropdown-toggle' and @aria-label='About Us']");

    public static By OverviewMenuItem = By.CssSelector("[nav-id='overview']");

    public static By DiversityInclusionMenuItem = By.CssSelector("[nav-id='diversity-inclusion']");

    public static By SustainableInvestingMenuItem = By.CssSelector("[nav-id='sustainable-investing']");

    public static By InvestmentTeamsMenuItem = By.CssSelector("[nav-id='investment-teams']");

    public static By InvestmentProfessionalsMenuItem = By.CssSelector("[nav-id='investment-professionals']");

    public static By NewsroomMenuItem = By.CssSelector("[nav-id='newsroom']");

    public static By ContactUsMenuItem = By.CssSelector("[nav-id='contact-us']");
}