using System.Collections.Generic;
using System;
public class PersonList {
    private List<Person> personList;
    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }
    public int x=0,y=0,z=0;
    public void FetchPersonList() {
        Console.WriteLine("List & Type Persons");
        Console.WriteLine("*******************");
        foreach (Person person in this.personList) {
            if (person is CurrentStudent) {
                Console.WriteLine("| Name : {0}{1} \n| Type : CurrentStudent.",person.GetNamePrefix(),person.GetName());
                x++;
            } else if (person is Student) {
                Console.WriteLine("| Name : {0}{1} \n| Type : Student.",person.GetNamePrefix(),person.GetName());

            } else if (person is Teacher) {
                Console.WriteLine("| Name : {0}{1} \n| Type : Teacher.",person.GetNamePrefix(),person.GetName());
            } 
        }
        Console.WriteLine("*******************");
    }

    public void CurrentStudentList() {
        Console.WriteLine("List Current Students.");
        Console.WriteLine("**********************");

        foreach (Person person in this.personList) {
            if (person is CurrentStudent) {
                Console.WriteLine("| Name : {0}{1} {2}",person.GetNamePrefix(),person.GetName(),person.GetSurname());
            } 
        }
        Console.WriteLine("**********************");
    }
    public void StudentList() {
        Console.WriteLine("List Students.");
        Console.WriteLine("**************");

        foreach (Person person in this.personList) {
            if (person is Student) {
                Console.WriteLine("| Name : {0}{1} {2}",person.GetNamePrefix(),person.GetName(),person.GetSurname());
            } 
        }
        Console.WriteLine("**************");
    }
    public void TeacherList() {
        Console.WriteLine("List Teachers.");
        Console.WriteLine("**************");

        foreach (Person person in this.personList) {
            if (person is Teacher) {
                Console.WriteLine("| Name : {0}{1} {2}",person.GetNamePrefix(),person.GetName(),person.GetSurname());
            } 
        }
        Console.WriteLine("**************");
    }
}