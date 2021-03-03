using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentWebApp.DAL.Gateway;
using StudentWebApp.DAL.Models;
using StudentWebApp.DAL.Models.ViewModels;
using StudentWebApp.Utility;

namespace StudentWebApp.BLL
{
    public class StudentManager
    {
        private StudentGateway studentGateway = new StudentGateway();
        public string Save(Student student)
        {
            if (studentGateway.IsRegNoExists(student.RegNo))
            {
                return "RegNo Already Exists";
            }
            else
            {
                int rowAffect = studentGateway.Save(student);

                if (rowAffect > 0)
                {
                    return ConstMessage.SaveSuccessful;
                }
                else
                {
                    return "Save Failed";
                }            
            }          
        }

        public List<StudentViewModel> GetAllStudents()   
        {
            return studentGateway.GetAllStudents();
        }


        public Student GetStudentById(int id)
        {
            return studentGateway.GetStudentById(id);
        }

        public string UpdateById(Student student)
        {                                  
                int rowAffect = studentGateway.UpdateById(student);

                if (rowAffect > 0)
                {
                    return "Update Successful";
                }
                else
                {
                    return "Update Failed";
                }
                 
        }

        public string DeleteById(int id)
        {
            int rowAffect = studentGateway.DeleteById(id);

            if (rowAffect > 0)
            {
                return "Delete Successful";
            }
            else
            {
                return "Delete Failed";
            }
        }

    }
}