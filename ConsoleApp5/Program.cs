using System.Text.Json;
namespace ConsoleApp5
{

    class Purchase
    {
        public string? ProductName {  get; set; }   
        public DateTime DateTime { get; set; }
        public decimal PriductPrice {  get; set; }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
            var purchaseJson =  File.ReadAllText("purchase.json");
            Purchase purchase = JsonSerializer.Deserialize<Purchase>(purchaseJson);
        }
    }
}