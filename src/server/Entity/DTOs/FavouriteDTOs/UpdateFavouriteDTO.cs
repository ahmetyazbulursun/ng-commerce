﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.FavouriteDTOs
{
    public class UpdateFavouriteDTO
    {
        public int ProductId { get; set; }
        public int AppUserId { get; set; }
    }
}
