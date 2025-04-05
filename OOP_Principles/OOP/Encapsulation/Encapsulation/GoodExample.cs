
namespace Encapsulation
{
    public class GoodExample
    {
        private decimal _balance;

        public GoodExample(decimal balance) 
        {
            _balance = balance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            var results = amount <= 0 ? throw new ArgumentException("Deposit amount must be positive") : _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive and greater than zero");
            }
            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            _balance -= amount;
        }
    }
}
