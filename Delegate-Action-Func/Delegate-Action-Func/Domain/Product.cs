using System.Text;

namespace Delegate_Action_Func.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("--> Product");
            stringBuilder.AppendLine($"Id: #{Id}");
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Price: {Price}");
            stringBuilder.AppendLine($"Discount: {Discount}");

            return stringBuilder.ToString();
        }
    }
}
