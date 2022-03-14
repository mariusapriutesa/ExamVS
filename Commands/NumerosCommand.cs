using ExamVS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamVS.Commands
{
    internal class NumerosCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {

            return true;


        }

        public void Execute(object parameter)
        {


            if (parameter is string)
            {

                string numero = parameter.ToString();

                if (homeViewModel.FuncionSeleccionada.Equals("") )
                {
                    if(homeViewModel.Contraseña.Length < 4)
                    {
                        homeViewModel.Contraseña = homeViewModel.Contraseña + numero;
                        homeViewModel.Pantalla =   homeViewModel.Pantalla + "*";

                    }
                   


                }
                
            }



        }

        public HomeViewModel homeViewModel { get; set; }
        public NumerosCommand(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
    }
}
