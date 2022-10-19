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
            new MainPresenter(_view,_addview);
            Application.Run((Form)_view);
        }
    }
}