using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xdgk.Common;

namespace gwlman
{
    public interface IAddEdit
    {

        ADEStatus AdeStatus { get; }
        bool Add();
        bool Edit();
        void Fill();

//        void OnOK()
//        {
//            if (this.AdeStatus == ADEStatus.Add)
//            {
//Add();
//            }
//            else ( this.AdeStatus == ADEStatus.Edit )
//            {
//                Edit ();
//            }

//        }
    }
}
