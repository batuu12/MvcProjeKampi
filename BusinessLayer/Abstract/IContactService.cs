﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IContactService
    {
        List<Contact> GetList();
        void ContactAddBL(Contact contact);
        Contact GetById(int id);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);
    }
}
