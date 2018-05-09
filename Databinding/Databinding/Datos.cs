using System;
using System.Collections.Generic;

using System.Text;

namespace Databinding
{
    using System.Collections.ObjectModel;
   
    public class Datos: Notificable
    {
        public Datos()
        {
            personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = $"persona {i}",
                    Pais = $"Pais {i}"
                });
            }
        }

        private ObservableCollection<Persona> personas;
       
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }

            set {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
                
                
            }
        }

       
    }
}
