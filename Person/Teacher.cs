public class Teacher : Person {
    private string rank;
    private string carNum;
    private string admin;
    public Teacher(string namePrefix,string name,string surname
    ,string rank
    ,string age,string allergic,string religion
    ,string carNum
    ,string admin)
    : base(namePrefix,name,surname,age,allergic,religion) {
        this.rank = rank;
        this.carNum = carNum;
        this.admin = admin;

    }
    public string GetAdmin(){
        return this.admin;
    }
}