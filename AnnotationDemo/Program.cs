using System;
using System.ComponentModel.DataAnnotations;

namespace AnnotationDemo;
class Program
{
    public static void Main(string[] args)
    {
       
        Employee employee = new Employee();

        employee.Name = "Mmqe";
        employee.Age = 18;
        employee.PhoneNumber = "5753012";
        employee.Email = "asfiarehmath.com";
        ValidationContext context = new ValidationContext(employee, null, null);
        List<ValidationResult> results = new List<ValidationResult>();
        bool valid=Validator.TryValidateObject(employee,context,results,true);
        if (!valid)
        {
            foreach(ValidationResult Totalresult in results)
            {
                Console.WriteLine("Member Name: {0}",Totalresult.MemberNames.First(),Environment.NewLine);
                Console.WriteLine("Error Msg : {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
            }
        }
        else
        {
            Console.WriteLine("Name: "+employee.Name+" "+"Age: "+employee.Age+" "+"PhoneNumber"+employee.PhoneNumber);
        }
        Console.WriteLine("Press any key to exit");

    }
}
