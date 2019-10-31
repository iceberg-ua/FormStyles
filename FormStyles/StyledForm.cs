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
    public partial class StyledForm : Form
    {
        public static int Style { get; set; }
        public static int ExStyle { get; set; }
        public static int ClassStyle { get; set; }

        public StyledForm()
        {
            InitializeComponent();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var createParams = new CreateParams
        //        {
        //            X = Location.X,
        //            Y = Location.Y,
        //            Height = Size.Height,
        //            Width = Size.Width,
        //            Style = (int)Style,
        //            ExStyle = (int)ExStyle,
        //            ClassStyle = (int)ClassStyle
        //        };

        //        return createParams;
        //    }        
        //}
    }
}
