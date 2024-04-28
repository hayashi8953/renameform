using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renameform.RenameOption
{
    public partial class OptionForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ob"></param>
        public OptionForm(OptionBool ob)
        {
            optionFormBool = ob;
            InitializeComponent();
            BoolDelivery();

        }
        public OptionBool optionFormBool = new OptionBool();

        /// <summary>
        /// 決定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDisition_Click(object sender, EventArgs e)
        {
            SetBool();
            this.Hide();
        }

        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 選択したオプションをOptionBoolクラスにsetする
        /// </summary>
        private void SetBool()
        {
            optionFormBool.AddFront = rbAddFront.Checked ? true : false;
            optionFormBool.AddBack = rbAddBack.Checked ? true : false;
            optionFormBool.Replace = rbReplace.Checked ? true : false;
            optionFormBool.AllSame = rbAllSame.Checked ? true : false;
            optionFormBool.AddInteger = cbInteger.Checked ? true : false;
        }


    }
}
