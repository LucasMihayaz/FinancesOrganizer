﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinancesOrganizer.Models.DTOS
{
    public class UpdateRecipeDTO
    {

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório")]
        public Double Value { get; set; }

        [Required(ErrorMessage = "O campo data é obrigatório")]
        public DateTime Date { get; set; }
    }
}
