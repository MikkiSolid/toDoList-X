using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoForMobile
{
    class MainViewModel
    {
        public ObservableCollection<Task> Tasks { get; set; }
        private int index;
        public ICommand addTask { get; set; }
        public ICommand deleteTask { get; set; }
        public MainViewModel()
        {
            Tasks = new ObservableCollection<Task>()
            {   new Task ("123"),
                new Task ("asdcsdasda"),
                new Task ("zxczxcz"),
                new Task ("cvs"),
            };

            addTask = new Command<string>(
                execute: (x) =>
                {
                    Tasks.Add(new Task(x));
                },
                canExecute: (x) =>
                {
                    return true;
                });

            deleteTask = new Command<Task>(
                execute: (x) =>
                {
                    Tasks.Remove(x);
                },
                canExecute: (x) =>
                {
                    return true;
                });
        }


    }

    public class Task
    {
        public string Title { get; set; }
        public bool Done { get; set; }
        public Task(string Title)
        {
            this.Title = Title;
            this.Done = false;
        }
    }
}
