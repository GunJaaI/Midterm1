public class Teacher : Person {
    private string rank;
    
    public Teacher(string namePrefix,string name,string surname
    ,string rank
    ,string age,string allergic,string religion,string email,string password)
    : base(namePrefix,name,surname,age,allergic,religion,email,password) {
        this.rank = rank;

    }

}