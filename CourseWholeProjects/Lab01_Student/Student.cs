using System;
using System.Collections.Generic;

namespace Lab01_Student
{
    class Student
    {
        // static var
        private static uint idCounter = 2021000000; // stars from 2021 year

        // instance variables, member variables, attributes, fields
        private string name;
        private uint id;
        private float gpa;
        readonly float gpaBased; // gpa can be based on 4.0, 5.0 most common, 6.0
        private List<float> gradesHistory;

        // props
        public string Name
        {
            get { return name; }
        }

        public uint ID
        {
            get { return id; }
        }

        public float GPA
        {
            get { return gpa; }
        }

        // constructors
        public Student(string name, float gpaBased)
        {
            this.name = name;
            this.id = ++idCounter;
            this.gpa = 0.0f;
            this.gpaBased = gpaBased;
            gradesHistory = new List<float>();
        }

        public Student(string name, float gpaBased , float initialGrade) : this(name, gpaBased)
        {
            UpdateGPA(initialGrade);            
        }

       
        // public methods
        public void UpdateGPA(float grade)
        {
            if (addGradeToHistory(grade))
            {
                gpa = calculateGPA();
            }
            else
            {
                Console.WriteLine("Could not update the GPA, it keeps being the same");
            }
        }

        public override string ToString()
        {
            return $"Student name: {name}, id: {id}, gpa: {gpa}";
        }

        // helper methods
        private float calculateGPA()
        {
            int size = gradesHistory.Count;
            float gradesSum = 0;
            foreach (var grade in gradesHistory)
            {
                gradesSum += grade;
            }
            return (float)Math.Round((gradesSum / size), 1);
        }

        private bool addGradeToHistory(float grade)
        {
            if (grade >= 0.0 && grade <= gpaBased)
            {
                gradesHistory.Add(grade);
                return true;
            }
            else
            {
                Console.WriteLine("Invalid grade!. GPA base is: " + gpaBased + " for this student id: " + id);
                return false;
            }
        }

    } // eof class
} // eof namespace

