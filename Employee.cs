public Class Employee
{
    string name;
    int age;
    float salary;
    public : string getName(); void setName(string name);
    int getAge();
    void setAge(int age);
    float getSalary();
    void setSalary(float salary);
};

//The Employee class behaves like a data structure because it only stores and retrieves data via getters and setters. To make it a true object, it should encapsulate both data and behavior.