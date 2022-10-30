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


    private void btn_Search_Click(object sender, EventArgs e) => SearchEvent?.Invoke(sender, e);

    private void btn_Add_Click(object sender, EventArgs e) => AddEvent?.Invoke(sender, e);

    private void btn_Update_Click(object sender, EventArgs e) => UpdateEvent.Invoke(sender, e);

    private void btn_Delete_Click(object sender, EventArgs e) => DeleteEvent?.Invoke(sender, e);
}
