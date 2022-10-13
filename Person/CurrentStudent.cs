public class CurrentStudent : Person {
    private string studentID;
    private string admin;
    
    public CurrentStudent(string namePrefix,string name,string surname
    ,string studentID
    ,string age,string allergic,string religion,string admin)
    : base(namePrefix,name,surname,age,allergic,religion) {
        this.studentID = studentID;
        this.admin = admin;
    }
    public string GetAdmin(){
        return this.admin;
    }
}