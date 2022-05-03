using System;

namespace SecurityStudio.Base.Main.Mvvm
{
    public abstract class SsViewModel : ObservableObject, IDisposable
    {
        public SsView SsView { get; set; }
        public SsWindowView SsWindowView { get; set; }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;

                if (SsView != null && SsView.Window != null)
                    SsView.Window.Title = Title;

                if (SsWindowView != null)
                    SsWindowView.Title = Title;
            }
        }

        public bool IsPrepared { get; set; }

        public void Prepare()
        {
            if (IsPrepared == false)
            {
                IsPrepared = true;
                Title = "Security Studio (Change Title !!!!)";
                PrepareSsCommands();
                PrepareVariables();
                FillData();
            }
        }

        protected abstract void PrepareSsCommands();
        protected abstract void PrepareVariables();
        protected abstract void FillData();

        public virtual void SsViewLoaded()
        {
        }

        public virtual bool OnWindowClosing()
        {
            return false;
        }

        public abstract void Dispose();
    }
}