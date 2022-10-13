public class Login {
    private Person[] persons;
    private string loginEmail;
    private string loginpassword;
    
    public Login(string loginEmail,string loginpassword){
        this.loginEmail = loginEmail;
        this.loginpassword = loginpassword;
    }
    public Login(Person[] persons) {
        this.persons = persons;
    }
    
    public Person GetLoginEmail(string email){
        foreach (Person person2 in persons){
            if (person2.GetEmail().Equals(email)){
                return person2;
            }
        }
        return null;
    }

    public Person Search(Person search){
        foreach (Person person in persons){
            string email = search.GetEmail();
            string password = search.GetPassword();

            if (person.GetEmail().Equals(email)){
                return person;
            }
        }
        return null;
    }

    public Person SearchName(Person searchName){
        foreach (Person person in persons){
            string namePrefix = searchName.GetNamePrefix();
            string name = searchName.GetName();
            string surname = searchName.GetSurname();

            if ((person.GetNamePrefix().Equals(namePrefix))&&(person.GetName().Equals(name))&&(person.GetSurname().Equals(surname))){
                return person;
            }
        }
        return null;
    }

}