public class Student : Person {
    private string grade;
    private string school;
    public Student(string namePrefix,string name,string surname,string age
    ,string grade
    ,string allergic,string religion
    ,string school)
    : base(namePrefix,name,surname,age,allergic,religion) {
        this.grade = grade;
        this.school = school;
    }
    public string GetGrade(){
        return this.grade;
    }
    
}