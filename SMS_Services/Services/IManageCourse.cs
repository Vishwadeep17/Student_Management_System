using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    [ServiceContract]
    public interface IManageCourse
    {
        [OperationContract]
        void AddCourse(Course course);
        [OperationContract]
        Course[] GetCourses();
        [OperationContract]
        void UpdateCourse(Course course);
        [OperationContract]
        void DeleteCourse(int id);
        [OperationContract]
        void AddCourseForStudent(int studentId, int courseId);
        [OperationContract]
        Course[] GetCoursesForStudent(int studentId);
        [OperationContract]
        void RemoveCourseForStudent(int studentId, int courseId);

    }
    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseId { get; set; }

        [DataMember]
        public string CourseName { get; set; }
    }
}
