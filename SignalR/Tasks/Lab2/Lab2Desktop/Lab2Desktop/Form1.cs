using Microsoft.AspNetCore.SignalR.Client;

namespace Lab2Desktop
{
    public partial class Form1 : Form
    {
        HubConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new HubConnectionBuilder().WithUrl("https://localhost:7100/chathub").Build();
            conn.StartAsync();
            conn.On<string>("desktopmessage", (message) =>
            {
                listBox1.Items.Add(message);
            });
        }

        private void btn_sendpublicmessage_Click(object sender, EventArgs e)
        {
            conn.InvokeAsync("SendDesktopMessage", tb_publicmessage.Text);
        }
    }
}
