using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Combi19.Ui.Helpers
{
    public static class IJSExtensions
    {
        public async static Task<bool> Confirm(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            return await js.InvokeAsync<bool>("CustomConfirm", titulo, mensaje, tipoMensajeSweetAlert.ToString());
        }

        public async static Task<object> MostrarMensaje(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipo)
        {
            return await js.InvokeAsync<object>("Swal.fire", titulo, mensaje, tipo);
        }

        public enum TipoMensajeSweetAlert
        {
            question, warning, error, success, info
        }
    }
}
