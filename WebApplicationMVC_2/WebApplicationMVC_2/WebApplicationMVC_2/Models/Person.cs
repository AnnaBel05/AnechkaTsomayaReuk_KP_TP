using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC_2.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        [Display(Name = "Фамилия")] 
        public string LastName { get; set; }
        [Display(Name = "Имя")] 
        public string FirstName { get; set; }
        [Display(Name = "Отчество")] 
        public string MiddleName { get; set; }
        [DataType(DataType.Date), Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
        [Display(Name = "ФИО")]
        public string FullName
        {
            get { return LastName + " " + FirstName + " " + MiddleName; }
        }
    }
    public class Employee : Person
    {
        public string Email { get; set; }
        [Display(Name = "Ученая степень")] 
        public string AcademicDegree { get; set; }
        [Display(Name = "Должность")] 
        public string Position { get; set; }
        [Display(Name = "Зарплата")] 
        public Decimal Salary { get; set; }
    }
    public class Student : Person
    {
        [Display(Name = "Номер зачётной книжки")]
        public string CreditCardNumber { get; set; }        
        [Display(Name = "Стипендия")] 
        public Decimal ScholarshipAmount { get; set; }

        [Display(Name = "Основа обучения")] 
        public int EducationalFormId { get; set; }
        public EducationalForm EducationalForm { get; set; }
        [Display(Name = "Группа")] 
        public Guid GroupId { get; set; }
        [Display(Name = "Группа")]
        public Group Group { get; set; }
        [Display(Name = "Форма обучения")]
        public int TrainingTypeId { get; set; }
        public TrainingType TrainingType { get; set; }
        [Display(Name = "Стипендия, вид")] 
        public int ScholarshipTypeId { get; set; }
        [Display(Name = "Стипендия, вид")]
        public ScholarshipType ScholarshipType { get; set; }
    }
}
