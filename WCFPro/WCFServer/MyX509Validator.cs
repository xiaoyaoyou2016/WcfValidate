using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    public class MyX509Validator : System.IdentityModel.Selectors.X509CertificateValidator
    {
        public override void Validate(X509Certificate2 certificate)
        {
            if (!certificate.Thumbprint.Equals("B9DF5B912B8CF8EAB07A7BB9B0D17694522AB0CE", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new System.IdentityModel.Tokens.SecurityTokenException("Unknown Certificate");
            }
        }
       
    }
}
