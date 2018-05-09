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
            return $"{Nombre} | {Pais}";
        }
        #endregion
    }
}
