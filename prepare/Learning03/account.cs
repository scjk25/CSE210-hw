/// Getter and setter example 

public class Account
{
    private int _number;

    public Account(int number)
    {
        SetNumber(number);
    }

    public int GetNumber()
    {
        return _number;
    }

    public void SetNumber(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Account number must be positive.");
        }
        _number = number;
    }
}   
