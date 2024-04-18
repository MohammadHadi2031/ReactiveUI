using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Windows;

#if NET_45
[assembly: ThemeInfo(
   ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                    //(used if a resource is not found in the page, 
                                    // or application resource dictionaries)
   ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                             //(used if a resource is not found in the page, 
                                             // app, or any theme specific resource dictionaries)
)]
#endif

[assembly: AssemblyDescription("An MVVM framework that integrates the Reactive Extensions")]
[assembly: AssemblyProduct("ReactiveUI")]
//[assembly: InternalsVisibleTo("ReactiveUI.Tests_Net45")]
//[assembly: InternalsVisibleTo("ReactiveUI.Tests_WinRT")]
//[assembly: InternalsVisibleTo("ReactiveUI_Tests_iOS")] // NB: iOS apps can't have '.' in the name
//[assembly: InternalsVisibleTo("ReactiveUI.Tests_Android")]
[assembly: InternalsVisibleTo("ReactiveUI.Net40.Winforms, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c9f1fb97f37b250d02b04512a63c1393197b8ab83ea562aeea29c7781cdd81e255c8ddb934dd8ce796495e2f518989f890af3516347e0957e53cf7f54efd3d381cde4f32a338aac222c91ebbc0b027d55d5a6dbdd757e8a415260c523d5529720edf358e133f18b98f640ad6303be1e66f356532454ff51b4a467a27f605b6cc")]
//[assembly: InternalsVisibleTo("ReactiveUI.XamForms")]
//[assembly: InternalsVisibleTo("ReactiveUI.AndroidSupport")]
