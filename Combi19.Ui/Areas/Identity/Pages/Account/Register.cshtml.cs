using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Combi19.Ui.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components;

namespace Combi19.Ui.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AspNetUsers> _signInManager;
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<AspNetUsers> userManager,
            SignInManager<AspNetUsers> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Se debe ingresar un nombre.")]
            [DataType(DataType.Text)]
            [Display(Name = "Nombre")]      
            public string Nombre { get; set; }
            [Required(ErrorMessage = "Se debe ingresar un apellido.")]
            [DataType(DataType.Text)]
            [Display(Name = "Apellido")]
            public string Apellido { get; set; }

            [Required(ErrorMessage = "Se debe ingresar un dni.")]
            [DataType(DataType.Text)]
            [Display(Name = "Dni")]
            public string Dni { get; set; }

            [Required(ErrorMessage = "Se debe ingresar un email.")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Se debe ingresar una contraseña.")]
            [MinLength(6, ErrorMessage = "La contraseña debe ser de al menos 6 caracteres.")]
           
            [DataType(DataType.Password)]
            [RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9]).+$", ErrorMessage = "La contraseña debe contener al menos 6 caracteres entre ellos un digito y una letra mayúscula")]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Se debe ingresar una confirmacion.")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirmar clave")]
            [Compare("Password", ErrorMessage = "La clave y la confirmacion no coinciden.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "Se debe ingresar una fecha de nacimiento.")]
            [DataType(DataType.Date)]
            [Display(Name = "FechaNacimiento")]
            public DateTime FechaNacimiento { get; set; }
         
            [Display(Name = "PlanPremium")]
            public bool PlanPremium { get; set; }

            [Required(ErrorMessage = "Se debe ingresar un numero de tarjeta.")]
            [StringLength(16, ErrorMessage = "El numero de la tarjeta debe ser de 16 digitos.", MinimumLength = 16)]
            [Display(Name = "NumeroTarjeta")]         
            public string NumeroTarjeta { get; set; }

            [Required(ErrorMessage = "Se debe ingresar un vencimiento.")]
            [Display(Name = "Vencimiento")]
            public DateTime Vencimiento { get; set; }

            [Required(ErrorMessage = "Se debe ingresar un codigo de seguridad.")]
            [StringLength(3, ErrorMessage = "El codigo de seguridad debe ser de 3 digitos.", MinimumLength = 3)]
            [Display(Name = "CodigoSeguridad")]
            public string CodigoSeguridad { get; set; }

            [Required(ErrorMessage = "Se debe ingresar un nombre de tarjeta.")]
            [Display(Name = "NombreTarjeta")]
            public string NombreTarjeta { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new AspNetUsers
                    {
                        UserName = Input.Email, Email = Input.Email,
                        Nombre = Input.Nombre, Apellido = Input.Apellido,
                        Dni = Input.Dni, FechaNacimiento = Input.FechaNacimiento,
                        PlanPremium = Input.PlanPremium, NumeroTarjeta = Input.NumeroTarjeta,
                        Vencimiento = Input.Vencimiento, CodigoSeguridad = Input.CodigoSeguridad,
                        NombreTarjeta = Input.NombreTarjeta
                    };

                var result = await _userManager.CreateAsync(user, Input.Password);
                result = await _userManager.AddToRoleAsync(user, "Normal");
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
