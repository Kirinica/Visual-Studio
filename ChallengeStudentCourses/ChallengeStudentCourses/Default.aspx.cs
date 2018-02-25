using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>() {
               new Course() {CourseId = 1, Name="Biology", Students=new List<Student>() {
                   new Student() {StudentId = 1, Name = "Kim Morgan"},
                   new Student() {StudentId = 2, Name = "Abbey Stanfield"},
               } },
               new Course() {CourseId = 2, Name="EAST", Students = new List<Student>() {
                       new Student() {StudentId = 3, Name = "Ashley Crook"},
                       new Student() {StudentId = 4, Name = "Valerie Bay"},
               } },
               new Course() {CourseId = 3, Name="Visual Tech", Students = new List<Student>() {
                       new Student() {StudentId = 5, Name = "Phoenix Murchin"},
                       new Student() {StudentId = 6, Name = "Kredlen Dentscheff"} }
               } };
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("</br>Course: {0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("</br>Student: {0} - {1}", student.StudentId, student.Name);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseId = 1, Name = "Photography" };
            Course course2 = new Course() { CourseId = 2, Name = "Econ" };
            Course course3 = new Course() { CourseId = 3, Name = "Theatre 101" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student{ StudentId = 1, Name = "Kim Morgan", Courses = new List<Course>{course1, course2}}},
                { 2, new Student{ StudentId = 2, Name = "Abbey Stanfield", Courses = new List<Course>{course2, course3}}},
                { 3, new Student{ StudentId = 3, Name = "Ashley Crook", Courses = new List<Course>{course3, course1}}},
            };
            foreach (var student in students)
            {
                resultLabel.Text += String.Format("</br>Student: {0} {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("</br>Course: {0} - {1}", course.CourseId, course.Name);
                }
            }
        }
        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = 18;
            student.Name = "Kim Morgan";
            student.Enrollments = new List<Enrollment>() {
                new Enrollment { Grade = 97, Course = new Course { CourseId = 1, Name = "Engligh 205"}},
                new Enrollment { Grade = 84, Course = new Course { CourseId = 2, Name = "Accounting"}},
            };
            resultLabel.Text += String.Format("</br>Student: {0} {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("</br>Enrolled In: {0} - Grade: {1}", enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
}