using System;
using System.Collections.Generic;
using System.Text;

namespace homework8
{
   
        class Student
        {
            private int id;
            public int Id
            {
                get { return id; }
                set
                {
                    if (value > 0) id = value;
                    else Console.WriteLine("Shecdoma: ID unda iyos dadebiti!");
                }
            }

            private string firstName;
            public string FirstName
            {
                get { return firstName; }
                set
                {
                    if (!string.IsNullOrEmpty(value)) firstName = value;
                    else Console.WriteLine("Shecdoma: Saxeli ar unda iyos carieli!");
                }
            }

            private string lastName;
            public string LastName
            {
                get { return lastName; }
                set
                {
                    if (!string.IsNullOrEmpty(value)) lastName = value;
                    else Console.WriteLine("Shecdoma: Gvari ar unda iyos carieli!");
                }
            }

            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0 && value <= 120) age = value;
                    else Console.WriteLine("Shecdoma: Asaki ar aris swori!");
                }
            }

            private double gpa;
            public double Gpa
            {
                get { return gpa; }
                set
                {
                    if (value >= 0 && value <= 100) gpa = value;
                    else Console.WriteLine("Shecdoma: Qula unda iyos 0-dan 100-mde!");
                }
            }

            private int course;
            public int Course
            {
                get { return course; }
                set
                {
                    if (value >= 1 && value <= 4) course = value;
                    else Console.WriteLine("Shecdoma: Kursi unda iyos 1-dan 4-mde!");
                }
            }

            private string email;
            public string Email
            {
                get { return email; }
                set
                {
                    if (value != null && value.Contains("@")) email = value;
                    else Console.WriteLine("Shecdoma: Email ar aris swori ('@' aklia)!");
                }
            }

            private string phoneNumber;
            public string PhoneNumber
            {
                get { return phoneNumber; }
                set
                {
                    if (!string.IsNullOrEmpty(value)) phoneNumber = value;
                    else Console.WriteLine("Shecdoma: Nomris veli carielia!");
                }
            }

            private string faculty;
            public string Faculty
            {
                get { return faculty; }
                set
                {
                    if (!string.IsNullOrEmpty(value)) faculty = value;
                    else Console.WriteLine("Shecdoma: Fakulteti carielia!");
                }
            }

            private bool isActive;
            public bool IsActive
            {
                get { return isActive; }
                set { isActive = value; }
            }

            public void PrintInfo()
            {
                Console.WriteLine("--- Studentis Sruli Informacia ---");
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Saxeli: {FirstName}");
                Console.WriteLine($"Gvari: {LastName}");
                Console.WriteLine($"Asaki: {Age}");
                Console.WriteLine($"Qula (GPA): {Gpa}");
                Console.WriteLine($"Kursi: {Course}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Telefoni: {PhoneNumber}");
                Console.WriteLine($"Fakulteti: {Faculty}");
                Console.WriteLine($"Aqtivia: {(IsActive ? "Ki" : "Ara")}");
            }
        }
    }

