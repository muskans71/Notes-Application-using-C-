﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotesApp.ViewModel.Commands
{
    public class RegisterCommand : ICommand
    {
        public LoginVM Vm { get; set; }
        public event EventHandler CanExecuteChanged;


        public RegisterCommand(LoginVM vm)
        {
            Vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //todo
        }

        
    }
}
