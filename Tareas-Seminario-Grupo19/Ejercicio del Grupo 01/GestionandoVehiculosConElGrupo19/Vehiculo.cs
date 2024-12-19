using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionandoVehiculosConElGrupo19
{
    public class Vehiculo
    {
        public string NombreDueno { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public Vehiculo(string nombreDueno, int ano, string marca, decimal precio, string descripcion)
        {
            NombreDueno = nombreDueno;
            Ano = ano;
            Marca = marca;
            Precio = precio;
            Descripcion = descripcion;
        }

       
        public override string ToString()
        {
            return $"Dueño: {NombreDueno}, Año: {Ano}, Marca: {Marca}, Precio: {Precio:C}, Descripción: {Descripcion}";
        }
    }

    public class Auto : Vehiculo
    {

        // Constructor que llama al constructor base
        public Auto(string nombreDueno, int ano, string marca, decimal precio, string descripcion)
            : base(nombreDueno, ano, marca, precio, descripcion)
        {
        }


        public override string ToString()
        {
            return $"Tipo: Auto, Dueño: {NombreDueno}, Año: {Ano}, Marca: {Marca}, Precio: {Precio:C}, Descripción: {Descripcion}";
        }
    }

    public class Moto : Vehiculo
    {

        // Constructor que llama al constructor base
        public Moto(string nombreDueno, int ano, string marca, decimal precio, string descripcion)
            : base(nombreDueno, ano, marca, precio, descripcion)
        {
        }

        
        public override string ToString()
        {
            return $"Tipo: Moto, Dueño: {NombreDueno}, Año: {Ano}, Marca: {Marca}, Precio: {Precio:C}, Descripción: {Descripcion}";
        }
    }


}
