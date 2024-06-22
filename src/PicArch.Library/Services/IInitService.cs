using PicArch.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicArch.Library.Services
{
    public interface IInitService
    {
        InitConfig? GetInitConfig();
    }
}
