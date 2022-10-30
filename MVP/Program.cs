using MVP.Presenters;
using MVP.Views;

namespace MVP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IMainView _view = new MainView();
            IAddView _addview = new AddView();
            IUpdateView _updateView = new UpdateView();
            new MainPresenter(_view,_addview,_updateView);
            new UpdatePresenter(_updateView);
            Application.Run((Form)_view);
        }
    }
}