﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAccessFunction.Services.Interfaces
{
    public interface ICloudTableClientProvider
    {
        CloudTableClient GetCloudTableClient();
    }
}
