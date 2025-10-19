using System;
using ClassLib;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;

public class XJS  //信捷PLC通信协议
{
    #region 变量声明
    /// <summary>
    /// 串口
    /// </summary>
    SerialPort Port = new SerialPort();

    /// <summary>
    /// 是否已连接
    /// </summary>
    public bool IsConn = false;

    /// <summary>
    /// 是否正在向PLC写入数据
    /// </summary>
    private bool IsWrite = false;

    /// <summary>
    /// 读取PLC数据线程
    /// </summary>
    private Thread ReadTh;

    /// <summary>
    /// 设置PLC寄存器的值的数据
    /// </summary>
    private List<byte> WriteAllBy = new List<byte>();

    /// <summary>
    /// X寄存器
    /// </summary>
    public bool[] X = new bool[32];

    /// <summary>
    /// Y寄存器
    /// </summary>
    public bool[] Y = new bool[32];

    /// <summary>
    /// Y寄存器
    /// </summary>
    public bool[] M = new bool[600];

    /// <summary>
    /// HD寄存器 HD800-HD809
    /// </summary>
    public ushort[] HD = new ushort[900];
    #endregion

    public event Action<string> OnNotfiy;
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="PortName"></param>
    /// <param name="BaudRate"></param>
    public XJS(string PortName, int BaudRate )
    {
        this.Port.PortName = PortName;           //选择COM端口
        this.Port.BaudRate = BaudRate;           //设置波特率
        this.Port.DataReceived += new SerialDataReceivedEventHandler(this.OnDataReceived);
        this.ReadTh = new Thread(this.RunReadTh);
        this.ReadTh.IsBackground = true;
        this.ReadTh.Start();
    }

    /// <summary>
    /// 打开串口
    /// </summary>
    private  void OpenPort()
    {
        try
        {
            Port.DataBits = 8;                             //设置每个字节的标准数据位长度
            Port.StopBits = StopBits.One;                  //设置每个字节的标准停止位数
            Port.Parity = Parity.Even;                     //设置奇偶校验检查协议
            Port.ReadBufferSize = 2048;                    //设置输入缓冲区的大小
            Port.WriteBufferSize = 2048;                   //设置输出缓冲区的大小
            Port.ReadTimeout = 500;                        //设置读取操作未完成时发生超时之前的毫秒数
            Port.WriteTimeout = 500;                       //设置写入操作未完成时发生超时之前的毫秒数
            Port.ReceivedBytesThreshold = 5;               //设置 DataReceived 事件发生前内部输入缓冲区中的字节数            
            Port.Open();
            this.IsConn = true;
        }
        catch (Exception ex) { }
    }

    /// <summary>
    /// 关闭串口
    /// </summary>
    public void ClosePort()
    {
        this.Port.Close();
    }

    /// <summary>
    /// 查询类型   0：X   1:Y   2:HD
    /// </summary>
    private int QueryTpye = 0;

    /// <summary>
    /// 执行读取PLC数据线程
    /// </summary>
    private void RunReadTh()
    {
        while (true)
        {
            if (!this.IsConn)
                this.OpenPort();
            else
            {
                try
                {
                    List<byte> AllBy = new List<byte>();
                    int TimeL = 30;
                    AllBy.AddRange(new byte[] { 0x01, 0x01, 0x50, 0x00, 0x00, 0x20 }); //读取32个X
                    AllBy.AddRange(XJS.CRC16(AllBy.ToArray()));
                    this.Port.DiscardOutBuffer();
                    this.Port.Write(AllBy.ToArray(), 0, AllBy.Count);
                    this.QueryTpye = 0;
                    Thread.Sleep(TimeL);

                    AllBy = new List<byte>();
                    AllBy.AddRange(new byte[] { 0x01, 0x01, 0x60, 0x00, 0x00, 0x20 }); //读取32个Y
                    AllBy.AddRange(XJS.CRC16(AllBy.ToArray()));
                    this.Port.DiscardOutBuffer();
                    this.Port.Write(AllBy.ToArray(), 0, AllBy.Count);
                    this.QueryTpye = 1;
                    Thread.Sleep(TimeL);

                    AllBy = new List<byte>();
                    AllBy.AddRange(new byte[] { 0x01, 0x01, 0x01, 0x90, 0x00, 0xC8 }); //读取200个M
                    AllBy.AddRange(XJS.CRC16(AllBy.ToArray()));
                    this.Port.DiscardOutBuffer();
                    this.Port.Write(AllBy.ToArray(), 0, AllBy.Count);
                    this.QueryTpye = 2;
                    Thread.Sleep(TimeL);

                    if (this.IsWrite)
                    {
                        this.Port.DiscardOutBuffer();
                        this.Port.Write(this.WriteAllBy.ToArray(), 0, this.WriteAllBy.Count);
                        this.QueryTpye = 3;
                        Thread.Sleep(TimeL * 2);
                        this.IsWrite = false;
                    }
                }
                catch (Exception ex) { }
            }
            Thread.Sleep(1);
        }
    }

