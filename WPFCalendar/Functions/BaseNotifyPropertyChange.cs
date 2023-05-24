using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalendar.Functions
{
    /// <summary>
    /// Centraliza os eventos.
    /// Classe abstrata com implementação de NotifyPropertyChange.
    /// </summary>
    public abstract class BaseNotifyPropertyChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Determina qual propriedade foi alterada e se o valor é diferente, utilizando uma referência do mesmo para finalizar a alteração.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        protected void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "NoName")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Invoca o PropertyChanged para a propriedade específica.
        /// </summary>
        /// <param name="propertyName">Nome da propriedade alvo</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
