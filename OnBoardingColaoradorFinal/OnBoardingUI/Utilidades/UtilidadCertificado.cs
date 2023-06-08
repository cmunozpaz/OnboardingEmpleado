using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace GestionSiaUI
{
   
    public class CertValidation : ICertificatePolicy
    {
        public Boolean CheckValidationResult(ServicePoint srvPoint, X509Certificate cert, WebRequest request, Int32 problem)
        {
            // Return true to indicate the cert is ALWAYS valid. Hacky-tastic!
            return true;
        }
    }
    
}
