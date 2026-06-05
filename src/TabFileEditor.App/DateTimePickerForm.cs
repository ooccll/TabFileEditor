namespace TabFileEditor.App;

public sealed class DateTimePickerForm : Form
{
    private readonly DateTimePicker _datePicker = new();
    private readonly DateTimePicker _timePicker = new();
    private readonly Button _okButton = new();
    private readonly Button _cancelButton = new();

    public DateTime SelectedDateTime => new(
        _datePicker.Value.Year,
        _datePicker.Value.Month,
        _datePicker.Value.Day,
        _timePicker.Value.Hour,
        _timePicker.Value.Minute,
        _timePicker.Value.Second);

    public DateTimePickerForm(DateTime initialDateTime)
    {
        Text = "选择日期时间";
        Size = new Size(320, 200);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;

        var dateLabel = new Label
        {
            Text = "日期:",
            Location = new Point(20, 25),
            AutoSize = true
        };

        _datePicker.Format = DateTimePickerFormat.Short;
        _datePicker.Location = new Point(80, 22);
        _datePicker.Width = 200;
        _datePicker.Value = initialDateTime;

        var timeLabel = new Label
        {
            Text = "时间:",
            Location = new Point(20, 65),
            AutoSize = true
        };

        _timePicker.Format = DateTimePickerFormat.Time;
        _timePicker.ShowUpDown = true;
        _timePicker.Location = new Point(80, 62);
        _timePicker.Width = 200;
        _timePicker.Value = initialDateTime;

        _okButton.Text = "确定";
        _okButton.DialogResult = DialogResult.OK;
        _okButton.Location = new Point(80, 110);
        _okButton.Width = 80;

        _cancelButton.Text = "取消";
        _cancelButton.DialogResult = DialogResult.Cancel;
        _cancelButton.Location = new Point(180, 110);
        _cancelButton.Width = 80;

        Controls.AddRange(new Control[]
        {
            dateLabel, _datePicker,
            timeLabel, _timePicker,
            _okButton, _cancelButton
        });

        AcceptButton = _okButton;
        CancelButton = _cancelButton;
    }
}
