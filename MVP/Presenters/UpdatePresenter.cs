using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters;
public class UpdatePresenter
{
    private IUpdateView _updateView;
    public UpdatePresenter(IUpdateView updateView)
    {
        _updateView = updateView;

        _updateView.UpdateEvent += _updateView_SaveEvent;
        _updateView.CancelEvent += _updateView_CancelEvent;
    }

    private void _updateView_CancelEvent(object? sender, EventArgs e)
    {
        _updateView.DialogResult = DialogResult.Cancel;
    }
    private void _updateView_SaveEvent(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_updateView.FirstName) || string.IsNullOrWhiteSpace(_updateView.LastName) || _updateView.BirthDate.Year > 2004)
            MessageBox.Show("Fill empty places or you must elder than 18");
        else
            _updateView.DialogResult = DialogResult.OK;


    }
}