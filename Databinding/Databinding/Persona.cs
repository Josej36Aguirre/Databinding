using System;
using System.Collections.Generic;
using System.Text;

namespace Databinding
{

    public class Persona:Notificable
    {
        #region atributos
        private string nombre;
        private string pais;
        #endregion

        #region propiedades
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set {
                if (saldo == value)
                {
                    return;
                }
                saldo = value;
                OnPropertyChanged();
            
             }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set {
                if (fechaNacimiento == value)
                {
                    return;
                }
                fechaNacimiento = value;
                OnPropertyChanged();

            }
           
        }



        public String Nombre
        {
            get { return nombre; }
            set {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged("Nombre");
                }
        }
       
        
        public String Pais
        {
            get { return pais; }
            set {
                if (nombre == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged("Pais");
            }
        }


        #endregion

        #region metodos
        public override string ToString()
        {
            return $"{Nombre} | {Pais}| {Saldo} | {FechaNacimiento}";
        }
        #endregion
    }
}
