﻿namespace InventoryQuickCRUD.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
