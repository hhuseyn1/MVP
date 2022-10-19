namespace MVP.Views;

public partial class MainView : Form,IMainView
{
    public MainView()
    {
        InitializeComponent();

    }
    public string SearchValue { get => txtbox_Students.Text; }

    public event EventHandler SearchEvent;
    public event EventHandler AddEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;

    public void SetStudentListBindingSource(BindingSource source)
    {
        lstbox_Students.DataSource = null;
        lstbox_Students.DataSource = source;

    }

    private void btn_Search_Click(object sender, EventArgs e)
    {
        SearchEvent?.Invoke(this,EventArgs.Empty);
    }

    private void btn_Delete_Click(object sender, EventArgs e)
    {
        DeleteEvent?.Invoke(this,EventArgs.Empty);
    }

    private void btn_Add_Click(object sender, EventArgs e)
    {
        AddEvent?.Invoke(this,EventArgs.Empty);
    }
}
