public class Personal2{
    public string Role;
    public string Name2;
    public string Surname2;
    public string Age;
    public string Money;

    public Personal2(string Role,string Name2,string Surname2,string Age,string Money){
        this.Role=Role;
        this.Name2=Name2;
        this.Surname2=Surname2;
        this.Age=Age;
        this.Money=Money;
    }
    public string PrintPersonalInfo(){
        return "Role is "+ this.Role 
        + " Name is "+ this.Name2 
        + " "+ this.Surname2 
        + " Age is "+this.Age
        +" Money is "+this.Money;
    }
}