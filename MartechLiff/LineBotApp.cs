using Line.Messaging;
using Line.Messaging.Webhooks;
using System.Threading.Tasks;

namespace MartechLiff
{
    internal class LineBotApp : WebhookApplication
    {
        private LineMessagingClient messagingClient { get; }

        public LineBotApp(LineMessagingClient lineMessagingClient)
        {
            this.messagingClient = lineMessagingClient;
        }

        protected override async Task OnFollowAsync(FollowEvent ev)
        {
            var userName = "";
            if (!string.IsNullOrEmpty(ev.Source.Id))
            {
                var userProfile = await messagingClient.GetUserProfileAsync(ev.Source.Id);
                userName = userProfile?.DisplayName ?? "";
            }

            await messagingClient.ReplyMessageAsync(ev.ReplyToken, $"Hello {userName}! Thank you for following !");
        }

        protected override async Task OnUnfollowAsync(UnfollowEvent ev)
        {
            // Remote source information which unfollows the bot.
            //await sourceState.DeleteAsync(ev.Source.Type.ToString(), ev.Source.Id);
        }

        protected override async Task OnJoinAsync(JoinEvent ev)
        {
            await messagingClient.ReplyMessageAsync(ev.ReplyToken, $"Thank you for letting me join your {ev.Source.Type.ToString().ToLower()}!");
        }
    }
}