namespace CSharpFrameworkExample.Models.RestApi.DocsV2Api;

public class DocsV2EndpointsBaseResponse
{
    public string locale { get; set; }

    public string alias { get; set; }

    public string name { get; set; }

    public string description { get; set; }

    public string content { get; set; }

    public bool isPublished { get; set; }
}