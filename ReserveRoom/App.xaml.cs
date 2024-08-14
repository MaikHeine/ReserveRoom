﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ReserveRoom.Models;
using ReserveRoom.Exceptions;

namespace ReserveRoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            Hotel hotel = new Hotel("Maiks Hotel");


            try
            {
                hotel.MakeReservation(new Reservation(
                   new RoomID(1, 3),
                   "Dieter Herrmann",
                   new DateTime(2000, 1, 1),
                   new DateTime(2000, 1, 2)));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "Dieter Herrmann",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2)));
            }
            catch (ReservationConflictException ex)
            {

                throw ex;
            }
               



            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Dieter Herrmann");

            base.OnStartup(e);
        }
    }
}
