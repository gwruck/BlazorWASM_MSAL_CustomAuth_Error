# BlazorWASM_MSAL_CustomAuth_Error
Error identified when trying to add CustomAuthorizationStateProvider to a Blazor WASM project.

Microsoft.AspNetCore.Components.WebAssembly.Rendering.WebAssemblyRenderer[100]
      Unhandled exception rendering component: Specified cast is not valid.
System.InvalidCastException: Specified cast is not valid.
   at Microsoft.Extensions.DependencyInjection.WebAssemblyAuthenticationServiceCollectionExtensions.<>c__0`3[[Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticationState, Microsoft.AspNetCore.Components.WebAssembly.Authentication, Version=6.0.10.0, Culture=neutral, PublicKeyToken=adb9793829ddae60],[Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteUserAccount, Microsoft.AspNetCore.Components.WebAssembly.Authentication, Version=6.0.10.0, Culture=neutral, PublicKeyToken=adb9793829ddae60],[Microsoft.Authentication.WebAssembly.Msal.Models.MsalProviderOptions, Microsoft.Authentication.WebAssembly.Msal, Version=6.0.10.0, Culture=neutral, PublicKeyToken=adb9793829ddae60]].<AddRemoteAuthentication>b__0_0(IServiceProvider sp)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.VisitFactory(FactoryCallSite factoryCallSite, RuntimeResolverContext context)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteVisitor`2[[Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext, Microsoft.Extensions.DependencyInjection, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60],[System.Object, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]].VisitCallSiteMain(ServiceCallSite callSite, RuntimeResolverContext argument)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.VisitCache(ServiceCallSite callSite, RuntimeResolverContext context, ServiceProviderEngineScope serviceProviderEngine, RuntimeResolverLock lockType)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.VisitScopeCache(ServiceCallSite callSite, RuntimeResolverContext context)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteVisitor`2[[Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeResolverContext, Microsoft.Extensions.DependencyInjection, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60],[System.Object, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]].VisitCallSite(ServiceCallSite callSite, RuntimeResolverContext argument)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.Resolve(ServiceCallSite callSite, ServiceProviderEngineScope scope)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeServiceProviderEngine.<>c__DisplayClass4_0.<RealizeService>b__0(ServiceProviderEngineScope scope)
   at Microsoft.Extensions.DependencyInjection.ServiceProvider.GetService(Type serviceType, ServiceProviderEngineScope serviceProviderEngineScope)
   at Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope.GetService(Type serviceType)
   at Microsoft.AspNetCore.Components.ComponentFactory.<>c__DisplayClass7_0.<CreateInitializer>g__Initialize|1(IServiceProvider serviceProvider, IComponent component)
   at Microsoft.AspNetCore.Components.ComponentFactory.PerformPropertyInjection(IServiceProvider serviceProvider, IComponent instance)
   at Microsoft.AspNetCore.Components.ComponentFactory.InstantiateComponent(IServiceProvider serviceProvider, Type componentType)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.InstantiateComponent(Type componentType)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.InstantiateChildComponentOnFrame(RenderTreeFrame& frame, Int32 parentComponentId)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InitializeNewComponentFrame(DiffContext& diffContext, Int32 frameIndex)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InitializeNewSubtree(DiffContext& diffContext, Int32 frameIndex)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InsertNewFrame(DiffContext& diffContext, Int32 newFrameIndex)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.AppendDiffEntriesForRange(DiffContext& diffContext, Int32 oldStartIndex, Int32 oldEndIndexExcl, Int32 newStartIndex, Int32 newEndIndexExcl)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.ComputeDiff(Renderer renderer, RenderBatchBuilder batchBuilder, Int32 componentId, ArrayRange`1 oldTree, ArrayRange`1 newTree)
   at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, Exception& renderFragmentException)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.RenderInExistingBatch(RenderQueueEntry renderQueueEntry)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.ProcessRenderQueue()
