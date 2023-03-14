using System;
using System.Collections.Generic;

class Program
{
    public static void listOfTheStudent(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No any student present");
            return;
        }


        foreach (Student student in students)
        {
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.City);
        }
    }

    public static void createNewStudent(List<Student> students)
    {
        Student newStudent = new Student();
        Console.Write("Enter student Id : ");
        newStudent.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Enter student Name : ");
        newStudent.Name = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Enter student City : ");
        newStudent.City = Console.ReadLine();

        students.Add(newStudent);
        Console.WriteLine($"Student {newStudent.Name} created!");
    }

    public static void updateStudentDetails(List<Student> students, int id, string city)
    {
        string name = "";
        foreach (Student student in students)
        {
            if (student.Id == id)
            {
                name = student.Name;
                student.City = city;
            }
        }
        Console.WriteLine($"id : {id}, name : {name} and city : {city} updated!");
    }

    public static void deleteStudent(List<Student> students, int id)
    {
        string name = "";
        foreach (Student student in students)
        {
            if (student.Id == id)
            {
                name = student.Name;
                students.Remove(student);
            }
        }
        Console.WriteLine($"{name} deleted!");
    }
    public static void Main()
    {
        List<Student> students = new List<Student>();

        string[] menu = {
            "1) List students",
            "2) Create new student",
            "3) Update student details",
            "4) Delete student",
            "5) Exit"
        };

        do
        {
            Console.WriteLine();
            Console.WriteLine("******* MENU *******");
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************");
            Console.WriteLine();

            Console.Write("Enter your choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 5)
            {
                Console.Write("Exit");
                break;
            }
            else if (choice == 1)
            {
                listOfTheStudent(students);
            }
            else if (choice == 2)
            {
                createNewStudent(students);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter existing student id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter updated city name of student id {id} : ");
                string city = Console.ReadLine();
                updateStudentDetails(students, id, city);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter student id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                deleteStudent(students, id);
            }
            else
            {
                Console.WriteLine("Enter valid input ...");
            }
        } while (true);
    }
}


public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}