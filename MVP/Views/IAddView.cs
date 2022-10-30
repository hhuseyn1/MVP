namespace MVP.Views;
public interface IAddView{

    string FirstName{ get;}
    string LastName{get;}
    DateTime BirthOfDate { get;}
    float Score { get;}

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;
}
