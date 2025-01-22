using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Dtos.LoginRegisterDtos
{
    public class RegisterDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWeb { get; set; }
        public string CompanyFile { get; set; }
        public string CompanyAddress { get; set; }
        public string TaxNumber { get; set; }



    }
}
