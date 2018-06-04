using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FTPClient
{
    public partial class Form1 : Form
    { 
        static String url;
        static String username;
        static String password;
        static int numberOfTimes = 0;
                 
        public Form1()
        {
            InitializeComponent();
        }

        private void displayB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();

            try
            {
                FtpWebRequest req;
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        addressBarTE.Text = url + "/" + path;
                        url = addressBarTE.Text.ToString();
                        break;
                    }
                req = (FtpWebRequest)WebRequest.Create("ftp://" + url); 
                req.Method = WebRequestMethods.Ftp.ListDirectory; 
                req.Credentials = new NetworkCredential(username, password); 
                FtpWebResponse res = (FtpWebResponse)req.GetResponse(); 
                Stream resStream = res.GetResponseStream(); 
                StreamReader reader = new StreamReader(resStream);
                if (numberOfTimes > 0)
                {
                    for (int i = (itemCounts - 1); i >= 0; i--)
                        contentLB.Items.RemoveAt(i);
                }
                while (!reader.EndOfStream)
                    contentLB.Items.Add(reader.ReadLine());              
                numberOfTimes++;
                reader.Close();
                res.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        private void downloadB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();

            try
            {
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        url = url + "/" + path;
                        break;
                    }
                WebClient req = new WebClient();
                req.Credentials = new NetworkCredential(username, password);              
                byte[] fileData = req.DownloadData("ftp://" + url);                
                FileStream file = File.Create(downloadTB.Text.ToString() + path);
                file.Write(fileData, 0, fileData.Length);
                MessageBox.Show("Download Completed");
                numberOfTimes++;
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        private void uploadB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();
            try
            {
                    FileInfo toUpload = new FileInfo(uploadTB.Text.ToString());
                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + url + "/" + toUpload.Name);
                    req.Method = WebRequestMethods.Ftp.UploadFile;
                    req.Credentials = new NetworkCredential(username, password);
                    Stream str = req.GetRequestStream();
                    FileStream file = File.OpenRead(uploadTB.Text.ToString());

                    int length = 1024;
                    byte[] buffer = new byte[length];
                    int byteRead = 0;

                    do
                    {
                        byteRead = file.Read(buffer, 0, length);
                        str.Write(buffer, 0, byteRead);
                    }
                    while (byteRead != 0);

                    file.Close();
                    str.Close();
                    
                    FtpWebRequest req3 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                    req3.Method = WebRequestMethods.Ftp.ListDirectory;
                    req3.Credentials = new NetworkCredential(username, password);

                    FtpWebResponse resq3 = (FtpWebResponse)req3.GetResponse();

                    Stream resStream3 = resq3.GetResponseStream();
                    StreamReader reader3 = new StreamReader(resStream3);

                    int itemCounts = contentLB.Items.Count;
                    if (numberOfTimes > 0)
                    {
                        for (int j = (itemCounts - 1); j >= 0; j--)
                            contentLB.Items.RemoveAt(j);
                    }

                    while (!reader3.EndOfStream)
                        contentLB.Items.Add(reader3.ReadLine());
                    resq3.Close();                
                
                MessageBox.Show("Upload Completed");
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }

            
        }

        private void directoryB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();
            try{
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + url + "/" + makedirectoryTB.Text.ToString());
                req.Method = WebRequestMethods.Ftp.MakeDirectory;
    
                req.Credentials = new NetworkCredential(username, password);
                    
                FtpWebResponse ftpResp = (FtpWebResponse)req.GetResponse();

                FtpWebRequest req3 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                req3.Method = WebRequestMethods.Ftp.ListDirectory;
                req3.Credentials = new NetworkCredential(username, password);

                FtpWebResponse resq3 = (FtpWebResponse)req3.GetResponse();

                Stream resStream3 = resq3.GetResponseStream();
                StreamReader reader3 = new StreamReader(resStream3);

                int itemCounts = contentLB.Items.Count;
                if (numberOfTimes > 0)
                {
                    for (int j = (itemCounts - 1); j >= 0; j--)
                        contentLB.Items.RemoveAt(j);
                }

                while (!reader3.EndOfStream)
                    contentLB.Items.Add(reader3.ReadLine());
                resq3.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();

            try
            {
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        url = url + "/" + path;
                        break;
                    }
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + url);
                req.Credentials = new NetworkCredential(username, password);
                req.Method = WebRequestMethods.Ftp.DeleteFile;
                

                FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                MessageBox.Show("File deleted");
                req = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                req.Method = WebRequestMethods.Ftp.ListDirectory;
                req.Credentials = new NetworkCredential(username, password);

                FtpWebResponse resq = (FtpWebResponse)req.GetResponse();

                Stream resStream = resq.GetResponseStream();
                StreamReader reader = new StreamReader(resStream);

                if (numberOfTimes > 0)
                {
                    for (int i = (itemCounts - 1); i >= 0; i--)
                        contentLB.Items.RemoveAt(i);
                }

                while (!reader.EndOfStream)
                    contentLB.Items.Add(reader.ReadLine());
                res.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        private void moveB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();
            try
            {
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        url = url + "/" + path;
                        break;
                    }
                WebClient req = new WebClient();
                req.Credentials = new NetworkCredential(username, password);
                byte[] fileData = req.DownloadData("ftp://" + url);
                FileStream file = File.Create(downloadTB.Text.ToString() + path);
                file.Write(fileData, 0, fileData.Length);
                file.Close();
                FileInfo toUpload = new FileInfo(downloadTB.Text.ToString() + path);
                MessageBox.Show(toUpload.Name);
                FtpWebRequest req2 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString() + "/" + destinationTB.Text.ToString() + "/" + toUpload.Name);
                MessageBox.Show("ftp://" + addressBarTE.Text.ToString() + "/" + destinationTB.Text.ToString() + "/" + toUpload.Name);
                req2.Credentials = new NetworkCredential(username, password);
                req2.Method = WebRequestMethods.Ftp.UploadFile;
                Stream str = req2.GetRequestStream();
                FileStream file2 = File.OpenRead(downloadTB.Text.ToString() + path);
                int length = 1024;
                byte[] buffer = new byte[length];
                int byteRead = 0;

                do
                {
                    byteRead = file2.Read(buffer, 0, length);
                    str.Write(buffer, 0, byteRead);
                }
                while (byteRead != 0);
                file2.Close();
                str.Close();

                FtpWebRequest req3 = (FtpWebRequest)WebRequest.Create("ftp://" + url);
                req3.Method = WebRequestMethods.Ftp.DeleteFile;
                req3.Credentials = new NetworkCredential(username, password);
                FtpWebResponse res3 = (FtpWebResponse)req3.GetResponse();
                MessageBox.Show("File moved");
                req3 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                req3.Method = WebRequestMethods.Ftp.ListDirectory;
                req3.Credentials = new NetworkCredential(username, password);
                FtpWebResponse resq3 = (FtpWebResponse)req3.GetResponse();
                Stream resStream3 = resq3.GetResponseStream();
                StreamReader reader3 = new StreamReader(resStream3);
                if (numberOfTimes > 0)
                {
                    for (int i = (itemCounts - 1); i >= 0; i--)
                        contentLB.Items.RemoveAt(i);
                }

                while (!reader3.EndOfStream)
                    contentLB.Items.Add(reader3.ReadLine());
                res3.Close();
                reader3.Close();

            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }




    }
}
