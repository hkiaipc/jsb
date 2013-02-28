using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Common.Validate
{
    internal class ErrorManager
    {
        Color m_errorColor = Color.Red;
        Hashtable m_oldColors;

        public ErrorManager()
        {
            m_oldColors = new Hashtable();
        }

        public Color ErrorColor
        {
            get { return m_errorColor; }
            set { m_errorColor = value; }
        }

        public void SetError(Control control)
        {
            ClearError();
            m_oldColors.Add(control, control.BackColor);
            control.BackColor = m_errorColor;
        }

        public void SetErrors(Control[] controls)
        {
            ClearError();
            foreach (Control control in controls)
            {
                m_oldColors.Add(control, control.BackColor);
                control.BackColor = m_errorColor;
            }
        }

        public void ClearError()
        {
            foreach (Control control in m_oldColors.Keys)
            {
                control.BackColor = (Color)m_oldColors[control];
            }
            m_oldColors.Clear();
        }
    }
}
