﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepriseMyProducks.Dtos
{
    public class Export
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool Active { get; set; }
    }
}