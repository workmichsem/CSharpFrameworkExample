using Allure.NUnit;
using Allure.NUnit.Attributes;
using CSharpFrameworkExample.Utils;
using NLog;
using NUnit.Framework;

namespace CSharpFrameworkExample.Tests.RestApi;

[AllureNUnit]
[AllureEpic("REST Api tests")]
public class BaseRestApiTest
{
    public string? GetTestId()
    {
        return TestContext.CurrentContext.Test.ToString();
    }

    [SetUp]
    [AllureBefore("Before test")]
    public void SetUp()
    {
        var log = LogManager.GetCurrentClassLogger();
        LoggerHolder.Add(GetTestId(), log);
        log.Info($"START TEST: {GetTestId()}");
    }

    [TearDown]
    [AllureAfter("After test")]
    public void TearDown()
    {
        LoggerHolder.Get(GetTestId()).Info($"FINISH TEST: {GetTestId()}");
        LoggerHolder.Remove(GetTestId());
    }
}