using System.Collections.Generic;

public class Department
{
    private string _name;
    private List<Employee> _employees;

    public Department()
    {
        this._employees = new List<Employee>();
    }

    public Department(string name)
        : this()
    {
        this._name = name;

    }

    public string Name { get => _name; set => _name = value; }

    public List<Employee> Employees { get => _employees; set => _employees = value; }


}

