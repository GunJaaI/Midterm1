using System;
class Program
{
    static PersonList personList;
    private static void Main(string[] args)
    {
        PreparePersonListProgramIsLoad();
        PrintMenuScreen();
    }
    static void PrintMenuScreen(){
        Console.Clear();
        PrintListMenu();
    }
    static void PrintListMenu(){
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("1. Registeration");
        Console.WriteLine("2. Show statistics of all attendees. ");
        Console.WriteLine("3. Login");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Please input Menu (1-3) : ");
        Menu menu = (Menu)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu) {
            case Menu.Registeration:
                InputRegisterationScreen();
                break;
            case Menu.ShowAllMemberStatistics:
                ShowStatisticsScreen();
                break;
            case Menu.Login:
                ShowLoginScreen();
                break;
        default:
            break;
        }
    }

    static void PrintListMenu2(){
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("1. Registeration");
        Console.WriteLine("2. Show all Current Students participating in the program.");
        Console.WriteLine("3. Show all Students participating in the program.");
        Console.WriteLine("4. Show all Teachers participating in the program.");
        Console.WriteLine("5. Log out.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Please input Menu (1-5) : ");
        Menu2 menu2 = (Menu2)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu2) {
            case Menu2.Registeration:
                InputRegisterationScreen();
                break;
            case Menu2.ShowAllCurrentStudentsParticipating:
                ShowAllCurrentStudentsParticipating();
                break;
            case Menu2.ShowAllStudentsParticipating:
                ShowAllStudentsParticipating();
                break;
            case Menu2.ShowAllTeachersParticipating:
                ShowAllTeachersParticipating();
                break;
            case Menu2.Logout:
                PrintMenuScreen();
                break;
        default:
            break;
        }
    }

    static void ShowStatisticsScreen() {
        Console.WriteLine("Show All Persons");
        Console.WriteLine("****************");
        //Console.WriteLine("Total number of current student : {0}",totalNewCurrentStudent);
        Program.personList.FetchPersonList();

        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToMainMenu();
    }

    static void ShowAllCurrentStudentsParticipating() {
        Console.WriteLine("Show all Current Students participating");
        Console.WriteLine("***************************************");

        Program.personList.CurrentStudentList();

        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToMenu2();
    }

    static void ShowAllStudentsParticipating() {
        Console.WriteLine("Show all Students participating");
        Console.WriteLine("*******************************");

        Program.personList.StudentList();

        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToMenu2();
    }

    static void ShowAllTeachersParticipating() {
        Console.WriteLine("Show all Teachers participating");
        Console.WriteLine("*******************************");

        Program.personList.TeacherList();

        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToMenu2();
    }

    static void InputRegisterationScreen() {
        Console.Clear();
        Console.WriteLine("  Register New User ");
        Console.WriteLine("********************");
        Console.WriteLine("1. Current Student");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("********************");
        Console.Write("Please input type member (1-3) : ");
        Registeration register = (Registeration)int.Parse(Console.ReadLine());
        switch (register) {
            case Registeration.CurrentStudent:
                InputCurrentStudentFormKeyboard();
                break;
            case Registeration.Student:
                InputStudentFormKeyboard();
                break;
            case Registeration.Teacher:
                InputTeacherFormKeyboard();
                break;
        default:
            break;
        }
    }

    static void InputCurrentStudentFormKeyboard() {
        Console.Write("Input Total new CurrentStudent : ");
        int totalNewCurrentStudent = int.Parse(Console.ReadLine());
        for(int i=0;i < totalNewCurrentStudent;i++) {
            Console.Clear();
            CurrentStudent currentStudent = new CurrentStudent(CheckNamePrefix(InputNamePrefix()),
                                      InputName(),
                                      InputSurname(),
                                      InputStudentID(),
                                      InputAge(),
                                      InputAllergic(),
                                      CheckReligion(InputReligion()),
                                      CheckEmail(InputEmail()),
                                      InputPassword());
            Program.personList.AddNewPerson(currentStudent);
        }

        BackToMainMenu();
    }
    /*
    static void CheckName(){
        PersonList inventory = new PersonList(personList);
        Person checkperson = new Person(InputNamePrefix(),InputName(),InputSurname(),"","","","","");
        Person searchName = inventory.SearchName(checkperson);

    }
    */
    static void PreparePersonListProgramIsLoad() {
        Program.personList = new PersonList();
    }
    static string InputNamePrefix() {
        Console.Write("Name prefix ( Mr./Mrs./Miss. ) : ");
        return Console.ReadLine();
    }

    static string InputName() {
        Console.Write("Name : ");
        return Console.ReadLine();
    }

    static string InputSurname() {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }

    static string InputStudentID() {
        Console.Write("StudentID : ");
        return Console.ReadLine();
    }

    static string InputAge() {
        Console.Write("Age : ");
        return Console.ReadLine();
    }

    static string InputAllergic() {
        Console.Write("Allergic : ");
        return Console.ReadLine();
    }

    static string InputReligion() {
        Console.Write("Religion ( Buddhist/Christ/Islam/Other ): ");
        return Console.ReadLine();
    }

    static string InputEmail() {
        Console.Write("Email : ");
        return Console.ReadLine();
    }

    static string InputPassword() {
        Console.Write("Password : ");
        return Console.ReadLine();
    }

    static string CheckNamePrefix(string namePrefix){
        if ((namePrefix == "Mr.")||(namePrefix == "Mrs.")||(namePrefix == "Miss.")) {
            return namePrefix;
        }
        throw new Exception("Please input Name-prefix");
    }

    static string CheckReligion(string religion){
        if ((religion == "Buddhist")||(religion == "Christ")||(religion == "Islam")||(religion == "Other")) {
            return religion;
        }
        throw new Exception("Please input Religion");
    }

    static string CheckEmail(string email){
        if ((email == "exit")) {
            Console.Write("Invalid email. Please try again.");
            Console.ReadLine();
            BackToMainMenu();
        }
        return email;
    }

    ///////////////////////////////////////////////////////////////////////////
    static void InputStudentFormKeyboard() {
        Console.Write("Input Total new Student : ");
        int totalNewStudent = int.Parse(Console.ReadLine());
        for(int i=0;i < totalNewStudent;i++) {
            Console.Clear();
            Student student = new Student(CheckNamePrefix(InputNamePrefix()),
                                      InputName(),
                                      InputSurname(),
                                      CheckGrade(InputGrade()),
                                      InputAge(),
                                      InputAllergic(),
                                      CheckReligion(InputReligion()),
                                      InputSchool(),
                                      CheckEmail(InputEmail()),
                                      InputPassword());
            Program.personList.AddNewPerson(student);
        }

        BackToMainMenu();
    }

    static string InputGrade() {
        Console.Write("Grade ( 10 - 12 ): ");
        return Console.ReadLine();
    }

    static string InputSchool() {
        Console.Write("School : ");
        return Console.ReadLine();
    }

    static string CheckGrade(string grade){
        if ((grade == "10")||(grade == "11")||(grade == "12")) {
            return grade;
        }
        throw new Exception("Please input Grade 10 - 12");
    }

    ///////////////////////////////////////////////////////////////////////////
    static void InputTeacherFormKeyboard() {
        Console.Write("Input Total new Teacher : ");
        int totalNewTeacher = int.Parse(Console.ReadLine());
        for(int i=0;i < totalNewTeacher;i++) {
            Console.Clear();
            Teacher teacher = new Teacher(CheckNamePrefix(InputNamePrefix()),
                                      InputName(),
                                      InputSurname(),
                                      CheckRank(InputRank()),
                                      InputAge(),
                                      InputAllergic(),
                                      CheckReligion(InputReligion()),
                                      CheckEmail(InputEmail()),
                                      InputPassword());
            Program.personList.AddNewPerson(teacher);
        }

        BackToMainMenu();
    }

    static string InputRank() {
        Console.WriteLine("Rank ( Dean / Head of department / Full-time teacher )");
        Console.Write("Rank : ");
        return Console.ReadLine();
    }

    static string CheckRank(string rank){
        if ((rank == "Dean")||(rank == "Head of department")||(rank == "Full-time teacher")) {
            return rank;
        }
        throw new Exception("Please input Grade 10 - 12");
    }

    static void BackToMainMenu() {
        Console.Clear();
        PrintListMenu();
    }

    static void ShowLoginScreen() {
        Console.Clear();
        Console.WriteLine("   Log-in   ");
        Console.WriteLine("************");
        /*PersonList per = new PersonList(this.personList);*/
        Login login = new Login(CheckLoginEmail(InputLoginEmail()),/*CheckEmail(InputEmail()),*/
                                InputLoginPassword()/*InputPassword()*/);
        //Person search = per.Search(login); 
        Console.Clear();
        PrintListMenu2();
    }

    static string InputLoginEmail() {
        Console.Write("Email : ");
        return Console.ReadLine();
    }

    static string InputLoginPassword() {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    string checkEmail = InputEmail();
    static string CheckLoginEmail(string loginEmail/*,string checkEmail*/){
        if ((loginEmail == "exit")) {
            Console.Clear();
            BackToMainMenu();
        } 
        /*
        else if (loginEmail != checkEmail) {
            Console.WriteLine("Incorrect email or password. Please try again.");
            BackToLoginScreen();
        }
        */
        return loginEmail;
    }
    /*
    static string CheckLoginPassword(string loginPassword,string getEmail){
        if ((loginPassword != person.GetEmail())) {
            Console.WriteLine("Incorrect email or password. Please try again.");
            BackToLoginScreen();
        }
        return loginPassword;
    }
    */
    static void BackToLoginScreen() {
        Console.Clear();
        ShowLoginScreen();
    }

    static void BackToMenu2() {
        Console.Clear();
        PrintListMenu2();
    }
}