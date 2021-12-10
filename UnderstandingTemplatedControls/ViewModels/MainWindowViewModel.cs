using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnderstandingTemplatedControls.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private string? _File1;

        /// <summary>
        ///   Validation using exception
        /// </summary>
        public string? File1
        {
            get { return _File1; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                else
                {
                    this.RaiseAndSetIfChanged(ref _File1, value);
                }
            }
        }



        private string? _File2;

        /// <summary>
        ///   Validation using DataAnnotation
        /// </summary>
        [Required]
        [StringLength(10)]
        [CustomValidation (typeof(MainWindowViewModel), nameof(MyValidation))]
        public string? File2
        {
            get { return _File2; }
            set { this.RaiseAndSetIfChanged(ref _File2, value); }
        }


        public static ValidationResult? MyValidation(object? value, ValidationContext validationContext)
        {
            if (value?.ToString() == "error")
            {
                return new ValidationResult("You should type something ...");
            }
            return ValidationResult.Success;
        }

        public OtherViewModel OtherViewModel { get; } = new();
    }
}