﻿using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.DomainObjects
{
    public class Card
    {
        public string Account { get; internal set; }
        public string CardNumber { get; internal set; }
        public string CardType { get; internal set; }
        public string CardName { get; internal set; }
        public Currency Currency { get; internal set; }
        public Status Status { get; internal set; }
        public string MainCardNumber { get; internal set; }
    }
}