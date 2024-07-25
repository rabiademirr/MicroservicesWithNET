namespace TrainingCourses.Services.Basket.Dtos
{
    public class BasketDto
	{

		public string UserId { get; set; }

		public string CouponCode { get; set; }

		public List<BasketItemDto> BasketItems { get; set; }

		public decimal TotalPice {
			get => BasketItems.Sum(x => x.Price * x.Quantity);
			 }
	}
}

