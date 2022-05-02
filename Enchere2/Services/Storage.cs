using System;
using Xamarin.Essentials;

namespace Enchere2.Services
{
    public static class Storage
    {
        public static async void StockerId(string id)
        {
            try
            {
                await SecureStorage.SetAsync("ID", id);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
