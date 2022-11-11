using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Persona
{
    int ID;
    string Nombre;
    string Direccion;
    long telefono;


    public Persona(int id, string nombre, string direccion, long telefono)
    {
        this.ID = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.telefono = telefono;
    }

    public int getID()
    {
        return (this.ID);
    }
}

