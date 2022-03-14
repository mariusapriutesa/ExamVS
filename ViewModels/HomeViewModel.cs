using ExamVS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamVS.ViewModels
{
    class HomeViewModel:ViewModelBase
    {



        private bool panelCajaFuerte { set; get; }

        public bool PanelCajaFuerte
        {

            get { return panelCajaFuerte; }
            set
            {
                panelCajaFuerte = value;
                OnPropertyChanged(nameof(PanelCajaFuerte));
            }

        }
        private bool abrir { set; get; }

        public bool Abrir
        {

            get { return abrir; }
            set
            {
                abrir = value;
                OnPropertyChanged(nameof(Abrir));
            }

        }

        private string contraseña;
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; OnPropertyChanged(nameof(Contraseña)); }
        }


        private string pantalla;
        public string Pantalla
        {
            get { return pantalla; }
            set { pantalla = value; OnPropertyChanged(nameof(Pantalla)); }
        }

        private string funcionSeleccionada;
        public string FuncionSeleccionada
        {
            set { funcionSeleccionada = value; }
            get { return funcionSeleccionada; OnPropertyChanged(nameof(FuncionSeleccionada)); }
        }

        public ICommand NumerosCommand { get; set; }
        public ICommand FuncionesCommand { get; set; }

        public ICommand UpdateViewCommand { get; set; }


        public HomeViewModel()
        {
            Contraseña = "";
            Pantalla = "";
            FuncionSeleccionada = "";
            panelCajaFuerte = true;

            NumerosCommand = new NumerosCommand(this);
            FuncionesCommand = new FuncionesCommand(this);
            UpdateViewCommand = new UpdateViewCommand(this);

        }


    }
}
