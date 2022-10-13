public class CurrentStudent : Person {
    private string studentID;
    
    public CurrentStudent(string namePrefix,string name,string surname
    ,string studentID
    ,string age,string allergic,string religion,string email,string password)
    : base(namePrefix,name,surname,age,allergic,religion,email,password) {
        this.studentID = studentID;
        
    }

}