using System;

namespace Proto4
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product ShallowCopy()
        {
         return (Product)this.MemberwiseClone();            
        }

        public Product DeepCopy()
        {
            Product clone = (Product)this.MemberwiseClone();
            clone.Name = string.Copy(Name);
            return clone;
        }

    }
}