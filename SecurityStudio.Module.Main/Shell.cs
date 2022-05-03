using Ninject;
using SecurityStudio.Database.Model.Validation;
using SecurityStudio.Module.CodeEditor;
using SecurityStudio.Module.Definition;
using SecurityStudio.Module.Linux;
using SecurityStudio.Module.Mitre;
using SecurityStudio.Module.MobilePenTest;
using SecurityStudio.Module.NetworkPenTest;
using SecurityStudio.Module.Tool;
using SecurityStudio.Module.WebPenTest;
using SecurityStudio.Module.Windows;
using SecurityStudio.Service.CodeEditor;
using SecurityStudio.Service.Definition;
using SecurityStudio.Service.Linux;
using SecurityStudio.Service.Main;
using SecurityStudio.Service.Mitre;
using SecurityStudio.Service.MobilePenTest;
using SecurityStudio.Service.NetworkPenTest;
using SecurityStudio.Service.Tool;
using SecurityStudio.Service.WebPenTest;
using SecurityStudio.Service.Windows;

namespace SecurityStudio.Module.Main
{
    public class Shell
    {
        public IKernel Kernel { get; set; }

        public Shell()
        {
            Kernel = new StandardKernel(


                new SsModelValidationModule(),

                // Module
                new SsCodeEditorModuleModule(),
                new SsDefinitionModuleModule(),
                new SsLinuxModuleModule(),
                new SsMainModuleModule(),
                new SsMitreModuleModule(),
                new SsMobilePenTestModuleModule(),
                new SsNetworkPenTestModuleModule(),
                new SsToolModuleModule(),
                new SsWebPenTestModuleModule(),
                new SsWindowsModuleModule(),

                // Service
                new SsCodeEditorServiceModule(),
                new SsDefinitionServiceModule(),
                new SsLinuxServiceModule(),
                new SsMainServiceModule(),
                new SsMitreServiceModule(),
                new SsMobilePenTestServiceModule(),
                new SsNetworkPenTestServiceModule(),
                new SsToolServiceModule(),
                new SsWebPenTestServiceModule(),
                new SsWindowsServiceModule());
        }
    }
}