﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public class MsgHelper
    {
        public static DialogResult ShowErrorMsgBox(string error)
        {
            return MessageBox.Show(error, "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult ShowInformationMsgBox(string information)
        {
            return MessageBox.Show(information, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowQuestionMsgBox(string information)
        {
            return MessageBox.Show(information, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
