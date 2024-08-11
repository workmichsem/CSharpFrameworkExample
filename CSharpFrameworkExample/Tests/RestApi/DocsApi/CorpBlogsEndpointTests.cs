using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Models.RestApi.DocsV2Api;
using CSharpFrameworkExample.RestApi.Clients;
using FluentAssertions;
using NUnit.Framework;

namespace CSharpFrameworkExample.Tests.RestApi.DocsApi;

[TestFixture]
[AllureFeature("CorpBlogsEndpoint")]
public class CorpBlogsEndpointTests : BaseRestApiTest
{
    [Test]
    public void SuccessCorpBlogs()
    {
        var responseJson = new DocsV2Client()
            .CorpBlogsEndpoint()
            .Then()
            .StatusCode(200)
            .DeserializeTo(typeof(DocsV2EndpointsBaseResponse));

        var expectedJson = new DocsV2EndpointsBaseResponse
        {
            locale = "en",
            alias = "corpblogs",
            name = "Corporate blogs",
            description = "Corporate blogs on the Habr",
            content =
                "<h2>Corporate blogs</h2><p>Official\u00a0<a href=\"https://habr.com/companies/\">accounts of companies</a>, whose activities are related to IT. Representatives of companies share news and knowledge within their blog. You can directly contact them in comments or via private messages.</p><p>For convenience, on the right side of the page with a list of companies there is a rubricator that allows, for example, to deduce only those who are engaged in software development. Or design.</p><p>The list is sorted by rating, which consists of total score for company publications, karma of its employees and a number of other factors.</p><p>According to that, the more well rated publications the company has (and the more often they appear), the higher its position in the overall list.</p><p>Technically, a corporate blog is a\u00a0<a href=\"/docs/help/hubs/\">hub</a>, hub, that is, you can\u00a0<a href=\"/docs/help/lenta/\">subscribe</a>\u00a0to it just like any other hub, after which it will appear in your stream.</p><h3>How to create my company's blog</h3><p>To create a blog of the company is quite easy enough to choose a tariff plan, click the \"order\" button and fill out the form. In case of approval of the application, our managers will contact you.</p><p>For any questions about company blogging, you can use the special help section available in the blog administration panel.</p><p>If suddenly you did not find an answer to your question, write to our\u00a0<a href=\"https://habr.com/feedback/\">support team</a>, we will help you.</p>",
            isPublished = true
        };

        responseJson.Should().BeEquivalentTo(expectedJson);
    }
}