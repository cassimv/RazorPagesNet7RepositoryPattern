using AutoMapper.Internal.Mappers;
using BusinessLogic.StaticMappings;
using DataLogic.LogicInterfaces;
using DataLogic.Students;
using Repository.RepositoryInterfaces;
using ViewLogic;

namespace BusinessLogic.StudentBusiness
{
    public class StudentLogic: IStudentLogic
    {
        private readonly iStudentRepository _repository;

        public StudentLogic(iStudentRepository repository)
        {
            _repository = repository;
        }
        public async Task<StudentView?> GetStudentByIdAsync(int id)
        {
            var student = await _repository.GetByIdAsync(id);
            return student != null ? ObjectMapper.Mapper.Map<Students, StudentView>(student) : null;
        }
        public async Task<List<StudentView>> GetAllStudentsAsync()
        {
            var student = await _repository.GetAllAsync();
            return ObjectMapper.Mapper.Map<List<Students>,List<StudentView>>(student.ToList());
        }

        public async Task AddStudentAsync(StudentView student)
        {
            var studentDataModel = ObjectMapper.Mapper.Map<StudentView, Students>(student);
            await _repository.AddAsync(studentDataModel);
        }

        public async Task UpdateStudentAsync(StudentView student)
        {
            var studentDataModel = await _repository.GetByIdAsync(student.Id);

            if (studentDataModel != null)
            {
                studentDataModel.FirstName = student.FirstName;
                studentDataModel.LastName = student.LastName;
                await _repository.UpdateAsync(studentDataModel);
            }
        }
    }
}