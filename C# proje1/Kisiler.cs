namespace C__proje1{
public  class Kisiler{
     string name;
     string surName;
     string phoneNumber;

    public Kisiler(string name, string surName, string phoneNumber){
        this.name=name;
        this.surName=surName;
        this.phoneNumber = phoneNumber;
    
    }
    
    public string getName(){
        return this.name;
    }
    public string getSurname(){
        return this.surName;
    }
    public string getPhoneNumber(){
        return this.phoneNumber;
    }
    
    }
}