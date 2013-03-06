using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gwlman
{
    public partial class UCConditionWrapper : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler SearchEvent;

        /// <summary>
        /// 
        /// </summary>
        public UCConditionWrapper()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Xdgk.Common.KeyValueCollection GetConditionKeyValues()
        {
            return this.ucCondition1.GetConditionKeyValues();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.SearchEvent != null)
            {
                this.SearchEvent(this, EventArgs.Empty);
            }
        }

    }
}
