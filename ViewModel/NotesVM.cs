using NotesApp.Model;
using NotesApp.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.ViewModel
{
    public class NotesVM
    {
        public ObservableCollection<Notebook> Notebooks { get; set; }
		private Notebook notebook;

		public Notebook SelectedNotebook
		{
			get { return notebook; }
			set { notebook = value;
			//TODO: get notes
			}
		}

		public ObservableCollection<Note> Notes { get; set; }

		public NewNotebookCommand NewNotebookCommand { get; set; }

		public NewNoteCommand NewNoteCommand { get; set; }

		public NotesVM()
		{
			NewNotebookCommand = new NewNotebookCommand(this);
			NewNoteCommand = new NewNoteCommand(this);
		}

		public void CreateNote(int notebookId)
		{
			Note newNote = new Note()
			{
				NotebookId = notebookId,
				CreateTime = DateTime.Now,
				UpdatedTime = DateTime.Now,
				Title = "New note"
			};

			DatabaseHelper.Insert(newNote);
		}

		public void CreateNotebook()
		{
			Notebook newNotebook = new Notebook()
			{
				Name="New notebook"

			};
			DatabaseHelper.Insert(newNotebook);
		}

	}
}
