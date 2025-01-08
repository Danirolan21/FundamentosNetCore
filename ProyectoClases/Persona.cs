using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino, Otro }
    public enum Paises { España, Francia, Italia, Alemania, ReinoUnido }
    public class Persona
    {
        #region CONSTRUCTORES
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacío");
            this.Domicilio = new Direccion();
            this.DomicilioVacaciones = new Direccion();
        }
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA 2 parametros");
            this.Domicilio = new Direccion();
            this.DomicilioVacaciones = new Direccion();
        }
        #endregion

        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                Random random = new Random();
                int aleat = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + aleat;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }



        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get
            {
                return this._Genero;
            }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino &&
                    value != TipoGenero.Otro)
                {
                    throw new Exception("El genero no es correcto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        //CAMPO PRIVADO PARA LA EDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //DEBEMOS COMPROBAR EL VALOR DE LA EDAD
                //QUE VIENE EN value
                if ( value < 0)
                {
                    //SI NOS DAN UN VALOR INCORRECTO
                    //this._Edad = 0;
                    //LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    //TODO CORRECTO
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return "Nombre: " + this.Nombre + ", Apellidos: " + this.Apellidos;
        }
        public string GetNombreCompletoAlReves()
        {
            return "Apellidos: " + this.Apellidos + ", Nombre: " + this.Nombre;
        }
        public string GetNombreCompletoMayusculas()
        {
            return ("Nombre: " + this.Nombre + ", Apellidos: " + this.Apellidos).ToUpper();
        }
        public string GetNombreCompletoMinusculas()
        {
            return ("Nombre: " + this.Nombre + ", Apellidos: " + this.Apellidos).ToLower();
        }
        #endregion
    }
}
