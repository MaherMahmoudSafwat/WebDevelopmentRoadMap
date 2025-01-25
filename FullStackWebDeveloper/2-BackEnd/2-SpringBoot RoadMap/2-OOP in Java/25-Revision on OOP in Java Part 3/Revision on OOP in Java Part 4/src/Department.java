import java.util.ArrayList;

public class Department
{
    int dno;
    String dname;
    //To store different types of objects of different classes in the same ArrayList you must specify the type of ArrayList as Parent Class.
    ArrayList<Employee>emplist;
    //If you want to store different objects or different datatypes of different classes in an ArrayList you can you use Type Object Class.
    //ArrayList<Object>X;


    public Department(int dno, String dname) {
        this.dno = dno;
        this.dname = dname;
        emplist = new ArrayList<>();
    }

    public int getDno() {
        return dno;
    }

    public void setDno(int dno) {
        this.dno = dno;
    }

    public String getDname() {
        return dname;
    }

    public void setDname(String dname) {
        this.dname = dname;
    }

    public void add_employee(Employee e)
    {
        emplist.add(e);
    }

    public void remove_employee(int idx)
    {
        emplist.remove(idx);
    }

    public int getemployeecount()
    {
        return emplist.size();
    }

    public void print_basic_data()
    {
        for(int i = 0; i < emplist.size(); i++)
        {
            System.out.println(emplist.get(i).getSSN() + " " + emplist.get(i).getName() + " " + emplist.get(i).getSex());
        }
    }

    public void print_All_details()
    {
        for(int i = 0; i < emplist.size(); i++)
        {
            // To determine the type of object in the Employee list (whether it is CommissionEmployee, SalariedEmployee, or other subclasses), use the 'instanceof' keyword in Java.
            if(emplist.get(i) instanceof SalariedEmployee)
            {
                // Type casting to convert the object to a specific subclass (SalariedEmployee) from its superclass (Employee).
                ((SalariedEmployee)emplist.get(i)).DisplayAllDetails();
            }
            else if(emplist.get(i) instanceof HourlyEmployee)
            {
                ((HourlyEmployee)emplist.get(i)).DisplayAllDetails();
            }
            else if(emplist.get(i) instanceof CommissionEmployee)
            {
                ((CommissionEmployee)emplist.get(i)).DisplayAllDetails();
            }
        }
    }
}
