﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Wallet.Models
{
    public class BalanceStatsModel
    {
        public BalanceStatsModel()
        {
            Balances = new ObservableCollection<BalanceItemModel>();
            this.Balances.Add(new BalanceItemModel() { Currency = "Eur", Value = 3.45m });
            this.Balances.Add(new BalanceItemModel() { Currency = "Iota", Value = 10000000 });
        }

        public ObservableCollection<BalanceItemModel> Balances { get; set; }
    }
}