using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class Dog
    {
        private int age;
        private double legs;

        public int Id { get; set; } = Controllers.DogController.dogsList.Count + 1;
        public int Age
        {
            get => age;
            set
            {
                if (value < 0 ) value = 0;
                age = value;
            }
        }
        public string Name { get; set; } = "";
        public double Legs
        {
            get => legs;
            set
            {
                if (value < 0) value = 0;
                legs = value;
            }
        }

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