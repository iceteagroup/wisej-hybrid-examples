using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace FeaturesShared.Panels
{
	[Category("Media")]
	public partial class Chat : TestBase
	{
		private static User _bot = new User("1", "Bot", "resource.wx/wisej-red.png");

		private static event EventHandler<Message> NewMessage;

		private Random _rand = new Random();

		private User _me = null;

		public Chat()
		{
			InitializeComponent();
		}

		private async void Chat_Appear(object sender, EventArgs e)
		{
			// listen for new messages.
			NewMessage += Chat_NewMessage;

			// initialize user.
			if (_me == null)
			{
				// random id.
				var id = _rand.Next(10000);

				// prompt name.
				string name;
				if (Device.Valid)
				{
					name = Device.Popups.DisplayPrompt("Enter Chat", "Enter Username", initialValue: $"User{id}");
				}
				else
				{
					name = await Application.PromptAsync("Enter a username", $"User{id}");
				}

				// add to chat.
				if (!string.IsNullOrEmpty(name)) 
				{
					this._me = new User(id.ToString(), name, "resource.wx/wisej-blue.png");
					this.chatBox1.User = this._me;

					NewMessage?.Invoke(this, new Message($"{name} has entered the chat.", user: _bot));

					this.chatBox1.SendMessage += ChatBox1_SendMessage;
				}
			}
		}

		private void ChatBox1_SendMessage(SendMessageEventArgs e)
		{
			e.Cancel = true;

			NewMessage?.Invoke(this, e.Message);
		}

		private void Chat_NewMessage(object? sender, Message e)
		{
			Application.Update(this, () =>
			{
				this.chatBox1.DataSource.Add(e);
			});
		}

		public override bool IsSupported()
		{
			// only run this example when connected to a remote web server.
			return Application.StartupUri.Host != "localhost";
		}

		private void Chat_Disappear(object sender, EventArgs e)
		{
			NewMessage -= Chat_NewMessage;
			this.chatBox1.DataSource.Clear();
		}
	}
}
