using MVPParteSofi.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.SearchHandlers
{
    public class PacienteSearchHandler : SearchHandler
    {

        public IList<PacienteData> Pacientes { get; set; }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Pacientes.Where(paciente => paciente.PacienteName.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
        }
    }
}
