using SMOWMS.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;


partial class frmMain
{
    /// <summary>
    /// 网卡字典
    /// </summary>
    /// <remarks></remarks>
    Dictionary<string, string> networkDict = new Dictionary<string, string>();
    /// <summary>
    /// Smobiler服务
    /// </summary>
    /// <remarks></remarks>
    Smobiler.Core.MobileServer server;

    private void frmMain_Load(object sender, EventArgs e)
    {
        try
        {
            InitialNetworkInterfaces();
            //定义Smobiler服务
            server = new Smobiler.Core.MobileServer();
            //设置默认网卡
            if (networkDict.Count > 0)
            {
                string[] combvalues = new string[networkDict.Count];
                networkDict.Keys.CopyTo(combvalues, 0);
                this.combNets.Items.AddRange(combvalues);
                this.combNets.SelectedIndex = 0;
            }
            //启动Smobiler服务
            StartServer();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }

    /// <summary>
    /// 获取当前可用的网卡信息
    /// </summary>
    /// <remarks></remarks>
    private void InitialNetworkInterfaces()
    {
        int i = 1;
        NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface NetworkIntf in NetworkInterfaces)
        {
            if (NetworkIntf.OperationalStatus == OperationalStatus.Up && NetworkIntf.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            {
                IPInterfaceProperties IPInterfaceProperties = NetworkIntf.GetIPProperties();
                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        networkDict.Add(i.ToString() + ":" + NetworkIntf.Name + "/" + NetworkIntf.Description, UnicastIPAddressInformation.Address.ToString());
                        i += 1;
                    }
                }
            }
        }
    }

    private void StartServer()
    {
        try
        {
            //服务起始界面
            server.StartUpForm = typeof(frmLogon);
            //服务TCP端口，默认为2323   
            this.txtTcpPort.Text = server.Setting.TcpServerPort.ToString();
            //服务HTTP端口，默认为2324  
            this.txtHTTPPort.Text = server.Setting.HttpServerPort.ToString();
            //启用服务
            server.StartServer();
        }
        catch (System.Net.HttpListenerException ex)
        {
            //遇到HTTP监听无法添加的异常时，需要注册HTTP监听，一般原因是由于当前用户没有管理员权限
            //运行下面的代码，会提示用户账户控制（网络命令外壳），这时请点击是
            //如果出现拒绝访问并且没有提示用户账户控制，请在 控制面板\安全性与维护\更改用户账户控制设置 选择 仅当应用尝试更改我的计算机时通知我（默认）
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "http delete urlacl url=http://+:" + server.Setting.HttpServerPort.ToString() + "/");
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            Process.Start(psi).WaitForExit();
            psi = new ProcessStartInfo("netsh", "http add urlacl url=http://+:" + server.Setting.HttpServerPort.ToString() + "/ user=" + Environment.UserDomainName + "\\" + Environment.UserName);
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            Process.Start(psi).WaitForExit();
            server.StartServer();
        }
    }

    /// <summary>
    /// 在下拉框选择变更事件重新生成二维码
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <remarks></remarks>
    private void combNets_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (networkDict.Count > 0)
        {
            this.txtNetAddress.Text = networkDict[this.combNets.SelectedItem.ToString()];
            qrcodeControl.SetServerInfo(this.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort, this.txtName.Text);
        }
    }

    /// <summary>
    /// 打开设置界面
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSetting_Click(object sender, EventArgs e)
    {
        try
        {
            frmSetting setting = new frmSetting();
            if (setting.ShowDialog() == DialogResult.Yes)
            {
                server.StopServer();
                server.Setting.InitialData();
                StartServer();
                qrcodeControl.SetServerInfo(this.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort, this.txtName.Text);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        frmHelp help = new frmHelp();
        help.ShowDialog();
    }

    /// <summary>
    /// 关闭窗体前保存设定值
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        SMOWMS.UI.Properties.Settings.Default.Save();
    }

    /// <summary>
    /// 点击完成按钮后保存设定值重新生成二维码
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnsavename_Click(object sender, EventArgs e)
    {
        SMOWMS.UI.Properties.Settings.Default.Save();
        if (networkDict.Count > 0)
        {
            this.txtNetAddress.Text = networkDict[this.combNets.SelectedItem.ToString()];
            qrcodeControl.SetServerInfo(this.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort, this.txtName.Text);
        }
    }

    private void btnGenerateQRcode_Click(object sender, EventArgs e)
    {
        frmGenerateQRcode generateQRcode = new frmGenerateQRcode();
        generateQRcode.ShowDialog();
    }
}