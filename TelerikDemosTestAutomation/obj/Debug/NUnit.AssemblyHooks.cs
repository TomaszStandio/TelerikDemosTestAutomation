// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;
using global::System.Runtime.CompilerServices;

[GeneratedCode("SpecFlow", "3.9.74")]
[SetUpFixture]
public class TelerikDemosTestAutomation_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(TelerikDemosTestAutomation_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(TelerikDemosTestAutomation_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
#pragma warning restore
