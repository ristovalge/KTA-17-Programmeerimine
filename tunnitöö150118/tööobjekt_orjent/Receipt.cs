using System.Linq;
using System.Text;


namespace tööobjekt_orjent
{
    internal class Receipt
    {
        private string _restarauntName;
        private string _restarauntAdress;
        private Tab _tab;

        public Receipt(string restarauntName, string restarauntAddress, Tab tab)
        {
            this._restarauntName = restarauntName;
            this._restarauntAdress = restarauntAddress;
            this._tab = tab;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this._restarauntName);
            sb.AppendLine(this._restarauntAdress);

            sb.AppendLine("-------------------------");
            foreach (var entry in _tab.Entries)
            {
                sb.AppendLine($"Price of food item: {entry}");
            }
            sb.AppendLine("-------------------------");


            sb.AppendLine($"Subtotal: €{_tab.Entries.Sum():f2}");
            sb.AppendLine($"15% Gratuity: €{_tab.Entries.Sum() * 0.15:f2}");
            sb.AppendLine($"Total: €{_tab.Entries.Sum() * 0.85:f2}");

            return sb.ToString();
        }
    }
}