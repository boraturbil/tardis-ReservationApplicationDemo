﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Bussiness.Abstract;
using YazılımMimarisiProje.DataAccess.Abstract;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.Bussiness.Concrete
{
    
    public class ReservationManager:IReservationService
    {
        /*There is just bussiness code.In this way, the Data layer and the user are separated from each other.*/
        private IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public List<ReservationInformation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public void Delete(string ReservationEmail)
        {
            _reservationDal.Delete(ReservationEmail);
        }

        public void Add(ReservationInformation reservationInformation,Booker booker)
        {
            _reservationDal.Add(reservationInformation,booker);
        }

        public List<ReservationInformation> GetUserInformation(string BookerEmail)
        {
           return _reservationDal.GetUserInformation(BookerEmail);
        }

        public List<Booker> GetReservationInformation(string BookerEmail)
        {
            return _reservationDal.GetReservationInformation(BookerEmail);
        }
    }


}
