﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickBootstrap.Entities;
using QuickBootstrap.Services.Models;
using QuickBootstrap.Services.Util;

namespace QuickBootstrap.Services
{
    public interface IDepartmentService
    {
        PagedResult<DepartmentManagePageItem> GetList(Paging paging);

        List<Department> GetAllList();
    }
}
