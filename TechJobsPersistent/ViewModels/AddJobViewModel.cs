using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        [Required(ErrorMessage = "Employer Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ID is required")]
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }

        public List<Skill> Skills { get; set; }  
        public AddJobViewModel(List<Employer> employerList, List<Skill>skills)
          
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in employerList)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
            Skills=skills;
        }
        public AddJobViewModel() { }
    }
}
