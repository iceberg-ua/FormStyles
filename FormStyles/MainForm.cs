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
        }

        Dictionary<WinApi.WindowStyles, CheckBox> _styleSettings = new Dictionary<WinApi.WindowStyles, CheckBox>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Point location = new Point(10, 15);

            foreach (WinApi.WindowStyles item in Enum.GetValues(typeof(WinApi.WindowStyles)))
            {
                var checkBox = new CheckBox();
                checkBox.Padding = new Padding(2);
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.AutoSize = true;
                checkBox.Text = item.ToString();
                checkBox.Location = location;

                _windowStyleGB.Controls.Add(checkBox);
                _styleSettings.Add(item, checkBox);

                location.Y += 20;
            }
        }

        private int CollectFormStyle()
        {
            int style = 0;

            foreach (var item in _styleSettings)
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
            if(_testForm == null)
            {
                StyledForm.Style = CollectFormStyle();

                _testForm = new StyledForm
                {
                    Location = new Point(100, 100),
                    Size = new Size(400, 250)
                };

                _testForm.Show();
                _testForm.FormClosed += (s, args) => { button1.Text = "Create Form"; _testForm = null; };

                button1.Text = "UpdateForm";
            }
        }
    }
}
