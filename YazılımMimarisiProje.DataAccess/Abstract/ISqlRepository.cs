﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.DataAccess.Abstract
{
    public interface ISqlRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        void Delete(string ReservationEmail);
        

    }
}
