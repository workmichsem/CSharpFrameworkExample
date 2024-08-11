using CSharpFrameworkExample.Models.Base;
using RestAssured.Request.Builders;
using RestAssured.Request.Logging;
using RestAssured.Response;
using RestAssured.Response.Logging;
using static RestAssured.Dsl;

namespace CSharpFrameworkExample.RestApi.Base;

public class BaseClient
{
    public VerifiableResponse Get(string endpoint)
    {
        return Given()
            .Spec(GetSpecification())
            .When()
            .Get(endpoint)
            .Log(ResponseLogLevel.All);
    }

    public VerifiableResponse GetWithParams(string endpoint, Dictionary<string, object> query)
    {
        return Given()
            .Spec(GetSpecification())
            .When()
            .QueryParams(query)
            .Get(endpoint)
            .Log(ResponseLogLevel.All);
    }

    public VerifiableResponse Post(string endpoint)
    {
        return Given()
            .Spec(GetSpecification())
            .When()
            .Post(endpoint)
            .Log(ResponseLogLevel.All);
    }

    public VerifiableResponse PostWithJson(string endpoint, BaseJson json)
    {
        return Given()
            .Spec(GetSpecification())
            .When()
            .Body(json)
            .Post(endpoint)
            .Log(ResponseLogLevel.All);
    }

    public RequestSpecification GetSpecification()
    {
        return new RequestSpecBuilder()
            .WithRequestLogLevel(RequestLogLevel.All)
            .WithBaseUri("https://habr.com")
            .WithDisabledSslCertificateValidation()
            .WithTimeout(TimeSpan.FromSeconds(15))
            .Build();
    }
}