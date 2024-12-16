namespace ProductAPI.Models
{
    public class Product
    {
        public int Id { get; set; }           // Унікальний ідентифікатор
        public string Name { get; set; } = string.Empty;      // Назва товару 
        public string Description { get; set; } = string.Empty; // Опис
        public decimal Price { get; set; }   // Вартість
        public int Stock { get; set; }   // Кількість на складі
    }
}
