using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class Validation");
            Console.WriteLine("-----------------------------\n");
            Employee objEmployee = new Employee();
            objEmployee.Name = "Suraj";
            objEmployee.Age = 19;
            objEmployee.PhoneNumber = "9874563210";
            objEmployee.Email = "Suraj@gmail.com";

            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name + "\n" + "Age: " + objEmployee.Age + "\n" + "PhoneNumber: " + objEmployee.PhoneNumber + "\n" + "Email: " + objEmployee.Email);
            }
            Console.ReadKey();

        }
    }
}
