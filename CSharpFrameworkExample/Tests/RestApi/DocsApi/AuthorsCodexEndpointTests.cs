using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Models.RestApi.DocsV2Api;
using CSharpFrameworkExample.RestApi.Clients;
using FluentAssertions;
using NUnit.Framework;

namespace CSharpFrameworkExample.Tests.RestApi.DocsApi;

[TestFixture]
[AllureFeature("AuthorsCodexEndpoint")]
public class AuthorsCodexEndpointTests : BaseRestApiTest
{
    [Test]
    public void SuccessAuthorsCodex()
    {
        var responseJson = new DocsV2Client()
            .AuthorsCodexEndpoint()
            .Then()
            .StatusCode(200)
            .DeserializeTo(typeof(DocsV2EndpointsBaseResponse));

        var expectedJson = new DocsV2EndpointsBaseResponse
        {
            locale = "en",
            alias = "codex",
            name = "Habr Code of Authors",
            description = "The code followed by the authors publishing their material on Habr",
            content =
                "<h2>Habr Code of Authors </h2><p>This is not a document you should strictly abide. Frankly speaking it is not a document at all. It's just a bunch of rules some authors follow.</p><ul><li><p>I try to create my own content and avoid reprints.</p></li><li><p>By publishing the content of other authors (graphics, text) I always refer to sources.</p></li><li><p>I do not create stupid comments like \"+1\" or \"LooooL\".</p></li><li><p>I don't use obscene words and humiliate anyone.</p></li><li><p>I put maximum effort to ensure that my text is written without mistakes.</p></li><li><p>I respect the administration and users of the website, and I do not want to humiliate or insult them.</p></li><li><p>When arguing I try not to inflate the conflict but to solve the problem independently in direct messages.</p></li><li><p>If I can't solve a conflict I do not call users to bully and don't do it myself.</p></li><li><p>It's totally up to me whether to publish my content on Habr or not, and I do not expect any reward for it.</p></li><li><p>I help newbies on Habr if necessary .</p></li><li><p>I first use search to clarify if similar content has been published earlier by anyone. If so I'll complement that in comments.</p></li><li><p>I try to bring order instead of chaos on Habr.</p></li><li><p>I do not want to destroy or discredit the community.</p></li><li><p>I don't beg for karma and I'm comfortable with rating changes.</p></li><li><p>I try to take into account readers' feedback. </p></li><li><p>I think positive. There is always a way out of the difficult situation.</p></li><li><p>I understand that Habr is a community of people with different interests, and if some topic is not interesting to me, I do not prevent others from discussing it.</p></li></ul>",
            isPublished = true
        };

        responseJson.Should().BeEquivalentTo(expectedJson);
    }
}