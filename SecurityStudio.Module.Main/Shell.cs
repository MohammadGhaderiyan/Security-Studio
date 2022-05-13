using Ninject;
using SecurityStudio.Database.Model.Validation;
using SecurityStudio.Module.CodeEditor;
using SecurityStudio.Module.Database;
using SecurityStudio.Module.Definition;
using SecurityStudio.Module.Exploit;
using SecurityStudio.Module.Forensic;
using SecurityStudio.Module.Linux;
using SecurityStudio.Module.Mitre;
using SecurityStudio.Module.Osint;
using SecurityStudio.Module.PenTest;
using SecurityStudio.Module.Tool;
using SecurityStudio.Module.Wiki;
using SecurityStudio.Module.Windows;
using SecurityStudio.Service.CodeEditor;
using SecurityStudio.Service.Database;
using SecurityStudio.Service.Definition;
using SecurityStudio.Service.Exploit;
using SecurityStudio.Service.Forensic;
using SecurityStudio.Service.Linux;
using SecurityStudio.Service.Main;
using SecurityStudio.Service.Mitre;
using SecurityStudio.Service.Osint;
using SecurityStudio.Service.PenTest;
using SecurityStudio.Service.Tool;
using SecurityStudio.Service.Wiki;
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
                new SsDatabaseModuleModule(),
                new SsDefinitionModuleModule(),
                new SsExploitModuleModule(),
                new SsForensicModuleModule(),
                new SsLinuxModuleModule(),
                new SsMainModuleModule(),
                new SsMitreModuleModule(),
                new SsOsintModuleModule(),
                new SsPenTestModuleModule(),
                new SsToolModuleModule(),
                new SsWikiModuleModule(),
                new SsWindowsModuleModule(),

                // Service
                new SsCodeEditorServiceModule(),
                new SsDatabaseServiceModule(),
                new SsDefinitionServiceModule(),
                new SsExploitServiceModule(),
                new SsForensicServiceModule(),
                new SsLinuxServiceModule(),
                new SsMainServiceModule(),
                new SsMitreServiceModule(),
                new SsOsintServiceModule(),
                new SsPenTestServiceModule(),
                new SsToolServiceModule(),
                new SsWikiServiceModule(),
                new SsWindowsServiceModule());
        }
    }
}