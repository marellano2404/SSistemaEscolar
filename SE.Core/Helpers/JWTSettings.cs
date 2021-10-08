using System;
using System.Collections.Generic;
using System.Text;

namespace SE.Core.Helpers
{
    /// <summary>
    /// Clase para establecer la estructura para configurar el JWT.
    /// </summary>
    public class JWTSettings
    {
        /// <summary>
        /// Código de autenticación del token.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Identificador de quién emitió el token
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Tiempo de expiración del token.
        /// </summary>
        public int Expire { get; set; }

        /// <summary>
        /// Firma de encriptación.
        /// </summary>
        public bool UseRsa { get; set; }
    }
}
