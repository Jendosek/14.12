namespace _14._12.Entities;

public class CreditCard
{
    private int _cardNumber { get; set; }
    private string _name { get; set; }
    private DateTime _expiryDate { get; set; }
    private int _pin { get; set; }
    private int _creditLimit { get; set; }
    private int _balance { get; set; }
    
    public int CardNumber
    {
        get 
        {
            return _cardNumber;
        }
        set 
        {
            if (value.ToString().Length == 8)
            {
                _cardNumber = value;
            }
            else
            {
                throw new ArgumentException("Card number must contain exactly 8 digits.");
            }
        }
    }
    
    public string Name
    {
        get 
        {
            return _name;
        }
        set 
        {
            if (value.Length > 0)
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException("Name must not be empty.");
            }
        }
    }
    
    public string ExpiryDate
    {
        get
        {
            return _expiryDate.ToString("dd.MM.yyyy");
        }
        set
        {
            if (DateTime.TryParseExact(value, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                _expiryDate = parsedDate;
            }
            else
            {
                throw new ArgumentException("Expiry date must be in the format dd.MM.yyyy.");
            }
        }
    }
    
    public int Pin
    {
        get 
        {
            return _pin;
        }
        set 
        {
            if (value.ToString().Length == 4)
            {
                _pin = value;
            }
            else
            {
                throw new ArgumentException("PIN must contain exactly 4 digits.");
            }
        }
    }
    
    public int CreditLimit
    {
        get 
        {
            return _creditLimit;
        }
        set 
        {
            if (value >= 0)
            {
                _creditLimit = value;
            }
            else
            {
                throw new ArgumentException("Credit limit must be a positive number.");
            }
        }
    }
    
    public int Balance
    {
        get 
        {
            return _balance;
        }
        set 
        {
            if (value >= 0)
            {
                _balance = value;
            }
            else
            {
                throw new ArgumentException("Balance must be a positive number.");
            }
        }
    }

    public CreditCard()
    {
        CardNumber = 0;
        Name = "Unknown";
        ExpiryDate = "01.01.2022";
        Pin = 0;
        CreditLimit = 0;
        Balance = 0;
    }
    
    public CreditCard(int cardNumber, string name, string expiryDate, int pin, int creditLimit, int balance)
    {
        CardNumber = cardNumber;
        Name = name;
        ExpiryDate = expiryDate;
        Pin = pin;
        CreditLimit = creditLimit;
        Balance = balance;
    }
    
    public void AddBalance(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            throw new ArgumentException("Amount must be a positive number.");
        }
    }
    
    public void RemoveBalance(int amount)
    {
        if (amount > 0)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException("Insufficient funds.");
            }
        }
        else
        {
            throw new ArgumentException("Amount must be a positive number.");
        }
    }
    
    public void UseCredit(int amount)
    {
        if (amount > 0)
        {
            if (Balance + amount <= CreditLimit)
            {
                Balance += amount;
                CreditLimit -= amount;
            }
            else
            {
                throw new ArgumentException("Credit limit exceeded.");
            }
        }
        else
        {
            throw new ArgumentException("Amount must be a positive number.");
        }
    }
    
    public bool WillExceedLimit(int amount)
    {
        if (amount > 0)
        {
            return Balance + amount > CreditLimit;
        }
        else
        {
            throw new ArgumentException("Amount must be a positive number.");
        }
    }
    
    public void ChangePin(int newPin)
    {
        if (newPin.ToString().Length == 4)
        {
            _pin = newPin;
        }
        else
        {
            throw new ArgumentException("PIN must contain exactly 4 digits.");
        }
    }
    
    public override string ToString()
    {
        return $"Card number: {CardNumber}\nName: {Name}\nExpiry date: {ExpiryDate}\nPIN: {Pin}\nCredit limit: {CreditLimit}\nBalance: {Balance}";
    }
}