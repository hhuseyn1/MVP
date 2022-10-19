using MVP.Models;
using MVP.Views;
using System.Web;
using System.Windows.Forms;

namespace MVP.Presenters;

public class MainPresenter{

    private IMainView _view;
    private IAddView _addView;
	private BindingSource _bindingSource;
	private List<Student>_students;

    public MainPresenter(IMainView view,IAddView addView)
	{
		_view = view;
		_addView = addView;
		_students = new List<Student>()
		{
			new Student("Vasif","Babazade",new DateOnly(2004,2,10),9.6f),
			new Student("Huseyn","Hemidov",new DateOnly(2004,6,30),6.6f)
		};
		_bindingSource = new BindingSource();
        _bindingSource.DataSource = _students;
		_view.SetStudentListBindingSource(_bindingSource);
		_view.SearchEvent += _view_SearchEvent;
		_view.DeleteEvent += _view_DeleteEvent;
		_view.AddEvent += _view_AddEvent;
	}

	private void _view_AddEvent(object? sender, EventArgs e)
	{
		var result = ((Form)_addView).ShowDialog();
		if (result == DialogResult.Cancel)
			return;
		else
		{
			var newStudent = new Student(_addView.FirstName, _addView.LastName, _addView.BirthOfDate, _addView.Score);
			_students.Add(newStudent);
			_view.SetStudentListBindingSource(_bindingSource);
		}
    }

    private void _view_DeleteEvent(object? sender, EventArgs e)
	{
		var current = _bindingSource.Current;
		if (current is not null)
		{
			_students.Remove((Student)current);
			_view.SetStudentListBindingSource(_bindingSource);
		}
	}

	private void _view_SearchEvent(object? sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(_view.SearchValue))
		{
			_bindingSource.DataSource = _students
				.Where(s => s.FirstName.ToUpper().Contains(_view.SearchValue.ToUpper()) ||
			s.LastName.ToUpper().Contains(_view.SearchValue.ToUpper())).ToList();

		}
		else
			_bindingSource.DataSource = _students;
		_view.SetStudentListBindingSource(_bindingSource);


    }
}
