using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StudentWebApp.DAL.Models;
using StudentWebApp.DAL.Models.ViewModels;

namespace StudentWebApp.DAL.Gateway
{
    public class StudentGateway : BaseGateway
    {
      
        public int Save(Student student)
        {
            string query = "INSERT INTO Students(RegNo, Name, Email, Address, DepartmentId) VALUES(@regNo,@name,@email,@address,@departmentId)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@regNo", student.RegNo);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@address", student.Address);
            command.Parameters.AddWithValue("@departmentId", student.DepartmentId);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

        public bool IsRegNoExists(string regNo)
        {
            string query = "SELECT * FROM Students WHERE RegNo = @regNo";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@regNo", regNo);
            connection.Open();
            reader = command.ExecuteReader();
            bool isExists = reader.HasRows;
            connection.Close();
            return isExists;

        }

        public List<StudentViewModel> GetAllStudents()
        {
            string query = "SELECT * FROM StudentView";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();

            List<StudentViewModel> studentViewModelList = new List<StudentViewModel>();

            while (reader.Read())
            {
                StudentViewModel studentViewModel = new StudentViewModel();
                studentViewModel.Id = Convert.ToInt32(reader["Id"]);
                studentViewModel.RegNo = reader["RegNo"].ToString();
                studentViewModel.StudentName = reader["StudentName"].ToString();
                studentViewModel.Email = reader["Email"].ToString();
                studentViewModel.Address = reader["Address"].ToString();
                studentViewModel.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                studentViewModel.DepartmentName = reader["DepartmentName"].ToString();
                studentViewModel.Code = reader["Code"].ToString();

                studentViewModelList.Add(studentViewModel);
            }
            connection.Close();

            return studentViewModelList;
        }


        public Student GetStudentById(int id)
        {
            string query = "SELECT * FROM Students WHERE Id = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            reader = command.ExecuteReader();
            Student student = null;
            reader.Read();
            if (reader.HasRows)
            {
                student = new Student();
                student.Id = Convert.ToInt32(reader["Id"]);
                student.RegNo = reader["RegNo"].ToString();
                student.Name = reader["Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
            }                        
            connection.Close();
            return student;
        }

        public int UpdateById(Student student)
        {
            string query = "Update Students Set Name=@name, Address=@address, DepartmentId=@departmentId Where Id=@id ";
            command=new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@address", student.Address);
            command.Parameters.AddWithValue("@departmentId", student.DepartmentId);
            command.Parameters.AddWithValue("@id", student.Id);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();
            return rowEffect;
        }

        public int DeleteById(int id)
        {
            string query = "DELETE FROM Students WHERE Id=@id ";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);           
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();
            return rowEffect;
        }

    }
}