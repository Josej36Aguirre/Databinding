using System;


namespace Databinding
{
    using System.Collections.ObjectModel;
   
    public class Datos: Notificable
    {
        private String personaSeleccionada;

   

        public Datos()
        {
            var aleatorio = new Random();
            personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = $"persona {i}",
                    Pais = $"Pais {i}",
                    FechaNacimiento = new DateTime(1980+i, i+1, 1),
                    Saldo = (decimal) (aleatorio.Next(100, 5000)*3.1416)
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
        public String PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                if (personaSeleccionada == value)
                {
                    return;
                }
                personaSeleccionada = value;
                OnPropertyChanged();

            }

        }

    }
}
