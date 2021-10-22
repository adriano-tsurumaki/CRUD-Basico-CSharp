using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CRUD___Adriano.Features.Utils
{
    public static class BindingListExtension
    {
        public static void ConfiguracaoPadrao<T>(this BindingList<T> bindingList)
        {
            bindingList.AllowNew = true;
            bindingList.AllowRemove = true;
            bindingList.RaiseListChangedEvents = true;
        }
    }
}
