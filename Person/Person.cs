public class Person {
    private string namePrefix;
    private string name;
    private string surname;
    private string age;
    private string allergic;
    private string religion;
    private string email;
    private string password;

    public Person(string namePrefix,string name,string surname
    ,string age,string allergic,string religion) {
        this.namePrefix = namePrefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergic = allergic;
        this.religion = religion;
        

    }

    public string GetNamePrefix(){
        return this.namePrefix;
    }
    public string GetName(){
        return this.name ;
    }
    public string GetSurname(){
        return this.surname;
    }
    public string GetAge(){
        return this.age;
    }
    public string GetAllergic(){
        return this.allergic;
    }
    public string GetReligion(){
        return this.religion;
    }
    public string GetEmail(){
        return this.email;
    }
    public string GetPassword(){
        return this.password;
    }

}