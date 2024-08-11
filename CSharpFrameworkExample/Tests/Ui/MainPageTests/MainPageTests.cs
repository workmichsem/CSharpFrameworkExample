using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Ui.PageObjects.Main;
using CSharpFrameworkExample.Ui.Utils;
using NUnit.Framework;


namespace CSharpFrameworkExample.Tests.Ui.MainPageTests;

[AllureFeature("Main Page Tests")]
public class MainPageTests : BaseUiTest
{
    [Test]
    public void CheckForOpeningContactUsPageTest()
    {
        
        Driver = WebDriverFactory.CreateDriver(Browser.Chrome);
        Driver.Navigate().GoToUrl("https://www.morganstanley.com/im/en-gb/intermediary-investor/");
        // MainPage = new MainPage(Driver, Log);
        // MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickContactUsMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
    
    [Test]
    public void CheckForOpeningDiversityInclusionPageTest()
    {
        MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickDiversityInclusionMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
    
    [Test]
    public void CheckForOpeningInvestmentProfessionalsPageTest()
    {
        MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickInvestmentProfessionalsMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
    
    [Test]
    public void CheckForOpeningInvestmentTeamsPageTest()
    {
        MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickInvestmentTeamsMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
    
    [Test]
    public void CheckForOpeningNewsroomPageTest()
    {
        MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickNewsroomMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
    
    [Test]
    public void CheckForOpeningOverviewPageTest()
    {
        MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickOverviewMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
    
    [Test]
    public void CheckForOpeningSustainableInvestingPageTest()
    {
        MainPage.OpenPage();
        var result = MainPage
            .ClickAboutUsDropdown()
            .ClickSustainableInvestingMenuItem()
            .IsPageOpened();

        Assert.IsTrue(result, "Page in not opened");
    }
}