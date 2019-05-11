using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;   //for WebClient Class
using System.Xml.Linq; //for XDocument
using System.Runtime.Serialization.Json; //for DataContractJsonSerializer
using System.IO; // for MemoryStream
using System.Text; //for Encoding


public partial class MyForm : System.Web.UI.Page
{
    private WebClient client = new WebClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        client.DownloadStringCompleted +=
        new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        client.DownloadStringAsync(new Uri("http://localhost:1207/Service.svc/welcome/" + TextBox1.Text));
    }
    private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
    {
        // check if any error occurred in retrieving service data
        if (e.Error == null)
        {
            DataContractJsonSerializer sobj = new DataContractJsonSerializer(typeof(Student));
            Student obj = (Student)sobj.ReadObject(new MemoryStream(Encoding.Unicode.GetBytes(e.Result)));
            Label1.Text = obj.Name;
        }
    }
    
}
[Serializable]
public class Student
{
    public string Name;
}
