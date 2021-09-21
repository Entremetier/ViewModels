using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public int Age { get; set; } = 0;
        public string Name { get; set; } = "";
        public double Legs { get; set; } = 4;

        //FellId ist der Fremdschlüssel für das Fell
        public int FurId { get; set; } = -1;
        public bool IsActive { get; set; } = true;
    }

    public class Fur
    {
        public int Id { get; set; }
        public ColorEnum Color { get; set; }
        public bool Active { get; set; } = true;
    }

    public enum ColorEnum
    {
        Braun, Schwarz, Orange, Andere
    }
}