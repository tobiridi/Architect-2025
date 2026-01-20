using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Bank
    {
        private string _Name;

        private BankingAccount[] _Accounts;

        public BankingAccount? this[int index]
        {
            get { return _Accounts[index]; }
        }

        public void Add(BankingAccount account)
        {
            this._Accounts = [.. this._Accounts, account];
        }

        public void Remove(string numAccount)
        {
            //this._Accounts[numAccount];

        }
    }
}
