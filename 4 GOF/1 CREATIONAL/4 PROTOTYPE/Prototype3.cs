using System;

namespace Proto3
{
    public class Product
    {
        public string  Name { get; set; }
        public string description { get; set; }

        public Product ShallowCopy()
        {
            return (Product)this.MemberwiseClone();
        }
        public Product DeepCopy()
        {
            Product clone = (Product)this.MemberwiseClone();
            clone.Name = string.Copy(Name);
            clone.description = string.Copy(description);
            return clone;
        }
    }
}