﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StarTEDSystem.DAL;
using StarTEDSystem.Entities;
using System.ComponentModel;

namespace StarTEDSystem.BLL
{
    [DataObject(true)]
    public class PropertyOwnersController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<PropertyOwners> LandLords_List()
        {
            using (var context = new StarTEDContext())
            {
                return context.PropertyOwners.ToList();
            }
        }
    }
}
