using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renameform
{
    public partial class FormConfirm : Form
    {
        public FormConfirm(ICollection<string[]> pairs)
        {
            InitializeComponent();
            AddBtText(pairs);
        }
        public bool confirmThis = false;

        private void btCancel_Click(object sender, EventArgs e)
        {
            confirmThis = false;
            this.Hide();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            confirmThis = true;
            this.Hide();
        }
        private void AddBtText(ICollection<string[]> pairs)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (string[] pair in pairs)
                {
                    sb.Append(pair[0])
                        .Append(" => ")
                        .Append(pair[1])
                        .Append(Environment.NewLine);
                }
                tb.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("Form1AddBtText error");
            }
        }
    }
}
