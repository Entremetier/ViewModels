using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModel
{
    public class DogFurViewModel
    {
        public Dog DogAdress { get; set; }
        public Fur FurAdress { get; set; }
        public DateTime Timestamp { get; set; }
    }
}