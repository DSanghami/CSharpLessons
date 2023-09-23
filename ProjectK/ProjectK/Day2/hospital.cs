using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SessionApp1.DayTwo
{
    internal class hospital
    {
        public string hosName { get; set; } = string.Empty;
        public string hosbranch { get; set; } = string.Empty;
        public string hosSpeciality { get; set; } = string.Empty;

        public string hosDean { get; set; } = string.Empty;
        public string hosDoctors { get; set; } = string.Empty;
        public string hosEmployee { get; set; } = string.Empty;
       
        



        public override string ToString()
        {
            return $"Name: {this.hosName},Branch:{hosbranch}\n" +
                $"Speciality:  {hosSpeciality},Dean: {hosDean}, Doctors: {hosDoctors}\n " +
                $"Employee :{hosEmployee} ";
        }









    }
    internal class TestHospital
    {
        public static void TestOne()
        {
            hospital person = new hospital();
            person.hosName = "AkashClinic";
            person.hosbranch = "Chennai";
            person.hosSpeciality = "Multispciality";
            person.hosDean = "Sanghami";
            person.hosDoctors = "12";
            person.hosEmployee = "24";
            
            String data = person.ToString();
            Console.WriteLine(data);
        }
    }
}





