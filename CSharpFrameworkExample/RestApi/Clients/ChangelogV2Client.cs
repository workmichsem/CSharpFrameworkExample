using CSharpFrameworkExample.RestApi.Base;
using RestAssured.Response;

namespace CSharpFrameworkExample.RestApi.Clients;

public class ChangelogV2Client : BaseClient
{
    public VerifiableResponse Menu(Dictionary<string, object> query = null)
    {
        return GetWithParams("kek/v2/docs/changelog/menu", query);
    }
}