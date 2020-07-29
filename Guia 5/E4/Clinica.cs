using System;
using System.Collections.Generic;
using System.Linq;
namespace E4
{
    public class Clinica
    {
        List<Medico> medicos=new List<Medico>();
        public void consulta(string espe)
        {
            medicos.Add(new Medico("Franco","Fernandez","cardeologo",3));
            medicos.Add(new Medico("Federico","Aranzabal","psiquiatra",50));
            medicos.Add(new Medico("Fabian","Gardeazabal","neurologo",51));
            medicos.Add(new Medico("Francisco","Sozaki","nutricionista",37));
            medicos.Add(new Medico("Fabrizio","Aguilar","traumatologo",40));
            medicos.Add(new Medico("Facundo","Cardozo","pediatra",90));
            medicos.Add(new Medico("Finn","Iraola","radiologia",4));
            medicos.Where(medicos=>medicos.Especialidad==espe&&true==medicos.Estadisponible()).ToList().ForEach(medicos=>Console.WriteLine("El medico "+medicos.Nombre+" lo atendera"));
            medicos.Where(medicos=>medicos.Especialidad==espe&&false==medicos.Estadisponible()).ToList().ForEach(medicos=>Console.WriteLine("intente de nuevo más tarde"));
        }
    }
}