namespace MVP.Views;

public interface IUpdateView
{
    string FirstName { get; set; }
    string LastName { get; set; }
    DateTime BirthDate { get; set; }
    float Score { get; set; }
    DialogResult DialogResult { get; set; }

    event EventHandler UpdateEvent;
    event EventHandler CancelEvent;
    DialogResult ShowDialog();
}
