using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTemplatedControls.ViewModels
{
    public class OtherViewModel : ViewModelBase
    {

        private string? _OtherFile;

        /// <summary>
        /// Just a sample property
        /// </summary>
        [Required]
        [MinLength(5)]
        public string? OtherFile
        {
            get { return _OtherFile; }
            set { this.RaiseAndSetIfChanged(ref _OtherFile, value); }
        }
    }
}
