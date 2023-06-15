using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using DapperExercise;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

//var repo = new DepartmentRepo(conn);

//Console.Write("Type a new Department name: ");

//var newDepartment = Console.ReadLine();

//repo.InsertDepartment(newDepartment);

//var departments = repo.GetAllDepartments();

//foreach(var department in departments)
//{
//    Console.WriteLine($"{department.Name} | {department.DepartmentID}");
//}

var repo = new DapperProductRepo(conn);

//repo.CreateProduct("Diablo 4", 60.00, 1);
//repo.DeleteProduct(942);
//repo.UpdateProductName(943, "Banana");

var products = repo.GetAllProducts();

foreach(var product in products)
{
    Console.WriteLine($"{product.Name} | {product.Price} | {product.ProductID}");
}
