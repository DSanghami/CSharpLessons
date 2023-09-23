using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWind.Models
{
    public class OrderIdViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIdViewModel(List<int> orderIds)
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (var no  in orderIds)
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }


    }
}
