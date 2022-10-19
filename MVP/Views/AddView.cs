namespace MVP.Views
{
    public partial class AddView : Form, IAddView
    {
        public AddView()
        {
            InitializeComponent();
        }

        public string FirstName { get => txtbox_SaveFirstName.Text; }
        public string LastName { get => txtbox_SaveLastName.Text; }
        public DateOnly BirthOfDate { get => DateOnly.Parse(moncal.SelectionStart.ToShortDateString()); }
        public float Score { get => (float)nUpdown_Score.Value; }

        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        private void btn_Save_Click(object sender, EventArgs e)=>DialogResult = DialogResult.OK;

        private void btn_Cancel_Click(object sender, EventArgs e)=>DialogResult = DialogResult.Cancel;


        //private void btn_Save_Click(object sender, EventArgs e)
        //{
        //    SaveEvent?.Invoke(sender,e);
        //}

        //private void btn_Cancel_Click(object sender, EventArgs e)
        //{
        //    CancelEvent?.Invoke(sender, e);
        //}


    }
}
