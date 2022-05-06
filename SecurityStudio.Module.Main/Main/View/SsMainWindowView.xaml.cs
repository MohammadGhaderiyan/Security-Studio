using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Docking.Base;
using SecurityStudio.Base.Control.Dock;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Main.ViewModel;
using SecurityStudio.Module.Main.Manage.View;
using SecurityStudio.Service.Main.Container;
using SecurityStudio.Service.Main.Dock;
using SecurityStudio.Service.Main.Tunnel;

namespace SecurityStudio.Module.Main.Main.View
{
    public partial class SsMainWindowView : SsWindowView
    {
        private readonly ITunnelService _tunnelService;
        private readonly IContainerService _containerService;

        public SsMainWindowView(SsMainWindowViewModel ssMainWindowViewModel,
            ITunnelService tunnelService, IContainerService containerService)
            : base(ssMainWindowViewModel)
        {
            _tunnelService = tunnelService;
            _containerService = containerService;
            InitializeComponent();
        }

        public override void LoadSsView()
        {
            _tunnelService.Register<ShowDockMessage>("ShowDockMessage", ShowDockMessageReceived);
            _tunnelService.Register<CloseDockMessage>("CloseDockMessage", CloseDockMessageReceived);
        }

        private readonly List<SsDocumentPanel> _ssDocumentPanels = new List<SsDocumentPanel>();

        private void ShowDockMessageReceived(ShowDockMessage showDockMessage)
        {
            var currentSsDocumentPanel = _ssDocumentPanels.FirstOrDefault(item => item.Content.GetType() == showDockMessage.SsViewType);
            if (currentSsDocumentPanel != null)
            {
                currentSsDocumentPanel.IsActive = true;
            }
            else
            {
                var ssView = (SsView)_containerService.Resolve(showDockMessage.SsViewType);
                var ssDocumentPanel = new SsDocumentPanel
                {
                    Padding = new Thickness(2),
                    Content = ssView,
                    Caption = ssView.SsViewModel.Title,
                    IsSelectedItem = true
                };

                _ssDocumentPanels.Add(ssDocumentPanel);
                SdvDocumentGroupMain.Items.Add(ssDocumentPanel);
            }
        }

        private void CloseDockMessageReceived(CloseDockMessage closeDockMessage)
        {
            CloseSsView(closeDockMessage.SsView);
        }

        private void DockLayoutManagerOnDockItemClosing(object sender, ItemCancelEventArgs e)
        {
            var ssDocumentPanel = (SsDocumentPanel)e.Item;
            var ssView = (SsView)ssDocumentPanel.Content;
            e.Cancel = ssView.GetType() == typeof(SsManageMenu01View);
        }

        private void DockLayoutManagerOnDockItemClosed(object sender, DockItemClosedEventArgs e)
        {
            var ssDocumentPanel = (SsDocumentPanel)e.Item;
            CloseSsView((SsView)ssDocumentPanel.Content);
        }

        private void CloseSsView(SsView ssView)
        {
            var currentSsDocumentPanel = _ssDocumentPanels.FirstOrDefault(item => Equals(item.Content, ssView));
            if (currentSsDocumentPanel != null)
            {
                ssView.SsViewModel.Dispose();

                _ssDocumentPanels.Remove(currentSsDocumentPanel);
                //SdvDocumentGroupMain.Items.Remove(currentSsDocumentPanel);
            }
        }
    }
}