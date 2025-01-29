﻿using DAM_Leccion_EZC.Model;

namespace DAM_Leccion_EZC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void Ejecutar()
        {
            PersonaModel personaModel = new PersonaModel();

            personaModel.Nombre = "Hola aqui estoy";


            txtNombre.Text = personaModel.Nombre;
        }

        private void btnAceptar_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD", "Aceptar");
        }
    }

}
