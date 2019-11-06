using Delegate_Action_Func.Core;
using System.Text;

namespace Delegate_Action_Func.Domain
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public CustomerType CustomerType { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("--> Customer");
            stringBuilder.AppendLine($"Id: #{Id}");
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Address: {Address}");
            stringBuilder.AppendLine($"Type: {CustomerType}");
            stringBuilder.AppendLine();

            return stringBuilder.ToString();
        }
    }
}
