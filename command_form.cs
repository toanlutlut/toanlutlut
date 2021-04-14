using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotateElement_V2
{
    public partial class Window_Form : Form
    {
        public readonly command_class data;
        public Window_Form(command_class data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void TextBox_Angle_TextChanged(object sender, EventArgs e)
        {
            data.Angle = Convert.ToDouble(TextBox_Angle.Text);
        }

        private void but_left_Click(object sender, EventArgs e)
        {
            if(but_left.Enabled = true)
            {
                data.Angle = data.Angle;
            }
            
        }

        private void but_right_Click(object sender, EventArgs e)
        {
            if (but_right.Enabled = true)
            {
                data.Angle = -data.Angle;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

 
    }
}
