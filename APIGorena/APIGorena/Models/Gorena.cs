namespace APIGorena.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public enum typeplace
    {
        Registro1 = 10,
        Registro2 = 20,
        Registro3 = 30,
        Registro4 = 40,
        Registro5 = 50
    }
    public class Gorena
    {
        [Key]
        public int GorenaID { get; set; }

        [StringLength(24, ErrorMessage = "The filed {0} must contain between {2} and {1} characters.")]
        [Required(ErrorMessage = "You must enter your full name {0}")]
        public string FriendOfGorena { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del producto")]
        public typeplace Place { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }


      

    }
}