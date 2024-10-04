using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestConsolaBD;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // Ejecutar una consulta SQL para obtener todos los usuarios
            var sql = "SELECT * FROM Users";
            var users = context.Users.FromSqlRaw(sql).ToList();
            Console.WriteLine("----- Usuarios -----");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.ID}, Username: {user.Username}, Email: {user.Email}, Height: {user.Height}, Weight: {user.Weight}, ObjectiveID: {user.ObjectiveID}");
            }

            // Consultar todos los objetivos usando SQL
            var sqlObjectives = "SELECT * FROM Objectives";
            var objectives = context.Objectives.FromSqlRaw(sqlObjectives).ToList();
            Console.WriteLine("----- Objetivos -----");
            foreach (var objective in objectives)
            {
                Console.WriteLine($"ID: {objective.ID}, GoalWeight: {objective.GoalWeight}");
            }

            // Consulta de comidas
            var sqlMeals = "SELECT * FROM Meals";
            var meals = context.Meals.FromSqlRaw(sqlMeals).ToList();
            Console.WriteLine("----- Comidas -----");
            foreach (var meal in meals)
            {
                Console.WriteLine($"ID: {meal.ID}, Name: {meal.Name}, Kcal: {meal.Kcal}, UserID: {meal.UserID}");
            }
        }
    }
}
