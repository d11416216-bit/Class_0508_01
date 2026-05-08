using System;

public class Person 
{

    public virtual string GetName()
    {
        return "Person";
    }
}

public class Student : Person
{

    public override string GetName()
    {
        return "Student";
    }
}

public class People
{

    public string GetName()
    {
        return "People";
    }
}

public class Teacher : People
{

    public string GetName()
    {
        return "Teacher";
    }
}