'<auto-generated />

Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TechTalk.SpecFlow
Imports TechTalk.SpecFlow.MSTest.SpecFlowPlugin
Imports System
Imports System.Reflection
Imports System.CodeDom.Compiler
Imports System.Runtime.CompilerServices

<GeneratedCode("SpecFlow", "3.9.22")>
<TestClass>
Public NotInheritable Class PROJECT_ROOT_NAMESPACE_MSTestAssemblyHooks
    <AssemblyInitialize>
    <MethodImpl(MethodImplOptions.NoInlining)>
    Public Shared Sub AssemblyInitialize(testContext As TestContext)

        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_MSTestAssemblyHooks).Assembly
        Dim containerBuilder As New MsTestContainerBuilder(testContext)

        TestRunnerManager.OnTestRunStart(currentAssembly, containerBuilder)
    End Sub

    <AssemblyCleanup>
    <MethodImpl(MethodImplOptions.NoInlining)>
    Public Shared Sub AssemblyCleanup()

        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_MSTestAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunEnd(currentAssembly)
    End Sub

End Class
