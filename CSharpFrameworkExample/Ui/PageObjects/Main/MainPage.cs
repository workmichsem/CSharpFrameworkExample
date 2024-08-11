using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.PageObjects.ContactUs;
using CSharpFrameworkExample.Ui.PageObjects.DiversityInclusion;
using CSharpFrameworkExample.Ui.PageObjects.InvestmentProfessionals;
using CSharpFrameworkExample.Ui.PageObjects.InvestmentTeams;
using CSharpFrameworkExample.Ui.PageObjects.Newsroom;
using CSharpFrameworkExample.Ui.PageObjects.Overview;
using CSharpFrameworkExample.Ui.PageObjects.SustainableInvesting;
using CSharpFrameworkExample.Ui.Utils;
using NLog;
using OpenQA.Selenium;
using static CSharpFrameworkExample.Ui.PageObjects.Main.MainMap;

namespace CSharpFrameworkExample.Ui.PageObjects.Main;

public class MainPage : BasePage
{
    public MainPage(IWebDriver driver, Logger logger) : base(driver, logger)
    {
    }

    private string PageUrl = PageUrls.MainPage;

    [AllureStep("Click Products And Performance Dropdown")]
    public MainPage ClickProductsAndPerformanceDropdown()
    {
        Click(ProductsAndPerformanceDropdown);
        return this;
    }

    [AllureStep("Click Strategies Dropdown")]
    public MainPage ClickStrategiesDropdown()
    {
        Click(StrategiesDropdown);
        return this;
    }

    [AllureStep("Click Investment Ideas Dropdown")]
    public MainPage ClickInvestmentIdeasDropdown()
    {
        Click(InvestmentIdeasDropdown);
        return this;
    }

    [AllureStep("Click Insights Dropdown")]
    public MainPage ClickInsightsDropdown()
    {
        Click(InsightsDropdown);
        return this;
    }

    [AllureStep("Click Resources Dropdown")]
    public MainPage ClickResourcesDropdown()
    {
        Click(ResourcesDropdown);
        return this;
    }

    [AllureStep("Click About Us Dropdown")]
    public MainPage ClickAboutUsDropdown()
    {
        Click(AboutUsDropdown);
        return this;
    }

    [AllureStep("Click Overview Menu Item")]
    public OverviewPage ClickOverviewMenuItem()
    {
        Click(OverviewMenuItem);
        return new OverviewPage(Driver, Logger);
    }

    [AllureStep("Click Diversity Inclusion Menu Item")]
    public DiversityInclusionPage ClickDiversityInclusionMenuItem()
    {
        Click(DiversityInclusionMenuItem);
        return new DiversityInclusionPage(Driver, Logger);
    }

    [AllureStep("Click Sustainable Investing Menu Item")]
    public SustainableInvestingPage ClickSustainableInvestingMenuItem()
    {
        Click(SustainableInvestingMenuItem);
        return new SustainableInvestingPage(Driver, Logger);
    }

    [AllureStep("Click Investment Teams Menu Item")]
    public InvestmentTeamsPage ClickInvestmentTeamsMenuItem()
    {
        Click(InvestmentTeamsMenuItem);
        return new InvestmentTeamsPage(Driver, Logger);
    }

    [AllureStep("Click Investment Professionals Menu Item")]
    public InvestmentProfessionalsPage ClickInvestmentProfessionalsMenuItem()
    {
        Click(InvestmentProfessionalsMenuItem);
        return new InvestmentProfessionalsPage(Driver, Logger);
    }

    [AllureStep("Click Newsroom Menu Item")]
    public NewsroomPage ClickNewsroomMenuItem()
    {
        Click(NewsroomMenuItem);
        return new NewsroomPage(Driver, Logger);
    }

    [AllureStep("Click Contact Us Menu Item")]
    public ContactUsPage ClickContactUsMenuItem()
    {
        Click(ContactUsMenuItem);
        return new ContactUsPage(Driver, Logger);
    }

    [AllureStep("Check for opened page")]
    public bool IsPageOpened()
    {
        try
        {
            WaitForVisible(ProductsAndPerformanceDropdown);
            WaitForVisible(StrategiesDropdown);
            WaitForVisible(InvestmentIdeasDropdown);
            WaitForVisible(InsightsDropdown);
            WaitForVisible(ResourcesDropdown);
            WaitForVisible(AboutUsDropdown);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}