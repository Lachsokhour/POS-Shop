using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Interface
{
    interface IBehaviorForm
    {
        void ClearValue();
        void SetValueToFieldWhenEditMode();
        void LoadValue();
        void SetLabelTitle();
        void ShowAlert(string msg, FormAlertNotification.Type type);
    }
}
