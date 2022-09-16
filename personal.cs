public class Personal1{
    public string Value;
    public string NameKFC;
    public string Name;
    public string Surname;
    public string Number;

    public Personal1(string Value,string NameKFC,string Name,string Surname,string Number){
        this.Value=Value;
        this.NameKFC=NameKFC;
        this.Name=Name;
        this.Surname=Surname;
        this.Number=Number;
    }
    public string PrintPersonalInfo(){
        return " Name is "+this.Name+" "+this.Surname
        +" Number is "+this.Number;
    }
    public string PrintShopInfo(){
        return "Value is "+ this.Value 
        + " Name KFC is "+ this.NameKFC 
        + " Address is "+ this.NameKFC ;
    }
}