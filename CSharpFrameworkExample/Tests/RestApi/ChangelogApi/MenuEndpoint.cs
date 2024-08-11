using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Models.RestApi.ChangelogV2Api;
using CSharpFrameworkExample.RestApi.Clients;
using FluentAssertions;
using NUnit.Framework;

namespace CSharpFrameworkExample.Tests.RestApi.ChangelogApi;

[TestFixture]
[AllureFeature("ChangelogApi")]
public class MenuEndpoint : BaseRestApiTest
{
    [TestCase("ru")]
    [TestCase("en")]
    public void SuccessMenu(string lang)
    {
        var query = new Dictionary<string, object>
        {
            { "fl", lang },
            { "hl", lang }
        };

        var responseJson = new ChangelogV2Client().Menu(query)
            .Then()
            .StatusCode(200)
            .DeserializeTo(typeof(MenuResponse));

        var expectedJson = new MenuResponse();
        switch (lang)
        {
            case "ru":
                expectedJson = new MenuResponse
                {
                    articlesList = new List<ArticlesList>
                    {
                        new()
                        {
                            alias = "2024",
                            name = "2024",
                            description = "Список изменений на Хабре за 2024 год"
                        },
                        new()
                        {
                            alias = "2023",
                            name = "2023",
                            description = "Список изменений на Хабре за 2023 год"
                        },
                        new()
                        {
                            alias = "2022",
                            name = "2022",
                            description = "Список изменений на Хабре за 2022 год"
                        }
                    }
                };
                break;
            case "en":
                expectedJson = new MenuResponse
                {
                    articlesList = new List<ArticlesList>
                    {
                        new()
                        {
                            alias = "2024",
                            name = "2024",
                            description = "Changelog for 2024"
                        },
                        new()
                        {
                            alias = "2023",
                            name = "2023",
                            description = "Changelog for 2023"
                        },
                        new()
                        {
                            alias = "2022",
                            name = "2022",
                            description = "Changelog for 2022"
                        }
                    }
                };
                break;
        }

        responseJson.Should().BeEquivalentTo(expectedJson);
    }
}