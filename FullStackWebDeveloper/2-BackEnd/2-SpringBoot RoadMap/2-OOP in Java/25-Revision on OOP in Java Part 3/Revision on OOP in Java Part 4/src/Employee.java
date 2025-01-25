enum Gender {Male,Female};
public abstract class Employee
{
    String Name;
    String Address;
    int SSN;
    Gender Sex;

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getAddress() {
        return Address;
    }

    public void setAddress(String address) {
        Address = address;
    }

    public int getSSN() {
        return SSN;
    }

    public void setSSN(int SSN) {
        this.SSN = SSN;
    }

    public Gender getSex() {
        return Sex;
    }

    public void setSex(Gender sex) {
        Sex = sex;
    }

    public Employee() {
    }

    public Employee(String name, String Address, int SSN, Gender Sex)
    {
        Name = name;
        this.Address = Address;
        this.SSN = SSN;
        this.Sex = Sex;
    }
    public abstract double earnings();

    @Override
    public String toString() {
        return "Employee{" +
                "Name='" + Name + '\'' +
                ", Address='" + Address + '\'' +
                ", SSN='" + SSN + '\'' +
                ", Sex=" + Sex +
                '}';
    }
}
