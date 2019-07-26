using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// execute field
        /// </summary>
        private readonly Action<object> execute;

        /// <summary>
        /// Can Execute
        /// </summary>
        private readonly Predicate<object> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">Action object </param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute"> action object for the command </param>
        /// <param name="canExecute">predicate object for the command </param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Event when can execute changed
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Get or Sets if can Execute
        /// </summary>
        /// <param name="parameter"> object parameter</param>
        /// <returns>return if can execute the command</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null ? true : this.canExecute(parameter);
        }

        /// <summary>
        /// execute the operation
        /// </summary>
        /// <param name="parameter">object argument for the method</param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
