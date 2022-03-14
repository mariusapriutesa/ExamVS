using ExamVS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamVS.Commands
{
    internal class FuncionesCommand : ICommand
    {
        private string secreto = "1234";
        private int intentos = 0;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {

            return true;
            

        }

        public void Execute(object parameter)
        {
            if (parameter is string)
            {
                string funcion = (string)parameter;

                if (funcion.Equals("C") )
                {

                    homeViewModel.Abrir = false;
                    homeViewModel.Contraseña = "";
                    homeViewModel.Pantalla = "";
                    homeViewModel.FuncionSeleccionada = "";


                }
                else if (funcion.Equals("OK"))
                { 
                    
                    if(homeViewModel.Contraseña.Equals(secreto))
                    {
                        homeViewModel.Pantalla = "CORRECTO!";
                        homeViewModel.Abrir = true;

                    }
                    else
                    {
                        intentos++;
                        homeViewModel.Pantalla = "";
                        homeViewModel.Pantalla = "Error. Intento: " + intentos;
                        
                        homeViewModel.Contraseña = "";


                        if(intentos > 2){

                            homeViewModel.Pantalla = "BLOQUEADA";
                            homeViewModel.PanelCajaFuerte = false;
                        }

                    }




                }


               

            }




        }


        public HomeViewModel homeViewModel { get; set; }
        public FuncionesCommand(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }

    }
}
