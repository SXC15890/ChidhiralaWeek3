using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

// Created By Chidhirala

namespace ChidhiralaWeek3.Models
{
    public class RealEstateModel
    {
        private readonly int _bedValueAdd = 25000;
        private readonly int _bathValueAdd = 20000;
        private readonly decimal _areaValue = 159; // per Sqaure Feet

        public decimal HomeValue {  get; set; } // where home value is calculated

        /*
         * properties have data annotation validations
         */

        [Required(ErrorMessage ="Please Enter Your Name")]
        public String? Name { get; set; }

        [Required(ErrorMessage ="Enter Area in Square Feet")]
        [Range((double)500, (double)9999, ErrorMessage ="Square Foot should be between 500 and 9999")]
        public decimal Area { get; set;}

        [Required(ErrorMessage = "Please select number of bath rooms")]
        [Range(2, 5, ErrorMessage = "Number of baths must be between 2 and 5")]
        public int Baths { get; set; }

        //property for select dropdown
        [Required(ErrorMessage = "Please select number of bed rooms")]
        [Range(1, 7, ErrorMessage = "Number of baths must be between 1 and 7")]
        public int BedRooms { get; set; }

        // under lying list supporting the dropdown list items/ options
        public List<SelectListItem> BedRoomList { get; set; } = new() { 
            new SelectListItem { Value = " ", Text = " " } ,
            new SelectListItem { Value = "1", Text = "One (1)" } ,
            new SelectListItem { Value = "2", Text = "Two (2)" } ,
            new SelectListItem { Value = "3", Text = "Three (3)" } ,
            new SelectListItem { Value = "4", Text = "Four (4)" } ,
            new SelectListItem { Value = "5", Text = "Five (5)" } ,
            new SelectListItem { Value = "6", Text = "Six (6)" } ,
            new SelectListItem { Value = "7", Text = "Seven (7)" } ,
        };

        public void CalculateHomeValue()
        {
            HomeValue = (Area * _areaValue) + (BedRooms * _bedValueAdd) + (Baths * _bathValueAdd);
        }

    }
}
