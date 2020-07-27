using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotesApp.ViewModel
{
    public class NewNotebookCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public NotesVM VM { get; set; }

        public NewNotebookCommand(NotesVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.CreateNotebook();
            //TODo
        }
    }
}
