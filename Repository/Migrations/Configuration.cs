namespace Repository.Migrations
{
    using Repository.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Repository.StudentGradesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Repository.StudentGradesContext context)
        {
            var lstSubjects = new List<Subject>
            {
                new Subject { Id = 1, SubjectName = "Language & Arts"},
                new Subject { Id = 2, SubjectName = "Science"},
                new Subject { Id = 3, SubjectName = "Social Studies"},
                new Subject { Id = 4, SubjectName = "Maths"}
            };

            lstSubjects.ForEach(x => context.Subjects.Add(x));

            var lstStudents = new List<Student>
            {
                new Student { Id = 1, Name = "Anna Taylor"},
                new Student { Id = 2, Name = "Mark Smith"},
                new Student { Id = 3, Name = "John Doe"},
                new Student { Id = 4, Name = "Jack Jones"},
                new Student { Id = 5, Name = "Melody Queens"},
                new Student { Id = 6, Name = "Noah Menac"}
            };

            lstStudents.ForEach(x => context.Students.Add(x));

            var lstStudentGrades = new List<StudentGrade>
            {
                //Anna Taylor
                new StudentGrade { Id = 1, StudentId = 1, Mark = 90, SubjectId = 1},
                new StudentGrade { Id = 2, StudentId = 1, Mark = 85, SubjectId = 2},
                new StudentGrade { Id = 3, StudentId = 1, Mark = 86, SubjectId = 3},
                new StudentGrade { Id = 4, StudentId = 1, Mark = 89, SubjectId = 4},

                //Mark Smith
                new StudentGrade { Id = 5, StudentId = 2, Mark = 82, SubjectId = 1},
                new StudentGrade { Id = 6, StudentId = 2, Mark = 75, SubjectId = 2},
                new StudentGrade { Id = 7, StudentId = 2, Mark = 89, SubjectId = 3},
                new StudentGrade { Id = 8, StudentId = 2, Mark = 86, SubjectId = 4},

                //John Doe
                new StudentGrade { Id = 9, StudentId = 3, Mark = 89, SubjectId = 1},
                new StudentGrade { Id = 10, StudentId = 3, Mark = 76, SubjectId = 2},
                new StudentGrade { Id = 11, StudentId = 3, Mark = 94, SubjectId = 3},
                new StudentGrade { Id = 12, StudentId = 3, Mark = 82, SubjectId = 4},

                //Jack Jones
                new StudentGrade { Id = 13, StudentId = 4, Mark = 93, SubjectId = 1},
                new StudentGrade { Id = 14, StudentId = 4, Mark = 73, SubjectId = 2},
                new StudentGrade { Id = 15, StudentId = 4, Mark = 97, SubjectId = 3},
                new StudentGrade { Id = 16, StudentId = 4, Mark = 90, SubjectId = 4},

                //Melody Queens
                new StudentGrade { Id = 17, StudentId = 5, Mark = 87, SubjectId = 1},
                new StudentGrade { Id = 18, StudentId = 5, Mark = 89, SubjectId = 2},
                new StudentGrade { Id = 19, StudentId = 5, Mark = 80, SubjectId = 3},
                new StudentGrade { Id = 20, StudentId = 5, Mark = 83, SubjectId = 4},

                //Noah Menac
                new StudentGrade { Id = 21, StudentId = 6, Mark = 86, SubjectId = 1},
                new StudentGrade { Id = 22, StudentId = 6, Mark = 90, SubjectId = 2},
                new StudentGrade { Id = 23, StudentId = 6, Mark = 83, SubjectId = 3},
                new StudentGrade { Id = 24, StudentId = 6, Mark = 85, SubjectId = 4},
            };

            lstStudentGrades.ForEach(x => context.StudentGrades.Add(x));

            var lstStudentGradeDetails = new List<StudentGradeDetail>
            {
                new StudentGradeDetail{ Id = 1, Student = "Anna Taylor", LanguageArts = 90, Science = 85, SocialStudies = 86, Maths = 89},
                new StudentGradeDetail{ Id = 2, Student = "Mark Smith", LanguageArts = 82, Science = 75, SocialStudies = 89, Maths = 86},
                new StudentGradeDetail{ Id = 3, Student = "John Doe", LanguageArts = 89, Science = 76, SocialStudies = 94, Maths = 82},
                new StudentGradeDetail{ Id = 4, Student = "Jack Jones", LanguageArts = 93, Science = 73, SocialStudies = 97, Maths = 90},
                new StudentGradeDetail{ Id = 5, Student = "Melody Queens", LanguageArts = 87, Science = 89, SocialStudies = 80, Maths = 83},
                new StudentGradeDetail{ Id = 6, Student = "Noah Menac", LanguageArts = 86, Science = 90, SocialStudies = 83, Maths = 85},
            };

            lstStudentGradeDetails.ForEach(x => context.StudentGradeDetails.Add(x));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
