using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BuisnessLayer.Repository;
using StudentInformationSystem.BuisnessLayer.Services;

namespace StudentInformationSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ****************************Student details***************************
            Student s = new Student();

            Console.WriteLine("Enter student Details:");

            int student_id = Convert.ToInt32(Console.ReadLine());
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            string date = Console.ReadLine();
            string email = Console.ReadLine();
            string phone = Console.ReadLine();

            StudentRepository student_repository = new StudentRepository(student_id, first_name, last_name, date, email, phone);
            StudentService student_service = new StudentService(student_repository);

            //display before updating details
            student_service.DisplayStudentInfo();

            //Updating and displaying data
            student_service.UpdateStudentInfo("zahabiya", "kapadia", date, "zahabiya@email.com", "98090899");
            student_service.DisplayStudentInfo();
            student_service.GetEnrolledCourses();
            

            // ****************************Course Details***************************
            Course c = new Course();

            Console.WriteLine("Enter Course Details:");
            int course_id = Convert.ToInt32(Console.ReadLine());
            string course_name = Console.ReadLine();
            string course_code = Console.ReadLine();
            string instructor = Console.ReadLine();

            CourseRepository course_repository = new CourseRepository(course_id, course_name, course_code, instructor); 
            CourseService course_service = new CourseService(course_repository);

            course_service.DisplayCourseInfo();
            course_service.UpdateCourseInfo("CS501", "OOPs Concept", "Varsha");
            course_service.DisplayCourseInfo();

            // ****************************Enrollment Details***************************

            // ****************************Teacher Details***************************

            // ****************************Payment Details***************************
            Payment p = new Payment();

            //PaymentRepository payment_Repository = new PaymentRepository(190,500.07M,"2024/10/02");
            //PaymentService payment_Service = new PaymentService(payment_Repository);
            //decimal get_amount = payment_Service.GetPaymentAmount();
            //DateTime get_date = payment_Service.GetPaymentDate();

            //Console.WriteLine($"Payment amount: {get_amount}\nPayment Date: {get_date}");

            Console.ReadKey();
        }
    }
}
