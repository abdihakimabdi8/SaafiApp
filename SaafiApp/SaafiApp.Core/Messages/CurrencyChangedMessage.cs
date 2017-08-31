using MvvmCross.Plugins.Messenger;
using SaafiApp.Core.Model;

namespace SaafiApp.Core.Messages
{
    public class CurrencyChangedMessage : MvxMessage
    {
        public CurrencyChangedMessage(object sender) : base(sender)
        {
        }

        public Currency NewCurrency { get; set; }
    }
}