using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Domain
{
    public class Activity
    {
        private AccountId id1;
        private AccountId id2;
        private AccountId targetAccountId;
        private DateTime now;
        private Money money;

        public Activity(AccountId id1, AccountId id2, AccountId targetAccountId, DateTime now, Money money)
        {
            this.id1 = id1;
            this.id2 = id2;
            this.targetAccountId = targetAccountId;
            this.now = now;
            this.money = money;
        }

        public   ActivityId Id { get ; set; }

    }

    public   class ActivityId
    {
        public   long CurrentValue { get; set; };
    }
}



}
