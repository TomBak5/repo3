using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace BUS_MVC
{
    public class funkcijos
    {

        public string fjos_to_hash(string pass823)
        {


            System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();

            var pass_in_bytes = sha256.ComputeHash(Encoding.UTF7.GetBytes(pass823));

            //var pass_hash = Encoding.UTF7.GetString(pass_in_bytes);

            var pass_hash = System.Convert.ToBase64String(pass_in_bytes);

            return pass_hash;


        }



    }
}