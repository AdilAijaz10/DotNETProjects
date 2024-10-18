using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(std=> std.RollNo == id).FirstOrDefault();
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { RollNo = 1 , Name = "Adil", Gender ="Male", Standard =12},
                new StudentModel { RollNo = 2 , Name = "Ahmed", Gender ="Male", Standard =8},
                new StudentModel { RollNo = 3 , Name = "Ali", Gender ="Male", Standard =9},
                new StudentModel { RollNo = 4 , Name = "Alina", Gender ="Female", Standard =11},
                new StudentModel { RollNo = 5 , Name = "Alishba", Gender ="Female", Standard =12},
            };
        }
    }
}
