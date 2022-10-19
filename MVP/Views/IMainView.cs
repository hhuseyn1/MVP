namespace MVP.Views;
public interface IMainView{

    public string SearchValue { get; }

    public event EventHandler SearchEvent;
    public event EventHandler AddEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;

    public void SetStudentListBindingSource(BindingSource source);
    void Show();
}
