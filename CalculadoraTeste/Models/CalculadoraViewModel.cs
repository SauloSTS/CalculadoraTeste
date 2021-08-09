using System.ComponentModel.DataAnnotations;

namespace CalculadoraTeste.Models
{
    public class CalculadoraViewModel
    {
        /// <summary>
        /// Primeiro número do calculo
        /// </summary>
        [Display(Name ="Numero 1")]
        public int Num1 { get; set; }
        /// <summary>
        /// segundo número do calculo
        /// </summary>
        [Display(Name = "Numero 2")]
        public int Num2 { get; set; }
        /// <summary>
        /// Tipo de operador( + - * / ) que vai ser realizado
        /// </summary>
        public string Operador { get; set; }
        /// <summary>
        /// Resultado da operação
        /// </summary>
        public int Resultado { get; set; }
    }
}