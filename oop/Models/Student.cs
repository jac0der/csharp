class Student : Member
{   
    /* 
        class variables cannot be defined with the var keyword
        only local variables.
    */
 
    public int Grade { get; set; }
    public string Birthday { get; set; } = string.Empty;


    public string TestProperty
    {
        set{ TestProperty = value; }
    }

    /*
        To be able to track how many students created
        without manually tracking the count on each student 
        object, as each student would have their own count
        when instantiated.

        Use static keyword is not associated with any instance
        or object created from this class. So even if I have 10
        students, I only have one count I need to worry about and
        not 10.

        So the field is shared accross all instances of students.

        Also the static field is accessible from the class level, 
        not from an instantiated object of student.
    */
    static public int Count = 0;

    // constructor executes assoon as the object is created/constructed
    // default consrtuctor
    public Student()
    {
        
    }

    // initializing student object via constructor
    public Student(string name, int grade, string birthday, string address, int phone)
    {
        this.Name = name;
        this.Grade = grade;
        Birthday = birthday;
        Address = address;
        this.Phone = phone;
    }
}