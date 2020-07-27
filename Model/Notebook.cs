using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    public class Notebook: INotifyPropertyChanged
    {
		private int id;

		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get { return id; }
			set { id = value;
				OnPropertyChanged("Id");
			}
		}
		private int userid;

		//index denotes it is foreign key
		[Indexed]
		public int UserId
		{
			get { return userid; }
			set { userid = value;
				OnPropertyChanged("UserId");
			}
		}

		private string name;

		public event PropertyChangedEventHandler PropertyChanged;

		public string Name
		{
			get { return name; }
			set { name = value;
				OnPropertyChanged("Name");
			}
		}

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}


	}
}
