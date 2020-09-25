using Microsoft.AspNetCore.Mvc;
using Plugin.Abstraction;
using Plugin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.Service
{
    public class CommonService : ICommonService
    {
        public Task<byte[]> Modify(byte[] picture, ModificationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
