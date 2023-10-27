using Blazored.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Client.Shared
{
    public class SharedModalOptions
    {
        public static ModalOptions modalOptionsWait = new ModalOptions()
        {
            DisableBackgroundCancel = true,
            HideCloseButton = true,
            HideHeader = true
        };

        public static ModalOptions modalOptionsInfo = new ModalOptions()
        {
            //cambie la version para utilizar contentScrollable de 7.0.1 a 6.0.1
            DisableBackgroundCancel = true,
            ContentScrollable = true,
            Animation = ModalAnimation.FadeInOut(0.5)
        };


        public static ModalParameters SetParameterModalInfo(string msj, string cssClass)
        {
            ModalParameters parameters = new ModalParameters();
            parameters.Add(nameof(ModalInfo.Msj), msj);
            parameters.Add(nameof(ModalInfo.CssClass), cssClass);

            return parameters;
        }
    }
}
