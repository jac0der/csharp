class Member
{
     // Auto-implemented properties must have get accessors.

    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    // accessible within this class and within all 
    // calsses that inherits this class.
    // not accessible from calling codes of the inherited classes.
    protected int Phone { get; set; }
}