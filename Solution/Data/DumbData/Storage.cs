using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class Storage
    {
        static List<PersonalInfo> PersonalInfoes = new List<PersonalInfo>() 
        { 
            new PersonalInfo() {Id =0, FirstName = "Vasiliy0", LastName = "Vasilkov0", MiddleName = "Vasilievich0"},
            new PersonalInfo() {Id =1, FirstName = "Vasiliy1", LastName = "Vasilkov1", MiddleName = "Vasilievich1"},
            new PersonalInfo() {Id =2, FirstName = "Vasiliy2", LastName = "Vasilkov2", MiddleName = "Vasilievich2"},
            new PersonalInfo() {Id =3, FirstName = "Vasiliy3", LastName = "Vasilkov3", MiddleName = "Vasilievich3"},
            new PersonalInfo() {Id =4, FirstName = "Vasiliy4", LastName = "Vasilkov4", MiddleName = "Vasilievich4"},
            new PersonalInfo() {Id =5, FirstName = "Vasiliy5", LastName = "Vasilkov5", MiddleName = "Vasilievich5"},
            new PersonalInfo() {Id =6, FirstName = "Vasiliy6", LastName = "Vasilkov6", MiddleName = "Vasilievich6"},
            new PersonalInfo() {Id =7, FirstName = "Vasiliy7", LastName = "Vasilkov7", MiddleName = "Vasilievich7"},
            new PersonalInfo() {Id =8, FirstName = "Vasiliy8", LastName = "Vasilkov8", MiddleName = "Vasilievich8"},
            new PersonalInfo() {Id =9, FirstName = "Vasiliy9", LastName = "Vasilkov9", MiddleName = "Vasilievich9"},
        };

        static List<Player> Players = new List<Player>() 
        { 
            new Player() {Id = 0},
            new Player() {Id = 1},
            new Player() {Id = 2},
            new Player() {Id = 3},
            new Player() {Id = 4},
            new Player() {Id = 5},
            new Player() {Id = 6},
            new Player() {Id = 7},
            new Player() {Id = 8},
            new Player() {Id = 9},
        };
}
