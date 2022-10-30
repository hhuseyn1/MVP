using MVP.Models;
using MVP.Views;
using System.Web;
using System.Windows.Forms;

namespace MVP.Presenters;

public class MainPresenter{

    private IMainView _view;
    private IAddView _addView;
    private IUpdateView _updateView;
	private BindingSource _bindingSource;
	private List<Student>_students;

    public MainPresenter(IMainView view,IAddView addView,IUpdateView updateView)
	{
		_view = view;
		_addView = addView;
		_updateView = updateView;
		_students = new List<Student>()
		{
			new Student("Vasif","Babazade",new DateTime(2004,2,10),9.6f),
			new Student("Huseyn","Hemidov",new DateTime(2004,6,30),6.6f)
		};
		_bindingSource = new BindingSource();
        _bindingSource.DataSource = _students;
		_view.SetStudentListBindingSource(_bindingSource);
		_view.SearchEvent += _view_SearchEvent;
		_view.DeleteEvent += _view_DeleteEvent;
		_view.AddEvent += _view_AddEvent;
		_view.UpdateEvent += _view_UpdateEvent;
	}

	private void _view_UpdateEvent(object? sender, EventArgs e)
	{
        var student = _bindingSource.Current as Student;
        _updateView.FirstName = student.FirstName;
        _updateView.LastName = student.LastName;
        _updateView.Score = (float)student.Score;
        _updateView.BirthDate = student.BirthOfDate;

        var result = _updateView.ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        student.FirstName = _updateView.FirstName;
        student.LastName = _updateView.LastName;
        student.BirthOfDate = _updateView.BirthDate;
        student.Score = (float)_updateView.Score;
        _view.SetStudentListBindingSource(_bindingSource);

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
