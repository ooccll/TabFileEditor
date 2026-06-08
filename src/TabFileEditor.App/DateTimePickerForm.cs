namespace TabFileEditor.App;

public sealed class DateTimePickerForm : Form
{
    private readonly DateTimePicker _datePicker = new();
    private readonly DateTimePicker _timePicker = new();
    private readonly Button _okButton = new();
    private readonly Button _cancelButton = new();

    private float DpiScale => DeviceDpi / 96f;
    private int Scaled(int pixels) => (int)Math.Round(pixels * DpiScale);

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
        Size = new Size(Scaled(320), Scaled(180));
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;

        var dateLabel = new Label
        {
            Text = "日期:",
            Location = new Point(Scaled(20), Scaled(25)),
            AutoSize = true
        };

        _datePicker.Format = DateTimePickerFormat.Short;
        _datePicker.Location = new Point(Scaled(80), Scaled(22));
        _datePicker.Width = Scaled(200);
        _datePicker.Value = initialDateTime;

        var timeLabel = new Label
        {
            Text = "时间:",
            Location = new Point(Scaled(20), Scaled(65)),
            AutoSize = true
        };

        _timePicker.Format = DateTimePickerFormat.Time;
        _timePicker.ShowUpDown = true;
        _timePicker.Location = new Point(Scaled(80), Scaled(62));
        _timePicker.Width = Scaled(200);
        _timePicker.Value = initialDateTime;

        _okButton.Text = "确定";
        _okButton.DialogResult = DialogResult.OK;
        _okButton.Location = new Point(Scaled(80), Scaled(100));
        _okButton.Size = new Size(Scaled(80), Scaled(23));

        _cancelButton.Text = "取消";
        _cancelButton.DialogResult = DialogResult.Cancel;
        _cancelButton.Location = new Point(Scaled(180), Scaled(100));
        _cancelButton.Size = new Size(Scaled(80), Scaled(23));

        Controls.AddRange(new Control[]
        {
            dateLabel, _datePicker,
            timeLabel, _timePicker,
            _okButton, _cancelButton
        });

        AcceptButton = _okButton;
        CancelButton = _cancelButton;

        DpiChanged += (_, _) => ApplyDpiScaling();
    }

    private void ApplyDpiScaling()
    {
        Size = new Size(Scaled(320), Scaled(180));
        _datePicker.Location = new Point(Scaled(80), Scaled(22));
        _datePicker.Width = Scaled(200);
        _timePicker.Location = new Point(Scaled(80), Scaled(62));
        _timePicker.Width = Scaled(200);
        _okButton.Location = new Point(Scaled(80), Scaled(100));
        _okButton.Size = new Size(Scaled(80), Scaled(23));
        _cancelButton.Location = new Point(Scaled(180), Scaled(100));
        _cancelButton.Size = new Size(Scaled(80), Scaled(23));
    }
}
