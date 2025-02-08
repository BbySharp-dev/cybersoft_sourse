using StudentLibrary;

namespace StudentTests
{
    [TestFixture]
    public class StudentManagerTests
    {
        private StudentManager _studentManager;

        [SetUp]
        public void Setup()
        {
            _studentManager = new StudentManager();
        }

        [Test]
        public void AddStudent_ValidStudent_AddsSuccessfully()
        {
            var student = new Student(1, "Truong", 20, 3.5);
            _studentManager.AddStudent(student);

            var result = _studentManager.GetStudentById(1);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Truong"));
        }

        [Test]
        public void GetAllStudents_ReturnsCorrectCount()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            _studentManager.AddStudent(new Student(2, "Joy", 22, 3.8));

            var students = _studentManager.GetAllStudents();
            Assert.That(students.Count, Is.EqualTo(2));
        }

        [Test]
        public void UpdateStudent_ValidId_UpdatesSuccessfully()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            _studentManager.UpdateStudent(1, "Joy", 21, 3.9);

            var student = _studentManager.GetStudentById(1);
            Assert.That(student.Name, Is.EqualTo("Joy"));
            Assert.That(student.Age, Is.EqualTo(21));
            Assert.That(student.GPA, Is.EqualTo(3.9));
        }

        [Test]
        public void RemoveStudent_ValidId_RemovesSuccessfully()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            _studentManager.RemoveStudent(1);

            var student = _studentManager.GetStudentById(1);
            Assert.That(student, Is.Null);
        }

        [Test]
        public void CalculateAverageGPA_ReturnsCorrectValue()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            _studentManager.AddStudent(new Student(2, "Joy", 22, 3.0));

            double avgGPA = _studentManager.CalculateAverageGPA();
            Assert.That(avgGPA, Is.EqualTo(3.25).Within(0.01));
        }

        [Test]
        public void GetTopStudent_ReturnsHighestGPAStudent()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            _studentManager.AddStudent(new Student(2, "Joy", 21, 3.9));

            var topStudent = _studentManager.GetTopStudent();
            Assert.That(topStudent.Name, Is.EqualTo("Joy"));
        }

        [Test]
        public void AddStudent_NullStudent_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => _studentManager.AddStudent(null));
        }

        [Test]
        public void AddStudent_DuplicateId_ThrowsException()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            Assert.Throws<ArgumentException>(() => _studentManager.AddStudent(new Student(1, "Joy", 22, 3.8)));
        }

        [Test]
        public void UpdateStudent_InvalidId_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _studentManager.UpdateStudent(99, "Truong", 20, 3.5));
        }

        [Test]
        public void RemoveStudent_InvalidId_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _studentManager.RemoveStudent(99));
        }

        [Test]
        public void CalculateAverageGPA_NoStudents_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _studentManager.CalculateAverageGPA());
        }

        [Test]
        public void GetTopStudent_NoStudents_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _studentManager.GetTopStudent());
        }

        [Test]
        public void AddStudent_InvalidNegativeGPA_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _studentManager.AddStudent(new Student(3, "Joy", 20, -1.0)));
        }

        [Test]
        public void UpdateStudent_InvalidNegativeGPA_ThrowsException()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            Assert.Throws<ArgumentException>(() => _studentManager.UpdateStudent(1, "Joy", 20, -1.0));
        }

        [Test]
        public void AddStudent_MinimumValidAge_AddsSuccessfully()
        {
            var student = new Student(1, "Truong", 18, 3.2);
            _studentManager.AddStudent(student);

            var result = _studentManager.GetStudentById(1);
            Assert.That(result.Age, Is.EqualTo(18));
        }

        [Test]
        public void AddStudent_MaximumValidGPA_AddsSuccessfully()
        {
            var student = new Student(2, "Joy", 22, 4.0);
            _studentManager.AddStudent(student);

            var result = _studentManager.GetStudentById(2);
            Assert.That(result.GPA, Is.EqualTo(4.0));
        }

        [Test]
        public void AddStudent_MinimumValidGPA_AddsSuccessfully()
        {
            var student = new Student(3, "Truong", 20, 0.0);
            _studentManager.AddStudent(student);

            var result = _studentManager.GetStudentById(3);
            Assert.That(result.GPA, Is.EqualTo(0.0));
        }

        [Test]
        public void FilterStudentsByGPA_ReturnsCorrectStudents()
        {
            _studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
            _studentManager.AddStudent(new Student(2, "Joy", 21, 3.0));
            _studentManager.AddStudent(new Student(3, "Joy", 22, 2.5));

            var filtered = _studentManager.FilterStudentsByGPA(3.0, 4.0);
            Assert.That(filtered.Count, Is.EqualTo(2));
        }
    }
}
