using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
