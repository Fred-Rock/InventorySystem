using System;
using System.Collections.Generic;

public static class InventoryEventHandler
{
    // Inventory updated event
    public static event Action<InventoryLocation, List<InventoryItem>> InventoryUpdatedEvent;

    public static void CallInventoryUpdatedEvent(InventoryLocation inventoryLocation, List<InventoryItem> inventoryList)
    {
        if (InventoryUpdatedEvent != null)
        {
            InventoryUpdatedEvent(inventoryLocation, inventoryList);
        }
    }

    // Item traded event
    public static event Action ItemTradedEvent;

    public static void CallItemTradedEvent()
    {
        if (ItemTradedEvent != null)
        {
            ItemTradedEvent();
        }
    }
}
