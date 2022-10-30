using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views;

public partial class UpdateView : Form,IUpdateView
{
    public UpdateView()
    {
        InitializeComponent();
    }

    public string FirstName { get => txtbox_UpdateFirstName.Text; set => txtbox_UpdateFirstName.Text = value; }
    public string LastName { get => txtbox_UpdateLastName.Text; set => txtbox_UpdateLastName.Text = value; }
    public DateTime BirthDate { get => moncalUpdate.SelectionStart; set => moncalUpdate.SelectionStart = value; }
    public float Score { get => (float)nUpdown_Score.Value; set => nUpdown_Score.Value = (decimal)value; }

    public event EventHandler UpdateEvent;
    public event EventHandler CancelEvent;

    private void btn_Update_Click(object sender, EventArgs e)
    => UpdateEvent?.Invoke(sender, e);

    private void btn_Cancel_Click(object sender, EventArgs e) 
        => CancelEvent?.Invoke(sender, e);

   
}
