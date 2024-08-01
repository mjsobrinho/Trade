﻿using TradeCategoryUbsAPI.Interfaces;

namespace TradeCategoryUbsAPI.Models
{
    // Implementa a classe Trade
    public class Trade : ITrade
    {
        public double Value { get; private set; }
        public string ClientSector { get; private set; }

        public Trade(double value, string clientSector)
        {
            Value = value;
            ClientSector = clientSector;
        }
    }
}
