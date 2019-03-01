using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "~~換成你自己的channelAccessToken~~";
        const string AdminUserId= "~~換成你自己的User Id~~";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            isRock.LineBot.TextMessage msg = new TextMessage($"測試 {DateTime.Now.ToString()} ! ");
            msg.quickReply.items.Add(
                new isRock.LineBot.QuickReplyPostbackAction("顯示的文字", "abc=123&def=456", "", ""));
            bot.PushMessage(AdminUserId, msg);
            //Response.Write(msg.ToJSON());
        }
    }
}