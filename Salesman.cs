public abstract class Salesman
{
    private string _firstName;
    private string _lastName;
    public string fullName
    {
        get
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);            
        }
    }
    public Salesman(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public void Sell()
    {
        this.Engage();
        this.EstablishedTrust();
        this.AddressConcerns();
        this.DemoValue();
        this.Close();
    }

    protected abstract void Engage();
    protected abstract void EstablishedTrust();
    protected abstract void AddressConcerns();
    protected abstract void DemoValue();
    protected abstract void Close();
}
    