using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Domain
{
    public class Account
    {
        private   AccountId id;
        private Money money;

        public Account(AccountId id, Money baselineBalance, ActivityWindow activityWindow)
        {
            this.id = id;
            BaselineBalance = baselineBalance;
            ActivityWindow = activityWindow;
        }

        public Money   BaselineBalance { get; set; }

        public ActivityWindow ActivityWindow { get; set; }


        public static Account WithoutId(Money baselineBalance, ActivityWindow activityWindow)
        {
            return new Account(null, baselineBalance, activityWindow);
        }

        public static Account withId(AccountId accountId, Money baselineBalance, ActivityWindow activityWindow)
        {
            return new Account(accountId, baselineBalance, activityWindow);
        }


        public Money calculateBalance()
        {
            return Money.Add(this.BaselineBalance, this.ActivityWindow.CalculateBalance(this.id));
        }

        public AccountId  getId()
        {
            return this.id;
        }

        public bool Withdraw(Money money, AccountId targetAccountId)
        {
            /**
             * Business Validation
             * í˜„ìž¬ ìž”ê³ ë³´ë‹¤ ë§Žì�€ ë�ˆì�„ ì�¸ì¶œí•  ê²½ìš°
             */
            if (!MayWithdraw(money))
            {
                return false;
            }

            Activity withdrawal = new Activity(
                    this.id,
                    this.id,
                    targetAccountId,
                    DateTime.Now,
                    money);

            this.ActivityWindow.AddActivity(withdrawal);
            return true;
        }

        private bool MayWithdraw(Money money)
        {
            return Money.Add(
          this.calculateBalance(),
          money.Negate())
          .IsPositiveOrZero();
        }
    }

    public   class AccountId
    {
        public long Value { get; set; }
    }

}
