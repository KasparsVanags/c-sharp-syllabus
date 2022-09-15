namespace VendingMachine
{
    public static class ProductValidator
    {
        public static bool Validate(Product product)
        {
            return !string.IsNullOrEmpty(product.Name) &&
                   product.Price.GetNumericValueInCents() > 0 &&
                   product.Available >= 0;
        }
    }
}