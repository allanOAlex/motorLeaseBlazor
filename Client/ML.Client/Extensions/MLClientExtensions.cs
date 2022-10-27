using BlazorStrap;
using Radzen;

namespace ML.Client.Extensions
{
    public static class MLClientExtensions
    {
        private static readonly NotificationService notificationService;
        public static async Task ShowModal(BSModal modal)
        {
            await modal.ShowAsync();
        }

        public static async Task HideModal(BSModal modal)
        {
            await modal.HideAsync();
        }

        public static void ShowNotification(NotificationMessage message)
        {
            notificationService.Notify(message);
        }
    }
}