    /// <summary>
    /// 串口接收事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        try
        {
            int TimeL = 10;
            Thread.Sleep(TimeL);
            byte[] readBuf = new byte[this.Port.BytesToRead];//返回字节数据
            int aaaa = Port.Read(readBuf, 0, readBuf.Length);
            this.Port.DiscardInBuffer();//清空接收缓冲区

            if (readBuf[01] == 0x01 )
            {
                if (readBuf.Length == 9 && readBuf[02] == 0x04 )
                {
                    if (QueryTpye == 0)  //X
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string strX = Convert.ToString(readBuf[3 + i], 2).PadLeft(8, '0');
                            for (int j = 0; j < 8; j++)
                                X[i * 8 + 7 - j] = strX.Substring(j, 1) == "1";
                        }
                    }
                    if (QueryTpye == 1) //Y
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string strY = Convert.ToString(readBuf[3 + i], 2).PadLeft(8, '0');
                            for (int j = 0; j < 8; j++)
                                Y[i * 8 + 7 - j] = strY.Substring(j, 1) == "1";
                        }
                    }
                }
                if (readBuf.Length == 30 && readBuf[02] == 0x19 &&  QueryTpye == 2)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        string strM = Convert.ToString(readBuf[i + 3], 2).PadLeft(8, '0');
                        for (int j = 0; j < 8; j++)
                           M[i * 8 + 7 - j + 400] = strM.Substring(j, 1) == "1";
                    }
                }
            }

            switch (readBuf[01])//功能码
            {
                case 0x03://读多个寄存器
                    if (readBuf.Length == 29)
                        for (int i = 0; i < 12; i++)
                            HD[800 + i] = (ushort)(readBuf[i * 2 + 3] * 256 + readBuf[i * 2 + 4]);
                    break;
            }
        }
        catch (Exception ex) { }
    }

    /// <summary>
    /// 获取寄存器的浮点数
    /// </summary>
    /// <param name="Name">寄存器名称</param>
    /// <returns></returns>
    public float GetHDToFloat(string Name)
    {
        if (Name.Length > 1)
        {
            if (Name.Substring(0, 2) == "HD" && Name.Length > 2)   //如果HD寄存器
            {
                try
                {
                    int Index = Convert.ToInt32(Name.Substring(2, Name.Length - 2));
                    byte[] src = new byte[4];
                    src[1] = (byte)((this.HD[Index] >> 8) & 0xFF);      //高8位
                    src[0] = (byte)(this.HD[Index] & 0xFF);             //低位
                    src[3] = (byte)((this.HD[Index + 1] >> 8) & 0xFF);  //高8位
                    src[2] = (byte)(this.HD[Index + 1] & 0xFF);         //低位
                    return BitConverter.ToSingle(src, 0);
                }
                catch (Exception ex) { }
            }
        }
        return 0;
    }

    /// <summary>
    /// 设置16位整数寄存器的值
    /// </summary>
    /// <param name="Name">寄存器名称</param>
    /// <param name="Value">要设置的值</param>
    public void SetUshort( string Name, ushort Value)
    {
        while (this.IsWrite)
            Thread.Sleep(2);
        if (Name.Length > 1)
        {
            ushort Index = 0;
            if (Name.Substring(0, 2) == "HD" && Name.Length > 2)   //如果是HD寄存器
            {
                try
                {
                     Index = (ushort)(Convert.ToUInt16(Name.Substring(2, Name.Length - 2)) + 41088);
                }
                catch (Exception ex) 
                {
                    return;
                }
            }
            if (Name.Substring(0, 1) == "D" && Name.Length > 1)   //如果是D寄存器
            {
                try
                {
                    Index = (ushort)(Convert.ToUInt16(Name.Substring(1, Name.Length - 1)) );
                }
                catch (Exception ex)
                {
                    return;
                }
            }

            this.WriteAllBy = new List<byte>();
            byte[] Addr = new byte[2];
            Addr[1] = (byte)((Index >> 8) & 0xFF); //高8位
            Addr[0] = (byte)(Index & 0xFF);        //低位
            byte[] bValue = new byte[2];
            bValue[1] = (byte)((Value >> 8) & 0xFF); //高8位
            bValue[0] = (byte)(Value & 0xFF);        //低位
            this.WriteAllBy.AddRange(new byte[] {0x01, 0x06, Addr[1], Addr[0], bValue[1], bValue[0] });
            this.WriteAllBy.AddRange(XJS.CRC16(this.WriteAllBy.ToArray()));
            this.IsWrite = true;
            while (this.IsWrite)
                Thread.Sleep(2);
        }
    }

    /// <summary>
    /// 设置32位浮点数寄存器的值
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="Value"></param>
    public void SetFloat( string Name, float Value)
    {
        while (this.IsWrite)
            Thread.Sleep(2);
        if (Name.Length > 1)
        {
            ushort Index = 0;
            if (Name.Substring(0, 2) == "HD" && Name.Length > 2)   //如果是HD寄存器
            {
                try
                {
                    Index = (ushort)(Convert.ToUInt16(Name.Substring(2, Name.Length - 2)) + 41088);
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            if (Name.Substring(0, 1) == "D" && Name.Length > 1)   //如果是D寄存器
            {
                try
                {
                    Index = (ushort)(Convert.ToUInt16(Name.Substring(1, Name.Length - 1)));
                }
                catch (Exception ex)
                {
                    return;
                }
            }

            this.WriteAllBy = new List<byte>();
            byte[] Addr = new byte[2];
            Addr[1] = (byte)((Index >> 8) & 0xFF); //高8位
            Addr[0] = (byte)(Index & 0xFF);        //低位
            byte[] result = BitConverter.GetBytes(Value);
            this.WriteAllBy.AddRange(new byte[] {0x01,0x10, Addr[1], Addr[0], 0x00, 0x02, 0x04, result[1], result[0], result[3], result[2] });
            this.WriteAllBy.AddRange(XJS.CRC16(this.WriteAllBy.ToArray()));
            this.IsWrite = true;
            while (this.IsWrite)
                Thread.Sleep(2);
        }
    }

    /// <summary>
    /// 设置单个位状态  M，Y
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="State"></param>
    public void SetBit( string Name, bool Value)
    {
        while (this.IsWrite)
            Thread.Sleep(2);
        if (Name.Length > 1)
        {
            try
            {
                ushort Index = (ushort)(Convert.ToUInt16(Name.Substring(1, Name.Length - 1)));
                this.WriteAllBy = new List<byte>();
                if (Name.Substring(0, 1) == "Y")
                {
                    byte[] Addr = new byte[2];
                    this.WriteAllBy.AddRange(new byte[] { 0x01, 0x05, 0x60, (byte)Index, (byte)(Value ? 0xFF : 0x00), 0x00 });
                    this.WriteAllBy.AddRange(XJS.CRC16(this.WriteAllBy.ToArray()));
                    this.IsWrite = true;
                }
                if (Name.Substring(0, 1) == "M")
                {
                    byte[] Addr = new byte[2];
                    Addr[0] = (byte)((Index >> 8) & 0xFF); //高8位
                    Addr[1] = (byte)(Index & 0xFF);        //低位
                    this.WriteAllBy.AddRange(new byte[] { 0x01, 0x05, Addr[0], Addr[1], (byte)(Value ? 0xFF : 0x00), 0x00 });
                    this.WriteAllBy.AddRange(XJS.CRC16(this.WriteAllBy.ToArray()));
                    this.IsWrite = true;
                    while (this.IsWrite)
                        Thread.Sleep(2);
                }
            }
            catch (Exception ex) { }
        }
    }

    /// <summary>
    /// CRC16码计算
    /// </summary>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static byte[] CRC16(byte[] Data)
    {
        ushort Crc16 = 0xffff;
        for (int i = 0; i < Data.Length; i++)
        {
            Crc16 = (ushort)(Crc16 ^ Data[i]);
            for (int j = 0; j < 8; j++)
                Crc16 = (ushort)((Crc16 & 0x01) > 0 ? (Crc16 >> 1) ^ 0xa001 : Crc16 >> 1);
        }
        return new byte[] { (byte)(0xff & Crc16), (byte)((0xff00 & Crc16) >> 8) };
    }
}