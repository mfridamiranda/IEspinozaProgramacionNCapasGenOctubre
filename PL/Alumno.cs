﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Alumno
    {
        public static void Add()
        {
            ML.Alumno alumno = new ML.Alumno(); //Instancia

            Console.WriteLine("Por favor ingrese los datos del alumno");
            Console.WriteLine("Nombre: ");
            alumno.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno: ");
            alumno.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno: ");
            alumno.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha Nacimiento (dd-MM-yyyy): ");
            alumno.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Genero (M-F):  ");
            alumno.Genero = Console.ReadLine();

            Console.WriteLine("Ingrese el semestre:  ");
            alumno.Semestre = new ML.Semestre();
            alumno.Semestre.IdSemestre = byte.Parse(Console.ReadLine());
            //alumno.Genero = char.Parse(Console.ReadLine());

            //llenamos el objeto de informacion 

            //ML.Result result = BL.Alumno.Add(alumno);//Query
            //ML.Result result = BL.Alumno.AddSP(alumno);//SP
            ML.Result result = BL.Alumno.AddLINQ(alumno);//EF

            if (result.Correct)
            {
                Console.WriteLine("Mensaeje: "+ result.Message);
            }
        }

        public static void GetAll()
        {
            //ML.Result result = BL.Alumno.GetAll();
            //ML.Result result = BL.Alumno.GetAllEF();
            ML.Result result = BL.Alumno.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Alumno alumno in result.Objects)
                {
                    Console.WriteLine("El id del alumno es:" + alumno.IdAlumno);
                    Console.WriteLine("El nombre del alumno es:" + alumno.Nombre);
                    Console.WriteLine("El apellido paterno del alumno es:" + alumno.ApellidoPaterno);
                    Console.WriteLine("El apellido materno del alumno es:" + alumno.ApellidoMaterno);
                    Console.WriteLine("La fecha de nacimiento del alumno es:" + alumno.FechaNacimiento);
                    Console.WriteLine("El genero del alumno es:" + alumno.Genero);
                    Console.WriteLine("El Semestre del alumno es:" + alumno.Semestre.IdSemestre);
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
        }

        public static void GetById()
        {
            ML.Alumno alumno = new ML.Alumno(); //Instancia



            Console.WriteLine("Por favor ingrese el id del alumno");
            Console.WriteLine("IdAlumno: ");
            alumno.IdAlumno = int.Parse(Console.ReadLine());
            //ML.Result result = BL.Alumno.GetById(alumno.IdAlumno);
            ML.Result result = BL.Alumno.GetByIdEF(alumno.IdAlumno);

            if (result.Correct)
            {
                alumno = (ML.Alumno)result.Object; // unboxing 

                Console.WriteLine("El id del alumno es:" + alumno.IdAlumno);
                Console.WriteLine("El nombre del alumno es:" + alumno.Nombre);
                Console.WriteLine("El apellido paterno del alumno es:" + alumno.ApellidoPaterno);
                Console.WriteLine("El apellido materno del alumno es:" + alumno.ApellidoMaterno);
                Console.WriteLine("La fecha de nacimiento del alumno es:" + alumno.FechaNacimiento);
                Console.WriteLine("El genero del alumno es:" + alumno.Genero);
                Console.WriteLine("El Semestre del alumno es:" + alumno.Semestre.IdSemestre);
                Console.WriteLine("----------------------------------------------------------");

            }
        }
    }
}
