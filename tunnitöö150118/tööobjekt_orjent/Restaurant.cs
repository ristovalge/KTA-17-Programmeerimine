using System;

namespace tööobjekt_orjent
{
    internal class Restaurant
    {

        private string _name;
        private string _aadress;

        public Restaurant(string name, string aadress)
        {
            this._name = name;
            this._aadress = aadress;
        }

        internal Receipt GetReceipt(Tab tab)
        {
            return new Receipt(_name, _aadress, tab);
        }
    }
}