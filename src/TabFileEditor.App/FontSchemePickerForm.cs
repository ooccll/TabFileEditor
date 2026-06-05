using System.Drawing.Text;

namespace TabFileEditor.App;

public sealed class FontSchemePickerForm : Form
{
    private readonly ElemSchemeLoader _loader;
    private readonly TextBox _searchBox = new();
    private readonly DataGridView _grid = new();
    private readonly Panel _previewPanel = new();
    private readonly Button _okButton = new();
    private readonly Button _cancelButton = new();
    private readonly List<FontSchemeEntry> _allEntries;
    private List<FontSchemeEntry> _filteredEntries;

    public int SelectedFontSchemeId { get; private set; }

    public FontSchemePickerForm(ElemSchemeLoader loader, int currentFontSchemeId)
    {
        _loader = loader;
        _allEntries = loader.FontSchemes.Values.OrderBy(e => e.Id).ToList();
        _filteredEntries = _allEntries;
        SelectedFontSchemeId = currentFontSchemeId;

        Text = "选择字体方案";
        Size = new Size(700, 600);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;

        BuildUi();
        SelectCurrentEntry(currentFontSchemeId);
    }

    private void BuildUi()
    {
        var searchLabel = new Label
        {
            Text = "搜索:",
            Location = new Point(12, 14),
            AutoSize = true,
        };

        _searchBox.Location = new Point(56, 10);
        _searchBox.Size = new Size(612, 28);
        _searchBox.TextChanged += (_, _) => ApplyFilter();

        _grid.Dock = DockStyle.Fill;
        _grid.AllowUserToAddRows = false;
        _grid.AllowUserToDeleteRows = false;
        _grid.ReadOnly = true;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _grid.MultiSelect = false;
        _grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _grid.BackgroundColor = Color.White;
        _grid.CellDoubleClick += (_, _) => AcceptSelection();

        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "ID",
            DataPropertyName = "Id",
            Width = 50,
            ReadOnly = true,
        });
        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "名称",
            DataPropertyName = "Name",
            Width = 180,
            ReadOnly = true,
        });
        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "颜色",
            DataPropertyName = "Color",
            Width = 80,
            ReadOnly = true,
        });
        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "FontID",
            DataPropertyName = "FontId",
            Width = 60,
            ReadOnly = true,
        });
        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "大小",
            DataPropertyName = "Size",
            Width = 50,
            ReadOnly = true,
        });
        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "描边色",
            DataPropertyName = "BorderColor",
            Width = 80,
            ReadOnly = true,
        });
        _grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "描边",
            DataPropertyName = "BorderSize",
            Width = 50,
            ReadOnly = true,
        });

        _previewPanel.Dock = DockStyle.Bottom;
        _previewPanel.Height = 60;
        _previewPanel.BackColor = Color.FromArgb(0x1A, 0x1A, 0x2E);
        _previewPanel.Paint += PreviewPanelPaint;

        var bottomPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 50,
        };

        _okButton.Text = "确定";
        _okButton.Size = new Size(80, 34);
        _okButton.Location = new Point(ClientSize.Width - 190, 8);
        _okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        _okButton.DialogResult = DialogResult.OK;
        _okButton.Click += (_, _) => AcceptSelection();

        _cancelButton.Text = "取消";
        _cancelButton.Size = new Size(80, 34);
        _cancelButton.Location = new Point(ClientSize.Width - 96, 8);
        _cancelButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        _cancelButton.DialogResult = DialogResult.Cancel;

        bottomPanel.Controls.AddRange([_okButton, _cancelButton]);

        var topPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 40,
        };
        topPanel.Controls.AddRange([searchLabel, _searchBox]);

        var centerPanel = new Panel
        {
            Dock = DockStyle.Fill,
        };
        centerPanel.Controls.Add(_grid);
        centerPanel.Controls.Add(_previewPanel);

        Controls.Add(centerPanel);
        Controls.Add(bottomPanel);
        Controls.Add(topPanel);

        AcceptButton = _okButton;
        CancelButton = _cancelButton;

        _grid.SelectionChanged += (_, _) =>
        {
            _previewPanel.Invalidate();
            if (_grid.CurrentRow?.DataBoundItem is FontSchemeEntry entry)
                SelectedFontSchemeId = entry.Id;
        };

        RefreshGrid();
    }

    private void RefreshGrid()
    {
        var bs = new BindingSource { DataSource = _filteredEntries };
        _grid.DataSource = bs;
    }

    private void ApplyFilter()
    {
        var query = _searchBox.Text.Trim();
        if (string.IsNullOrEmpty(query))
        {
            _filteredEntries = _allEntries;
        }
        else
        {
            _filteredEntries = _allEntries.Where(e =>
                e.Id.ToString().Contains(query) ||
                e.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                e.Color.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        RefreshGrid();
    }

    private void SelectCurrentEntry(int fontSchemeId)
    {
        for (var i = 0; i < _filteredEntries.Count; i++)
        {
            if (_filteredEntries[i].Id == fontSchemeId)
            {
                _grid.ClearSelection();
                _grid.Rows[i].Selected = true;
                _grid.FirstDisplayedScrollingRowIndex = i;
                break;
            }
        }
    }

    private void AcceptSelection()
    {
        if (_grid.CurrentRow?.DataBoundItem is FontSchemeEntry entry)
        {
            SelectedFontSchemeId = entry.Id;
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void PreviewPanelPaint(object? sender, PaintEventArgs e)
    {
        if (_grid.CurrentRow?.DataBoundItem is not FontSchemeEntry entry) return;

        var spec = _loader.ResolveFont(entry.Id);
        var g = e.Graphics;

        Font font;
        if (!string.IsNullOrEmpty(spec.FontFile) && File.Exists(spec.FontFile))
        {
            try
            {
                using var pfc = new PrivateFontCollection();
                pfc.AddFontFile(spec.FontFile);
                font = pfc.Families.Length > 0
                    ? new Font(pfc.Families[0], spec.Size, GraphicsUnit.Pixel)
                    : new Font("Microsoft YaHei UI", spec.Size * 0.75f, GraphicsUnit.Pixel);
            }
            catch
            {
                font = new Font("Microsoft YaHei UI", spec.Size * 0.75f, GraphicsUnit.Pixel);
            }
        }
        else
        {
            font = new Font("Microsoft YaHei UI", spec.Size * 0.75f, GraphicsUnit.Pixel);
        }

        using (font)
        {
            var text = $"方案 {entry.Id} — 示例文字 AaBbCc 123";
            var x = 12f;
            var y = (_previewPanel.Height - font.Height) / 2f;

            if (spec.ShadowSize > 0)
            {
                using var shadowBrush = new SolidBrush(Color.FromArgb(180, spec.ShadowColor));
                g.DrawString(text, font, shadowBrush, x + spec.ShadowSize, y + spec.ShadowSize);
            }

            if (spec.BorderSize > 0)
            {
                using var borderBrush = new SolidBrush(spec.BorderColor);
                g.DrawString(text, font, borderBrush, x, y - 1);
                g.DrawString(text, font, borderBrush, x, y + 1);
                g.DrawString(text, font, borderBrush, x - 1, y);
                g.DrawString(text, font, borderBrush, x + 1, y);
            }

            using var fillBrush = new SolidBrush(spec.FillColor);
            g.DrawString(text, font, fillBrush, x, y);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        _okButton.Location = new Point(ClientSize.Width - 190, 8);
        _cancelButton.Location = new Point(ClientSize.Width - 96, 8);
    }
}
