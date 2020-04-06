﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class Passenger : Person, Iinformable
    {
        public Flight Flight { get; private set; }
        private double _cash;

        public Passenger(string name, string lastName, int age, double cash) : base(name, lastName, age)
        {

            _cash = cash;
        }

        public void BuyTicket(Flight flight)
        {
            flight.AddPassenger(this);
            Flight = flight;
        }

        public bool Hold(double amount)
        {
            if (amount <= this._cash)
            {
                _charge(amount);
                return true;
            }
            return false;
        }
        private void _charge(double amount)
        {
            this._cash -= amount;
        }

    }
}
