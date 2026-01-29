public class InventoryServiceProxy : IInventoryService
{
    private InventoryService realService;

    private InventoryService RealService
    {
        get
        {
            if (realService == null)
            {
                realService = new InventoryService();
            }
            return realService;
        }
    }

    public bool CheckStock(string productId, int quantity)
    {
        return RealService.CheckStock(productId, quantity);
    }

    public void ReserveStock(string productId, int quantity)
    {
        RealService.ReserveStock(productId, quantity);
    }
}
