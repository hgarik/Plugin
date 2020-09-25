using Microsoft.AspNetCore.Mvc;
using Plugin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.Abstraction
{
    public interface ICommonService
    {
        Task<byte[]> Modify(byte[] picture, ModificationModel model);
    }
}
