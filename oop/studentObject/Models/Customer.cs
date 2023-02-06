/*
    This class has two properties, Name and Age, 
    with private backing fields _name and _age respectively. 
    The properties allow read and write access to these fields 
    through getter and setter methods.
*/
public class Customer
{
    private string _name = string.Empty;
    private int _age;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
       // private set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}