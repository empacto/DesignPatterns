using System;

namespace Proto2
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
             clone.Id = new Product().Id;
             clone.Name = string.Copy(Name);
             return clone;
        }


    }
}