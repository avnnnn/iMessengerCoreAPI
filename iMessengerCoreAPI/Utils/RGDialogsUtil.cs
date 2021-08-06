
using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace iMessengerCoreAPI.Utils
{
    public class RGDialogsUtil
    {
        public static Guid FindDialog(List<RGDialogsClients> dialogCLinets)
        {
            Guid dialogId;
            if (!dialogCLinets.Contains(null))
            {
                dialogId = dialogCLinets[0].IDRGDialog;
            }
            else
            {
                return Guid.NewGuid();
            }
            foreach (var dialog in dialogCLinets)
            {
                if (!Guid.Equals(dialog.IDRGDialog, dialogId))
                {
                    return Guid.NewGuid();
                }
            }
            return dialogId;
        }
    }
}
