using System.Collections.Generic;
using lastproject.Shared.Models;



namespace lastproject.Client.Models
{
    public static class HC
    {
        public static List<Clothe> HCClothes = new List<Clothe>{};

        public static int Price()
        {
            int sum = 0;
            foreach (var clothe in HCClothes)
                sum += clothe.Price * clothe.number;
            return sum;
        }
    }
}