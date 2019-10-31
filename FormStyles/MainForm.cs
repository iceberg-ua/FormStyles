using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormStyles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _windowStyleGB.Size = Size.Empty;
            _windowStyleGB.AutoSize = true;

            _windowStyleExGB.Size = Size.Empty;
            _windowStyleExGB.AutoSize = true;

            _classStyleGB.Size = Size.Empty;
            _classStyleGB.AutoSize = true;
        }

        Dictionary<uint, CheckBox> _styleSettings = new Dictionary<uint, CheckBox>();
        Dictionary<uint, CheckBox> _styleExSettings = new Dictionary<uint, CheckBox>();
        Dictionary<uint, CheckBox> _classStyleSettings = new Dictionary<uint, CheckBox>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            int low = 0;

            Point location = new Point(10, 15);

            _windowStyleGB.Location = new Point(10, 5);
            FillStyleGroups(typeof(WinApi.WindowStyles), location, _windowStyleGB, _styleSettings);
            low = Math.Max(low, _windowStyleGB.Bottom);

            _windowStyleExGB.Location = new Point(_windowStyleGB.Right + 5, 5);
            FillStyleGroups(typeof(WinApi.WindowExStyles), location, _windowStyleExGB, _styleExSettings);
            low = Math.Max(low, _windowStyleExGB.Bottom);

            _classStyleGB.Location = new Point(_windowStyleExGB.Right + 5, 5);
            FillStyleGroups(typeof(WinApi.ClassStyle), location, _classStyleGB, _classStyleSettings);
            low = Math.Max(low, _classStyleGB.Bottom);

            button1.Top = low + 5;
            button2.Top = low + 5;
        }

        private void FillStyleGroups(Type enumType, Point startLocation, GroupBox container, Dictionary<uint, CheckBox> dictionary)
        {
            foreach (uint item in enumType.GetEnumValues().Cast<uint>())
            {
                if (dictionary.ContainsKey(item))
                    continue;

                var checkBox = new CheckBox
                {
                    Padding = new Padding(2),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true,
                    Text = Enum.GetName(enumType, item),
                    Location = startLocation
                };

                container.Controls.Add(checkBox);
                dictionary.Add(item, checkBox);

                startLocation.Y += 20;
            }
        }

        private int CollectFormStyle(Dictionary<uint, CheckBox> dict)
        {
            int style = 0;

            foreach (var item in dict)
            {
                if(item.Value.Checked)
                {
                    style |= (int)item.Key;
                }
            }

            return style;
        }

        StyledForm _testForm = null;

        private void CreateButtonClick(object sender, EventArgs e)
        {
            StyledForm.Style = CollectFormStyle(_styleSettings);
            StyledForm.ExStyle = CollectFormStyle(_styleExSettings);
            StyledForm.ClassStyle = CollectFormStyle(_classStyleSettings);

            if (_testForm == null)
            {
                _testForm = new StyledForm
                {
                    Location = new Point(900, 100),
                    Size = new Size(400, 250)
                };

                _testForm.FormClosed += (s, args) => { button1.Text = "Create Form"; _testForm = null; };
                button1.Text = "UpdateForm";
            }

            WinApi.SetWindowLong(_testForm.Handle, (int)WinApi.GWLParameter.GWL_STYLE, StyledForm.Style);
            WinApi.SetWindowLong(_testForm.Handle, (int)WinApi.GWLParameter.GWL_EXSTYLE, StyledForm.ExStyle);
            WinApi.SetWindowLong(_testForm.Handle, (int)WinApi.GCLParameter.GCL_STYLE, StyledForm.ClassStyle);

            _testForm.Show();
        }


        private void CloseButtonClick(object sender, EventArgs e)
        {
            _testForm?.Close();
        }
    }
}
