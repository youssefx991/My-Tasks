using Microsoft.AspNetCore.SignalR.Client;

namespace chatapp
{
    public partial class Form1 : Form
    {
        HubConnection con;
        public Form1()
        {
            InitializeComponent();
             con = new HubConnectionBuilder().WithUrl("http://localhost:5015/mychat").Build();
            con.StartAsync();
            con.On<data>("newmessage", (d) => lb_mess.Invoke(() => lb_mess.Items.Add(d.name + ":" + d.messagebody)));
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("sendmessage", new data() { name = "desktop user", messagebody = txt_mess.Text });
        }
    }
}
