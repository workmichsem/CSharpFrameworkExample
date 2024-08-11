using CSharpFrameworkExample.RestApi.Base;
using RestAssured.Response;

namespace CSharpFrameworkExample.RestApi.Clients;

public class DocsV2Client : BaseClient
{
    public VerifiableResponse CorpBlogsEndpoint()
    {
        return Get("kek/v2/docs/companies/corpblogs");
    }

    public VerifiableResponse AuthorsCodexEndpoint()
    {
        return Get("kek/v2/docs/authors/codex");
    }
}