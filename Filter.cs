using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using System.Windows.Forms;
using System.Collections.Generic;

/// <summary>
/// 类库
/// </summary>
namespace ClassLib
{
    /// <summary>
    /// 过滤类
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// 编辑框过滤非正整数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TxtBoxFilterNoPositiveInt(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            TextBox tBox = (TextBox)sender;
            char[] ReceiveChar = new char[1];   //接收的字符
            ReceiveChar[0] = e.KeyChar;
            string ReceiveStr = tBox.Text + new string(ReceiveChar);   //接收的字符串
            try
            {
                Convert.ToInt32(ReceiveStr);
            }
            catch (Exception ex)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 编辑框过滤非整数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TxtBoxFilterNoInt(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            TextBox tBox = (TextBox)sender;
            char[] ReceiveChar = new char[1];   //接收的字符
            ReceiveChar[0] = e.KeyChar;
            string ReceiveStr = "";    //接收的字符串
            if (tBox.SelectedText == tBox.Text)
                ReceiveStr = new string(ReceiveChar) + "1";
            else
                ReceiveStr = tBox.Text + new string(ReceiveChar) + "1";
            try
            {
                Convert.ToDouble(ReceiveStr);
            }
            catch (Exception ex)
            {
                e.Handled = true;
            }
            for (int i = 0; i < ReceiveStr.Count(); i++)
                if (ReceiveStr[i] == '.')
                    e.Handled = true;
        }

        /// <summary>
        /// 编辑框过滤非正数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TxtBoxFilterNoPositiveValue(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if (e.KeyChar == '-')
                e.Handled = true;
            TextBox tBox = (TextBox)sender;
            char[] ReceiveChar = new char[1];   //接收的字符
            ReceiveChar[0] = e.KeyChar;
            string ReceiveStr = tBox.Text + new string(ReceiveChar) + "1";   //接收的字符串
            try
            {
                Convert.ToDouble(ReceiveStr);
            }
            catch (Exception ex)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 编辑框过滤非数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TxtBoxFilterNoValue(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            TextBox tBox = (TextBox)sender;
            int aaa = tBox.SelectionStart;
            char[] ReceiveChar = new char[1];  //接收的字符
            ReceiveChar[0] = e.KeyChar;
            string ReceiveStr = "";     //接收的字符串
            if (tBox.SelectedText == tBox.Text)
                ReceiveStr = new string(ReceiveChar) + "1";
            else
            {
                if (tBox.SelectionStart == 0)   //判断光标是不是在编辑框的首位置
                    ReceiveStr = new string(ReceiveChar) + tBox.Text + "1";
                else
                    ReceiveStr = tBox.Text + new string(ReceiveChar) + "1";
            }
            try
            {
                Convert.ToDouble(ReceiveStr);
            }
            catch (Exception ex)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 编辑框过滤空格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TxtBoxFilterSpace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')  //过滤空格
                e.Handled = true;
        }
    }

    /// <summary>
    /// 比较类
    /// </summary>
    public class Compare
    {
        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static byte GetTwoMax(byte a, byte b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static short GetTwoMax(short a, short b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GetTwoMax(int a, int b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long GetTwoMax(long a, long b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float GetTwoMax(float a, float b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double GetTwoMax(double a, double b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最小的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static byte GetTwoMin(byte a, byte b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最小的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static short GetTwoMin(short a, short b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最小的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GetTwoMin(int a, int b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最小的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long GetTwoMin(long a, long b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最小的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float GetTwoMin(float a, float b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// 获取两个数中最小的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double GetTwoMin(double a, double b)
        {
            return a < b ? a : b;
        }
    }

    /// <summary>
    /// 杂项类
    /// </summary>
    public class SundryS
    {
        #region 获取文件夹
        /// <summary>
        /// 获取文件夹：如果不存在则创建
        /// </summary>
        /// <param name="Path">路径</param>
        /// <returns></returns>
        public static string GetPath(string Path)
        {
            string[] AllPath = Path.Split('\\');
            Path = "";
            for (int i = 0; i < AllPath.Length; i++)
            {
                Path = Path + AllPath[i] + "\\";
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            return Path;
        }

        /// <summary>
        /// 获取文件夹：如果不存在则创建
        /// </summary>
        /// <param name="File">包含文件名的路径</param>
        /// <returns></returns>
        public static string GetContainFileNameForPath(string File)
        {
            string[] AllPath = File.Split('\\');
            string Path = "";
            for (int i = 0; i < AllPath.Length; i++)
            {
                Path = Path + AllPath[i] + "\\";
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            return Path + AllPath[AllPath.Length - 1];
        }
        #endregion

        #region 设置数值某一位的值
        /// <summary>
        /// 设置字节的某一位的值(将该位设置成0或1)
        /// </summary>
        /// <param name="data">要设置的字节</param>
        /// <param name="index">要设置的位， 值从低到高为 1-8</param>
        /// <param name="flag">要设置的值 true(1) / false(0)</param>
        /// <returns></returns>
        public static byte SetbitValue(byte data, int index, bool flag)
        {
            if (index > 8 || index < 1)
                throw new ArgumentOutOfRangeException();
            int v = index < 2 ? index : (2 << (index - 2));
            return flag ? (byte)(data | v) : (byte)(data & ~v);
        }

        /// <summary>
        /// 设置16位整数的某一位的值(将该位设置成0或1)
        /// </summary>
        /// <param name="data">要设置的16位整数</param>
        /// <param name="index">要设置的位， 值从低到高为 1-16</param>
        /// <param name="flag">要设置的值 true(1) / false(0)</param>
        /// <returns></returns>
        public static ushort SetbitValue(ushort data, int index, bool flag)
        {
            if (index > 16 || index < 1)
                throw new ArgumentOutOfRangeException();
            int v = index < 2 ? index : (2 << (index - 2));
            return flag ? (ushort)(data | v) : (ushort)(data & ~v);
        }
        #endregion

        #region 数组排序
        /// <summary>
        /// 浮点数组排序
        /// </summary>
        /// <param name="AllData">要排序的数组</param>
        /// <param name="IsMinToMax">是否从小到大</param>
        /// <returns></returns>
        public static int[] Sort(int[] AllData, bool IsMinToMax)
        {
            if (AllData.Length > 0)
            {
                if (AllData.Length == 1)
                    return AllData;
                else
                {
                    for (int i = 0; i < AllData.Length - 1; i++)
                    {
                        for (int j = i + 1; j < AllData.Length; j++)
                        {
                            if ((AllData[i] > AllData[j] && IsMinToMax) || (AllData[i] < AllData[j] && !IsMinToMax))
                            {
                                int temp = AllData[i];
                                AllData[i] = AllData[j];
                                AllData[j] = temp;
                            }
                        }
                    }
                }
            }
            return AllData;
        }

        /// <summary>
        /// 浮点数组排序
        /// </summary>
        /// <param name="AllData">要排序的数组</param>
        /// <param name="IsMinToMax">是否从小到大</param>
        /// <returns></returns>
        public static float[] Sort(float[] AllData, bool IsMinToMax)
        {
            if (AllData.Length > 0)
            {
                if (AllData.Length == 1)
                    return AllData;
                else
                {
                    for (int i = 0; i < AllData.Length - 1; i++)
                    {
                        for (int j = i + 1; j < AllData.Length; j++)
                        {
                            if ((AllData[i] > AllData[j] && IsMinToMax) || (AllData[i] < AllData[j] && !IsMinToMax))
                            {
                                float temp = AllData[i];
                                AllData[i] = AllData[j];
                                AllData[j] = temp;
                            }
                        }
                    }
                }
            }
            return AllData;
        }

        /// <summary>
        /// 浮点数组排序
        /// </summary>
        /// <param name="AllData">要排序的数组</param>
        /// <param name="IsMinToMax">是否从小到大</param>
        /// <returns></returns>
        public static double[] Sort(double[] AllData, bool IsMinToMax)
        {
            if (AllData.Length > 0)
            {
                if (AllData.Length == 1)
                    return AllData;
                else
                {
                    for (int i = 0; i < AllData.Length - 1; i++)
                    {
                        for (int j = i + 1; j < AllData.Length; j++)
                        {
                            if ((AllData[i] > AllData[j] && IsMinToMax) || (AllData[i] < AllData[j] && !IsMinToMax))
                            {
                                double temp = AllData[i];
                                AllData[i] = AllData[j];
                                AllData[j] = temp;
                            }
                        }
                    }
                }
            }
            return AllData;
        }

        /// <summary>
        /// 浮点数组排序
        /// </summary>
        /// <param name="AllData">要排序的数组</param>
        /// <param name="IsMinToMax">是否从小到大</param>
        /// <returns></returns>
        public static List<int> Sort(List<int> AllData, bool IsMinToMax)
        {
            if (AllData.Count > 0)
            {
                if (AllData.Count == 1)
                    return AllData;
                else
                {
                    for (int i = 0; i < AllData.Count - 1; i++)
                    {
                        for (int j = i + 1; j < AllData.Count; j++)
                        {
                            if ((AllData[i] > AllData[j] && IsMinToMax) || (AllData[i] < AllData[j] && !IsMinToMax))
                            {
                                int temp = AllData[i];
                                AllData[i] = AllData[j];
                                AllData[j] = temp;
                            }
                        }
                    }
                }
            }
            return AllData;
        }

        /// <summary>
        /// 浮点数组排序
        /// </summary>
        /// <param name="AllData">要排序的数组</param>
        /// <param name="IsMinToMax">是否从小到大</param>
        /// <returns></returns>
        public static List<float> Sort(List<float> AllData, bool IsMinToMax)
        {
            if (AllData.Count > 0)
            {
                if (AllData.Count == 1)
                    return AllData;
                else
                {
                    for (int i = 0; i < AllData.Count - 1; i++)
                    {
                        for (int j = i + 1; j < AllData.Count; j++)
                        {
                            if ((AllData[i] > AllData[j] && IsMinToMax) || (AllData[i] < AllData[j] && !IsMinToMax))
                            {
                                float temp = AllData[i];
                                AllData[i] = AllData[j];
                                AllData[j] = temp;
                            }
                        }
                    }
                }
            }
            return AllData;
        }

        /// <summary>
        /// 浮点数组排序
        /// </summary>
        /// <param name="AllData">要排序的数组</param>
        /// <param name="IsMinToMax">是否从小到大</param>
        /// <returns></returns>
        public static List<double> Sort(List<double> AllData, bool IsMinToMax)
        {
            if (AllData.Count > 0)
            {
                if (AllData.Count == 1)
                    return AllData;
                else
                {
                    for (int i = 0; i < AllData.Count - 1; i++)
                    {
                        for (int j = i + 1; j < AllData.Count; j++)
                        {
                            if ((AllData[i] > AllData[j] && IsMinToMax) || (AllData[i] < AllData[j] && !IsMinToMax))
                            {
                                double temp = AllData[i];
                                AllData[i] = AllData[j];
                                AllData[j] = temp;
                            }
                        }
                    }
                }
            }
            return AllData;
        }
        #endregion
    }

    /// <summary>
    /// 计时类
    /// </summary>
    public class TimeKeepingS
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        protected long StartTime = 0;

        private bool StartState = false;

        /// <summary>
        /// 开始计时
        /// </summary>
        public void Start()
        {
            this.StartTime = DateTime.Now.Ticks / 10000;
            this.StartState = true;
        }

        /// <summary>
        /// 获取计时时长:ms
        /// </summary>
        public int GetEndTime()
        {
            return this.StartState ? (int)(DateTime.Now.Ticks / 10000 - this.StartTime) : 0;
        }

        /// <summary>
        /// 停止计时
        /// </summary>
        public void Stop()
        {
            this.StartState = false;
        }
    }
}

/// <summary>
/// 几何类库
/// </summary>
namespace Geometry
{
    /// <summary>
    /// 凸度类
    /// </summary>
    public class ConvexityS
    {
        /// <summary>
        /// x坐标
        /// </summary>
        private double x = 0;

        /// <summary>
        /// y坐标
        /// </summary>
        private double y = 0;

        /// <summary>
        /// 凸度:正数： 逆时针  负数：顺时针
        /// </summary>
        public double Convexity = 0;

        /// <summary>
        /// 坐标
        /// </summary>
        public PointD Po
        {
            get { return new PointD(this.x, this.y); }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public ConvexityS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    /// <summary>
    /// Dxf文件操作类
    /// </summary>
    public class DxfS
    {
        #region 数据结构
        /// <summary>
        /// 块类
        /// </summary>
        public class BlockS
        {
            /// <summary>
            /// 块名
            /// </summary>
            public string Name = "";

            /// <summary>
            /// 所有直线
            /// </summary>
            public List<LineS> AllLine = new List<LineS>();

            /// <summary>
            /// 所有圆
            /// </summary>
            public List<CircleS> AllCircle = new List<CircleS>();

            /// <summary>
            /// 所有圆弧
            /// </summary>
            public List<ArcThreePoS> AllArc = new List<ArcThreePoS>();

            /// <summary>
            /// 所有多段线
            /// </summary>
            public List<PolylineS> AllPolyline = new List<PolylineS>();

            /// <summary>
            /// 是否有数据
            /// </summary>
            public bool IsHave = true;
        }

        /// <summary>
        /// 元素类
        /// </summary>
        public class ElementS
        {
            private bool isLine = false;
            private bool isArc = false;

            /// <summary>
            /// 直线
            /// </summary>
            public LineS Line = new LineS(0, 0, 0, 0);

            /// <summary>
            /// 圆弧
            /// </summary>
            public ArcThreePoS Arc = new ArcThreePoS(0, 0, 0, 0, 0, 0);

            /// <summary>
            /// 是否为直线
            /// </summary>
            public bool IsLine
            {
                get { return this.isLine; }
            }

            /// <summary>
            /// 是否为圆弧
            /// </summary>
            public bool IsArc
            {
                get { return this.isArc; }
            }

            /// <summary>
            /// 构造函数1
            /// </summary>
            public ElementS(LineS Line)
            {
                this.isLine = true;
                this.Line = Line;
            }

            /// <summary>
            /// 构造函数2
            /// </summary>
            public ElementS(ArcThreePoS Arc)
            {
                this.isArc = true;
                this.Arc = Arc;
            }
        }

        /// <summary>
        /// 块数据类
        /// </summary>
        public class BLOCK_Data
        {
            /// <summary>
            /// 块名
            /// </summary>
            public string Name = "";

            /// <summary>
            /// 头部数据
            /// </summary>
            public List<string> HeadData = new List<string>();

            /// <summary>
            /// 数据
            /// </summary>
            public List<string> Data = new List<string>();
        }

        /// <summary>
        /// 多段线类
        /// </summary>
        public class PolylineS
        {
            /// <summary>
            /// 所有元素
            /// </summary>
            public List<ElementS> AllElement = new List<ElementS>();
        }
        #endregion

        #region 变量
        /// <summary>
        /// 所有直线
        /// </summary>
        public List<LineS> AllLine = new List<LineS>();

        /// <summary>
        /// 所有圆
        /// </summary>
        public List<CircleS> AllCircle = new List<CircleS>();

        /// <summary>
        /// 所有圆弧
        /// </summary>
        public List<ArcS> AllArc = new List<ArcS>();

        /// <summary>
        /// 所有多段线
        /// </summary>
        public List<PolylineS> AllPolyline = new List<PolylineS>();

        /// <summary>
        /// 所有块
        /// </summary>
        public List<BlockS> AllBlock = new List<BlockS>();
        #endregion

        /// <summary>
        /// 加载Dxf文件
        /// </summary>
        /// <param name="dxf文件名"></param>
        /// <returns></returns>
        public bool LoadDxf(string DxfFile)
        {
            try
            {
                FileStream OpenFile = new FileStream(DxfFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader OpenDxfFile = new StreamReader(OpenFile, Encoding.Default);
                List<string> AllRow = new List<string>();     //所有行
                String line = "";
                while ((line = OpenDxfFile.ReadLine()) != null)
                {
                    line = line.Trim();      //消除前后空格
                    if (line != "")
                        AllRow.Add(line);
                }
                OpenDxfFile.Close();
                OpenFile.Close();

                for (int i = 0; i < AllRow.Count(); i++)
                {
                    if (AllRow[i] == "LINE")
                    {
                        LineS tLine = this.GetLine(AllRow, i);
                        if (tLine != null)
                            this.AllLine.Add(tLine);
                    }
                    if (AllRow[i] == "CIRCLE")
                    {
                        CircleS tCircle = this.GetCircle(AllRow, i);
                        if (tCircle != null)
                            this.AllCircle.Add(tCircle);
                    }
                    if (AllRow[i] == "ARC")
                    {
                        ArcS tArcS = this.GetArc(AllRow, i);
                        if (tArcS != null)
                            this.AllArc.Add(tArcS);
                    }
                    if (AllRow[i] == "LWPOLYLINE")    //AcDbPolyline
                    {
                        PolylineS tPolyline = this.GetPolyline(AllRow, i);
                        if (tPolyline != null)
                            this.AllPolyline.Add(tPolyline);
                    }
                }

                this.GetAllBlock(AllRow);   //获取所有块
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示！");
                return false;
            }
        }

        /// <summary>
        /// 获取所有块
        /// </summary>
        /// <param name="AllRow">所有行内容</param> 
        /// <returns></returns>
        private void GetAllBlock(List<string> AllRow)
        {
            List<string> tAllRow = new List<string>();
            for (int i = 0; i < AllRow.Count; i++)
                tAllRow.Add(AllRow[i]);
            List<BLOCK_Data> AllBLOCK_Data = new List<BLOCK_Data>();
            int Index = 0;
            while (Index < AllRow.Count)   //获取数据
            {
                if (AllRow[Index] == "BLOCK")
                {
                    BLOCK_Data tBLOCK_Data = new BLOCK_Data();
                    while (Index < AllRow.Count)
                    {
                        if (AllRow[Index] == "ENDBLK")
                        {
                            tBLOCK_Data.Data.Add(AllRow[Index]);
                            AllRow.RemoveAt(Index);
                            break;
                        }
                        if (AllRow[Index] == "AcDbBlockBegin" && AllRow[Index + 1] == "2")
                        {
                            tBLOCK_Data.Name = AllRow[Index + 2];
                            if (tBLOCK_Data.Name[0] == '*')
                                break;
                        }
                        tBLOCK_Data.Data.Add(AllRow[Index]);
                        AllRow.RemoveAt(Index);
                    }
                    if (tBLOCK_Data.Name[0] != '*')
                        AllBLOCK_Data.Add(tBLOCK_Data);
                }
                Index++;
            }

            Index = 0;
            while (Index < AllRow.Count)    //获取头部数据
            {
                if (AllRow[Index] == "100" && AllRow[Index + 1] == "AcDbBlockTableRecord" && AllRow[Index + 2] == "2")
                {
                    string Name = AllRow[Index + 3];
                    if (Name[0] != '*')
                    {
                        List<string> tALlRow = new List<string>();
                        for (int i = 0; i < 3; i++)
                        {
                            tALlRow.Add(AllRow[Index]);
                            AllRow.RemoveAt(Index);
                        }
                        while (Index < AllRow.Count)
                        {
                            if (AllRow[Index] == "BLOCK_RECORD" || (AllRow[Index] == "1002" && AllRow[Index + 1] == "}"))
                            {
                                tALlRow.Add(AllRow[Index]);
                                AllRow.RemoveAt(Index);
                                if (AllRow[Index] == "}")
                                {
                                    tALlRow.Add(AllRow[Index]);
                                    AllRow.RemoveAt(Index);
                                }
                                for (int i = 0; i < AllBLOCK_Data.Count; i++)
                                    if (AllBLOCK_Data[i].Name == Name)
                                        AllBLOCK_Data[i].HeadData = tALlRow;
                                break;
                            }
                            tALlRow.Add(AllRow[Index]);
                            AllRow.RemoveAt(Index);
                        }
                    }
                }
                Index++;
            }

            for (int i = AllBLOCK_Data.Count - 1; i > -1; i--)
            {
                bool IsDel = true;       //是否删除
                for (int j = 0; j < AllBLOCK_Data[i].HeadData.Count - 1; j++)
                {
                    if (AllBLOCK_Data[i].HeadData[j] == "102" && AllBLOCK_Data[i].HeadData[j + 1] == "{BLKREFS")
                    {
                        IsDel = false;
                        break;
                    }
                }
                if (IsDel)
                    AllBLOCK_Data.RemoveAt(i);
            }

            List<BlockS> tAllBlock = new List<BlockS>();   //所有块
            for (int i = 0; i < AllBLOCK_Data.Count; i++)
            {
                BlockS Block = new BlockS();
                Block.Name = AllBLOCK_Data[i].Name;
                for (int j = 0; j < AllBLOCK_Data[i].Data.Count; j++)
                {
                    if (AllBLOCK_Data[i].Data[j] == "LINE")
                    {
                        LineS tLine = this.GetLine(AllBLOCK_Data[i].Data, j);
                        if (tLine != null)
                            Block.AllLine.Add(tLine);
                    }
                    if (AllBLOCK_Data[i].Data[j] == "CIRCLE")
                    {
                        CircleS tCircle = this.GetCircle(AllBLOCK_Data[i].Data, j);
                        if (tCircle != null)
                            Block.AllCircle.Add(tCircle);
                    }
                    if (AllBLOCK_Data[i].Data[j] == "ARC")
                    {
                        ArcS tArcS = this.GetArc(AllBLOCK_Data[i].Data, j);
                        if (tArcS != null)
                            Block.AllArc.Add(Algorithm.ArcToArcThreePo(tArcS));
                    }
                    if (AllBLOCK_Data[i].Data[j] == "LWPOLYLINE")    //AcDbPolyline
                    {
                        PolylineS tPolyline = this.GetPolyline(AllBLOCK_Data[i].Data, j);
                        if (tPolyline != null)
                        {
                            for (int k = 0; k < tPolyline.AllElement.Count; k++)
                            {
                                if (tPolyline.AllElement[k].IsLine)
                                    Block.AllLine.Add(tPolyline.AllElement[k].Line);
                                if (tPolyline.AllElement[k].IsArc)
                                    Block.AllArc.Add(tPolyline.AllElement[k].Arc);
                            }
                        }
                    }
                }

                if (Block.AllLine.Count != 0 || Block.AllArc.Count != 0 || Block.AllCircle.Count != 0 || Block.AllPolyline.Count != 0)
                {
                    Index = 0;
                    while (Index < tAllRow.Count)   //处理复制块
                    {
                        if (tAllRow[Index] == "AcDbBlockReference" && tAllRow[Index + 2] == Block.Name)
                        {
                            try
                            {
                                double x = Convert.ToDouble(tAllRow[Index + 4]);
                                double y = Convert.ToDouble(tAllRow[Index + 6]);
                                double Angle = 0;
                                double ScaleX = 1;         //x坐标比例
                                double ScaleY = 1;         //y坐标比例
                                if (tAllRow[Index + 9] == "41" && tAllRow[Index + 11] == "42")
                                {
                                    ScaleX = Math.Abs(Convert.ToDouble(tAllRow[Index + 10]));
                                    ScaleY = Convert.ToDouble(tAllRow[Index + 12]);
                                }
                                else
                                {
                                    if (tAllRow[Index + 9] == "41")
                                    {
                                        ScaleX = Math.Abs(Convert.ToDouble(tAllRow[Index + 10]));
                                        ScaleY = Convert.ToDouble(tAllRow[Index + 10]);
                                    }
                                    if (tAllRow[Index + 11] == "42")
                                    {
                                        ScaleX = Math.Abs(Convert.ToDouble(tAllRow[Index + 12]));
                                        ScaleY = Convert.ToDouble(tAllRow[Index + 12]);
                                    }
                                    if (tAllRow[Index + 9] == "50")
                                        Angle = Convert.ToDouble(tAllRow[Index + 10]);
                                    if (tAllRow[Index + 11] == "50")
                                        Angle = Convert.ToDouble(tAllRow[Index + 12]);
                                }
                                if (tAllRow[Index + 15] == "50")
                                    Angle = Convert.ToDouble(tAllRow[Index + 16]);

                                BlockS AfterBlock = Block;
                                if (tAllRow[Index + 9] == "41")
                                    if (Convert.ToDouble(tAllRow[Index + 10]) < 0)   //如果镜像
                                        AfterBlock = this.GetBlockMirror(Block);     //获取x轴镜像后的块
                                AfterBlock = this.GetRotateAndZoomBlock(AfterBlock, Angle, ScaleX);   //旋转和缩放处理之后的块

                                BlockS tBlock = new BlockS();
                                tBlock.Name = Block.Name;
                                for (int j = 0; j < AfterBlock.AllLine.Count; j++)
                                {
                                    PointD StartPo = new PointD(AfterBlock.AllLine[j].StartPo.x + x, AfterBlock.AllLine[j].StartPo.y + y);
                                    PointD EndPo = new PointD(AfterBlock.AllLine[j].EndPo.x + x, AfterBlock.AllLine[j].EndPo.y + y);
                                    tBlock.AllLine.Add(new LineS(StartPo, EndPo));
                                }
                                for (int j = 0; j < AfterBlock.AllCircle.Count; j++)
                                {
                                    CircleS tCircle = AfterBlock.AllCircle[j];
                                    tBlock.AllCircle.Add(new CircleS(tCircle.CenterPo.x + x, tCircle.CenterPo.y + y, tCircle.R));
                                }
                                for (int j = 0; j < AfterBlock.AllArc.Count; j++)
                                {
                                    PointD StartPo = new PointD(AfterBlock.AllArc[j].StartPo.x + x, AfterBlock.AllArc[j].StartPo.y + y);
                                    PointD TwoPo = new PointD(AfterBlock.AllArc[j].TwoPo.x + x, AfterBlock.AllArc[j].TwoPo.y + y);
                                    PointD EndPo = new PointD(AfterBlock.AllArc[j].EndPo.x + x, AfterBlock.AllArc[j].EndPo.y + y);
                                    tBlock.AllArc.Add(new ArcThreePoS(StartPo, TwoPo, EndPo));
                                }
                                for (int j = 0; j < AfterBlock.AllPolyline.Count; j++)
                                {
                                    PolylineS tPolyline = new PolylineS();
                                    for (int k = 0; k < Block.AllPolyline[j].AllElement.Count; k++)
                                    {
                                        LineS tLine = Block.AllPolyline[j].AllElement[k].Line;
                                        ArcThreePoS tArc = Block.AllPolyline[j].AllElement[k].Arc;
                                        if (Block.AllPolyline[j].AllElement[k].IsLine)
                                        {
                                            PointD StartPo = new PointD(tLine.StartPo.x * ScaleX + x, tLine.StartPo.y * ScaleY + y);
                                            PointD EndPo = new PointD(tLine.EndPo.x * ScaleX + x, tLine.EndPo.y * ScaleY + y);
                                            tPolyline.AllElement.Add(new ElementS(new LineS(StartPo, EndPo)));
                                        }
                                        else
                                        {
                                            PointD StartPo = new PointD(tArc.StartPo.x * ScaleX + x, tArc.StartPo.y * ScaleY + y);
                                            PointD TwoPo = new PointD(tArc.TwoPo.x * ScaleX + x, tArc.TwoPo.y * ScaleY + y);
                                            PointD EndPo = new PointD(tArc.EndPo.x * ScaleX + x, tArc.EndPo.y * ScaleY + y);
                                            tPolyline.AllElement.Add(new ElementS(new ArcThreePoS(StartPo, TwoPo, EndPo)));
                                        }
                                    }
                                    tBlock.AllPolyline.Add(tPolyline);
                                }
                                this.AllBlock.Add(tBlock);
                            }
                            catch { }
                        }
                        Index++;
                    }
                }
            }
        }

        /// <summary>
        /// 获取x轴镜像后的块
        /// </summary>
        private BlockS GetBlockMirror(BlockS Block)
        {
            BlockS tBlock = new BlockS();
            for (int k = 0; k < Block.AllLine.Count; k++)
            {
                PointD StartPo = new PointD(-Block.AllLine[k].StartPo.x, Block.AllLine[k].StartPo.y);
                PointD EndPo = new PointD(-Block.AllLine[k].EndPo.x, Block.AllLine[k].EndPo.y);
                tBlock.AllLine.Add(new LineS(StartPo, EndPo));
            }
            for (int k = 0; k < Block.AllArc.Count; k++)
            {
                PointD StartPo = new PointD(-Block.AllArc[k].StartPo.x, Block.AllArc[k].StartPo.y);
                PointD TwoPo = new PointD(-Block.AllArc[k].TwoPo.x, Block.AllArc[k].TwoPo.y);
                PointD EndPo = new PointD(-Block.AllArc[k].EndPo.x, Block.AllArc[k].EndPo.y);
                tBlock.AllArc.Add(new ArcThreePoS(StartPo, TwoPo, EndPo));
            }
            for (int k = 0; k < Block.AllCircle.Count; k++)
            {
                PointD CenterPo = new PointD(-Block.AllCircle[k].CenterPo.x, Block.AllCircle[k].CenterPo.y);
                tBlock.AllCircle.Add(new CircleS(CenterPo, Block.AllCircle[k].R));
            }
            for (int k = 0; k < Block.AllPolyline.Count; k++)
            {
                for (int l = 0; l < Block.AllPolyline[k].AllElement.Count; l++)
                {
                    PolylineS tPolyline = Block.AllPolyline[k];
                    PointD StartPo = new PointD(-Block.AllPolyline[k].AllElement[l].Line.StartPo.x, Block.AllPolyline[k].AllElement[l].Line.StartPo.y);
                    PointD EndPo = new PointD(-Block.AllPolyline[k].AllElement[l].Line.EndPo.x, Block.AllPolyline[k].AllElement[l].Line.EndPo.y);
                    tPolyline.AllElement.Add(new ElementS(new LineS(StartPo, EndPo)));

                    StartPo = new PointD(-Block.AllPolyline[k].AllElement[l].Arc.StartPo.x, Block.AllPolyline[k].AllElement[l].Arc.StartPo.y);
                    PointD TwoPo = new PointD(-Block.AllPolyline[k].AllElement[l].Arc.TwoPo.x, Block.AllPolyline[k].AllElement[l].Arc.TwoPo.y);
                    EndPo = new PointD(-Block.AllPolyline[k].AllElement[l].Arc.EndPo.x, Block.AllPolyline[k].AllElement[l].Arc.EndPo.y);
                    tPolyline.AllElement.Add(new ElementS(new ArcThreePoS(StartPo, TwoPo, EndPo)));
                    tBlock.AllPolyline.Add(tPolyline);
                }
            }
            return tBlock;
        }

        /// <summary>
        /// 获取旋转和缩放后的块
        /// </summary>
        /// <param name="Block">处理前的块</param>
        /// <param name="Angle">旋转角度</param>
        /// <param name="Zoom">缩放比例</param>
        /// <returns>返回处理后的块</returns>
        private BlockS GetRotateAndZoomBlock(BlockS Block, double Angle, double Zoom)
        {
            BlockS tBlock = new BlockS();
            for (int i = 0; i < Block.AllLine.Count; i++)
            {
                LineS tLine = Algorithm.CalculateRotateLine(new PointD(0, 0), Block.AllLine[i], Angle);
                PointD StartPo = new PointD(tLine.StartPo.x * Zoom, tLine.StartPo.y * Zoom);
                PointD EndPo = new PointD(tLine.EndPo.x * Zoom, tLine.EndPo.y * Zoom);
                tBlock.AllLine.Add(new LineS(StartPo, EndPo));
            }
            for (int i = 0; i < Block.AllCircle.Count; i++)
            {
                PointD Center = new PointD(Block.AllCircle[i].CenterPo.x * Zoom, Block.AllCircle[i].CenterPo.y * Zoom);
                tBlock.AllCircle.Add(new CircleS(Center, Block.AllCircle[i].R * Zoom));
            }
            for (int i = 0; i < Block.AllArc.Count; i++)
            {
                ArcThreePoS tArc = Algorithm.CalculateRotateArc(new PointD(0, 0), Block.AllArc[i], Angle);
                PointD StartPo = new PointD(tArc.StartPo.x * Zoom, tArc.StartPo.y * Zoom);
                PointD TwoPo = new PointD(tArc.TwoPo.x * Zoom, tArc.TwoPo.y * Zoom);
                PointD EndPo = new PointD(tArc.EndPo.x * Zoom, tArc.EndPo.y * Zoom);
                tBlock.AllArc.Add(new ArcThreePoS(StartPo, TwoPo, EndPo));
            }
            return tBlock;
        }

        /// <summary>
        /// 清除所有数据
        /// </summary>
        private void CleanData()
        {
            this.AllLine.Clear();
            this.AllCircle.Clear();
            this.AllArc.Clear();
        }

        /// <summary>
        /// 获取直线
        /// </summary>
        /// <param name="AllRow">所有行内容</param>
        /// <param name="index">行索引</param>
        private LineS GetLine(List<string> AllRow, int index)
        {
            if (!IsEffectiveLine(ref index, AllRow, "AcDbLine"))
                return null;
            try
            {
                double x1 = Convert.ToSingle(AllRow[index + 2]);
                double y1 = Convert.ToSingle(AllRow[index + 4]);
                double x2 = Convert.ToSingle(AllRow[index + 8]);
                double y2 = Convert.ToSingle(AllRow[index + 10]);
                return new LineS(new PointD(x1, y1), new PointD(x2, y2));
            }
            catch { }
            return null;
        }

        /// <summary>
        /// 获取圆
        /// </summary>
        /// <param name="AllRow">所有行内容</param>
        /// <param name="index">行索引</param>
        private CircleS GetCircle(List<string> AllRow, int index)
        {
            if (!IsEffectiveLine(ref index, AllRow, "AcDbCircle"))
                return null;
            try
            {
                float x = Convert.ToSingle(AllRow[index + 2]);
                float y = Convert.ToSingle(AllRow[index + 4]);
                float R = Convert.ToSingle(AllRow[index + 8]);
                return new CircleS(new PointD(x, y), R);
            }
            catch { }
            return null;
        }

        /// <summary>
        ///  获取圆弧
        /// </summary>
        /// <param name="AllRow">所有行内容</param>
        /// <param name="index">行索引</param>
        private ArcS GetArc(List<string> AllRow, int index)
        {
            if (!IsEffectiveLine(ref index, AllRow, "AcDbCircle"))
                return null;
            double x = Convert.ToSingle(AllRow[index + 2]);
            double y = Convert.ToSingle(AllRow[index + 4]);
            double R = Convert.ToSingle(AllRow[index + 8]);
            while (true)
            {
                index++;
                if (AllRow[index] == "AcDbArc")
                    break;
            }
            try
            {
                double StartAngle = Convert.ToSingle(AllRow[index + 2]);
                double EndAngle = Convert.ToSingle(AllRow[index + 4]);
                return new ArcS(new PointD(x, y), R, StartAngle, EndAngle);
            }
            catch { }
            return null;
        }

        /// <summary>
        /// 获取多段线
        /// </summary>
        /// <param name="AllRow"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private PolylineS GetPolyline(List<string> AllRow, int index)
        {
            if (!IsEffectiveLine(ref index, AllRow, "AcDbPolyline"))
                return null;
            bool IsSeal = false;  //是否封闭
            List<ConvexityS> AllConvexity = new List<ConvexityS>();
            while (index < AllRow.Count - 10)
            {
                index++;
                if (AllRow[index] == "90" && AllRow[index + 2] == "70")
                    IsSeal = AllRow[index + 3] == "1" ? true : false;
                if (AllRow[index] == "10" && AllRow[index + 2] == "20")
                {
                    try
                    {
                        double x = Convert.ToDouble(AllRow[index + 1]);
                        double y = Convert.ToDouble(AllRow[index + 3]);
                        ConvexityS Convexity = new ConvexityS(x, y);
                        AllConvexity.Add(Convexity);
                        if (AllRow[index + 4] == "42")
                        {
                            Convexity.Convexity = Convert.ToDouble(AllRow[index + 5]);    //凸度
                            if (AllRow[index + 6] == "0")
                                break;
                        }
                        else
                        {
                            if (AllRow[index + 4] == "0")
                                break;
                        }
                    }
                    catch { }
                }
            }
            if (IsSeal)
                AllConvexity.Add(AllConvexity[0]);
            PolylineS tPolyline = new PolylineS();
            for (int i = 0; i < AllConvexity.Count - 1; i++)
            {
                if (AllConvexity[i].Convexity == 0)
                {
                    ElementS tElement = new ElementS(new LineS(AllConvexity[i].Po, AllConvexity[i + 1].Po));
                    tPolyline.AllElement.Add(tElement);
                }
                else
                {
                    PointD CircleCenter = GetConvexityCircleCenter(AllConvexity[i].Po, AllConvexity[i + 1].Po, AllConvexity[i].Convexity);
                    double R = Algorithm.CalculateTwoPoDistance(CircleCenter, AllConvexity[i].Po);
                    double StartAngle = Algorithm.CalculateLineAngle(CircleCenter, AllConvexity[i].Po);
                    double EndAngle = Algorithm.CalculateLineAngle(CircleCenter, AllConvexity[i + 1].Po);
                    tPolyline.AllElement.Add(new ElementS(Algorithm.ArcToArcThreePo(new ArcS(CircleCenter, R, StartAngle, EndAngle))));
                }
            }
            return tPolyline;
        }

        /// <summary>
        /// 获取凸角的圆心
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="EndPo"></param>
        /// <param name="Convexity"></param>
        /// <returns></returns>
        private PointD GetConvexityCircleCenter(PointD StartPo, PointD EndPo, double Convexity)
        {
            double b = 0.5 * (1 / Convexity - Convexity);
            double x = 0.5 * (StartPo.x + EndPo.x - (EndPo.y - StartPo.y) * b);
            double y = 0.5 * (StartPo.y + EndPo.y + (EndPo.x - StartPo.x) * b);
            return new PointD(x, y);
        }

        /// <summary>
        /// 是否为有效线条
        /// </summary>
        /// <param name="index">行索引</param>
        /// <param name="AllRow">所有行内容</param>
        /// <param name="Keyword">要寻找的字符串：AcDbLine</param>
        /// <returns></returns>
        private bool IsEffectiveLine(ref int index, List<string> AllRow, string Keyword)
        {
            while (true)
            {
                index++;
                if (AllRow[index] == "370")
                    if ((float)(Convert.ToSingle(AllRow[index + 1]) / 100) < 0)
                        return false;
                if (AllRow[index] == Keyword)
                    break;
            }
            return true;
        }
    }

    /// <summary>
    /// 算法类
    /// </summary>
    public class Algorithm   //已经整理到：获取圆弧中点
    {
        #region 设置数值某一位的值
        /// <summary>
        /// 设置字节的某一位的值(将该位设置成0或1)
        /// </summary>
        /// <param name="data">要设置的字节</param>
        /// <param name="index">要设置的位， 值从低到高为 1-8</param>
        /// <param name="flag">要设置的值 true(1) / false(0)</param>
        /// <returns></returns>
        public static byte SetbitValue(byte data, int index, bool flag)
        {
            if (index > 8 || index < 1)
                throw new ArgumentOutOfRangeException();
            int v = index < 2 ? index : (2 << (index - 2));
            return flag ? (byte)(data | v) : (byte)(data & ~v);
        }

        /// <summary>
        /// 设置16位整数的某一位的值(将该位设置成0或1)
        /// </summary>
        /// <param name="data">要设置的16位整数</param>
        /// <param name="index">要设置的位， 值从低到高为 1-16</param>
        /// <param name="flag">要设置的值 true(1) / false(0)</param>
        /// <returns></returns>
        public static ushort SetbitValue(ushort data, int index, bool flag)
        {
            if (index > 16 || index < 1)
                throw new ArgumentOutOfRangeException();
            int v = index < 2 ? index : (2 << (index - 2));
            return flag ? (ushort)(data | v) : (ushort)(data & ~v);
        }
        #endregion

        #region 计算直线终点坐标
        /// <summary>
        /// 计算直线终点坐标
        /// </summary>
        /// <param name="StartPoX">直线起点X坐标</param>
        /// <param name="StartPoY">直线起点Y坐标</param>
        /// <param name="Angle">直线角度</param>
        /// <param name="Length">直线长度</param>
        /// <returns></returns>
        public static PointD CalculateLineEndPo(double StartPoX, double StartPoY, double Angle, double Length)
        {
            PointD EndPo = new PointD();
            double Radian = (Angle * Math.PI) / 180;   //弧度
            EndPo.x = StartPoX + Length * Math.Cos(Radian);
            EndPo.y = StartPoY + Length * Math.Sin(Radian);
            return EndPo;
        }

        /// <summary>
        /// 计算直线终点坐标
        /// </summary>
        /// <param name="StartPo">直线起点</param>
        /// <param name="Angle">直线角度</param>
        /// <param name="Length">直线长度</param>
        /// <returns></returns>
        public static PointD CalculateLineEndPo(PointD StartPo, double Angle, double Length)
        {
            return CalculateLineEndPo(StartPo.x, StartPo.y, Angle, Length);
        }
        #endregion

        #region 计算旋转后的点
        /// <summary>
        /// 计算旋转后的点
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="PoX">要旋转的点x坐标</param>
        /// <param name="PoY">要旋转的点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static PointD CalculateRotatePo(double RotatePoX, double RotatePoY, double PoX, double PoY, double RotateAngle)
        {
            double Distance = CalculateTwoPoDistance(RotatePoX, RotatePoY, PoX, PoY);          //距离
            double Angle = CalculateLineAngle(RotatePoX, RotatePoY, PoX, PoY) + RotateAngle;   //角度
            Angle = RotateAngle >= 360 ? Angle - 360 : Angle;
            Angle = RotateAngle < 0 ? Angle + 360 : Angle;
            return CalculateLineEndPo(RotatePoX, RotatePoY, Angle, Distance);
        }

        /// <summary>
        /// 计算旋转后的点
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="Po">要旋转的点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static PointD CalculateRotatePo(double RotatePoX, double RotatePoY, PointD Po, double RotateAngle)
        {
            return CalculateRotatePo(RotatePoX, RotatePoY, Po.x, Po.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的点
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="PoX">要旋转的点x坐标</param>
        /// <param name="PoY">要旋转的点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static PointD CalculateRotatePo(PointD RotatePo, double PoX, double PoY, double RotateAngle)
        {
            return CalculateRotatePo(RotatePo.x, RotatePo.y, PoX, PoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的点
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="Po">要旋转的点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static PointD CalculateRotatePo(PointD RotatePo, PointD Po, double RotateAngle)
        {
            return CalculateRotatePo(RotatePo.x, RotatePo.y, Po, RotateAngle);
        }
        #endregion

        #region 计算旋转后的直线
        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPoX">旋转直线的起点x坐标</param>
        /// <param name="StartPoY">旋转直线的起点y坐标</param>
        /// <param name="EndPoX">旋转直线的终点x坐标</param>
        /// <param name="EndPoY">旋转直线的终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(double RotatePoX, double RotatePoY, double StartPoX, double StartPoY, double EndPoX, double EndPoY, double RotateAngle)
        {
            PointD StartPo = CalculateRotatePo(RotatePoX, RotatePoY, StartPoX, StartPoY, RotateAngle);
            PointD EndPo = CalculateRotatePo(RotatePoX, RotatePoY, EndPoX, EndPoY, RotateAngle);
            return new LineS(StartPo, EndPo);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPoX">旋转直线的起点x坐标</param>
        /// <param name="StartPoY">旋转直线的起点y坐标</param>
        /// <param name="EndPo">旋转直线的终点坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(double RotatePoX, double RotatePoY, double StartPoX, double StartPoY, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateLine(RotatePoX, RotatePoY, StartPoX, StartPoY, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPo">旋转直线的起点坐标</param>
        /// <param name="EndPoX">旋转直线的终点x坐标</param>
        /// <param name="EndPoY">旋转直线的终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(double RotatePoX, double RotatePoY, PointD StartPo, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateLine(RotatePoX, RotatePoY, StartPo.x, StartPo.y, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPo">旋转直线的起点坐标</param>
        /// <param name="EndPo">旋转直线的终点坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(double RotatePoX, double RotatePoY, PointD StartPo, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateLine(RotatePoX, RotatePoY, StartPo, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPoX">旋转直线的起点x坐标</param>
        /// <param name="StartPoY">旋转直线的起点y坐标</param>
        /// <param name="EndPoX">旋转直线的终点x坐标</param>
        /// <param name="EndPoY">旋转直线的终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(PointD RotatePo, double StartPoX, double StartPoY, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateLine(RotatePo.x, RotatePo.y, StartPoX, StartPoY, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPoX">旋转直线的起点x坐标</param>
        /// <param name="StartPoY">旋转直线的起点y坐标</param>
        /// <param name="EndPo">旋转直线的终点坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(PointD RotatePo, double StartPoX, double StartPoY, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateLine(RotatePo, StartPoX, StartPoY, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPo">旋转直线的起点坐标</param>
        /// <param name="EndPoX">旋转直线的终点x坐标</param>
        /// <param name="EndPoY">旋转直线的终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(PointD RotatePo, PointD StartPo, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateLine(RotatePo, StartPo.x, StartPo.y, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPo">旋转直线的起点坐标</param>
        /// <param name="EndPo">旋转直线的终点坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(PointD RotatePo, PointD StartPo, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateLine(RotatePo, StartPo, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="Line">旋转直线</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(double RotatePoX, double RotatePoY, LineS Line, double RotateAngle)
        {
            return CalculateRotateLine(RotatePoX, RotatePoY, Line.StartPo, Line.EndPo, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的直线
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="Line">旋转直线</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static LineS CalculateRotateLine(PointD RotatePo, LineS Line, double RotateAngle)
        {
            return CalculateRotateLine(RotatePo.x, RotatePo.y, Line, RotateAngle);
        }
        #endregion

        #region 计算旋转后的圆
        /// <summary>
        /// 计算旋转后的圆
        /// </summary>
        /// <param name="RotatePoX">旋转基点x</param>
        /// <param name="RotatePoY">旋转基点y</param>
        /// <param name="CenterPoX">圆心x坐标</param>
        /// <param name="CenterPoY">圆心y坐标</param>
        /// <param name="R">半径</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static CircleS CalculateRotateCircle(double RotatePoX, double RotatePoY, double CenterPoX, double CenterPoY, double R, double RotateAngle)
        {
            PointD CenterPo = CalculateRotatePo(RotatePoX, RotatePoY, CenterPoX, CenterPoY, RotateAngle);
            return new CircleS(CenterPo, R);
        }

        /// <summary>
        /// 计算旋转后的圆
        /// </summary>
        /// <param name="RotatePoX">旋转基点x</param>
        /// <param name="RotatePoY">旋转基点y</param>
        /// <param name="CenterPo">圆心</param>
        /// <param name="R">半径</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static CircleS CalculateRotateCircle(double RotatePoX, double RotatePoY, PointD CenterPo, double R, double RotateAngle)
        {
            return CalculateRotateCircle(RotatePoX, RotatePoY, CenterPo.x, CenterPo.y, R, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆
        /// </summary>
        /// <param name="RotatePoX"></param>
        /// <param name="RotatePoY"></param>
        /// <param name="Circle"></param>
        /// <param name="RotateAngle"></param>
        /// <returns></returns>
        public static CircleS CalculateRotateCircle(double RotatePoX, double RotatePoY, CircleS Circle, double RotateAngle)
        {
            return CalculateRotateCircle(RotatePoX, RotatePoY, Circle.CenterPo, Circle.R, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="CenterPoX">圆心x坐标</param>
        /// <param name="CenterPoY">圆心y坐标</param>
        /// <param name="R">半径</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static CircleS CalculateRotateCircle(PointD RotatePo, double CenterPoX, double CenterPoY, double R, double RotateAngle)
        {
            return CalculateRotateCircle(RotatePo.x, RotatePo.y, CenterPoX, CenterPoY, R, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="CenterPo">圆心</param>
        /// <param name="R">半径</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static CircleS CalculateRotateCircle(PointD RotatePo, PointD CenterPo, double R, double RotateAngle)
        {
            return CalculateRotateCircle(RotatePo, CenterPo.x, CenterPo.y, R, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="Circle">圆</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static CircleS CalculateRotateCircle(PointD RotatePo, CircleS Circle, double RotateAngle)
        {
            return CalculateRotateCircle(RotatePo.x, RotatePo.y, Circle, RotateAngle);
        }
        #endregion

        #region 计算旋转后的圆弧
        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, double RotateAngle)
        {
            PointD StartPo = CalculateRotatePo(RotatePoX, RotatePoY, StartPoX, StartPoY, RotateAngle);   //起点
            PointD TwoPo = CalculateRotatePo(RotatePoX, RotatePoY, TwoPoX, TwoPoY, RotateAngle);         //中间点：第二点
            PointD EndPo = CalculateRotatePo(RotatePoX, RotatePoY, EndPoX, EndPoY, RotateAngle);         //终点
            return new ArcThreePoS(StartPo, TwoPo, EndPo);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPoX, StartPoY, TwoPo.x, TwoPo.y, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPoX, StartPoY, TwoPo, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPo, TwoPo.x, TwoPo.y, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, PointD StartPo, PointD TwoPo, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, StartPo, TwoPo, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePoX">旋转基点x坐标</param>
        /// <param name="RotatePoY">旋转基点y坐标</param>
        /// <param name="Arc">圆弧</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(double RotatePoX, double RotatePoY, ArcThreePoS Arc, double RotateAngle)
        {
            return CalculateRotateArc(RotatePoX, RotatePoY, Arc.StartPo, Arc.TwoPo, Arc.EndPo, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo.x, RotatePo.y, StartPoX, StartPoY, TwoPoX, TwoPoY, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPoX, StartPoY, TwoPo.x, TwoPo.y, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPoX, StartPoY, TwoPo, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPo, TwoPoX, TwoPoY, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPo">起点</</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPo, TwoPo.x, TwoPo.y, EndPoX, EndPoY, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">中间点：第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, PointD StartPo, PointD TwoPo, PointD EndPo, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo, StartPo, TwoPo, EndPo.x, EndPo.y, RotateAngle);
        }

        /// <summary>
        /// 计算旋转后的圆弧
        /// </summary>
        /// <param name="RotatePo">旋转基点</param>
        /// <param name="Arc">圆弧</param>
        /// <param name="RotateAngle">旋转角度</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateRotateArc(PointD RotatePo, ArcThreePoS Arc, double RotateAngle)
        {
            return CalculateRotateArc(RotatePo.x, RotatePo.y, Arc, RotateAngle);
        }
        #endregion

        #region 计算偏置后的直线
        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPoX">直线起点X坐标</param>
        /// <param name="StartPoY">直线起点Y坐标</param>
        /// <param name="EndPoX">直线终点X坐标</param>
        /// <param name="EndPoY">直线终点Y坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(double StartPoX, double StartPoY, double EndPoX, double EndPoY, double OffsetPoX, double OffsetPoY, double Distance)
        {
            Distance = Math.Abs(Distance);
            LineS Line = new LineS(StartPoX, StartPoY, EndPoX, EndPoY);
            double Angle = CalculateLineAngle(Line);
            PointD temp_po1 = CalculateLineEndPo(Line.StartPo, Angle + 90, Distance);
            PointD temp_po2 = CalculateLineEndPo(Line.StartPo, Angle - 90, Distance);
            if (CalculateTwoPoDistance(OffsetPoX, OffsetPoY, temp_po1) < CalculateTwoPoDistance(OffsetPoX, OffsetPoY, temp_po2))
            {
                PointD temp = CalculateLineEndPo(Line.EndPo, Angle + 90, Distance);
                return new LineS(temp_po1, temp);
            }
            else
            {
                PointD temp = CalculateLineEndPo(Line.EndPo, Angle - 90, Distance);
                return new LineS(temp_po2, temp);
            }
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPoX">直线起点X坐标</param>
        /// <param name="StartPoY">直线起点Y坐标</param>
        /// <param name="EndPoX">直线终点X坐标</param>
        /// <param name="EndPoY">直线终点Y坐标</param>
        /// <param name="OffsetPo">偏置基点</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(double StartPoX, double StartPoY, double EndPoX, double EndPoY, PointD OffsetPo, double Distance)
        {
            return CalculateOffsetLine(StartPoX, StartPoY, EndPoX, EndPoY, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPoX">直线起点X坐标</param>
        /// <param name="StartPoY">直线起点Y坐标</param>
        /// <param name="EndPo">直线终点</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(double StartPoX, double StartPoY, PointD EndPo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return CalculateOffsetLine(StartPoX, StartPoY, EndPo.x, EndPo.y, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPoX">直线起点X坐标</param>
        /// <param name="StartPoY">直线起点Y坐标</param>
        /// <param name="EndPo">直线终点</param>
        /// <param name="OffsetPo">偏置基点</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(double StartPoX, double StartPoY, PointD EndPo, PointD OffsetPo, double Distance)
        {
            return CalculateOffsetLine(StartPoX, StartPoY, EndPo, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPo">直线起点</param>
        /// <param name="EndPoX">直线终点X坐标</param>
        /// <param name="EndPoY">直线终点Y坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(PointD StartPo, double EndPoX, double EndPoY, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return CalculateOffsetLine(StartPo.x, StartPo.y, EndPoX, EndPoY, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPo">直线起点</param>
        /// <param name="EndPoX">直线终点X坐标</param>
        /// <param name="EndPoY">直线终点Y坐标</param>
        /// <param name="OffsetPo">偏置基点</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(PointD StartPo, double EndPoX, double EndPoY, PointD OffsetPo, double Distance)
        {
            return CalculateOffsetLine(StartPo, EndPoX, EndPoY, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPo">直线起点</param>
        /// <param name="EndPo">直线终点</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(PointD StartPo, PointD EndPo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return CalculateOffsetLine(StartPo, EndPo.x, EndPo.y, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="StartPo">直线起点</param>
        /// <param name="EndPo">直线终点</param>
        /// <param name="OffsetPo">偏置基点</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(PointD StartPo, PointD EndPo, PointD OffsetPo, double Distance)
        {
            return CalculateOffsetLine(StartPo, EndPo, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="Ling">直线</param>
        /// <param name="OffsetPo">偏置基点</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(LineS Line, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return CalculateOffsetLine(Line.StartPo, Line.EndPo, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的直线
        /// </summary>
        /// <param name="Ling">直线</param>
        /// <param name="OffsetPo">偏置基点</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static LineS CalculateOffsetLine(LineS Line, PointD OffsetPo, double Distance)
        {
            return CalculateOffsetLine(Line, OffsetPo.x, OffsetPo.y, Distance);
        }
        #endregion

        #region 获取偏移后的矩形
        /// <summary>
        /// 获取偏移后的矩形
        /// </summary>
        /// <param name="ReStartPoX">矩形起始点X坐标</param>
        /// <param name="ReStartPoY">矩形起始点Y坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static RectD GetRectOffset(double ReStartPoX, double ReStartPoY, double ReW, double ReH, double OffsetPoX, double OffsetPoY, double Distance)
        {
            RectD Re = new RectD(ReStartPoX, ReStartPoY, ReW, ReH);
            Distance = Math.Abs(Distance);
            Distance = IsPoInRectangleInside(ReStartPoX, ReStartPoY, ReW, ReH, OffsetPoX, OffsetPoY) ? Distance : -Distance;

            LineS ab = new LineS(Re.StartPo.x, Re.StartPo.y - Distance, Re.TwoPo.x, Re.TwoPo.y - Distance);
            LineS bc = new LineS(Re.TwoPo.x + Distance, Re.TwoPo.y, Re.ThreePo.x + Distance, Re.ThreePo.y);
            LineS cd = new LineS(Re.ThreePo.x, Re.ThreePo.y + Distance, Re.EndPo.x, Re.EndPo.y + Distance);
            LineS da = new LineS(Re.EndPo.x - Distance, Re.EndPo.y, Re.StartPo.x - Distance, Re.StartPo.y);

            PointD a = GetLineAndLineIntersection(ab, da);
            PointD c = GetLineAndLineIntersection(bc, cd);
            return new RectD(a, c.x - a.x, c.y - a.y);
        }

        /// <summary>
        /// 获取偏移后的矩形
        /// </summary>
        /// <param name="ReStartPoX">矩形起始点X坐标</param>
        /// <param name="ReStartPoY">矩形起始点X坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static RectD GetRectOffset(double ReStartPoX, double ReStartPoY, double ReW, double ReH, PointD OffsetPo, double Distance)
        {
            return GetRectOffset(ReStartPoX, ReStartPoY, ReW, ReH, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 获取偏移后的矩形
        /// </summary>
        /// <param name="ReStartPo">矩形起始点坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static RectD GetRectOffset(PointD ReStartPo, double ReW, double ReH, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetRectOffset(ReStartPo.x, ReStartPo.y, ReW, ReH, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 获取偏移后的矩形
        /// </summary>
        /// <param name="ReStartPo">矩形起始点坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static RectD GetRectOffset(PointD ReStartPo, double ReW, double ReH, PointD OffsetPo, double Distance)
        {
            return GetRectOffset(ReStartPo.x, ReStartPo.y, ReW, ReH, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 获取偏移后的矩形
        /// </summary>
        /// <param name="Re">矩形</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static RectD GetRectOffset(RectD Re, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetRectOffset(Re.StartPo, Re.w, Re.h, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 获取偏移后的矩形
        /// </summary>
        /// <param name="Re">矩形</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static RectD GetRectOffset(RectD Re, PointD OffsetPo, double Distance)
        {
            return GetRectOffset(Re, OffsetPo.x, OffsetPo.y, Distance);
        }
        #endregion

        #region 计算偏置后的三点圆弧
        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, double OffsetPoX, double OffsetPoY, double Distance)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);  //圆心
            double R = CalculateTwoPoDistance(ArcStartPoX, ArcStartPoY, CenterPo);                //半径
            double PoToCenterPoDistance = CalculateTwoPoDistance(CenterPo, OffsetPoX, OffsetPoY);  //点离圆心的距离
            double ro_a = CalculateLineAngle(CenterPo, ArcStartPoX, ArcStartPoY);
            double ro_b = CalculateLineAngle(CenterPo, ArcTwoPoX, ArcTwoPoY);
            double ro_c = CalculateLineAngle(CenterPo, ArcEndPoX, ArcEndPoY);
            Distance = Math.Abs(Distance);
            Distance = PoToCenterPoDistance > R ? Distance : -Distance;

            PointD po_a = CalculateLineEndPo(CenterPo, ro_a, R + Distance);
            PointD po_b = CalculateLineEndPo(CenterPo, ro_b, R + Distance);
            PointD po_c = CalculateLineEndPo(CenterPo, ro_c, R + Distance);
            return new ArcThreePoS(po_a, po_b, po_c);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点X坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPoX, ArcEndPoY, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPoX">圆弧起点X坐标</param>
        /// <param name="ArcStartPoY">圆弧起点Y坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPoX">圆弧第二点X坐标</param>
        /// <param name="ArcTwoPoY">圆弧第二点Y坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点X坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点X坐标</param>
        /// <param name="ArcEndPoX">圆弧终点X坐标</param>
        /// <param name="ArcEndPoY">圆弧终点Y坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPo, ArcEndPoX, ArcEndPoY, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点X坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcStartPo">圆弧起点坐标</param>
        /// <param name="ArcTwoPo">圆弧第二点X坐标</param>
        /// <param name="ArcEndPo">圆弧终点坐标</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo, PointD OffsetPo, double Distance)
        {
            return GetArcThreePoOffset(ArcStartPo, ArcTwoPo, ArcEndPo, OffsetPo.x, OffsetPo.y, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcThreePo">圆弧</param>
        /// <param name="OffsetPoX">偏置基点X坐标</param>
        /// <param name="OffsetPoY">偏置基点Y坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(ArcThreePoS ArcThreePo, double OffsetPoX, double OffsetPoY, double Distance)
        {
            return GetArcThreePoOffset(ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo, OffsetPoX, OffsetPoY, Distance);
        }

        /// <summary>
        /// 计算偏置后的三点圆弧
        /// </summary>
        /// <param name="ArcThreePo">圆弧</param>
        /// <param name="OffsetPo">偏置基点坐标</param>
        /// <param name="Distance">偏置距离</param>
        /// <returns></returns>
        public static ArcThreePoS GetArcThreePoOffset(ArcThreePoS ArcThreePo, PointD 偏置基点, double Distance)
        {
            return GetArcThreePoOffset(ArcThreePo, 偏置基点.x, 偏置基点.y, Distance);
        }
        #endregion

        #region 计算移动后的直线
        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPoX">直线的起点x坐标</param>
        /// <param name="StartPoY">直线的起点y坐标</param>
        /// <param name="EndPoX">直线的终点x坐标</param>
        /// <param name="EndPoY">直线的终点y坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(double StartPoX, double StartPoY, double EndPoX, double EndPoY, double MovePoX, double MovePoY)
        {
            PointD StartPo = new PointD(StartPoX + MovePoX, StartPoY + MovePoY);
            PointD EndPo = new PointD(EndPoX + MovePoX, EndPoY + MovePoY);
            return new LineS(StartPo, EndPo);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPoX">直线的起点x坐标</param>
        /// <param name="StartPoY">直线的起点y坐标</param>
        /// <param name="EndPoX">直线的终点x坐标</param>
        /// <param name="EndPoY">直线的终点y坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(double StartPoX, double StartPoY, double EndPoX, double EndPoY, PointD MovePo)
        {
            return CalculateMoveLine(StartPoX, StartPoY, EndPoX, EndPoY, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPoX">直线的起点x坐标</param>
        /// <param name="StartPoY">直线的起点y坐标</param>
        /// <param name="EndPo">直线的终点坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(double StartPoX, double StartPoY, PointD EndPo, double MovePoX, double MovePoY)
        {
            return CalculateMoveLine(StartPoX, StartPoY, EndPo.x, EndPo.y, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPoX"><直线的起点x坐标/param>
        /// <param name="StartPoY">直线的起点y坐标</param>
        /// <param name="EndPo">直线的终点坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(double StartPoX, double StartPoY, PointD EndPo, PointD MovePo)
        {
            return CalculateMoveLine(StartPoX, StartPoY, EndPo, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPo">直线的起点坐标</param>
        /// <param name="EndPoX">直线的终点x坐标</param>
        /// <param name="EndPoY">直线的终点y坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(PointD StartPo, double EndPoX, double EndPoY, double MovePoX, double MovePoY)
        {
            return CalculateMoveLine(StartPo.x, StartPo.y, EndPoX, EndPoY, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPo">直线的起点坐标</param>
        /// <param name="EndPoX">直线的终点x坐标</param>
        /// <param name="EndPoY">直线的终点y坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(PointD StartPo, double EndPoX, double EndPoY, PointD MovePo)
        {
            return CalculateMoveLine(StartPo.x, StartPo.y, EndPoX, EndPoY, MovePo);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPo">直线的起点坐标</param>
        /// <param name="EndPo">直线的终点坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(PointD StartPo, PointD EndPo, double MovePoX, double MovePoY)
        {
            return CalculateMoveLine(StartPo, EndPo.x, EndPo.y, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="StartPo">直线的起点坐标</param>
        /// <param name="EndPo">直线的终点坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(PointD StartPo, PointD EndPo, PointD MovePo)
        {
            return CalculateMoveLine(StartPo, EndPo, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(LineS Line, double MovePoX, double MovePoY)
        {
            return CalculateMoveLine(Line.StartPo, Line.EndPo, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的直线
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static LineS CalculateMoveLine(LineS Line, PointD MovePo)
        {
            return CalculateMoveLine(Line, MovePo.x, MovePo.y);
        }
        #endregion

        #region 计算移动后的圆弧
        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, double MovePoX, double MovePoY)
        {
            PointD StartPo = new PointD(StartPoX + MovePoX, StartPoY + MovePoY);
            PointD TwoPo = new PointD(TwoPoX + MovePoX, TwoPoY + MovePoY);
            PointD EndPo = new PointD(EndPoX + MovePoX, EndPoY + MovePoY);
            return new ArcThreePoS(StartPo, TwoPo, EndPo);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, PointD MovePo)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPoX, EndPoY, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点x坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo.x, EndPo.y, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo, PointD MovePo)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPo.x, TwoPo.y, EndPoX, EndPoY, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY, PointD MovePo)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPo, EndPoX, EndPoY, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPo, EndPo.x, EndPo.y, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo, PointD MovePo)
        {
            return CalculateMoveArc(StartPoX, StartPoY, TwoPo, EndPo, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPoX, EndPoY, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY, PointD MovePo)
        {
            return CalculateMoveArc(StartPo, TwoPoX, TwoPoY, EndPoX, EndPoY, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPo, TwoPoX, TwoPoY, EndPo.x, EndPo.y, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPoX">第二点x坐标</param>
        /// <param name="TwoPoY">第二点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo, PointD MovePo)
        {
            return CalculateMoveArc(StartPo, TwoPoX, TwoPoY, EndPo, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPo, TwoPo.x, TwoPo.y, EndPoX, EndPoY, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY, PointD MovePo)
        {
            return CalculateMoveArc(StartPo, TwoPo, EndPoX, EndPoY, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, PointD TwoPo, PointD EndPo, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(StartPo, TwoPo, EndPo.x, EndPo.y, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="TwoPo">第二点</param>
        /// <param name="EndPo">终点</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(PointD StartPo, PointD TwoPo, PointD EndPo, PointD MovePo)
        {
            return CalculateMoveArc(StartPo, TwoPo, EndPo.x, EndPo.y, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="Arc">圆弧</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(ArcThreePoS Arc, double MovePoX, double MovePoY)
        {
            return CalculateMoveArc(Arc.StartPo, Arc.TwoPo, Arc.EndPo, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆弧
        /// </summary>
        /// <param name="Arc">圆弧</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static ArcThreePoS CalculateMoveArc(ArcThreePoS Arc, PointD MovePo)
        {
            return CalculateMoveArc(Arc.StartPo, Arc.TwoPo, Arc.EndPo, MovePo.x, MovePo.y);
        }
        #endregion

        #region 计算移动后的圆
        /// <summary>
        /// 计算移动后的圆
        /// </summary>
        /// <param name="CenterPoX">圆心x坐标</param>
        /// <param name="CenterPoY">圆心y坐标</param>
        /// <param name="R">半径</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static CircleS CalculateMoveCircle(double CenterPoX, double CenterPoY, double R, double MovePoX, double MovePoY)
        {
            PointD CenterPo = new PointD(CenterPoX + MovePoX, CenterPoY + MovePoY);
            return new CircleS(CenterPo, R);
        }

        /// <summary>
        /// 计算移动后的圆
        /// </summary>
        /// <param name="CenterPoX">圆心x坐标</param>
        /// <param name="CenterPoY">圆心y坐标</param>
        /// <param name="R">半径</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static CircleS CalculateMoveCircle(double CenterPoX, double CenterPoY, double R, PointD MovePo)
        {
            return CalculateMoveCircle(CenterPoX, CenterPoY, R, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆
        /// </summary>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static CircleS CalculateMoveCircle(PointD CenterPo, double R, double MovePoX, double MovePoY)
        {
            return CalculateMoveCircle(CenterPo.x, CenterPo.y, R, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆
        /// </summary>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static CircleS CalculateMoveCircle(PointD CenterPo, double R, PointD MovePo)
        {
            return CalculateMoveCircle(CenterPo, R, MovePo.x, MovePo.y);
        }

        /// <summary>
        /// 计算移动后的圆
        /// </summary>
        /// <param name="Circle">圆</param>
        /// <param name="MovePoX">移动x坐标距离</param>
        /// <param name="MovePoY">移动y坐标距离</param>
        /// <returns></returns>
        public static CircleS CalculateMoveCircle(CircleS Circle, double MovePoX, double MovePoY)
        {
            return CalculateMoveCircle(Circle.CenterPo, Circle.R, MovePoX, MovePoY);
        }

        /// <summary>
        /// 计算移动后的圆
        /// </summary>
        /// <param name="Circle">圆</param>
        /// <param name="MovePo">移动坐标距离</param>
        /// <returns></returns>
        public static CircleS CalculateMoveCircle(CircleS Circle, PointD MovePo)
        {
            return CalculateMoveCircle(Circle, MovePo.x, MovePo.y);
        }
        #endregion

        #region 计算两点之间的距离
        /// <summary>
        /// 计算两点之间的距离
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点Y坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static double CalculateTwoPoDistance(double StartPoX, double StartPoY, double EndPoX, double EndPoY)
        {
            double a = Math.Abs(StartPoX - EndPoX);
            double b = Math.Abs(StartPoY - EndPoY);
            return Math.Sqrt(a * a + b * b);
        }

        /// <summary>
        /// 计算两点之间的距离
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点Y坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static double CalculateTwoPoDistance(double StartPoX, double StartPoY, PointD EndPo)
        {
            return CalculateTwoPoDistance(StartPoX, StartPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算两点之间的距离
        /// </summary>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static double CalculateTwoPoDistance(PointD StartPo, double EndPoX, double EndPoY)
        {
            return CalculateTwoPoDistance(StartPo.x, StartPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 计算两点之间的距离
        /// </summary>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static double CalculateTwoPoDistance(PointD StartPo, PointD EndPo)
        {
            return CalculateTwoPoDistance(StartPo.x, StartPo.y, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算直线长度
        /// </summary>
        /// <param name="Line">直线</param>
        /// <returns></returns>
        public static double CalculateLineLength(LineS Line)
        {
            return CalculateTwoPoDistance(Line.StartPo, Line.EndPo);
        }
        #endregion

        #region 获取圆弧中点
        public static PointD 获取圆弧中点(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(x1, y1, x2, y2, x3, y3);           //圆心
            double ArcMidPoAngle = CalculateArcThreePoMidPoAngle(x1, y1, x2, y2, x3, y3);     //圆弧中点角度
            List<PointD> EffectivePo = 获取直线与圆弧的有效交点(CenterPo, CalculateLineEndPo(CenterPo, ArcMidPoAngle, CalculateTwoPoDistance(CenterPo, x1, y1) * 2), new ArcThreePoS(x1, y1, x2, y2, x3, y3));
            return EffectivePo[0];
        }

        public static PointD 获取圆弧中点(double x1, double y1, double x2, double y2, PointD a)
        {
            return 获取圆弧中点(x1, y1, x2, y2, a.x, a.y);
        }

        public static PointD 获取圆弧中点(double x1, double y1, PointD a, double x2, double y2)
        {
            return 获取圆弧中点(x1, y1, a.x, a.y, x2, y2);
        }

        public static PointD 获取圆弧中点(double x, double y, PointD a, PointD b)
        {
            return 获取圆弧中点(x, y, a, b.x, b.y);
        }

        public static PointD 获取圆弧中点(PointD a, double x1, double y1, double x2, double y2)
        {
            return 获取圆弧中点(a.x, a.y, x1, y1, x2, y2);
        }

        public static PointD 计算圆弧中点(PointD a, double x, double y, PointD b)
        {
            return 获取圆弧中点(a, x, y, b.x, b.y);
        }

        public static PointD 获取圆弧中点(PointD a, PointD b, double x, double y)
        {
            return 获取圆弧中点(a, b.x, b.y, x, y);
        }

        public static PointD 获取圆弧中点(PointD a, PointD b, PointD c)
        {
            return 获取圆弧中点(a, b, c.x, c.y);
        }

        public static PointD 获取圆弧中点(ArcThreePoS a)
        {
            return 获取圆弧中点(a.StartPo, a.TwoPo, a.EndPo);
        }
        #endregion

        #region 三点坐标计算圆心
        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(double OnePoX, double OnePoY, double TwoPoX, double TwoPoY, double ThreePoX, double ThreePoY)
        {
            double a = 2 * (TwoPoX - OnePoX);
            double b = 2 * (TwoPoY - OnePoY);
            double c = TwoPoX * TwoPoX + TwoPoY * TwoPoY - OnePoX * OnePoX - OnePoY * OnePoY;
            double d = 2 * (ThreePoX - TwoPoX);
            double e = 2 * (ThreePoY - TwoPoY);
            double f = ThreePoX * ThreePoX + ThreePoY * ThreePoY - TwoPoX * TwoPoX - TwoPoY * TwoPoY;
            double x = (b * f - e * c) / (b * d - e * a);
            double y = (d * c - a * f) / (b * d - e * a);
            return new PointD(x, y);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(double OnePoX, double OnePoY, double TwoPoX, double TwoPoY, PointD ThreePo)
        {
            return ThreePoCalculateCircleCenter(OnePoX, OnePoY, TwoPoX, TwoPoY, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(double OnePoX, double OnePoY, PointD TwoPo, double ThreePoX, double ThreePoY)
        {
            return ThreePoCalculateCircleCenter(OnePoX, OnePoY, TwoPo.x, TwoPo.y, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(double OnePoX, double OnePoY, PointD TwoPo, PointD ThreePo)
        {
            return ThreePoCalculateCircleCenter(OnePoX, OnePoY, TwoPo.x, TwoPo.y, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(PointD OnePo, double TwoPoX, double TwoPoY, double ThreePoX, double ThreePoY)
        {
            return ThreePoCalculateCircleCenter(OnePo.x, OnePo.y, TwoPoX, TwoPoY, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(PointD OnePo, double TwoPoX, double TwoPoY, PointD ThreePo)
        {
            return ThreePoCalculateCircleCenter(OnePo.x, OnePo.y, TwoPoX, TwoPoY, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(PointD OnePo, PointD TwoPo, double ThreePoX, double ThreePoY)
        {
            return ThreePoCalculateCircleCenter(OnePo, TwoPo.x, TwoPo.y, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 三点坐标计算圆心
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static PointD ThreePoCalculateCircleCenter(PointD OnePo, PointD TwoPo, PointD ThreePo)
        {
            return ThreePoCalculateCircleCenter(OnePo, TwoPo, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 获取圆弧心
        /// </summary>
        /// <param name="Arc">圆弧</param>
        /// <returns></returns>
        public static PointD GetArcCenter(ArcThreePoS Arc)
        {
            return ThreePoCalculateCircleCenter(Arc.StartPo, Arc.TwoPo, Arc.EndPo);
        }
        #endregion

        #region 直线中点移位计算
        public static LineS 直线中点移位计算(PointD 直线起点, PointD 直线终点, PointD 新中点)
        {
            return 直线中点移位计算(new LineS(直线起点, 直线终点), 新中点);
        }

        public static LineS 直线中点移位计算(LineS 直线, PointD 新中点)
        {
            double x差距 = 新中点.x - 直线.MidPo.x;
            double y差距 = 新中点.y - 直线.MidPo.y;
            double x1 = 直线.StartPo.x + x差距;
            double y1 = 直线.StartPo.y + y差距;
            double x2 = 直线.EndPo.x + x差距;
            double y2 = 直线.EndPo.y + y差距;
            return new LineS(new PointD(x1, y1), new PointD(x2, y2));
        }
        #endregion

        #region 计算三点圆弧中角度
        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点Y坐标</param>
        /// <param name="TwoPoX">第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPoX, EndPoY);
            double MidPoAngle = (CalculateLineAngle(CenterPo, StartPoX, StartPoY) + CalculateLineAngle(CenterPo, EndPoX, EndPoY)) / 2;
            if (!IsThePointWithinTheArcAngleRange(new ArcThreePoS(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPoX, EndPoY), CalculateLineEndPo(CenterPo, MidPoAngle, 5)))
                MidPoAngle -= 180;
            MidPoAngle = MidPoAngle < 0 ? MidPoAngle + 360 : MidPoAngle;
            return MidPoAngle;
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点Y坐标</param>
        /// <param name="TwoPoX">第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            return CalculateArcThreePoMidPoAngle(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点Y坐标</param>
        /// <param name="TwoPo">第二点坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY)
        {
            return CalculateArcThreePoMidPoAngle(StartPoX, StartPoY, TwoPo.x, TwoPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点Y坐标</param>
        /// <param name="TwoPo">第二点坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo)
        {
            return CalculateArcThreePoMidPoAngle(StartPoX, StartPoY, TwoPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPo">起点X坐标</param>
        /// <param name="TwoPoX">第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            return CalculateArcThreePoMidPoAngle(StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPoX, EndPoY);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPo">起点X坐标</param>
        /// <param name="TwoPoX">第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            return CalculateArcThreePoMidPoAngle(StartPo, TwoPoX, TwoPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPo">起点X坐标</param>
        /// <param name="TwoPo">第二点坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY)
        {
            return CalculateArcThreePoMidPoAngle(StartPo, TwoPo.x, TwoPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="StartPo">起点X坐标</param>
        /// <param name="TwoPo">第二点坐标</param>
        /// <param name="EndPo">终点X坐标</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(PointD StartPo, PointD TwoPo, PointD EndPo)
        {
            return CalculateArcThreePoMidPoAngle(StartPo, TwoPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算三点圆弧中角度
        /// </summary>
        /// <param name="ArcThreePo">三点圆弧</param>
        /// <returns></returns>
        public static double CalculateArcThreePoMidPoAngle(ArcThreePoS ArcThreePo)
        {
            return CalculateArcThreePoMidPoAngle(ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }
        #endregion

        #region 计算圆弧起始角度
        /// <summary>t
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(double OnePoX, double OnePoY, double TwoPoX, double TwoPoY, double ThreePoX, double ThreePoY)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(OnePoX, OnePoY, TwoPoX, TwoPoY, ThreePoX, ThreePoY);  //圆心wws坐标
            double Angle1 = CalculateLineAngle(CenterPo, OnePoX, OnePoY);   //角度1
            double Angle2 = CalculateLineAngle(CenterPo, TwoPoX, TwoPoY);   //角度2
            double Angle3 = CalculateLineAngle(CenterPo, ThreePoX, ThreePoY);   //角度3
            double[] Angle = new double[2];  //角度

            //顺向
            if (Angle1 > Angle2 && Angle2 > Angle3 && (Angle3 - Angle1) > -360)
            {
                Angle[0] = Angle1;
                Angle[1] = Angle3 - Angle1;
                return Angle;
            }
            if (Angle1 > Angle2 && Angle2 > (Angle3 - 360) && ((Angle3 - 360) - Angle1) > -360)
            {
                Angle[0] = Angle1;
                Angle[1] = (Angle3 - 360) - Angle1;
                return Angle;
            }
            if (Angle1 > (Angle2 - 360) && (Angle2 - 360) > (Angle3 - 360) && ((Angle3 - 360) - Angle1) > -360)
            {
                Angle[0] = Angle1;
                Angle[1] = (Angle3 - 360) - Angle1;
                return Angle;
            }

            //逆向
            if (Angle1 < Angle2 && Angle2 < Angle3 && (Angle3 - Angle1) < 360)
            {
                Angle[0] = Angle1;
                Angle[1] = Angle3 - Angle1;
                return Angle;
            }
            if (Angle1 < (Angle2 + 360) && (Angle2 + 360) < (Angle3 + 360) && ((Angle3 + 360) - Angle1) < 360)
            {
                Angle[0] = Angle1;
                Angle[1] = (Angle3 + 360) - Angle1;
                return Angle;
            }
            if (Angle1 < Angle2 && Angle2 < (Angle3 + 360) && ((Angle3 + 360) - Angle1) < 360)
            {
                Angle[0] = Angle1;
                Angle[1] = (Angle3 + 360) - Angle1;
                return Angle;
            }
            return Angle;
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(double OnePoX, double OnePoY, double TwoPoX, double TwoPoY, PointD ThreePo)
        {
            return CalculationArcStartAngleAndEndStart(OnePoX, OnePoY, TwoPoX, TwoPoY, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(double OnePoX, double OnePoY, PointD TwoPo, double ThreePoX, double ThreePoY)
        {
            return CalculationArcStartAngleAndEndStart(OnePoX, OnePoY, TwoPo.x, TwoPo.y, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(double OnePoX, double OnePoY, PointD TwoPo, PointD ThreePo)
        {
            return CalculationArcStartAngleAndEndStart(OnePoX, OnePoY, TwoPo, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(PointD OnePo, double TwoPoX, double TwoPoY, double ThreePoX, double ThreePoY)
        {
            return CalculationArcStartAngleAndEndStart(OnePo.x, OnePo.y, TwoPoX, TwoPoY, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(PointD OnePo, double TwoPoX, double TwoPoY, PointD ThreePo)
        {
            return CalculationArcStartAngleAndEndStart(OnePo, TwoPoX, TwoPoY, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(PointD OnePo, PointD TwoPo, double ThreePoX, double ThreePoY)
        {
            return CalculationArcStartAngleAndEndStart(OnePo, TwoPo.x, TwoPo.y, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="OnePo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePo"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(PointD OnePo, PointD TwoPo, PointD ThreePo)
        {
            return CalculationArcStartAngleAndEndStart(OnePo, TwoPo, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 计算圆弧起始角度
        /// </summary>
        /// <param name="Arc"></param>
        /// <returns></returns>
        public static double[] CalculationArcStartAngleAndEndStart(ArcThreePoS Arc)
        {
            return CalculationArcStartAngleAndEndStart(Arc.StartPo, Arc.TwoPo, Arc.EndPo);
        }
        #endregion

        #region 计算直线角度
        /// <summary>
        /// 计算直线角度
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY">终点y坐标</param>
        /// <returns></returns>
        public static double CalculateLineAngle(double StartPoX, double StartPoY, double EndPoX, double EndPoY)
        {
            double a = Math.Atan2(EndPoX - StartPoX, EndPoY - StartPoY) * 180 / Math.PI - 90;
            return a > 0 ? 360 - a : Math.Abs(a);
        }

        /// <summary>
        /// 计算直线角度
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="EndPoX">终点x坐标</param>
        /// <param name="EndPoY"></param>
        /// <returns>终点y坐标</returns>
        public static double CalculateLineAngle(PointD StartPo, double EndPoX, double EndPoY)
        {
            return CalculateLineAngle(StartPo.x, StartPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 计算直线角度
        /// </summary>
        /// <param name="StartPoX">起点x坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="EndPo">终点</param>
        /// <returns></returns>
        public static double CalculateLineAngle(double StartPoX, double StartPoY, PointD EndPo)
        {
            return CalculateLineAngle(StartPoX, StartPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算直线角度
        /// </summary>
        /// <param name="StartPo">起点</param>
        /// <param name="EndPo">终点</param>
        /// <returns></returns>
        public static double CalculateLineAngle(PointD StartPo, PointD EndPo)
        {
            return CalculateLineAngle(StartPo.x, StartPo.y, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 计算直线角度
        /// </summary>
        /// <param name="Line">直线</param>
        /// <returns></returns>
        public static double CalculateLineAngle(LineS Line)
        {
            return CalculateLineAngle(Line.StartPo, Line.EndPo);
        }
        #endregion

        #region 计算点到直线的距离
        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double PoX, double PoY)
        {
            double LineLength = CalculateTwoPoDistance(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY);  //直线长度
            double PoToLineStartPoLength = CalculateTwoPoDistance(LineStartPoX, LineStartPoY, PoX, PoY);     //点到起点长度
            double PoToLineEndPoLength = CalculateTwoPoDistance(LineEndPoX, LineEndPoY, PoX, PoY);           //点到终点长度

            if ((PoToLineStartPoLength * PoToLineStartPoLength) >= (LineLength * LineLength + PoToLineEndPoLength * PoToLineEndPoLength))
                return PoToLineEndPoLength;
            if ((PoToLineEndPoLength * PoToLineEndPoLength) >= (LineLength * LineLength + PoToLineStartPoLength * PoToLineStartPoLength))
                return PoToLineStartPoLength;
            if (LineStartPoX == LineEndPoX)
                return Math.Abs(PoX - LineStartPoX);
            if (LineStartPoY == LineEndPoY)
                return Math.Abs(PoY - LineStartPoY);
            return CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD Po)
        {
            return CalculationPoToLineDimension(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double PoX, double PoY)
        {
            return CalculationPoToLineDimension(LineStartPoX, LineStartPoY, LineEndPo.x, LineEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD Po)
        {
            return CalculationPoToLineDimension(LineStartPoX, LineStartPoY, LineEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double PoX, double PoY)
        {
            return CalculationPoToLineDimension(LineStartPo.x, LineStartPo.y, LineEndPoX, LineEndPoY, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD Po)
        {
            return CalculationPoToLineDimension(LineStartPo, LineEndPoX, LineEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(PointD LineStartPo, PointD LineEndPo, double PoX, double PoY)
        {
            return CalculationPoToLineDimension(LineStartPo, LineEndPo.x, LineEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(PointD LineStartPo, PointD LineEndPo, PointD Po)
        {
            return CalculationPoToLineDimension(LineStartPo, LineEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(LineS Line, double PoX, double PoY)
        {
            return CalculationPoToLineDimension(Line.StartPo, Line.EndPo, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的距离
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineDimension(LineS Line, PointD Po)
        {
            return CalculationPoToLineDimension(Line, Po.x, Po.y);
        }
        #endregion

        #region 计算点到直线的垂直距离
        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double PoX, double PoY)
        {
            if (LineStartPoX == LineEndPoX)
                return Math.Abs(PoX - LineStartPoX);
            if (LineStartPoY == LineEndPoY)
                return Math.Abs(PoY - LineStartPoY);
            double lineK = (LineEndPoY - LineStartPoY) / (LineEndPoX - LineStartPoX);
            double lineC = (LineEndPoX * LineStartPoY - LineStartPoX * LineEndPoY) / (LineEndPoX - LineStartPoX);
            return Math.Abs(lineK * PoX - PoY + lineC) / Math.Sqrt(lineK * lineK + 1);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD Po)
        {
            return CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double PoX, double PoY)
        {
            return CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPo.x, LineEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPoX">直线起点x坐标</param>
        /// <param name="LineStartPoY">直线起点y坐标</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD Po)
        {
            return CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        public static double CalculationPoToLineVerticalDimension(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double PoX, double PoY)
        {
            return CalculationPoToLineVerticalDimension(LineStartPo.x, LineStartPo.y, LineEndPoX, LineEndPoY, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPoX">直线终点x坐标</param>
        /// <param name="LineEndPoY">直线终点y坐标</param>
        /// <param name="Po">点</param>
        public static double CalculationPoToLineVerticalDimension(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD Po)
        {
            return CalculationPoToLineVerticalDimension(LineStartPo, LineEndPoX, LineEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        public static double CalculationPoToLineVerticalDimension(PointD LineStartPo, PointD LineEndPo, double PoX, double PoY)
        {
            return CalculationPoToLineVerticalDimension(LineStartPo, LineEndPo.x, LineEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="LineStartPo">直线起点</param>
        /// <param name="LineEndPo">直线终点</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(PointD LineStartPo, PointD LineEndPo, PointD Po)
        {
            return CalculationPoToLineVerticalDimension(LineStartPo, LineEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="PoX">点x坐标</param>
        /// <param name="PoY">点y坐标</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(LineS Line, double PoX, double PoY)
        {
            return CalculationPoToLineVerticalDimension(Line.StartPo, Line.EndPo, PoX, PoY);
        }

        /// <summary>
        /// 计算点到直线的垂直距离
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="Po">点</param>
        /// <returns></returns>
        public static double CalculationPoToLineVerticalDimension(LineS Line, PointD Po)
        {
            return CalculationPoToLineVerticalDimension(Line, Po.x, Po.y);
        }
        #endregion

        #region 计算点到圆的距离
        public static double 计算点到圆的距离(double 圆心x, double 圆心y, double r, double 点x, double 点y)
        {
            return 计算点到圆的距离(new PointD(圆心x, 圆心y), r, new PointD(点x, 点y));
        }

        public static double 计算点到圆的距离(double 圆心x, double 圆心y, double r, PointD 点)
        {
            return 计算点到圆的距离(new PointD(圆心x, 圆心y), r, 点);
        }

        public static double 计算点到圆的距离(PointD 圆心, double r, double 点x, double 点y)
        {
            return 计算点到圆的距离(圆心, r, new PointD(点x, 点y));
        }

        public static double 计算点到圆的距离(PointD 圆心, double r, PointD 点)
        {
            return Math.Abs(CalculateTwoPoDistance(圆心, 点) - r);
        }

        public static double 计算点到圆的距离(CircleS 圆, PointD 点)
        {
            return 计算点到圆的距离(圆.CenterPo, 圆.R, 点);
        }
        #endregion

        #region 计算点到圆弧的距离
        public static double 计算点到圆弧的距离(PointD a, PointD b, PointD c, PointD 点)
        {
            PointD 圆心 = ThreePoCalculateCircleCenter(a, b, c);
            double 圆弧半径 = CalculateTwoPoDistance(圆心, a);
            double 点到圆心的距离 = CalculateTwoPoDistance(圆心, 点);
            double 点到a的距离 = CalculateTwoPoDistance(点, a);
            double 点到c的距离 = CalculateTwoPoDistance(点, c);
            return IsThePointWithinTheArcAngleRange(a, b, c, 点) ? 点到圆心的距离 - 圆弧半径 : (点到a的距离 < 点到c的距离 ? 点到a的距离 : 点到c的距离);
        }

        public static double 计算点到圆弧的距离(ArcThreePoS 圆弧, PointD 点)
        {
            return 计算点到圆弧的距离(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo, 点);
        }
        #endregion

        #region 获取直线到直线的距离
        /// <summary>
        /// 获取直线到直线的距离
        /// </summary>
        /// <param name="L1a">直线1起点</param>
        /// <param name="L1b">直线1终点</param>
        /// <param name="L2a">直线2起点</param>
        /// <param name="L2b">直线2终点</param>
        /// <returns></returns>
        public static double GetLineToLineDistance(PointD L1a, PointD L1b, PointD L2a, PointD L2b)
        {
            double Distance = CalculateTwoPoDistance(L1a, L2a);
            if (Distance > CalculateTwoPoDistance(L1a, L2b))
                Distance = CalculateTwoPoDistance(L1a, L2b);
            if (Distance > CalculateTwoPoDistance(L1b, L2a))
                Distance = CalculateTwoPoDistance(L1b, L2a);
            if (Distance > CalculateTwoPoDistance(L1b, L2b))
                Distance = CalculateTwoPoDistance(L1b, L2b);
            if (Distance > CalculationPoToLineVerticalDimension(L1a, L1b, L2a))
                Distance = CalculationPoToLineVerticalDimension(L1a, L1b, L2a);
            if (Distance > CalculationPoToLineVerticalDimension(L1a, L1b, L2b))
                Distance = CalculationPoToLineVerticalDimension(L1a, L1b, L2b);
            if (Distance > CalculationPoToLineVerticalDimension(L2a, L2b, L1a))
                Distance = CalculationPoToLineVerticalDimension(L2a, L2b, L1a);
            if (Distance > CalculationPoToLineVerticalDimension(L2a, L2b, L1b))
                Distance = CalculationPoToLineVerticalDimension(L2a, L2b, L1b);
            return Distance;
        }

        /// <summary>
        /// 获取直线到直线的距离
        /// </summary>
        /// <param name="L1a">直线1起点</param>
        /// <param name="L1b">直线1终点</param>
        /// <param name="L2">直线2</param>
        /// <returns></returns>
        public static double GetLineToLineDistance(PointD L1a, PointD L1b, LineS L2)
        {
            return GetLineToLineDistance(L1a, L1b, L2.StartPo, L2.EndPo);
        }

        /// <summary>
        /// 获取直线到直线的距离
        /// </summary>
        /// <param name="L1">直线1</param>
        /// <param name="L2a">直线2起点</param>
        /// <param name="L2b">直线2终点</param>
        /// <returns></returns>
        public static double GetLineToLineDistance(LineS L1, PointD L2a, PointD L2b)
        {
            return GetLineToLineDistance(L1.StartPo, L1.EndPo, L2a, L2b);
        }

        /// <summary>
        /// 获取直线到直线的距离
        /// </summary>
        /// <param name="L1">直线1</param>
        /// <param name="L2">直线2</param>
        /// <returns></returns>
        public static double GetLineToLineDistance(LineS L1, LineS L2)
        {
            return GetLineToLineDistance(L1.StartPo, L1.EndPo, L2);
        }
        #endregion

        #region 计算直线延长指定长度
        public static LineS 计算直线起点延长指定长度(PointD 直线起点, PointD 直线终点, double 长度)
        {
            PointD 终点 = CalculateLineEndPo(直线起点, CalculateLineAngle(直线起点, 直线终点), CalculateTwoPoDistance(直线起点, 直线终点) + 长度);
            return new LineS(直线起点, 终点);
        }

        public static LineS 计算直线起点延长指定长度(LineS 直线, double 长度)
        {
            return 计算直线起点延长指定长度(直线.StartPo, 直线.EndPo, 长度);
        }

        public static LineS 计算直线终点延长指定长度(PointD 直线起点, PointD 直线终点, double 长度)
        {
            PointD 起点 = CalculateLineEndPo(直线终点, CalculateLineAngle(直线终点, 直线起点), CalculateTwoPoDistance(直线起点, 直线终点) + 长度);
            return new LineS(直线终点, 起点);
        }

        public static LineS 计算直线终点延长指定长度(LineS 直线, double 长度)
        {
            return 计算直线终点延长指定长度(直线.StartPo, 直线.EndPo, 长度);
        }
        #endregion

        #region 获取圆弧的最大点和最小点
        public static PointD[] 获取圆弧的最大点和最小点(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return 获取圆弧的最大点和最小点(new PointD(x1, y1), new PointD(x2, y2), new PointD(x3, y3));
        }

        public static PointD[] 获取圆弧的最大点和最小点(double x1, double y1, double x2, double y2, PointD c)
        {
            return 获取圆弧的最大点和最小点(new PointD(x1, y1), new PointD(x2, y2), c);
        }

        public static PointD[] 获取圆弧的最大点和最小点(double x1, double y1, PointD b, double x3, double y3)
        {
            return 获取圆弧的最大点和最小点(new PointD(x1, y1), b, new PointD(x3, y3));
        }

        public static PointD[] 获取圆弧的最大点和最小点(double x1, double y1, PointD b, PointD c)
        {
            return 获取圆弧的最大点和最小点(new PointD(x1, y1), b, c);
        }

        public static PointD[] 获取圆弧的最大点和最小点(PointD a, double x2, double y2, double x3, double y3)
        {
            return 获取圆弧的最大点和最小点(a, new PointD(x2, y2), new PointD(x3, y3));
        }

        public static PointD[] 获取圆弧的最大点和最小点(PointD a, double x2, double y2, PointD c)
        {
            return 获取圆弧的最大点和最小点(a, new PointD(x2, y2), c);
        }

        public static PointD[] 获取圆弧的最大点和最小点(PointD a, PointD b, double x3, double y3)
        {
            return 获取圆弧的最大点和最小点(a, b, new PointD(x3, y3));
        }

        public static PointD[] 获取圆弧的最大点和最小点(PointD a, PointD b, PointD c)
        {
            double 最小x = a.x;
            double 最小y = a.y;
            double 最大x = a.x;
            double 最大y = a.y;
            List<PointD> 有效象限点 = GetArcEffectiveQuadrant(a, b, c);
            for (int i = 0; i < 有效象限点.Count(); i++)
            {
                if (有效象限点[i].x < 最小x)
                    最小x = 有效象限点[i].x;
                if (有效象限点[i].y < 最小y)
                    最小y = 有效象限点[i].y;
                if (有效象限点[i].x > 最大x)
                    最大x = 有效象限点[i].x;
                if (有效象限点[i].y > 最大y)
                    最大y = 有效象限点[i].y;
            }
            if (a.x < 最小x)
                最小x = a.x;
            if (a.y < 最小y)
                最小y = a.y;
            if (a.x > 最大x)
                最大x = a.x;
            if (a.y > 最大y)
                最大y = a.y;
            if (b.x < 最小x)
                最小x = b.x;
            if (b.y < 最小y)
                最小y = b.y;
            if (b.x > 最大x)
                最大x = b.x;
            if (b.y > 最大y)
                最大y = b.y;
            return new PointD[] { new PointD(最小x, 最小y), new PointD(最大x, 最大y) };
        }

        public static PointD[] 获取圆弧的最大点和最小点(ArcThreePoS 圆弧)
        {
            return 获取圆弧的最大点和最小点(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }
        #endregion

        #region 获取点到圆的切点
        public static PointD[] 获取点到圆的切点(PointD 圆心, double 半径, PointD 点)
        {
            PointD E = new PointD();
            PointD F = new PointD();
            PointD[] 切点 = new PointD[2];
            切点[0] = new PointD();
            切点[1] = new PointD();
            //坐标平移到圆心处,求园外点的新坐标E
            E.x = 点.x - 圆心.x;
            E.y = 点.y - 圆心.y; //平移变换到E

            //求圆与OE的交点坐标F, 相当于E的缩放变换
            double t = 半径 / Math.Sqrt(E.x * E.x + E.y * E.y); //得到缩放比例
            F.x = E.x * t;
            F.y = E.y * t; //缩放变换到F

            //将E旋转变换角度a到切点G，其中cos(a)=r/OF=t, 所以a=arccos(t);
            double a = Math.Acos(t); //得到旋转角度
            切点[0].x = F.x * Math.Cos(a) - F.y * Math.Sin(a) + 圆心.x;
            切点[0].y = F.x * Math.Sin(a) + F.y * Math.Cos(a) + 圆心.y;  //旋转变换到G

            切点[1].x = F.x * Math.Cos(-a) - F.y * Math.Sin(-a) + 圆心.x;
            切点[1].y = F.x * Math.Sin(-a) + F.y * Math.Cos(-a) + 圆心.y; //旋转变换到G
            return 切点;
        }

        public static PointD[] 获取点到圆的切点(CircleS 圆, PointD 点)
        {
            return 获取点到圆的切点(圆.CenterPo, 圆.R, 点);
        }
        #endregion

        #region 获取点到圆弧的切点
        public static PointD[] 获取点到圆弧的切点(PointD a, PointD b, PointD c, PointD 点)
        {
            PointD 圆心 = ThreePoCalculateCircleCenter(a, b, c);
            double 半径 = CalculateTwoPoDistance(a, 圆心);
            return 获取点到圆的切点(圆心, 半径, 点);
        }

        public static PointD[] 获取点到圆弧的切点(ArcThreePoS 圆弧, PointD 点)
        {
            return 获取点到圆弧的切点(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo, 点);
        }
        #endregion

        #region 获取点到圆弧的有效切点
        public static PointD[] 获取点到圆弧的有效切点(PointD a, PointD b, PointD c, PointD 点)
        {
            PointD[] 切点 = 获取点到圆弧的切点(a, b, c, 点);
            for (int i = 0; i < 2; i++)
            {
                if (!IsThePointWithinTheArcAngleRange(a, b, c, 点))
                    切点[i] = null;
            }
            return 切点;
        }

        public static PointD[] 获取点到圆弧的有效切点(ArcThreePoS 圆弧, PointD 点)
        {
            return 获取点到圆弧的有效切点(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo, 点);
        }
        #endregion

        #region 获取点到直线的垂点
        public static PointD 获取点到直线的垂点(PointD a, PointD b, PointD 点)
        {
            double 点到直线的垂直距离 = CalculationPoToLineVerticalDimension(a, b, 点);
            double 直线角度 = CalculateLineAngle(a, b);
            PointD 垂点1 = CalculateLineEndPo(点, 直线角度 + 90, 点到直线的垂直距离);
            PointD 垂点2 = CalculateLineEndPo(点, 直线角度 - 90, 点到直线的垂直距离);
            return (CalculateTwoPoDistance(垂点1, a) < CalculateTwoPoDistance(垂点2, a)) ? 垂点1 : 垂点2;
        }

        public static PointD 获取点到直线的垂点(LineS 直线, PointD 点)
        {
            return 获取点到直线的垂点(直线.StartPo, 直线.EndPo, 点);
        }
        #endregion

        #region 获取点到直线的最近点
        public static PointD 获取点到直线的最近点(PointD a, PointD b, PointD 点)
        {
            double 点到直线的距离 = CalculationPoToLineDimension(a, b, 点);
            double 直线角度 = CalculateLineAngle(a, b);
            PointD 最近点 = CalculateLineEndPo(点, 直线角度 + 90, 点到直线的距离);
            if (CalculationPoToLineDimension(a, b, 最近点) > 点到直线的距离 / 2)
                最近点 = CalculateLineEndPo(点, 直线角度 - 90, 点到直线的距离);
            return 最近点;
        }

        public static PointD 获取点到直线的最近点(LineS 直线, PointD 点)
        {
            return 获取点到直线的最近点(直线.StartPo, 直线.EndPo, 点);
        }
        #endregion

        #region 获取点到圆的最近点
        public static PointD 获取点到圆的最近点(PointD 圆心, double r, PointD 点)
        {
            List<PointD> EffectivePo = 获取直线与圆的有效交点(点, 圆心, 圆心, r);
            return EffectivePo[0];
        }

        public static PointD 获取点到圆的最近点(CircleS 圆, PointD 点)
        {
            return 获取点到圆的最近点(圆.CenterPo, 圆.R, 点);
        }
        #endregion

        #region 获取点到圆弧的最近点
        public static PointD 获取点到圆弧的最近点(PointD a, PointD b, PointD c, PointD 点)
        {
            if (!IsThePointWithinTheArcAngleRange(a, b, c, 点))
            {
                double 点到a的距离 = CalculateTwoPoDistance(a, 点);
                double 点到c的距离 = CalculateTwoPoDistance(c, 点);
                if (点到a的距离 < 点到c的距离)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            PointD 圆心 = ThreePoCalculateCircleCenter(a, b, c);
            return 获取点到圆的最近点(圆心, CalculateTwoPoDistance(圆心, a), 点);
        }

        public static PointD 获取点到圆弧的最近点(ArcThreePoS 圆弧, PointD 点)
        {
            return 获取点到圆弧的最近点(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo, 点);
        }
        #endregion

        #region 获取圆上点
        public static PointD 获取圆上点(double 圆心x, double 圆心y, double 角度, double 半径)
        {
            double x = 圆心x + 半径 * Math.Cos(角度 * Math.PI / 180);
            double y = 圆心y + 半径 * Math.Sin(角度 * Math.PI / 180);
            return new PointD(x, y);
        }

        public static PointD 获取圆上点(PointD 圆心, double 角度, double 半径)
        {
            return 获取圆上点(圆心.x, 圆心.y, 角度, 半径);
        }
        #endregion

        #region 获取直线与直线交点
        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            double x;
            double y;
            double 角度差 = Math.Abs(CalculateLineAngle(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY) - CalculateLineAngle(Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY));
            if ((角度差 > 0 - 0.00000001 && 角度差 < 0 + 0.00000001) || (角度差 > 180 - 0.00000001 && 角度差 < 180 + 0.00000001))  //如果两条直线是平行线
                return null;  //无法计算交点。
            double a, b;
            if (Math.Abs( Line1StatrPoX-  Line1EndPoX)< 0.00000001 && Math.Abs(Line2StatrPoY - Line2EndPoY)< 0.00000001)  //2条直线垂直水平相交
                return new PointD(Line1EndPoX, Line2StatrPoY);
            if (Math.Abs(Line2StatrPoX - Line2EndPoX)< 0.00000001 && Math.Abs(Line1StatrPoY - Line1EndPoY)< 0.00000001)  //2条直线垂直水平相交
                return new PointD(Line2EndPoX, Line1StatrPoY);
            if (Line1StatrPoX == Line1EndPoX)  //直线1垂直
            {
                x = Line1StatrPoX;
                b = (Line2EndPoY - Line2StatrPoY) / (Line2EndPoX - Line2StatrPoX);
                y = Line2EndPoY - (Line2EndPoX - x) * b;
                return new PointD(x, y);
            }
            if (Line2StatrPoX == Line2EndPoX)  //直线2垂直
            {
                x = Line2StatrPoX;
                b = (Line1EndPoY - Line1StatrPoY) / (Line1EndPoX - Line1StatrPoX);
                y = Line1EndPoY - (Line1EndPoX - x) * b;
                return new PointD(x, y);
            }
            if (Line1StatrPoY == Line1EndPoY)  //直线1水平
            {
                y = Line1StatrPoY;
                b = (Line2EndPoX - Line2StatrPoX) / (Line2EndPoY - Line2StatrPoY);
                x = Line2EndPoX - (Line2EndPoY - y) * b;
                return new PointD(x, y);
            }
            if (Line2StatrPoY == Line2EndPoY)  //直线2水平
            {
                y = Line2StatrPoY;
                b = (Line1EndPoX - Line1StatrPoX) / (Line1EndPoY - Line1StatrPoY);
                x = Line1EndPoX - (Line1EndPoY - y) * b;
                return new PointD(x, y);
            }
            a = (Line1EndPoY - Line1StatrPoY) / (Line1EndPoX - Line1StatrPoX);
            b = (Line2EndPoY - Line2StatrPoY) / (Line2EndPoX - Line2StatrPoX);
            x = (a * Line1StatrPoX - b * Line2StatrPoX - Line1StatrPoY + Line2StatrPoY) / (a - b);
            y = a * x - a * Line1StatrPoX + Line1StatrPoY;
            return new PointD(x, y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo.x, Line1EndPo.y, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, LineS Line2)
        {
            return GetLineAndLineIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPo.x, Line1StatrPo.y, Line1EndPoX, Line1EndPoY, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPo.x, Line1EndPo.y, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPo, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, PointD Line1EndPo, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPo, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, PointD Line1EndPo, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPo, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(PointD Line1StatrPo, PointD Line1EndPo, LineS Line2)
        {
            return GetLineAndLineIntersection(Line1StatrPo, Line1EndPo, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(LineS Line1, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1.StartPo, Line1.EndPo, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(LineS Line1, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(LineS Line1, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineIntersection(Line1, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(LineS Line1, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineIntersection(Line1, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineIntersection(LineS Line1, LineS Line2)
        {
            return GetLineAndLineIntersection(Line1, Line2.StartPo, Line2.EndPo);
        }
        #endregion

        #region 获取直线与直线的有效交点
        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线Y终点X坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点X坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            LineS Line1 = new LineS(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY);
            LineS Line2 = new LineS(Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);

            PointD Intersection = GetLineAndLineIntersection(Line1, Line2);    //交点:获取直线与直线交点
            if (Intersection == null)
                return null;
            double Line1Length = CalculateLineLength(Line1);    //直线1长度
            double Line2Length = CalculateLineLength(Line2);    //直线2长度
            if ( CalculateTwoPoDistance(Intersection, Line1.StartPo) - Line1Length > 0.00000001 || CalculateTwoPoDistance(Intersection, Line1.EndPo) - Line1Length > 0.00000001)      //计算两点之间的距离
                return null;
            if (CalculateTwoPoDistance(Intersection, Line2.StartPo) - Line2Length > 0.00000001 || CalculateTwoPoDistance(Intersection, Line2.EndPo) - Line2Length > 0.00000001)
                return null;
            if ((new PointD(Line1StatrPoX, Line1StatrPoY) == Intersection) || (new PointD(Line1EndPoX, Line1EndPoY) == Intersection))
                return null;
            return Intersection;
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线Y终点X坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线Y终点X坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线Y终点X坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线Y终点X坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo.x, Line1EndPo.y, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPoX">直线1起点X坐标</param>
        /// <param name="Line1StatrPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(double Line1StatrPoX, double Line1StatrPoY, PointD Line1EndPo, LineS Line2)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPoX, Line1StatrPoY, Line1EndPo, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo.x, Line1StatrPo.y, Line1EndPoX, Line1EndPoY, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPo.x, Line1EndPo.y, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, PointD Line1EndPo, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPo, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, PointD Line1EndPo, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPo, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, PointD Line1EndPo, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPo, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1StatrPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(PointD Line1StatrPo, PointD Line1EndPo, LineS Line2)
        {
            return GetLineAndLineEffectiveIntersection(Line1StatrPo, Line1EndPo, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(LineS Line1, double Line2StatrPoX, double Line2StatrPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1.StartPo, Line1.EndPo, Line2StatrPoX, Line2StatrPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPoX">直线2起点X坐标</param>
        /// <param name="Line2StatrPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(LineS Line1, double Line2StatrPoX, double Line2StatrPoY, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1, Line2StatrPoX, Line2StatrPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(LineS Line1, PointD Line2StatrPo, double Line2EndPoX, double Line2EndPoY)
        {
            return GetLineAndLineEffectiveIntersection(Line1, Line2StatrPo.x, Line2StatrPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StatrPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(LineS Line1, PointD Line2StatrPo, PointD Line2EndPo)
        {
            return GetLineAndLineEffectiveIntersection(Line1, Line2StatrPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 获取直线与直线的有效交点
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static PointD GetLineAndLineEffectiveIntersection(LineS Line1, LineS Line2)
        {
            return GetLineAndLineEffectiveIntersection(Line1, Line2.StartPo, Line2.EndPo);
        }
        #endregion

        #region 获取直线与圆交点
        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="CenterPoX">圆心X坐标</param>
        /// <param name="CenterPoY">圆心Y坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double CenterPoX, double CenterPoY, double R)
        {
            double Distance = Math.Sqrt(R * R - CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, CenterPoX, CenterPoY) * CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, CenterPoX, CenterPoY));
            PointD LineStartPoAndEndPo = new PointD(LineEndPoX - LineStartPoX, LineEndPoY - LineStartPoY);
            double LineStartPoAndEndPoSquare = (LineEndPoX - LineStartPoX) * (LineEndPoX - LineStartPoX) + (LineEndPoY - LineStartPoY) * (LineEndPoY - LineStartPoY);
            PointD e = new PointD(LineStartPoAndEndPo.x / Math.Sqrt(LineStartPoAndEndPoSquare), LineStartPoAndEndPo.y / Math.Sqrt(LineStartPoAndEndPoSquare));
            PointD Base = new PointD(e.x * Distance, e.y * Distance);      //向量base
            PointD LineStartPoAndCenterPo = new PointD(CenterPoX - LineStartPoX, CenterPoY - LineStartPoY);
            double l = (LineStartPoAndEndPo.x * LineStartPoAndCenterPo.x + LineStartPoAndEndPo.y * LineStartPoAndCenterPo.y) / Math.Sqrt(LineStartPoAndEndPoSquare);
            PointD Apr = new PointD(e.x * l, e.y * l);
            PointD pr = new PointD(LineStartPoX + Apr.x, LineStartPoY + Apr.y);          //点pr
            PointD[] IntersectionPo = new PointD[2];
            IntersectionPo[0] = new PointD(Base.x + pr.x, Base.y + pr.y);
            IntersectionPo[1] = new PointD(pr.x - Base.x, pr.y - Base.y);
            if (CalculationPoToLineVerticalDimension(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, CenterPoX, CenterPoY) > R)
                IntersectionPo[0] = IntersectionPo[1] = null;
            return IntersectionPo;
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD CenterPo, double R)
        {
            return GetLineAndCircleIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, CenterPo.x, CenterPo.y, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="Circle">圆</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, CircleS Circle)
        {
            return GetLineAndCircleIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Circle.CenterPo, Circle.R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="CenterPoX">圆心X坐标</param>
        /// <param name="CenterPoY">圆心Y坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double CenterPoX, double CenterPoY, double R)
        {
            return GetLineAndCircleIntersection(LineStartPoX, LineStartPoY, LineEndPo.x, LineEndPo.y, CenterPoX, CenterPoY, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD CenterPo, double R)
        {
            return GetLineAndCircleIntersection(LineStartPoX, LineStartPoY, LineEndPo, CenterPo.x, CenterPo.y, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="Circle">圆</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(double LineStartPoX, double LineStartPoY, PointD LineEndPo, CircleS Circle)
        {
            return GetLineAndCircleIntersection(LineStartPoX, LineStartPoY, LineEndPo, Circle.CenterPo, Circle.R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPo">直线起点坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="CenterPoX">圆心X坐标</param>
        /// <param name="CenterPoY">圆心Y坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double CenterPoX, double CenterPoY, double R)
        {
            return GetLineAndCircleIntersection(LineStartPo.x, LineStartPo.y, LineEndPoX, LineEndPoY, CenterPoX, CenterPoY, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPo">直线起点坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD CenterPo, double R)
        {
            return GetLineAndCircleIntersection(LineStartPo, LineEndPoX, LineEndPoY, CenterPo.x, CenterPo.y, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPo">直线起点坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="Circle">圆</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(PointD LineStartPo, double LineEndPoX, double LineEndPoY, CircleS Circle)
        {
            return GetLineAndCircleIntersection(LineStartPo, LineEndPoX, LineEndPoY, Circle.CenterPo, Circle.R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPo">直线起点坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="CenterPoX">圆心X坐标</param>
        /// <param name="CenterPoY">圆心Y坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(PointD LineStartPo, PointD LineEndPo, double CenterPoX, double CenterPoY, double R)
        {
            return GetLineAndCircleIntersection(LineStartPo, LineEndPo.x, LineEndPo.y, CenterPoY, CenterPoY, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPo">直线起点坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(PointD LineStartPo, PointD LineEndPo, PointD CenterPo, double R)
        {
            return GetLineAndCircleIntersection(LineStartPo, LineEndPo, CenterPo.x, CenterPo.y, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="LineStartPo">直线起点坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="Circle">圆</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(PointD LineStartPo, PointD LineEndPo, CircleS Circle)
        {
            return GetLineAndCircleIntersection(LineStartPo, LineEndPo, Circle.CenterPo, Circle.R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="CenterPoX">圆心X坐标</param>
        /// <param name="CenterPoY">圆心Y坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(LineS Line, double CenterPoX, double CenterPoY, double R)
        {
            return GetLineAndCircleIntersection(Line.StartPo, Line.EndPo, CenterPoX, CenterPoY, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="CenterPo">圆心坐标</param>
        /// <param name="R">半径</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(LineS Line, PointD CenterPo, double R)
        {
            return GetLineAndCircleIntersection(Line.StartPo, Line.EndPo, CenterPo.x, CenterPo.y, R);
        }

        /// <summary>
        /// 获取直线与圆交点
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="Circle">圆</param>
        /// <returns></returns>
        public static PointD[] GetLineAndCircleIntersection(LineS Line, CircleS Circle)
        {
            return GetLineAndCircleIntersection(Line, Circle.CenterPo, Circle.R);
        }
        #endregion

        #region 获取直线与圆的有效交点
        public static List<PointD> 获取直线与圆的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double CenterPoX, double CenterPoY, double R)
        {
            PointD[] PoS = GetLineAndCircleIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, CenterPoX, CenterPoY, R);  //交点
            double LineLengle = CalculateTwoPoDistance(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY);
            for (int i = 0; i < 2; i++)
            {
                if (PoS[i] != null)
                {
                    double 交点与直线起点距离 = CalculateTwoPoDistance(PoS[i], LineStartPoX, LineStartPoY);
                    double 交点与直线终点距离 = CalculateTwoPoDistance(PoS[i], LineEndPoX, LineEndPoY);
                    if (交点与直线起点距离 - LineLengle > 0.00000001 || 交点与直线终点距离 - LineLengle > 0.00000001 || IsCompareTowPoEqual(PoS[i], LineStartPoX, LineStartPoY) || IsCompareTowPoEqual(PoS[i], LineEndPoX, LineEndPoY))
                        PoS[i] = null;
                }
            }
            List<PointD> EffectivePo = new List<PointD>();
            for (int i = 0; i < PoS.Length; i++)
                EffectivePo.Add(PoS[i]);
            return EffectivePo;
        }

        public static List<PointD> 获取直线与圆的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD CenterPo, double R)
        {
            return 获取直线与圆的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, CircleS Circle)
        {
            return 获取直线与圆的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Circle.CenterPo, Circle.R);
        }

        public static List<PointD> 获取直线与圆的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double CenterPoX, double CenterPoY, double R)
        {
            return 获取直线与圆的有效交点(LineStartPoX, LineStartPoY, LineEndPo.x, LineEndPo.y, CenterPoX, CenterPoY, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD CenterPo, double R)
        {
            return 获取直线与圆的有效交点(LineStartPoX, LineStartPoY, LineEndPo, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, CircleS Circle)
        {
            return 获取直线与圆的有效交点(LineStartPoX, LineStartPoY, LineEndPo, Circle.CenterPo, Circle.R);
        }

        public static List<PointD> 获取直线与圆的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double CenterPoX, double CenterPoY, double R)
        {
            return 获取直线与圆的有效交点(LineStartPo.x, LineStartPo.y, LineEndPoX, LineEndPoY, CenterPoX, CenterPoY, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD CenterPo, double R)
        {
            return 获取直线与圆的有效交点(LineStartPo, LineEndPoX, LineEndPoY, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, CircleS Circle)
        {
            return 获取直线与圆的有效交点(LineStartPo, LineEndPoX, LineEndPoY, Circle.CenterPo, Circle.R);
        }

        public static List<PointD> 获取直线与圆的有效交点(PointD LineStartPo, PointD LineEndPo, double CenterPoX, double CenterPoY, double R)
        {
            return 获取直线与圆的有效交点(LineStartPo, LineEndPo.x, LineEndPo.y, CenterPoX, CenterPoY, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(PointD LineStartPo, PointD LineEndPo, PointD CenterPo, double R)
        {
            return 获取直线与圆的有效交点(LineStartPo, LineEndPo, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(PointD LineStartPo, PointD LineEndPo, CircleS Circle)
        {
            return 获取直线与圆的有效交点(LineStartPo, LineEndPo, Circle.CenterPo, Circle.R);
        }

        public static List<PointD> 获取直线与圆的有效交点(LineS Line, double CenterPoX, double CenterPoY, double R)
        {
            return 获取直线与圆的有效交点(Line.StartPo, Line.EndPo, CenterPoX, CenterPoY, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(LineS Line, PointD CenterPo, double R)
        {
            return 获取直线与圆的有效交点(Line, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取直线与圆的有效交点(LineS Line, CircleS Circle)
        {
            return 获取直线与圆的有效交点(Line, Circle.CenterPo, Circle.R);
        }
        #endregion

        #region 获取直线与圆弧的交点
        public static PointD[] 获取直线与圆弧交点(PointD 直线起点, PointD 直线终点, PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(圆弧点a, 圆弧点b, 圆弧点c);
            double 半径 = CalculateTwoPoDistance(圆弧点a, CenterPo);
            return GetLineAndCircleIntersection(直线起点, 直线终点, CenterPo, 半径);
        }

        public static PointD[] 获取直线与圆弧交点(PointD 直线起点, PointD 直线终点, ArcThreePoS 圆弧)
        {
            return 获取直线与圆弧交点(直线起点, 直线终点, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取直线与圆弧交点(ArcThreePoS 圆弧, PointD 直线起点, PointD 直线终点)
        {
            return 获取直线与圆弧交点(直线起点, 直线终点, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取直线与圆弧交点(LineS 直线, PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c)
        {
            return 获取直线与圆弧交点(直线.StartPo, 直线.EndPo, 圆弧点a, 圆弧点b, 圆弧点c);
        }

        public static PointD[] 获取直线与圆弧交点(PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c, LineS 直线)
        {
            return 获取直线与圆弧交点(直线.StartPo, 直线.EndPo, 圆弧点a, 圆弧点b, 圆弧点c);
        }

        public static PointD[] 获取直线与圆弧交点(LineS 直线, ArcThreePoS 圆弧)
        {
            return 获取直线与圆弧交点(直线, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取直线与圆弧交点(ArcThreePoS 圆弧, LineS 直线)
        {
            return 获取直线与圆弧交点(直线, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }
        #endregion

        #region 获取直线与圆弧的有效交点
        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            PointD 圆心 = ThreePoCalculateCircleCenter(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
            double 半径 = CalculateTwoPoDistance(ArcStartPoX, ArcStartPoY, 圆心);
            List<PointD> EffectivePo = 获取直线与圆的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, 圆心, 半径);  //有效交点
            for (int i = EffectivePo.Count - 1; i > -1; i--)
                if (EffectivePo[i] != null)
                    if (!IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, EffectivePo[i]) || IsCompareTowPoEqual(EffectivePo[i], ArcStartPoX, ArcStartPoY) || IsCompareTowPoEqual(EffectivePo[i], ArcEndPoX, ArcEndPoY))
                        EffectivePo.RemoveAt(i);
            return EffectivePo;
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, ArcThreePoS ArcThreePo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo.x, LineEndPo.y, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPoX"></param>
        /// <param name="LineStartPoY"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(double LineStartPoX, double LineStartPoY, PointD LineEndPo, ArcThreePoS ArcThreePo)
        {
            return 获取直线与圆弧的有效交点(LineStartPoX, LineStartPoY, LineEndPo, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo.x, LineStartPo.y, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPoX"></param>
        /// <param name="LineEndPoY"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, double LineEndPoX, double LineEndPoY, ArcThreePoS ArcThreePo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPoX, LineEndPoY, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo.x, LineEndPo.y, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="LineStartPo"></param>
        /// <param name="LineEndPo"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(PointD LineStartPo, PointD LineEndPo, ArcThreePoS ArcThreePo)
        {
            return 获取直线与圆弧的有效交点(LineStartPo, LineEndPo, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(Line.StartPo, Line.EndPo, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取直线与圆弧的有效交点(Line, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取直线与圆弧的有效交点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取直线与圆弧的有效交点(LineS Line, ArcThreePoS ArcThreePo)
        {
            return 获取直线与圆弧的有效交点(Line, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }
        #endregion

        #region 获取直线与矩形的有效交点
        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="ReStartPoX">矩形起始X坐标</param>
        /// <param name="ReStartPoY">矩形起始Y坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, double ReStartPoX, double ReStartPoY, double ReW, double ReH)
        {
            List<PointD> PoLi = new List<PointD>();
            RectD Re = new RectD(ReStartPoX, ReStartPoY, ReW, ReH);
            PoLi.Add(GetLineAndLineEffectiveIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Re.StartPo, Re.TwoPo));
            PoLi.Add(GetLineAndLineEffectiveIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Re.TwoPo, Re.ThreePo));
            PoLi.Add(GetLineAndLineEffectiveIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Re.ThreePo, Re.EndPo));
            PoLi.Add(GetLineAndLineEffectiveIntersection(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, Re.EndPo, Re.StartPo));
            for (int i = PoLi.Count() - 1; i > -1; i--)
                if (PoLi[i] == null)
                    PoLi.RemoveAt(i);
            return PoLi;
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="ReStartPo">矩形起始坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(double LineStartPoX, double LineStartPoY, double LineEndPoX, double LineEndPoY, PointD ReStartPo, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LineStartPoX, LineStartPoY, LineEndPoX, LineEndPoY, ReStartPo.x, ReStartPo.y, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LienStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="Re">矩形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(double LineStartPoX, double LienStartPoY, double LineEndPoX, double LineEndPoY, RectD Re)
        {
            return GetLineAndRectValidNode(LineStartPoX, LienStartPoY, LineEndPoX, LineEndPoY, Re.StartPo, Re.w, Re.h);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="ReStartPoX">矩形起始X坐标</param>
        /// <param name="ReStartPoY">矩形起始Y坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(double LineStartPoX, double LineStartPoY, PointD LineEndPo, double ReStartPoX, double ReStartPoY, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LineStartPoX, LineStartPoY, LineEndPo.x, LineEndPo.y, ReStartPoX, ReStartPoY, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="ReStartPo">矩形起始坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(double LineStartPoX, double LineStartPoY, PointD LineEndPo, PointD ReStartPo, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LineStartPoX, LineStartPoY, LineEndPo, ReStartPo.x, ReStartPo.y, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LineStartPoX">直线起点X坐标</param>
        /// <param name="LineStartPoY">直线起点Y坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="Re">矩形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(double LineStartPoX, double LineStartPoY, PointD LineEndPo, RectD Re)
        {
            return GetLineAndRectValidNode(LineStartPoX, LineStartPoY, LineEndPo, Re.StartPo, Re.w, Re.h);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LinStartPo">直线起点坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="ReStartPoX">矩形起始X坐标</param>
        /// <param name="ReStartPoY">矩形起始Y坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(PointD LinStartPo, double LineEndPoX, double LineEndPoY, double ReStartPoX, double ReStartPoY, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LinStartPo.x, LinStartPo.y, LineEndPoX, LineEndPoY, ReStartPoX, ReStartPoY, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LinStartPo">直线起点坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="ReStartPo">矩形起始坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(PointD LinStartPo, double LineEndPoX, double LineEndPoY, PointD ReStartPo, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LinStartPo, LineEndPoX, LineEndPoY, ReStartPo.x, ReStartPo.y, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LinStartPo">直线起点坐标</param>
        /// <param name="LineEndPoX">直线终点X坐标</param>
        /// <param name="LineEndPoY">直线终点Y坐标</param>
        /// <param name="Re">矩形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(PointD LinStartPo, double LineEndPoX, double LineEndPoY, RectD Re)
        {
            return GetLineAndRectValidNode(LinStartPo, LineEndPoX, LineEndPoY, Re.StartPo, Re.w, Re.h);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LinStartPo">直线起点坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="ReStartPoX">矩形起始X坐标</param>
        /// <param name="ReStartPoY">矩形起始Y坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(PointD LinStartPo, PointD LineEndPo, double ReStartPoX, double ReStartPoY, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LinStartPo, LineEndPo.x, LineEndPo.y, ReStartPoX, ReStartPoY, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LinStartPo">直线起点坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="ReStartPo">矩形起始坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(PointD LinStartPo, PointD LineEndPo, PointD ReStartPo, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(LinStartPo, LineEndPo, ReStartPo.x, ReStartPo.y, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="LinStartPo">直线起点坐标</param>
        /// <param name="LineEndPo">直线终点坐标</param>
        /// <param name="Re">矩形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(PointD LinStartPo, PointD LineEndPo, RectD Re)
        {
            return GetLineAndRectValidNode(LinStartPo, LineEndPo, Re.StartPo, Re.w, Re.h);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="ReStartPoX">矩形起始X坐标</param>
        /// <param name="ReStartPoY">矩形起始X坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(LineS Line, double ReStartPoX, double ReStartPoY, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(Line.StartPo, Line.EndPo, ReStartPoX, ReStartPoY, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="ReStartPo">矩形起始坐标</param>
        /// <param name="ReW">矩形宽度</param>
        /// <param name="ReH">矩形高度</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(LineS Line, PointD ReStartPo, double ReW, double ReH)
        {
            return GetLineAndRectValidNode(Line, ReStartPo.x, ReStartPo.y, ReW, ReH);
        }

        /// <summary>
        /// 获取直线与矩形的有效交点
        /// </summary>
        /// <param name="Line">直线</param>
        /// <param name="Re">矩形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndRectValidNode(LineS Line, RectD Re)
        {
            return GetLineAndRectValidNode(Line, Re.StartPo, Re.w, Re.h);
        }
        #endregion

        #region 获取直线与多边形的有效交点
        /// <summary>
        /// 获取直线与多边形的有效交点
        /// </summary>
        /// <param name="LiA">直线起点</param>
        /// <param name="LiB">直线终点</param>
        /// <param name="Polyg">多边形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndPolygValidNode(PointD LiA, PointD LiB, IrregularPolygS IrregularPolyg)
        {
            List<PointD> PoLi = new List<PointD>();
            for (int i = 0; i < IrregularPolyg.AllPo.Length; i++)
            {
                PointD EndPo = IrregularPolyg.AllPo[(i < IrregularPolyg.AllPo.Length - 1) ? i + 1 : 0];
                double Anage1 = CalculateLineAngle(LiA, LiB);
                double Anage2 = CalculateLineAngle(IrregularPolyg.AllPo[i], EndPo);
                PoLi.Add(GetLineAndLineEffectiveIntersection(LiA, LiB, IrregularPolyg.AllPo[i], EndPo));    //获取直线与直线的有效交点
            }
            for (int i = PoLi.Count() - 1; i > -1; i--)
                if (PoLi[i] == null)
                    PoLi.RemoveAt(i);
            for (int i = PoLi.Count - 1; i > -1; i--)
                for (int j = 0; j < PoLi.Count - 1; j++)
                    if (i != j && i < PoLi.Count)
                        if (PoLi[i] == PoLi[j])
                            PoLi.RemoveAt(i);
            return PoLi;
        }

        /// <summary>
        /// 获取直线与多边形的有效交点
        /// </summary>
        /// <param name="Li">直线</param>
        /// <param name="Polyg">多边形</param>
        /// <returns></returns>
        public static List<PointD> GetLineAndPolygValidNode(LineS Li, IrregularPolygS IrregularPolyg)
        {
            return GetLineAndPolygValidNode(Li.StartPo, Li.EndPo, IrregularPolyg);
        }
        #endregion

        #region 获取矩形与矩形的有效交点
        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1StartPoX">矩形1起点X坐标</param>
        /// <param name="Re1StartPoY">矩形1起点Y坐标</param>
        /// <param name="Re1W">矩形1宽度</param>
        /// <param name="Re1H">矩形1高度</param>
        /// <param name="Re2StartPoX">矩形2起点X坐标</param>
        /// <param name="Re2StartPoY">矩形2起点Y坐标</param>
        /// <param name="Re2W">矩形2宽度</param>
        /// <param name="Re2H">矩形2高度</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(double Re1StartPoX, double Re1StartPoY, double Re1W, double Re1H, double Re2StartPoX, double Re2StartPoY, double Re2W, double Re2H)
        {
            List<PointD> IntersectionPoS = new List<PointD>();
            RectD Re1 = new RectD(Re1StartPoX, Re1StartPoY, Re1W, Re1H);
            RectD Re2 = new RectD(Re2StartPoX, Re2StartPoY, Re2W, Re2H);
            PointD[] RePo1 = new PointD[] { Re1.StartPo, Re1.TwoPo, Re1.ThreePo, Re1.EndPo };
            PointD[] RePo2 = new PointD[] { Re2.StartPo, Re2.TwoPo, Re2.ThreePo, Re2.EndPo };
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    IntersectionPoS.Add(GetLineAndLineEffectiveIntersection(new LineS(RePo1[i], RePo1[i < 3 ? i + 1 : 0]), new LineS(RePo2[j], RePo2[j < 3 ? j + 1 : j])));
            for (int i = IntersectionPoS.Count() - 1; i > -1; i--)
                if (IntersectionPoS[i] == null)
                    IntersectionPoS.RemoveAt(i);
            return IntersectionPoS;
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1StartPoX">矩形1起点X坐标</param>
        /// <param name="Re1StartPoY">矩形1起点Y坐标</param>
        /// <param name="Re1W">矩形1宽度</param>
        /// <param name="Re1H">矩形1高度</param>
        /// <param name="Re2StartPo">矩形2起点坐标</param>
        /// <param name="Re2W">矩形2宽度</param>
        /// <param name="Re2H">矩形2高度</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(double Re1StartPoX, double Re1StartPoY, double Re1W, double Re1H, PointD Re2StartPo, double Re2W, double Re2H)
        {
            return GetRectAndRectEffectiveIntersection(Re1StartPoX, Re1StartPoY, Re1W, Re1H, Re2StartPo.x, Re2StartPo.y, Re2W, Re2H);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1StartPoX">矩形1起点X坐标</param>
        /// <param name="Re1StartPoY">矩形1起点Y坐标</param>
        /// <param name="Re1W">矩形1宽度</param>
        /// <param name="Re1H">矩形1高度</param>
        /// <param name="Re2">矩形2</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(double Re1StartPoX, double Re1StartPoY, double Re1W, double Re1H, RectD Re2)
        {
            return GetRectAndRectEffectiveIntersection(Re1StartPoX, Re1StartPoY, Re1W, Re1H, Re2.StartPo, Re2.w, Re2.h);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1StartPo">矩形1起点坐标</param>
        /// <param name="Re1W">矩形1宽度</param>
        /// <param name="Re1H">矩形1高度</param>
        /// <param name="Re2StartPoX">矩形2起点X坐标</param>
        /// <param name="Re2StartPoY">矩形2起点Y坐标</param>
        /// <param name="Re2W">矩形2宽度</param>
        /// <param name="Re2H">矩形2高度</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(PointD Re1StartPo, double Re1W, double Re1H, double Re2StartPoX, double Re2StartPoY, double Re2W, double Re2H)
        {
            return GetRectAndRectEffectiveIntersection(Re1StartPo.x, Re1StartPo.y, Re1W, Re1H, Re2StartPoX, Re2StartPoY, Re2W, Re2H);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1StartPo">矩形1起点坐标</param>
        /// <param name="Re1W">矩形1宽度</param>
        /// <param name="Re1H">矩形1高度</param>
        /// <param name="Re2StartPo">矩形2起点坐标</param>
        /// <param name="Re2W">矩形2宽度</param>
        /// <param name="Re2H">矩形2高度</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(PointD Re1StartPo, double Re1W, double Re1H, PointD Re2StartPo, double Re2W, double Re2H)
        {
            return GetRectAndRectEffectiveIntersection(Re1StartPo, Re1W, Re1H, Re2StartPo.x, Re2StartPo.y, Re2W, Re2H);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1StartPo">矩形1起点坐标</param>
        /// <param name="Re1W">矩形1宽度</param>
        /// <param name="Re1H">矩形1高度</param>
        /// <param name="Re2">矩形2</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(PointD Re1StartPo, double Re1W, double Re1H, RectD Re2)
        {
            return GetRectAndRectEffectiveIntersection(Re1StartPo, Re1W, Re1H, Re2.StartPo, Re2.w, Re2.h);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1">矩形1</param>
        /// <param name="Re2StartPoX">矩形2起点X坐标</param>
        /// <param name="Re2StartPoY">矩形2起点Y坐标</param>
        /// <param name="Re2W">矩形2宽度</param>
        /// <param name="Re2H">矩形2高度</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(RectD Re1, double Re2StartPoX, double Re2StartPoY, double Re2W, double Re2H)
        {
            return GetRectAndRectEffectiveIntersection(Re1.StartPo.x, Re1.StartPo.y, Re1.w, Re1.h, Re2StartPoX, Re2StartPoY, Re2W, Re2H);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1">矩形1</param>
        /// <param name="Re2StartPo">矩形2起点坐标</param>
        /// <param name="Re2W">矩形2宽度</param>
        /// <param name="Re2H">矩形2高度</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(RectD Re1, PointD Re2StartPo, double Re2W, double Re2H)
        {
            return GetRectAndRectEffectiveIntersection(Re1, Re2StartPo.x, Re2StartPo.y, Re2W, Re2H);
        }

        /// <summary>
        /// 获取矩形与矩形的有效交点
        /// </summary>
        /// <param name="Re1">矩形1</param>
        /// <param name="Re2">矩形2</param>
        /// <returns></returns>
        public static List<PointD> GetRectAndRectEffectiveIntersection(RectD Re1, RectD Re2)
        {
            return GetRectAndRectEffectiveIntersection(Re1, Re2.StartPo, Re2.w, Re2.h);
        }
        #endregion

        #region 获取矩形与圆的有效交点
        public static List<PointD> 获取矩形与圆的有效交点(double StartPoX, double StartPoY, double w, double h, double CenterPoX, double CenterPoY, double R)
        {
            LineS[] 所有直线 = new LineS[4];
            RectD Re = new RectD(StartPoX, StartPoY, w, h);
            所有直线[0] = new LineS(Re.StartPo, Re.TwoPo);
            所有直线[1] = new LineS(Re.TwoPo, Re.ThreePo);
            所有直线[2] = new LineS(Re.ThreePo, Re.EndPo);
            所有直线[3] = new LineS(Re.EndPo, Re.StartPo);
            List<PointD> AllEffectivePo = new List<PointD>();
            for (int i = 0; i < 所有直线.Count(); i++)
            {
                List<PointD> EffectivePo = 获取直线与圆的有效交点(所有直线[i], new PointD(CenterPoX, CenterPoY), R);
                AllEffectivePo.AddRange(EffectivePo);
            }
            return AllEffectivePo;
        }

        public static List<PointD> 获取矩形与圆的有效交点(double StartPoX, double StartPoY, double w, double h, PointD CenterPo, double R)
        {
            return 获取矩形与圆的有效交点(StartPoX, StartPoY, w, h, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(double StartPoX, double StartPoY, double w, double h, CircleS Circle)
        {
            return 获取矩形与圆的有效交点(StartPoX, StartPoY, w, h, Circle.CenterPo, Circle.R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(PointD StartPo, double w, double h, double CenterPoX, double CenterPoY, double R)
        {
            return 获取矩形与圆的有效交点(StartPo.x, StartPo.y, w, h, CenterPoX, CenterPoY, R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(PointD StartPo, double w, double h, PointD CenterPo, double R)
        {
            return 获取矩形与圆的有效交点(StartPo, w, h, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(PointD StartPo, double w, double h, CircleS Circle)
        {
            return 获取矩形与圆的有效交点(StartPo, w, h, Circle.CenterPo, Circle.R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(RectD Re, double CenterPoX, double CenterPoY, double R)
        {
            return 获取矩形与圆的有效交点(Re.StartPo, Re.w, Re.h, CenterPoX, CenterPoY, R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(RectD Re, PointD CenterPo, double R)
        {
            return 获取矩形与圆的有效交点(Re, CenterPo.x, CenterPo.y, R);
        }

        public static List<PointD> 获取矩形与圆的有效交点(RectD Re, CircleS Circle)
        {
            return 获取矩形与圆的有效交点(Re, Circle.CenterPo, Circle.R);
        }
        #endregion

        #region 获取矩形与圆弧的有效交点
        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            LineS[] AllLine = new LineS[4];
            RectD Re = new RectD(ReStartPoX, ReStartPoY, ReW, ReH);
            AllLine[0] = new LineS(Re.StartPo, Re.TwoPo);
            AllLine[1] = new LineS(Re.TwoPo, Re.ThreePo);
            AllLine[2] = new LineS(Re.ThreePo, Re.EndPo);
            AllLine[3] = new LineS(Re.EndPo, Re.StartPo);
            List<PointD> AllEffectivePo = new List<PointD>();
            for (int i = 0; i < AllLine.Count(); i++)
            {
                List<PointD> EffectivePo = 获取直线与圆弧的有效交点(AllLine[i], ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
                if (EffectivePo.Count > 0)
                    AllEffectivePo.AddRange(EffectivePo);
            }
            return AllEffectivePo;
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPoX"></param>
        /// <param name="ReStartPoY"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(double ReStartPoX, double ReStartPoY, double ReW, double ReH, ArcThreePoS ArcThreePo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPoX, ReStartPoY, ReW, ReH, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo.x, ReStartPo.y, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="ReStartPo"></param>
        /// <param name="ReW"></param>
        /// <param name="ReH"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(PointD ReStartPo, double ReW, double ReH, ArcThreePoS ArcThreePo)
        {
            return 获取矩形与圆弧的有效交点(ReStartPo, ReW, ReH, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(Re.StartPo, Re.w, Re.h, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y);
        }

        /// <summary>
        /// 获取矩形与圆弧的有效交点
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="ArcThreePo"></param>
        /// <returns></returns>
        public static List<PointD> 获取矩形与圆弧的有效交点(RectD Re, ArcThreePoS ArcThreePo)
        {
            return 获取矩形与圆弧的有效交点(Re, ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }
        #endregion

        #region 获取圆与圆的交点
        public static PointD[] 获取圆与圆的交点(PointD 圆心1, double 半径1, PointD 圆心2, double 半径2)
        {
            PointD[] 交点 = new PointD[2];
            交点[0] = new PointD(0, 0);
            交点[1] = new PointD(0, 0);
            double x1 = 圆心1.x;
            double y1 = 圆心1.y;
            double r1 = 半径1;
            double x2 = 圆心2.x;
            double y2 = 圆心2.y;
            double r2 = 半径2;
            double 两个圆心的距离 = CalculateTwoPoDistance(圆心1, 圆心2); // 圆心距离
            if (Math.Abs(x1 - x2) < 0.00000001 && Math.Abs(y1 - y2) < 0.00000001 && Math.Abs(r1 - r2) < 0.00000001) // 两圆重合
                return new PointD[] { null, null };
            if ((两个圆心的距离 > r1 + r2) || 两个圆心的距离 < Math.Abs(r1 - r2))     // 两圆相离或者内含
                return new PointD[] { null, null };
            if (Math.Abs(两个圆心的距离 - (r1 + r2)) < 0.00000001 || Math.Abs(两个圆心的距离 - Math.Abs(r1 - r2)) < 0.00000001) // 两圆有一个交点(即两圆相切[内切和外切])
            {
                if (Math.Abs(两个圆心的距离 - (r1 + r2)) < 0.00000001)// 外切
                {
                    if (Math.Abs(x1 - x2) < 0.00000001 && !(Math.Abs(y1 - y2) < 0.00000001))
                    {
                        if (y1 > y2)
                        {
                            交点[0].x = x1 = x2;
                            交点[0].y = y1 - r1;
                        }
                        else
                        {
                            交点[0].x = x1 = x2;
                            交点[0].y = y1 + r1;
                        }
                    }
                    else
                    {
                        if (!(Math.Abs(x1 - x2) < 0.00000001) && Math.Abs(y1 - y2) < 0.00000001)
                        {
                            if (x1 > x2)
                            {
                                交点[0].x = x1 - r1;
                                交点[0].y = y1 = y2;
                            }
                            else
                            {
                                交点[0].x = x1 + r1;
                                交点[0].y = y1 = y2;
                            }
                        }
                        else
                        {
                            if (!(Math.Abs(x1 - x2) < 0.00000001) && !(Math.Abs(y1 - y2) < 0.00000001))
                            {
                                // 外切情况，两圆的交点在圆心AB连线上
                                double k1 = (y2 - y1) / (x2 - x1);
                                double k2 = -1 / k1;
                                交点[0].x = x1 + (x2 - x1) * r1 / 两个圆心的距离;
                                交点[0].y = y1 + (y2 - y1) * r1 / 两个圆心的距离;
                            }
                        }
                    }
                }
                else if (Math.Abs(两个圆心的距离 - Math.Abs(r1 - r2)) < 0.00000001) // 内切 (是否要考虑A包含B 还是B包含A，对结果是否有影响)
                {
                    if (Math.Abs(x1 - x2) < 0.00000001 && !(Math.Abs(y1 - y2) < 0.00000001))
                    {
                        if (r1 > r2) // A内含B
                        {
                            if (y1 > y2)
                            {
                                交点[0].x = x1 = x2;
                                交点[0].y = y1 - r1;
                            }
                            else
                            {
                                交点[0].x = x1 = x2;
                                交点[0].y = y1 + r1;
                            }
                        }
                        else // B 内含A
                        {
                            if (y1 > y2)
                            {
                                交点[0].x = x1 = x2;
                                交点[0].y = y1 + r1;
                            }
                            else
                            {
                                交点[0].x = x1 = x2;
                                交点[0].y = y1 - r1;
                            }
                        }
                    }
                    else if (!(Math.Abs(x1 - x2) < 0.00000001) && Math.Abs(y1 - y2) < 0.00000001)
                    {
                        if (r1 > r2)
                        {
                            if (x1 > x2)
                            {
                                交点[0].x = x1 - r1;
                                交点[0].y = y1 = y2;
                            }
                            else
                            {
                                交点[0].x = x1 + r1;
                                交点[0].y = y1 = y2;
                            }
                        }
                        else
                        {
                            if (x1 > x2)
                            {
                                交点[0].x = x1 + r1;
                                交点[0].y = y1 = y2;
                            }
                            else
                            {
                                交点[0].x = x1 - r1;
                                交点[0].y = y1 = y2;
                            }
                        }
                    }
                    else if (!(Math.Abs(x1 - x2) < 0.00000001) && !(Math.Abs(y1 - y2) < 0.00000001)) // 是否要考虑内含关系(求坐标时是否有影响)
                    {
                        // 内切情况，交点在AB连线的延长线上，要考虑切点的位置 
                        double k1 = (y2 - y1) / (x2 - x1);
                        double k2 = -1 / k1;
                        交点[0].x = x1 + (x1 - x2) * r1 / 两个圆心的距离;
                        交点[0].y = y1 + (y1 - y2) * r1 / 两个圆心的距离;
                    }
                }
            }
            if ((两个圆心的距离 < r1 + r2) && 两个圆心的距离 > Math.Abs(r1 - r2))    // 两圆有两个交点(内交或者外交) 【内交与外交的情况是否一样？】
            {
                if (Math.Abs(x1 - x2) < 0.00000001 && !(Math.Abs(y1 - y2) < 0.00000001))  // 圆A和圆B x坐标相等
                {
                    double x0 = x1 = x2;
                    double y0 = y1 + (y2 - y1) * (r1 * r1 - r2 * r2 + 两个圆心的距离 * 两个圆心的距离) / (2 * 两个圆心的距离 * 两个圆心的距离);
                    double Dis1 = Math.Sqrt(r1 * r1 - (x0 - x1) * (x0 - x1) - (y0 - y1) * (y0 - y1));
                    交点[0].x = x0 - Dis1;
                    交点[0].y = y0;
                    交点[1].x = x0 + Dis1;
                    交点[1].y = y0;
                }
                else
                {
                    if (!(Math.Abs(x1 - x2) < 0.00000001) && Math.Abs(y1 - y2) < 0.00000001) // 圆A和圆B y坐标相等
                    {
                        double y0 = y1 = y2;
                        double x0 = x1 + (x2 - x1) * (r1 * r1 - r2 * r2 + 两个圆心的距离 * 两个圆心的距离) / (2 * 两个圆心的距离 * 两个圆心的距离);
                        double Dis1 = Math.Sqrt(r1 * r1 - (x0 - x1) * (x0 - x1) - (y0 - y1) * (y0 - y1));
                        交点[0].x = x0;
                        交点[0].y = y0 - Dis1;
                        交点[1].x = x0;
                        交点[1].y = y0 + Dis1;
                    }
                    else
                    {
                        if (!(Math.Abs(x1 - x2) < 0.00000001) && !(Math.Abs(y1 - y2) < 0.00000001)) // x,y坐标都不等 
                        {
                            double k1 = (y2 - y1) / (x2 - x1);//AB的斜率
                            double k2 = -1 / k1;             // CD的斜率
                            double x0 = x1 + (x2 - x1) * (r1 * r1 - r2 * r2 + 两个圆心的距离 * 两个圆心的距离) / (2 * 两个圆心的距离 * 两个圆心的距离);
                            double y0 = y1 + k1 * (x0 - x1);
                            double Dis1 = r1 * r1 - (x0 - x1) * (x0 - x1) - (y0 - y1) * (y0 - y1); //CE的平方
                            double Dis2 = Math.Sqrt(Dis1 / (1 + k2 * k2));//EF的长，过C作过E点水平直线的垂线，交于F点
                            交点[0].x = x0 - Dis2;
                            交点[0].y = y0 + k2 * (交点[0].x - x0);
                            交点[1].x = x0 + Dis2;
                            交点[1].y = y0 + k2 * (交点[1].y - x0);
                        }
                    }
                }
            }
            return 交点;
        }

        public static PointD[] 获取圆与圆的交点(PointD 圆心, double 半径, CircleS a)
        {
            return 获取圆与圆的交点(圆心, 半径, a.CenterPo, a.R);
        }

        public static PointD[] 获取圆与圆的交点(CircleS a, PointD 圆心, double 半径)
        {
            return 获取圆与圆的交点(a.CenterPo, a.R, 圆心, 半径);
        }

        public static PointD[] 获取圆与圆的交点(CircleS a, CircleS b)
        {
            return 获取圆与圆的交点(a, b.CenterPo, b.R);
        }
        #endregion

        #region 获取圆与圆弧的交点
        public static PointD[] 获取圆与圆弧的交点(PointD 圆心, double 半径, PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c)
        {
            PointD 圆弧圆心 = ThreePoCalculateCircleCenter(圆弧点a, 圆弧点b, 圆弧点c);
            double 圆弧半径 = CalculateTwoPoDistance(圆弧点a, 圆弧圆心);
            PointD[] 交点 = 获取圆与圆的交点(圆心, 半径, 圆弧圆心, 圆弧半径);
            return 交点;
        }

        public static PointD[] 获取圆与圆弧的交点(PointD 圆心, double 半径, ArcThreePoS 圆弧)
        {
            return 获取圆与圆弧的交点(圆心, 半径, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取圆与圆弧的交点(CircleS 圆, PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c)
        {
            return 获取圆与圆弧的交点(圆.CenterPo, 圆.R, 圆弧点a, 圆弧点b, 圆弧点c);
        }

        public static PointD[] 获取圆与圆弧的交点(CircleS 圆, ArcThreePoS 圆弧)
        {
            return 获取圆与圆弧的交点(圆.CenterPo, 圆.R, 圆弧);
        }

        public static PointD[] 获取圆与圆弧的交点(ArcThreePoS 圆弧, CircleS 圆)
        {
            return 获取圆与圆弧的交点(圆.CenterPo, 圆.R, 圆弧);
        }
        #endregion

        #region 获取圆与圆弧的有效交点
        public static PointD[] 获取圆与圆弧的有效交点(PointD 圆心, double 半径, PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c)
        {
            PointD[] 交点 = 获取圆与圆弧的交点(圆心, 半径, 圆弧点a, 圆弧点b, 圆弧点c);
            for (int i = 0; i < 2; i++)
                if (交点[i] != null)
                    if (!IsThePointWithinTheArcAngleRange(圆弧点a, 圆弧点b, 圆弧点c, 交点[i]) && Math.Abs(CalculateTwoPoDistance(交点[i], 圆弧点a)) > 0.00000001 && Math.Abs(CalculateTwoPoDistance(交点[i], 圆弧点c)) > 0.00000001)
                        交点[i] = null;
            return 交点;
        }

        public static PointD[] 获取圆与圆弧的有效交点(PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c, PointD 圆心, double 半径)
        {
            return 获取圆与圆弧的有效交点(圆心, 半径, 圆弧点a, 圆弧点b, 圆弧点c);
        }

        public static PointD[] 获取圆与圆弧的有效交点(PointD 圆心, double 半径, ArcThreePoS 圆弧)
        {
            return 获取圆与圆弧的有效交点(圆心, 半径, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取圆与圆弧的有效交点(ArcThreePoS 圆弧, PointD 圆心, double 半径)
        {
            return 获取圆与圆弧的有效交点(圆心, 半径, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取圆与圆弧的有效交点(CircleS 圆, PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c)
        {
            return 获取圆与圆弧的有效交点(圆.CenterPo, 圆.R, 圆弧点a, 圆弧点b, 圆弧点c);
        }

        public static PointD[] 获取圆与圆弧的有效交点(PointD 圆弧点a, PointD 圆弧点b, PointD 圆弧点c, CircleS 圆)
        {
            return 获取圆与圆弧的有效交点(圆.CenterPo, 圆.R, 圆弧点a, 圆弧点b, 圆弧点c);
        }

        public static PointD[] 获取圆与圆弧的有效交点(CircleS 圆, ArcThreePoS 圆弧)
        {
            return 获取圆与圆弧的有效交点(圆.CenterPo, 圆.R, 圆弧);
        }

        public static PointD[] 获取圆与圆弧的有效交点(ArcThreePoS 圆弧, CircleS 圆)
        {
            return 获取圆与圆弧的有效交点(圆.CenterPo, 圆.R, 圆弧);
        }
        #endregion

        #region 获取圆弧与圆弧的交点
        public static PointD[] 获取圆弧与圆弧的交点(PointD a1, PointD b1, PointD c1, PointD a2, PointD b2, PointD c2)
        {
            PointD 圆心1 = ThreePoCalculateCircleCenter(a1, b1, c1);
            double 半径1 = CalculateTwoPoDistance(a1, 圆心1);
            PointD 圆心2 = ThreePoCalculateCircleCenter(a2, b2, c2);
            double 半径2 = CalculateTwoPoDistance(a2, 圆心2);
            PointD[] 交点 = 获取圆与圆的交点(圆心1, 半径1, 圆心2, 半径2);
            return 交点;
        }

        public static PointD[] 获取圆弧与圆弧的交点(PointD a, PointD b, PointD c, ArcThreePoS 圆弧)
        {
            return 获取圆弧与圆弧的交点(a, b, c, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取圆弧与圆弧的交点(ArcThreePoS 圆弧, PointD a, PointD b, PointD c)
        {
            return 获取圆弧与圆弧的交点(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo, a, b, c);
        }

        public static PointD[] 获取圆弧与圆弧的交点(ArcThreePoS a, ArcThreePoS b)
        {
            return 获取圆弧与圆弧的交点(a.StartPo, a.TwoPo, a.EndPo, b);
        }
        #endregion

        #region 获取圆弧与圆弧的有效交点
        public static PointD[] 获取圆弧与圆弧的有效交点(PointD a1, PointD b1, PointD c1, PointD a2, PointD b2, PointD c2)
        {
            PointD[] 交点 = 获取圆弧与圆弧的交点(a1, b1, c1, a2, b2, c2);
            for (int i = 0; i < 2; i++)
            {
                if (交点[i] != null)
                {
                    if (!IsThePointWithinTheArcAngleRange(a1, b1, c1, 交点[i]) && Math.Abs(CalculateTwoPoDistance(交点[i], a1)) > 0.00000001 && Math.Abs(CalculateTwoPoDistance(交点[i], c1)) > 0.00000001)
                        交点[i] = null;
                    if (交点[i] != null)
                        if (!IsThePointWithinTheArcAngleRange(a2, b2, c2, 交点[i]) && Math.Abs(CalculateTwoPoDistance(交点[i], a2)) > 0.00000001 && Math.Abs(CalculateTwoPoDistance(交点[i], c2)) > 0.00000001)
                            交点[i] = null;
                    if (交点[i] != null)
                        if (IsCompareTowPoEqual(a1, 交点[i]) || IsCompareTowPoEqual(c1, 交点[i]))
                            交点[i] = null;
                }
            }
            return 交点;
        }

        public static PointD[] 获取圆弧与圆弧的有效交点(PointD a, PointD b, PointD c, ArcThreePoS 圆弧)
        {
            return 获取圆弧与圆弧的有效交点(a, b, c, 圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo);
        }

        public static PointD[] 获取圆弧与圆弧的有效交点(ArcThreePoS 圆弧, PointD a, PointD b, PointD c)
        {
            return 获取圆弧与圆弧的有效交点(圆弧.StartPo, 圆弧.TwoPo, 圆弧.EndPo, a, b, c);
        }

        public static PointD[] 获取圆弧与圆弧的有效交点(ArcThreePoS a, ArcThreePoS b)
        {
            return 获取圆弧与圆弧的有效交点(a.StartPo, a.TwoPo, a.EndPo, b);
        }
        #endregion

        #region 获取圆弧有效象限点
        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            PointD CircleCenter = ThreePoCalculateCircleCenter(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPoX, EndPoY);   //圆心点
            double R = CalculateTwoPoDistance(CircleCenter, StartPoX, StartPoY);//半径
            PointD[] Quadrant = new PointD[4];    //象限点
            Quadrant[0] = new PointD(CircleCenter.x + R, CircleCenter.y);
            Quadrant[1] = new PointD(CircleCenter.x - R, CircleCenter.y);
            Quadrant[2] = new PointD(CircleCenter.x, CircleCenter.y + R);
            Quadrant[3] = new PointD(CircleCenter.x, CircleCenter.y - R);
            List<PointD> EffectiveQuadrant = new List<PointD>();   //有效象限点
            for (int i = 0; i < 4; i++)
                if (IsThePointWithinTheArcAngleRange(new PointD(StartPoX, StartPoY), new PointD(TwoPoX, TwoPoY), new PointD(EndPoX, EndPoY), Quadrant[i]))
                    EffectiveQuadrant.Add(Quadrant[i]);
            return EffectiveQuadrant;
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPo"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            return GetArcEffectiveQuadrant(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY)
        {
            return GetArcEffectiveQuadrant(StartPoX, StartPoY, TwoPo.x, TwoPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPo"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo)
        {
            return GetArcEffectiveQuadrant(StartPoX, StartPoY, TwoPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            return GetArcEffectiveQuadrant(StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPoX, EndPoY);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPo"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            return GetArcEffectiveQuadrant(StartPo, TwoPoX, TwoPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY)
        {
            return GetArcEffectiveQuadrant(StartPo, TwoPo.x, TwoPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPo"></param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(PointD StartPo, PointD TwoPo, PointD EndPo)
        {
            return GetArcEffectiveQuadrant(StartPo, TwoPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 获取圆弧有效象限点
        /// </summary>
        /// <param name="Arc">圆弧</param>
        /// <returns></returns>
        public static List<PointD> GetArcEffectiveQuadrant(ArcThreePoS Arc)
        {
            return GetArcEffectiveQuadrant(Arc.StartPo, Arc.TwoPo, Arc.EndPo);
        }
        #endregion

        #region 获取圆弧的整圆
        public static CircleS 获取圆弧的整圆(PointD a, PointD b, PointD c)
        {
            PointD 圆心 = ThreePoCalculateCircleCenter(a, b, c);
            double 半径 = CalculateTwoPoDistance(圆心, a);
            return new CircleS(圆心, 半径);
        }

        public static CircleS 获取圆弧的整圆(ArcThreePoS a)
        {
            return 获取圆弧的整圆(a.StartPo, a.TwoPo, a.EndPo);
        }
        #endregion

        #region 点是否在圆弧角度范围内
        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, double PoX, double PoY)
        {
            double[] Angle = CalculationArcStartAngleAndEndStart(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);
            double Angle1 = Angle[0];
            double Angle2 = Angle[0] + Angle[1];
            PointD CircleCenter = ThreePoCalculateCircleCenter(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY);   //圆心
            double PointToCircleCenterAngle = CalculateLineAngle(CircleCenter, PoX, PoY);    //点到圆心的角度
            if (Angle1 < Angle2)
            {
                if (PointToCircleCenterAngle - Angle1 > -0.00000001 && PointToCircleCenterAngle - Angle2 < 0.00000001)
                    return true;
                if ((PointToCircleCenterAngle + 360) - Angle1 > -0.00000001 && (PointToCircleCenterAngle + 360) - Angle2 < 0.00000001)
                    return true;
            }
            if (Angle1 > Angle2)
            {
                if (PointToCircleCenterAngle - Angle1 < 0.00000001 && PointToCircleCenterAngle - Angle2 > -0.00000001)
                    return true;
                if ((PointToCircleCenterAngle - 360) - Angle1 < 0.00000001 && (PointToCircleCenterAngle - 360) - Angle2 > -0.00000001)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPoX, ArcTwoPoY, ArcEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPoX, ArcEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo.x, ArcEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPoX"></param>
        /// <param name="ArcStartPoY"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(double ArcStartPoX, double ArcStartPoY, PointD ArcTwoPo, PointD ArcEndPo, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPoX, ArcStartPoY, ArcTwoPo, ArcEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo.x, ArcStartPo.y, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, double ArcEndPoX, double ArcEndPoY, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPoX, ArcEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo.x, ArcEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPoX"></param>
        /// <param name="ArcTwoPoY"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, double ArcTwoPoX, double ArcTwoPoY, PointD ArcEndPo, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPoX, ArcTwoPoY, ArcEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPo.x, ArcTwoPo.y, ArcEndPoX, ArcEndPoY, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPoX"></param>
        /// <param name="ArcEndPoY"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, PointD ArcTwoPo, double ArcEndPoX, double ArcEndPoY, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPo, ArcEndPoX, ArcEndPoY, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPo, ArcEndPo.x, ArcEndPo.y, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcStartPo"></param>
        /// <param name="ArcTwoPo"></param>
        /// <param name="ArcEndPo"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(PointD ArcStartPo, PointD ArcTwoPo, PointD ArcEndPo, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcStartPo, ArcTwoPo, ArcEndPo, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcThreePo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(ArcThreePoS ArcThreePo, double PoX, double PoY)
        {
            return IsThePointWithinTheArcAngleRange(ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo, PoX, PoY);
        }

        /// <summary>
        /// 点是否在圆弧角度范围内
        /// </summary>
        /// <param name="ArcThreePo"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsThePointWithinTheArcAngleRange(ArcThreePoS ArcThreePo, PointD Po)
        {
            return IsThePointWithinTheArcAngleRange(ArcThreePo, Po.x, Po.y);
        }
        #endregion

        #region 点是否在圆范围内
        public static bool 点是否在圆范围内(PointD 圆心, double 半径, PointD 点)
        {
            return (CalculateTwoPoDistance(圆心, 点) < 半径);
        }

        public static bool 点是否在圆范围内(CircleS 圆, PointD 点)
        {
            return 点是否在圆范围内(圆.CenterPo, 圆.R, 点);
        }
        #endregion

        #region 点是否在直线范围内
        public static bool 点是否在直线范围内(double x1, double y1, double x2, double y2, double 点x, double 点y)
        {
            if (CalculationPoToLineVerticalDimension(new PointD(x1, y1), new PointD(x2, y2), new PointD(点x, 点y)) < 0.00000001)
            {
                double 直线长度 = CalculateTwoPoDistance(x1, y1, x2, y2);
                double a距离 = CalculateTwoPoDistance(x1, y1, 点x, 点y);
                double b距离 = CalculateTwoPoDistance(x2, y2, 点x, 点y);
                return !(a距离 > 直线长度 || b距离 > 直线长度);
            }
            else
                return false;
        }

        public static bool 点是否在直线范围内(double x1, double y1, double x2, double y2, PointD 点)
        {
            return 点是否在直线范围内(x1, y1, x2, y2, 点.x, 点.y);
        }

        public static bool 点是否在直线范围内(double x1, double y1, PointD b, double 点x, double 点y)
        {
            return 点是否在直线范围内(x1, y1, b.x, b.y, 点x, 点y);
        }

        public static bool 点是否在直线范围内(double x1, double y1, PointD b, PointD 点)
        {
            return 点是否在直线范围内(x1, y1, b, 点.x, 点.y);
        }

        public static bool 点是否在直线范围内(PointD a, double x2, double y2, double x3, double y3)
        {
            return 点是否在直线范围内(a.x, a.y, x2, y2, x3, y3);
        }

        public static bool 点是否在直线范围内(PointD a, double x2, double y2, PointD 点)
        {
            return 点是否在直线范围内(a, x2, y2, 点.x, 点.y);
        }

        public static bool 点是否在直线范围内(PointD a, PointD b, double 点x, double 点y)
        {
            return 点是否在直线范围内(a, b.x, b.y, 点x, 点y);
        }

        public static bool 点是否在直线范围内(PointD a, PointD b, PointD 点)
        {
            return 点是否在直线范围内(a, b, 点.x, 点.y);
        }

        public static bool 点是否在直线范围内(LineS 直线, PointD 点)
        {
            return 点是否在直线范围内(直线.StartPo, 直线.EndPo, 点);
        }
        #endregion

        #region 点是否在矩形范围内
        /// <summary>
        /// 点是否在矩形范围内
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsPoInRectangleInside(double StartPoX, double StartPoY, double w, double h, double PoX, double PoY)
        {
            double EndX = StartPoX + w;
            double EndY = StartPoY + h;
            return StartPoX < PoX && PoX < EndX && StartPoY < PoY && PoY < EndY;
        }

        /// <summary>
        /// 点是否在矩形范围内
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsPoInRectangleInside(double StartPoX, double StartPoY, double w, double h, PointD Po)
        {
            return IsPoInRectangleInside(StartPoX, StartPoY, w, h, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在矩形范围内
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsPoInRectangleInside(PointD StartPo, double w, double h, double PoX, double PoY)
        {
            return IsPoInRectangleInside(StartPo.x, StartPo.y, w, h, PoX, PoY);
        }

        /// <summary>
        /// 点是否在矩形范围内
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsPoInRectangleInside(PointD StartPo, double w, double h, PointD Po)
        {
            return IsPoInRectangleInside(StartPo, w, h, Po.x, Po.y);
        }

        /// <summary>
        /// 点是否在矩形范围内
        /// </summary>
        /// <param name=""></param>
        /// <param name="PoX"></param>
        /// <param name="PoY"></param>
        /// <returns></returns>
        public static bool IsPoInRectangleInside(RectD Re, double PoX, double PoY)
        {
            return IsPoInRectangleInside(Re.StartPo, Re.w, Re.h, PoX, PoY);
        }

        /// <summary>
        /// 点是否在矩形范围内
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static bool IsPoInRectangleInside(RectD Re, PointD Po)
        {
            return IsPoInRectangleInside(Re, Po.x, Po.y);
        }
        #endregion

        #region 点是否在多边形范围内
        /// <summary>
        /// 点是否在多边形范围内
        /// </summary>
        /// <param name="x">指定点的x坐标</param>
        /// <param name="y">指定点的y坐标</param>
        /// <param name="Polyg">多边形</param>
        /// <returns></returns>
        public static bool PointIsPolygRange(double x, double y, IrregularPolygS IrregularPolyg)
        {
            PointD PoA = CalculateLineEndPo(x, y, 0, IrregularPolyg.Len);
            PointD PoB = CalculateLineEndPo(x, y, 180, IrregularPolyg.Len);
            List<PointD> AllPo = GetLineAndPolygValidNode(new LineS(PoA, PoB), IrregularPolyg);

            if (GetLineAndPolygValidNode(new LineS(PoA, PoB), IrregularPolyg).Count == 2)
            {
                double Min = AllPo[0].x < AllPo[1].x ? AllPo[0].x : AllPo[1].x;
                double Max = AllPo[0].x > AllPo[1].x ? AllPo[0].x : AllPo[1].x;
                if (x > Min && x < Max)
                    return true;
                return false;
            }
            return false;
        }

        /// <summary>
        /// 点是否在多边形范围内
        /// </summary>
        /// <param name="Po">指定点坐标</param>
        /// <param name="Polyg">多边形</param>
        /// <returns></returns>
        public static bool PointIsPolygRange(PointD Po, IrregularPolygS IrregularPolyg)
        {
            return PointIsPolygRange(Po.x, Po.y, IrregularPolyg);
        }
        #endregion

        #region 圆弧是否在矩形范围内
        /// <summary>
        /// 圆弧是否在矩形范围内
        /// </summary>
        /// <param name="ArcThreePo"></param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static bool ArcIsRectRange(ArcThreePoS ArcThreePo, PointD StartPo, double w, double h)
        {
            RectD Re = new RectD(StartPo, w, h);
            List<PointD> PoS = 获取矩形与圆弧的有效交点(Re, ArcThreePo);
            if (PoS.Count > 0)
                return false;
            return IsPoInRectangleInside(Re, ArcThreePo.StartPo);  //点是否在矩形范围内
        }

        /// <summary>
        /// 圆弧是否在矩形范围内
        /// </summary>
        /// <param name="ArcThreePo"></param>
        /// <param name="Re"></param>
        /// <returns></returns>
        public static bool ArcIsRectRange(ArcThreePoS ArcThreePo, RectD Re)
        {
            return ArcIsRectRange(ArcThreePo, Re.StartPo, Re.w, Re.h);
        }
        #endregion

        #region 三点是否为一条直线
        public static bool 三点是否为一条直线(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return (CalculationPoToLineVerticalDimension(new PointD(x1, y1), new PointD(x2, y2), new PointD(x3, y3)) < 0.00000001);
        }

        public static bool 三点是否为一条直线(double x1, double y1, double x2, double y2, PointD c)
        {
            return 三点是否为一条直线(x1, y1, x2, y2, c.x, c.y);
        }

        public static bool 三点是否为一条直线(double x1, double y1, PointD b, double x3, double y3)
        {
            return 三点是否为一条直线(x1, y1, b.x, b.y, x3, y3);
        }

        public static bool 三点是否为一条直线(double x1, double y1, PointD b, PointD c)
        {
            return 三点是否为一条直线(x1, y1, b, c.x, c.y);
        }

        public static bool 三点是否为一条直线(PointD a, double x2, double y2, double x3, double y3)
        {
            return 三点是否为一条直线(a.x, a.y, x2, y2, x3, y3);
        }

        public static bool 三点是否为一条直线(PointD a, double x2, double y2, PointD c)
        {
            return 三点是否为一条直线(a, x2, y2, c.x, c.y);
        }

        public static bool 三点是否为一条直线(PointD a, PointD b, double x3, double y3)
        {
            return 三点是否为一条直线(a, b.x, b.y, x3, y3);
        }

        public static bool 三点是否为一条直线(PointD a, PointD b, PointD c)
        {
            return 三点是否为一条直线(a, b, c.x, c.y);
        }
        #endregion

        #region 获取点到直线的垂点
        /// <summary>
        /// 获取点到直线的垂点
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="EndPo"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static PointD GetPoToLineVerticalPo(PointD StartPo, PointD EndPo, PointD Po)
        {
            double Distance = CalculationPoToLineVerticalDimension(StartPo, EndPo, Po);    //点到直线的垂直距离
            double LineAngle = CalculateLineAngle(StartPo, EndPo);                         //直线角度
            PointD VerticalPo1 = CalculateLineEndPo(Po, LineAngle + 90, Distance);         //垂点1
            PointD VerticalPo2 = CalculateLineEndPo(Po, LineAngle - 90, Distance);         //垂点2
            return CalculateTwoPoDistance(VerticalPo1, StartPo) < CalculateTwoPoDistance(VerticalPo2, StartPo) ? VerticalPo1 : VerticalPo2;
        }

        /// <summary>
        /// 获取点到直线的垂点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static PointD GetPoToLineVerticalPo(LineS Line, PointD Po)
        {
            return GetPoToLineVerticalPo(Line.StartPo, Line.EndPo, Po);
        }
        #endregion

        #region 获取点到直线的最近点
        /// <summary>
        /// 获取点到直线的最近点
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="EndPo"></param>
        /// <param name="Po"></param>
        /// <returns></returns>
        public static PointD GetPoToLineNearestPo(PointD StartPo, PointD EndPo, PointD Po)
        {
            double Distance = CalculationPoToLineDimension(StartPo, EndPo, Po);    //点到直线的距离
            double LineAngle = CalculateLineAngle(StartPo, EndPo);            //直线角度
            PointD NearestPo = CalculateLineEndPo(Po, LineAngle + 90, Distance);    //最近点
            if (CalculationPoToLineDimension(StartPo, EndPo, NearestPo) > Distance / 2)
                NearestPo = CalculateLineEndPo(Po, LineAngle - 90, Distance);
            return NearestPo;
        }

        /// <summary>
        /// 获取点到直线的最近点
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="点"></param>
        /// <returns></returns>
        public static PointD GetPoToLineNearestPo(LineS Line, PointD 点)
        {
            return GetPoToLineNearestPo(Line.StartPo, Line.EndPo, 点);
        }
        #endregion

        #region 圆弧转换成三点圆弧
        /// <summary>
        /// 圆弧转换成三点圆弧
        /// </summary>
        /// <param name="CenterX"></param>
        /// <param name="CenterY"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        public static ArcThreePoS ArcToArcThreePo(double CenterX, double CenterY, double StartAngle, double EndAngle, double R)
        {
            PointD Center = new PointD(CenterX, CenterY);
            double TwoPoAngle = (StartAngle + EndAngle) / 2;   //中点角度
            TwoPoAngle = EndAngle > StartAngle ? TwoPoAngle : (StartAngle + EndAngle + 360) / 2;
            TwoPoAngle = TwoPoAngle > 360 ? TwoPoAngle - 360 : TwoPoAngle;
            PointD StartPo = Algorithm.CalculateLineEndPo(Center, StartAngle, R);
            PointD TwoPo = Algorithm.CalculateLineEndPo(Center, TwoPoAngle, R);
            PointD EndPo = Algorithm.CalculateLineEndPo(Center, EndAngle, R);
            return new ArcThreePoS(StartPo, TwoPo, EndPo);
        }

        /// <summary>
        /// 圆弧转换成三点圆弧
        /// </summary>
        /// <param name="CenterPo"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        public static ArcThreePoS ArcToArcThreePo(PointD CenterPo, double StartAngle, double EndAngle, double R)
        {
            return ArcToArcThreePo(CenterPo.x, CenterPo.y, StartAngle, EndAngle, R);
        }

        /// <summary>
        /// 圆弧转换成三点圆弧
        /// </summary>
        /// <param name="arc"></param>
        /// <returns></returns>
        public static ArcThreePoS ArcToArcThreePo(ArcS arc)
        {
            return ArcToArcThreePo(arc.CenterPo, arc.StartAngle, arc.EndAngle, arc.R);
        }
        #endregion

        #region 比较两个坐标点是否相同
        /// <summary>
        /// 比较两个坐标是否相同
        /// </summary>
        /// <param name="PoX1">点1X坐标</param>
        /// <param name="PoY1">点1Y坐标</param>
        /// <param name="PoX2">点2X坐标</param>
        /// <param name="PoY2">点2Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowPoEqual(double PoX1, double PoY1, double PoX2, double PoY2)
        {
            return (Math.Abs(PoX1 - PoX2) < 0.00000001 && Math.Abs(PoY1 - PoY2) < 0.00000001);
        }

        /// <summary>
        /// 比较两个坐标是否相同
        /// </summary>
        /// <param name="PoX1">点1X坐标</param>
        /// <param name="PoY1">点1Y坐标</param>
        /// <param name="Po2">点2坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowPoEqual(double PoX1, double PoY1, PointD Po2)
        {
            return IsCompareTowPoEqual(PoX1, PoY1, Po2.x, Po2.y);
        }

        /// <summary>
        /// 比较两个坐标是否相同
        /// </summary>
        /// <param name="Po1">点1X坐标</param>
        /// <param name="PoX2">点2X坐标</param>
        /// <param name="PoY2">点2Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowPoEqual(PointD Po1, double PoX2, double PoY2)
        {
            return IsCompareTowPoEqual(Po1.x, Po1.y, PoX2, PoY2);
        }

        /// <summary>
        /// 比较两个坐标是否相同
        /// </summary>
        /// <param name="Po1">点1坐标</param>
        /// <param name="Po2">点2坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowPoEqual(PointD Po1, PointD Po2)
        {
            return IsCompareTowPoEqual(Po1, Po2.x, Po2.y);
        }
        #endregion

        #region  比较两个三点圆弧是否相同
        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>

        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            if (IsCompareTowPoEqual(Arc1StartPoX, Arc1StartPoY, Arc2StartPoX, Arc2StartPoY) && IsCompareTowPoEqual(Arc1TwoPoX, Arc1TwoPoY, Arc2TwoPoX, Arc2TwoPoY) && IsCompareTowPoEqual(Arc1EndPoX, Arc1EndPoY, Arc2EndPoX, Arc2EndPoY))
                return true;
            if (IsCompareTowPoEqual(Arc1StartPoX, Arc1StartPoY, Arc2EndPoX, Arc2EndPoY) && IsCompareTowPoEqual(Arc1TwoPoX, Arc1TwoPoY, Arc2TwoPoX, Arc2TwoPoY) && IsCompareTowPoEqual(Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY))
                return true;
            return false;
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点X坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点X坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2S">圆弧2</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo.x, Arc1EndPo.y, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2">圆弧2</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo.x, Arc1TwoPo.y, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPoX">圆弧1起点X坐标</param>
        /// <param name="Arc1StartPoY">圆弧1起点Y坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2">圆弧2</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(double Arc1StartPoX, double Arc1StartPoY, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPoX, Arc1StartPoY, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo.x, Arc1StartPo.y, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2">圆弧2</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, double Arc1EndPoX, double Arc1EndPoY, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPoX, Arc1EndPoY, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo.x, Arc1EndPo.y, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo.x, Arc1EndPo.y, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo.x, Arc1EndPo.y, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPoX">圆弧1第二点X坐标</param>
        /// <param name="Arc1TwoPoY">圆弧1第二点Y坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2">圆弧2</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, double Arc1TwoPoX, double Arc1TwoPoY, PointD Arc1EndPo, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPoX, Arc1TwoPoY, Arc1EndPo, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo.x, Arc1TwoPo.y, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPoX">圆弧1终点X坐标</param>
        /// <param name="Arc1EndPoY">圆弧1终点Y坐标</param>
        /// <param name="Arc2">圆弧2</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, double Arc1EndPoX, double Arc1EndPoY, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPoX, Arc1EndPoY, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo.x, Arc1EndPo.y, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1StartPo">圆弧1起点坐标</param>
        /// <param name="Arc1TwoPo">圆弧1第二点坐标</param>
        /// <param name="Arc1EndPo">圆弧1终点坐标</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(PointD Arc1StartPo, PointD Arc1TwoPo, PointD Arc1EndPo, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1StartPo, Arc1TwoPo, Arc1EndPo, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1.StartPo, Arc1.TwoPo, Arc1.EndPo, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, double Arc2StartPoX, double Arc2StartPoY, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPoX, Arc2StartPoY, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPoX">圆弧2起点X坐标</param>
        /// <param name="Arc2StartPoY">圆弧2起点Y坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点X坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, double Arc2StartPoX, double Arc2StartPoY, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPoX, Arc2StartPoY, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPo.x, Arc2StartPo.y, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPoX">圆弧2第二点X坐标</param>
        /// <param name="Arc2TwoPoY">圆弧2第二点Y坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, PointD Arc2StartPo, double Arc2TwoPoX, double Arc2TwoPoY, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPo, Arc2TwoPoX, Arc2TwoPoY, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPoX">圆弧2终点X坐标</param>
        /// <param name="Arc2EndPoY">圆弧2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, PointD Arc2StartPo, PointD Arc2TwoPo, double Arc2EndPoX, double Arc2EndPoY)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPo, Arc2TwoPo.x, Arc2TwoPo.y, Arc2EndPoX, Arc2EndPoY);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, PointD Arc2StartPo, PointD Arc2TwoPo, PointD Arc2EndPo)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2StartPo, Arc2TwoPo, Arc2EndPo.x, Arc2EndPo.y);
        }

        /// <summary>
        /// 比较两个三点圆弧是否相同
        /// </summary>
        /// <param name="Arc1">圆弧1</param>
        /// <param name="Arc2StartPo">圆弧2起点坐标</param>
        /// <param name="Arc2TwoPo">圆弧2第二点坐标</param>
        /// <param name="Arc2EndPo">圆弧2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowArcThreePoEqual(ArcThreePoS Arc1, ArcThreePoS Arc2)
        {
            return IsCompareTowArcThreePoEqual(Arc1, Arc2.StartPo, Arc2.TwoPo, Arc2.EndPo);
        }
        #endregion

        #region 比较两个直线是否相同
        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            if (IsCompareTowPoEqual(Line1StartPoX, Line1StartPoY, Line2StartPoX, Line2StartPoY) && IsCompareTowPoEqual(Line1EndPoX, Line1EndPoY, Line2EndPoX, Line2EndPoY))
                return true;
            if (IsCompareTowPoEqual(Line1StartPoX, Line1StartPoY, Line2EndPoX, Line2EndPoY) && IsCompareTowPoEqual(Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY))
                return true;
            return false;
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPo.x, Line1EndPo.y, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, LineS Line2Start)
        {
            return IsCompareTowLineEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2Start.StartPo, Line2Start.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPo.x, Line1StartPo.y, Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPo.x, Line1EndPo.y, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPo, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, PointD Line1EndPo, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPo, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, PointD Line1EndPo, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1StartPo, Line1EndPo, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(PointD Line1StartPo, PointD Line1EndPo, LineS Line2)
        {
            return IsCompareTowLineEqual(Line1StartPo.x, Line1StartPo.y, Line1EndPo, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(LineS Line1, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1.StartPo, Line1.EndPo, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(LineS Line1, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1.StartPo, Line1.EndPo, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(LineS Line1, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineEqual(Line1, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(LineS Line1, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineEqual(Line1, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否相同
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineEqual(LineS Line1, LineS Line2)
        {
            return IsCompareTowLineEqual(Line1, Line2.StartPo, Line2.EndPo);
        }
        #endregion

        #region 比较两个直线是否同长
        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            double a = CalculateTwoPoDistance(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY);
            double b = CalculateTwoPoDistance(Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
            return Math.Abs(a - b) < 0.00000001;
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPo.x, Line1EndPo.y, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPoX">直线1起点X坐标</param>
        /// <param name="Line1StartPoY">直线1起点Y坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(double Line1StartPoX, double Line1StartPoY, PointD Line1EndPo, LineS Line2Start)
        {
            return IsCompareTowLineLengleEqual(Line1StartPoX, Line1StartPoY, Line1EndPo, Line2Start.StartPo, Line2Start.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo.x, Line1StartPo.y, Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPoX">直线1终点X坐标</param>
        /// <param name="Line1EndPoY">直线1终点Y坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, double Line1EndPoX, double Line1EndPoY, LineS Line2)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPoX, Line1EndPoY, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPo.x, Line1EndPo.y, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, PointD Line1EndPo, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPo, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, PointD Line1EndPo, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPo, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, PointD Line1EndPo, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo, Line1EndPo, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1StartPo">直线1起点坐标</param>
        /// <param name="Line1EndPo">直线1终点坐标</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(PointD Line1StartPo, PointD Line1EndPo, LineS Line2)
        {
            return IsCompareTowLineLengleEqual(Line1StartPo.x, Line1StartPo.y, Line1EndPo, Line2.StartPo, Line2.EndPo);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(LineS Line1, double Line2StartPoX, double Line2StartPoY, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1.StartPo, Line1.EndPo, Line2StartPoX, Line2StartPoY, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPoX">直线2起点X坐标</param>
        /// <param name="Line2StartPoY">直线2起点Y坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(LineS Line1, double Line2StartPoX, double Line2StartPoY, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1.StartPo, Line1.EndPo, Line2StartPoX, Line2StartPoY, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPoX">直线2终点X坐标</param>
        /// <param name="Line2EndPoY">直线2终点Y坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(LineS Line1, PointD Line2StartPo, double Line2EndPoX, double Line2EndPoY)
        {
            return IsCompareTowLineLengleEqual(Line1, Line2StartPo.x, Line2StartPo.y, Line2EndPoX, Line2EndPoY);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2StartPo">直线2起点坐标</param>
        /// <param name="Line2EndPo">直线2终点坐标</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(LineS Line1, PointD Line2StartPo, PointD Line2EndPo)
        {
            return IsCompareTowLineLengleEqual(Line1, Line2StartPo, Line2EndPo.x, Line2EndPo.y);
        }

        /// <summary>
        /// 比较两个直线是否同长
        /// </summary>
        /// <param name="Line1">直线1</param>
        /// <param name="Line2">直线2</param>
        /// <returns></returns>
        public static bool IsCompareTowLineLengleEqual(LineS Line1, LineS Line2)
        {
            return IsCompareTowLineLengleEqual(Line1, Line2.StartPo, Line2.EndPo);
        }
        #endregion

        #region 比较两个圆是否相同
        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1CenterPoX">圆1圆心X坐标</param>
        /// <param name="Circle1CenterPoY">圆1圆心Y坐标</param>
        /// <param name="Circle1R">圆1半径</param>
        /// <param name="Circle2CenterPoX">圆2圆心X坐标</param>
        /// <param name="Circle2CenterPoY">圆2圆心Y坐标</param>
        /// <param name="Circle2R">圆2半径</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(double Circle1CenterPoX, double Circle1CenterPoY, double Circle1R, double Circle2CenterPoX, double Circle2CenterPoY, double Circle2R)
        {
            return IsCompareTowPoEqual(Circle1CenterPoX, Circle1CenterPoY, Circle2CenterPoX, Circle2CenterPoY) && Math.Abs(Circle1R - Circle2R) < 0.00000001;
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1CenterPoX">圆1圆心X坐标</param>
        /// <param name="Circle1CenterPoY">圆1圆心Y坐标</param>
        /// <param name="Circle1R">圆1半径</param>
        /// <param name="Circle2CenterPo">圆2圆心坐标</param>
        /// <param name="Circle2R">圆2半径</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(double Circle1CenterPoX, double Circle1CenterPoY, double Circle1R, PointD Circle2CenterPo, double Circle2R)
        {
            return IsCompareTowCircleEqual(Circle1CenterPoX, Circle1CenterPoY, Circle1R, Circle2CenterPo.x, Circle2CenterPo.y, Circle2R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1CenterPoX">圆1圆心X坐标</param>
        /// <param name="Circle1CenterPoY">圆1圆心Y坐标</param>
        /// <param name="Circle1R">圆1半径</param>
        /// <param name="Circle2">圆2</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(double Circle1CenterPoX, double Circle1CenterPoY, double Circle1R, CircleS Circle2)
        {
            return IsCompareTowCircleEqual(Circle1CenterPoX, Circle1CenterPoY, Circle1R, Circle2.CenterPo, Circle2.R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1CenterPo">圆1圆心坐标</param>
        /// <param name="Circle1R">圆1半径</param>
        /// <param name="Circle2CenterPoX">圆2圆心X坐标</param>
        /// <param name="Circle2CenterPoY">圆2圆心Y坐标</param>
        /// <param name="Circle2R">圆2半径</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(PointD Circle1CenterPo, double Circle1R, double Circle2CenterPoX, double Circle2CenterPoY, double Circle2R)
        {
            return IsCompareTowCircleEqual(Circle1CenterPo.x, Circle1CenterPo.y, Circle1R, Circle2CenterPoX, Circle2CenterPoY, Circle2R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1CenterPo">圆1圆心坐标</param>
        /// <param name="Circle1R">圆1半径</param>
        /// <param name="Circle2CenterPo">圆2圆心坐标</param>
        /// <param name="Circle2R">圆2半径</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(PointD Circle1CenterPo, double Circle1R, PointD Circle2CenterPo, double Circle2R)
        {
            return IsCompareTowCircleEqual(Circle1CenterPo, Circle1R, Circle2CenterPo.x, Circle2CenterPo.y, Circle2R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1CenterPo">圆1圆心坐标</param>
        /// <param name="Circle1R">圆1半径</param>
        /// <param name="Circle2">圆2</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(PointD Circle1CenterPo, double Circle1R, CircleS Circle2)
        {
            return IsCompareTowCircleEqual(Circle1CenterPo, Circle1R, Circle2.CenterPo, Circle2.R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1">圆1</param>
        /// <param name="Circle2CenterPoX">圆2圆心X坐标</param>
        /// <param name="Circle2CenterPoY">圆2圆心Y坐标</param>
        /// <param name="Circle2R">圆2半径</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(CircleS Circle1, double Circle2CenterPoX, double Circle2CenterPoY, double Circle2R)
        {
            return IsCompareTowCircleEqual(Circle1.CenterPo, Circle1.R, Circle2CenterPoX, Circle2CenterPoY, Circle2R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1">圆1</param>
        /// <param name="Circle2CenterPo">圆2圆心坐标</param>
        /// <param name="Circle2R">圆2半径</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(CircleS Circle1, PointD Circle2CenterPo, double Circle2R)
        {
            return IsCompareTowCircleEqual(Circle1.CenterPo, Circle1.R, Circle2CenterPo.x, Circle2CenterPo.y, Circle2R);
        }

        /// <summary>
        /// 比较两个圆是否相同
        /// </summary>
        /// <param name="Circle1">圆1</param>
        /// <param name="Circle2">圆2</param>
        /// <returns></returns>
        public static bool IsCompareTowCircleEqual(CircleS Circle1, CircleS Circle2)
        {
            return IsCompareTowCircleEqual(Circle1, Circle2.CenterPo, Circle2.R);
        }
        #endregion

        #region 判断三点圆弧是否顺时针
        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX"> 第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPoX, EndPoY);
            double Angle1 = CalculateLineAngle(CenterPo, StartPoX, StartPoY);
            double Angle2 = CalculateLineAngle(CenterPo, TwoPoX, TwoPoY);
            double Angle3 = CalculateLineAngle(CenterPo, EndPoX, EndPoY);
            bool IsClockwise = true;

            //顺向
            if (Angle1 > Angle2 && Angle2 > Angle3 && (Angle3 - Angle1) > -360)
                IsClockwise = true;
            if (Angle1 > Angle2 && Angle2 > (Angle3 - 360) && (Angle3 - 360 - Angle1) > -360)
                IsClockwise = true;
            if (Angle1 > (Angle2 - 360) && (Angle2 - 360) > (Angle3 - 360) && (Angle3 - 360 - Angle1) > -360)
                IsClockwise = true;

            //逆向
            if (Angle1 < Angle2 && Angle2 < Angle3 && (Angle3 - Angle1) < 360)
                IsClockwise = false;
            if (Angle1 < (Angle2 + 360) && (Angle2 + 360) < (Angle3 + 360) && (Angle3 + 360 - Angle1) < 360)
                IsClockwise = false;
            if (Angle1 < Angle2 && Angle2 < (Angle3 + 360) && (Angle3 + 360 - Angle1) < 360)
                IsClockwise = false;
            return IsClockwise;
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPoX"> 第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            return IsArcThreePoClockwise(StartPoX, StartPoY, TwoPoX, TwoPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo"> 第二点坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY)
        {
            return IsArcThreePoClockwise(StartPoX, StartPoY, TwoPo.x, TwoPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPoX">起点X坐标</param>
        /// <param name="StartPoY">起点y坐标</param>
        /// <param name="TwoPo"> 第二点坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo)
        {
            return IsArcThreePoClockwise(StartPoX, StartPoY, TwoPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="TwoPoX"> 第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            return IsArcThreePoClockwise(StartPo.x, StartPo.y, TwoPoX, TwoPoY, EndPoX, EndPoY);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="TwoPoX"> 第二点X坐标</param>
        /// <param name="TwoPoY">第二点Y坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            return IsArcThreePoClockwise(StartPo, TwoPoX, TwoPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="TwoPo"> 第二点坐标</param>
        /// <param name="EndPoX">终点X坐标</param>
        /// <param name="EndPoY">终点Y坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY)
        {
            return IsArcThreePoClockwise(StartPo, TwoPo.x, TwoPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="StartPo">起点坐标</param>
        /// <param name="TwoPo"> 第二点坐标</param>
        /// <param name="EndPo">终点坐标</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(PointD StartPo, PointD TwoPo, PointD EndPo)
        {
            return IsArcThreePoClockwise(StartPo, TwoPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 判断三点圆弧是否顺时针
        /// </summary>
        /// <param name="ArcThreePo">圆弧</param>
        /// <returns></returns>
        public static bool IsArcThreePoClockwise(ArcThreePoS ArcThreePo)
        {
            return IsArcThreePoClockwise(ArcThreePo.StartPo, ArcThreePo.TwoPo, ArcThreePo.EndPo);
        }
        #endregion
    }

    /// <summary>
    /// 画图类
    /// </summary>
    public class Draw : Algorithm
    {
        #region 画实心多边形
        /// <summary>
        /// 画实心多边形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="AllLine">多边形的所有边</param>
        public static void DrawDilledPolygon(Graphics g, Color color, List<LineS> AllLine)
        {
            PointF[] AllPo = new PointF[AllLine.Count];
            for (int i = 0; i < AllLine.Count; i++)
                AllPo[i] = new PointF((float)AllLine[i].StartPo.x, (float)AllLine[i].StartPo.y);
            g.FillPolygon(new SolidBrush(color), AllPo);
        }

        /// <summary>
        /// 画实心多边形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="AllPo">点集合形成的多边形</param>
        public static void DrawDilledPolygon(Graphics g, Color color, PointD[] AllPo)
        {
            PointF[] AllPoF = new PointF[AllPo.Length];
            for (int i = 0; i < AllPo.Length; i++)
                AllPoF[i] = new PointF((float)AllPo[i].x, (float)AllPo[i].y);
            g.FillPolygon(new SolidBrush(color), AllPoF);
        }

        /// <summary>
        /// 画实心多边形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="AllPo">点集合形成的多边形</param>
        public static void DrawDilledPolygon(Graphics g, Color color, List<PointD> AllPo)
        {
            DrawDilledPolygon(g, color, AllPo.ToArray());
        }
        #endregion

        #region 画空心多边形
        /// <summary>
        /// 画空心多边形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">画笔</param>
        /// <param name="AllLine">多边形的所有顶点</param>
        public static void DrawPolygon(Graphics g, Pen p, PointD[] AllPo)
        {
            if (AllPo.Length > 2)
            {
                for (int i = 0; i < AllPo.Length; i++)
                {
                    if (i == AllPo.Length - 1)
                        g.DrawLine(p, (int)AllPo[i].x, (int)AllPo[i].y, (int)AllPo[0].x, (int)AllPo[0].y);
                    else
                        g.DrawLine(p, (int)AllPo[i].x, (int)AllPo[i].y, (int)AllPo[i + 1].x, (int)AllPo[i + 1].y);
                }
            }
        }

        /// <summary>
        /// 画空心多边形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">画笔</param>
        /// <param name="AllLine">多边形的所有顶点</param>
        public static void DrawPolygon(Graphics g, Pen p,List< PointD> AllPo)
        {
            if (AllPo.Count > 2)
            {
                for (int i = 0; i < AllPo.Count; i++)
                {
                    if (i == AllPo.Count - 1)
                        g.DrawLine(p, (int)AllPo[i].x, (int)AllPo[i].y, (int)AllPo[0].x, (int)AllPo[0].y);
                    else
                        g.DrawLine(p, (int)AllPo[i].x, (int)AllPo[i].y, (int)AllPo[i + 1].x, (int)AllPo[i + 1].y);
                }
            }
        }
        #endregion

        #region  画直线
        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public static void DrawLine(Graphics g, Pen p, double StartPoX, double StartPoY, double EndPoX, double EndPoY)
        {
            g.DrawLine(p, (int)StartPoX, (int)StartPoY, (int)EndPoX, (int)EndPoY);
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="EndPo"></param>
        public static void DrawLine(Graphics g, Pen p, double StartPoX, double StartPoY, PointD EndPo)
        {
            DrawLine(g, p, StartPoX, StartPoY, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="StartPo"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public static void DrawLine(Graphics g, Pen p, PointD StartPo, double EndPoX, double EndPoY)
        {
            DrawLine(g, p, StartPo.x, StartPo.y, EndPoX, EndPoY);
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="StartPo"></param>
        /// <param name="EndPo"></param>
        public static void DrawLine(Graphics g, Pen p, PointD StartPo, PointD EndPo)
        {
            DrawLine(g, p, StartPo, EndPo.x, EndPo.y);
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="Line"></param>
        public static void DrawLine(Graphics g, Pen p, LineS Line)
        {
            DrawLine(g, p, Line.StartPo, Line.EndPo);
        }
        #endregion

        #region 画实心矩形:中心坐标
        /// <summary>
        /// 画实心矩形:中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="CenterPoX">矩形中心x坐标</param>
        /// <param name="CenterPoY">矩形中心y坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawDilledRect(Graphics g, Color color, double CenterPoX, double CenterPoY, double w, double h)
        {
            if (w > 1 && h > 1)
                g.FillRectangle(new SolidBrush(color), (float)(CenterPoX - w / 2), (float)(CenterPoY - h / 2), (float)w, (float)h);
        }

        /// <summary>
        /// 画实心矩形:中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="CenterPoX">矩形中心x坐标</param>
        /// <param name="CenterPoY">矩形中心y坐标</param>
        /// <param name="Size">大小</param>
        public static void DrawDilledRect(Graphics g, Color color, double CenterPoX, double CenterPoY, SizeF Size)
        {
            DrawDilledRect(g, color, CenterPoX, CenterPoY, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画实心矩形:中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="CenterPo">矩形中心坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawDilledRect(Graphics g, Color color, PointD CenterPo, double w, double h)
        {
            DrawDilledRect(g, color, CenterPo.x, CenterPo.y, w, h);
        }

        /// <summary>
        /// 画实心矩形:中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="CenterPo">矩形中心坐标</param>
        /// <param name="大小">大小</param>
        public static void DrawDilledRect(Graphics g, Color color, PointD CenterPo, SizeF Size)
        {
            DrawDilledRect(g, color, CenterPo, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画实心矩形:中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="Rect">矩形</param>
        public static void DrawDilledRect(Graphics g, Color color, RectD Rect)
        {
            DrawDilledRect(g, color, Rect.CenterPo, Rect.w, Rect.h);
        }
        #endregion

        #region 画实心矩形:起始坐标
        /// <summary>
        /// 画实心矩形:起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="PoX">矩形起始x坐标</param>
        /// <param name="PoY">矩形起始y坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawDilledRect1(Graphics g, Color color, double PoX, double PoY, double w, double h)
        {
            if (w > 1 && h > 1)
                g.FillRectangle(new SolidBrush(color), (int)PoX, (int)PoY, (int)w, (int)h);
        }

        /// <summary>
        /// 画实心矩形:起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="PoX">矩形起始x坐标</param>
        /// <param name="PoY">矩形起始y坐标</param>
        /// <param name="Size">大小</param>
        public static void DrawDilledRect1(Graphics g, Color color, double PoX, double PoY, SizeF Size)
        {
            DrawDilledRect1(g, color, PoX, PoY, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画实心矩形:起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="Po">矩形起始坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawDilledRect1(Graphics g, Color color, PointD Po, double w, double h)
        {
            DrawDilledRect1(g, color, Po.x, Po.y, w, h);
        }

        /// <summary>
        /// 画实心矩形:起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="Po">矩形起始坐标</param>
        /// <param name="大小">大小</param>
        public static void DrawDilledRect1(Graphics g, Color color, PointD Po, SizeF Size)
        {
            DrawDilledRect1(g, color, Po, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画实心矩形:起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="color">颜色</param>
        /// <param name="Re">矩形</param>
        public static void DrawDilledRect1(Graphics g, Color color, RectD Re)
        {
            DrawDilledRect1(g, color, Re.StartPo, Re.w, Re.h);
        }
        #endregion

        #region 画空心矩形：中心坐标
        /// <summary>
        /// 画空心矩形：中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="CenterPoX">矩形中心x坐标</param>
        /// <param name="CenterPoY">矩形中心y坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawRect(Graphics g, Pen p, double CenterPoX, double CenterPoY, double w, double h)
        {
            if (w > 1 && h > 1)
                g.DrawRectangle(p, (int)(CenterPoX - w / 2), (int)(CenterPoY - h / 2), (int)w, (int)h);
        }

        /// <summary>
        /// 画空心矩形：中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="CenterPoX">矩形中心x坐标</param>
        /// <param name="CenterPoY">矩形中心x坐标</param>
        /// <param name="Size">大小</param>
        public static void DrawRect(Graphics g, Pen p, double CenterPoX, double CenterPoY, SizeF Size)
        {
            DrawRect(g, p, CenterPoX, CenterPoY, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画空心矩形：中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="a">矩形中心坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawRect(Graphics g, Pen p, PointD CenterPo, double w, double h)
        {
            DrawRect(g, p, CenterPo.x, CenterPo.y, w, h);
        }

        /// <summary>
        /// 画空心矩形：中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="a">矩形中心坐标</param>
        /// <param name="Size">大小</param>
        public static void DrawRect(Graphics g, Pen p, PointD CenterPo, SizeF Size)
        {
            DrawRect(g, p, CenterPo, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画空心矩形：中心坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="Rect">矩形</param>
        public static void DrawRect(Graphics g, Pen p, RectD Rect)
        {
            DrawRect(g, p, Rect.CenterPo, Rect.w, Rect.h);
        }
        #endregion

        #region 画空心矩形：起始坐标
        /// <summary>
        /// 画空心矩形：起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="PoX">矩形起始x坐标</param>
        /// <param name="PoY">矩形起始y坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawRect1(Graphics g, Pen p, double PoX, double PoY, double w, double h)
        {
            if (w > 1 && h > 1)
                g.DrawRectangle(p, (int)(PoX), (int)(PoY), (int)w, (int)h);
        }

        /// <summary>
        /// 画空心矩形：起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="PoX">矩形起始x坐标</param>
        /// <param name="PoY">矩形起始y坐标</param>
        /// <param name="Size">大小</param>
        public static void DrawRect1(Graphics g, Pen p, double PoX, double PoY, SizeF Size)
        {
            DrawRect1(g, p, PoX, PoY, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画空心矩形：起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="a">矩形起始坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public static void DrawRect1(Graphics g, Pen p, PointD Po, double w, double h)
        {
            DrawRect1(g, p, Po.x, Po.y, w, h);
        }

        /// <summary>
        /// 画空心矩形：起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="Po">矩形起始坐标</param>
        /// <param name="Size">大小</param>
        public static void DrawRect1(Graphics g, Pen p, PointD Po, SizeF Size)
        {
            DrawRect1(g, p, Po, Size.Width, Size.Height);
        }

        /// <summary>
        /// 画空心矩形：起始坐标
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="Re">矩形</param>
        public static void DrawRect1(Graphics g, Pen p, RectD Re)
        {
            DrawRect1(g, p, Re.StartPo, Re.w, Re.h);
        }
        #endregion

        #region 画实心扇形
        /// <summary>
        /// 画实心扇形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="br">画刷</param>
        /// <param name="CenterPoX">圆心X坐标</param>
        /// <param name="CenterPoY">圆心Y坐标</param>
        /// <param name="R">半径</param>
        /// <param name="StartAngle">起始角度</param>
        /// <param name="AngleLen">角度长度</param>
        public static void DrawFillPic(Graphics g, Brush br, double CenterPoX, double CenterPoY, double R, double StartAngle, double AngleLen)
        {
            g.FillPie(br, new Rectangle((int)(CenterPoX - R), (int)(CenterPoY - R), (int)(R * 2), (int)(R * 2)), (float)StartAngle, (float)AngleLen);
        }

        /// <summary>
        /// 画实心扇形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="br">画刷</param>
        /// <param name="CenterPo">圆心</param>
        /// <param name="R">半径</param>
        /// <param name="StartAngle">起始角度</param>
        /// <param name="AngleLen">角度长度</param>
        public static void DrawFillPic(Graphics g, Brush br, PointD CenterPo, double R, double StartAngle, double AngleLen)
        {
            DrawFillPic(g, br, CenterPo.x, CenterPo.y, R, StartAngle, AngleLen);
        }

        /// <summary>
        /// 画实心扇形
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="br">画刷</param>
        /// <param name="Circle">圆</param>
        /// <param name="StartAngle">起始角度</param>
        /// <param name="AngleLen">角度长度</param>
        public static void DrawFillPic(Graphics g, Brush br, CircleS Circle, double StartAngle, double AngleLen)
        {
            DrawFillPic(g, br, Circle.CenterPo, Circle.R, StartAngle, AngleLen);
        }
        #endregion

        #region 画圆
        /// <summary>
        /// 画圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="CenterPoX"></param>
        /// <param name="CenterPoY"></param>
        /// <param name="r"></param>
        public static void DrawCircle(Graphics g, Pen p, double CenterPoX, double CenterPoY, double r)
        {
            RectangleF DrawRect = new RectangleF((float)(CenterPoX - r), (float)(CenterPoY - r), (float)r * 2, (float)r * 2);
            try
            {
                g.DrawArc(p, DrawRect, 0, 360);
            }
            catch
            {
                MessageBox.Show("画圆失败");
            }
        }

        /// <summary>
        /// 画圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="CenterPo"></param>
        /// <param name="R"></param>
        public static void DrawCircle(Graphics g, Pen p, PointD CenterPo, double R)
        {
            DrawCircle(g, p, CenterPo.x, CenterPo.y, R);
        }

        /// <summary>
        /// 画圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="Circle"></param>
        public static void DrawCircle(Graphics g, Pen p, CircleS Circle)
        {
            DrawCircle(g, p, Circle.CenterPo, Circle.R);
        }
        #endregion

        #region 画实心圆
        /// <summary>
        /// 画实心圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="Brush"></param>
        /// <param name="CenterPoX"></param>
        /// <param name="CenterPoY"></param>
        /// <param name="r"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        public static void DrawRealCircle(Graphics g, Color Co, double CenterPoX, double CenterPoY, double r, double StartAngle, double EndAngle)   //SolidBrush Brush
        {
            Rectangle DrawRect = new Rectangle((int)(CenterPoX - r), (int)(CenterPoY - r), (int)r * 2, (int)r * 2);
            if (DrawRect.Width > 1 && DrawRect.Height > 0)
                g.FillPie(new SolidBrush(Co), DrawRect, (float)StartAngle, (float)EndAngle);
        }

        /// <summary>
        /// 画实心圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="Brush"></param>
        /// <param name="CenterPo"></param>
        /// <param name="r"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        public static void DrawRealCircle(Graphics g, Color Co, PointD CenterPo, double r, double StartAngle, double EndAngle)
        {
            DrawRealCircle(g, Co, CenterPo.x, CenterPo.y, r, StartAngle, EndAngle);
        }

        /// <summary>
        /// 画实心圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="Brush"></param>
        /// <param name="Circle"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        public static void DrawRealCircle(Graphics g, Color Co, CircleS Circle, double StartAngle, double EndAngle)
        {
            DrawRealCircle(g, Co, Circle.CenterPo.x, Circle.CenterPo.y, Circle.R, StartAngle, EndAngle);
        }

        /// <summary>
        /// 画实心圆
        /// </summary>
        /// <param name="g"></param>
        /// <param name="Brush"></param>
        /// <param name="Circle"></param>
        public static void DrawRealCircle(Graphics g, Color Co, CircleS Circle)
        {
            DrawRealCircle(g, Co, Circle, 0, 360);
        }
        #endregion

        #region 画半径圆弧
        /// <summary>
        /// 画半径圆弧
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="CenterPo">圆弧心</param>
        /// <param name="R">圆弧半径</param>
        /// <param name="StartAngle">圆弧起始角度</param>
        /// <param name="EndAngle">圆弧结束角度</param>
        public static void DrawArc(Graphics g, Pen p, PointD CenterPo, double R, double StartAngle, double EndAngle)
        {
            RectangleF DrawRect = new RectangleF((float)(CenterPo.x - R), (float)(CenterPo.y - R), (float)R * 2, (float)R * 2);
            if (DrawRect.Width > 1 && DrawRect.Height > 0)
                g.DrawArc(p, DrawRect, (float)StartAngle, (float)EndAngle);
        }

        /// <summary>
        /// 画半径圆弧
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="Arc">半径圆弧</param>
        public static void DrawArc(Graphics g, Pen p, ArcS Arc)
        {
            DrawArc(g, p, Arc.CenterPo, Arc.R, Arc.StartAngle, Arc.EndAngle);
        }
        #endregion

        #region 画三点圆弧
        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        public static void DrawArc3Po(Graphics g, Pen p, double OnePoX, double OnePoY, double TwoPoX, double TwoPoY, double ThreePoX, double ThreePoY)
        {
            PointD CenterPo = ThreePoCalculateCircleCenter(OnePoX, OnePoY, TwoPoX, TwoPoY, ThreePoX, ThreePoY);                   //圆心坐标
            double R = CalculateTwoPoDistance(CenterPo, OnePoX, OnePoY);                                                          //计算两点之间的距离，计算圆弧半径
            double[] Angle = CalculationArcStartAngleAndEndStart(OnePoX, OnePoY, TwoPoX, TwoPoY, ThreePoX, ThreePoY);             //计算圆弧起始角度
            RectangleF DrawRect = new RectangleF((float)(CenterPo.x - R), (float)(CenterPo.y - R), (float)R * 2, (float)R * 2);   //画图区域
            if (DrawRect.Width > 1 && DrawRect.Height > 0)
                g.DrawArc(p, DrawRect, (float)Angle[0], (float)Angle[1]);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePo"></param>
        public static void DrawArc3Po(Graphics g, Pen p, double OnePoX, double OnePoY, double TwoPoX, double TwoPoY, PointD ThreePo)
        {
            DrawArc3Po(g, p, OnePoX, OnePoY, TwoPoX, TwoPoY, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        public static void DrawArc3Po(Graphics g, Pen p, double OnePoX, double OnePoY, PointD TwoPo, double ThreePoX, double ThreePoY)
        {
            DrawArc3Po(g, p, OnePoX, OnePoY, TwoPo.x, TwoPo.y, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePoX"></param>
        /// <param name="OnePoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePo"></param>
        public static void DrawArc3Po(Graphics g, Pen p, double OnePoX, double OnePoY, PointD TwoPo, PointD ThreePo)
        {
            DrawArc3Po(g, p, OnePoX, OnePoY, TwoPo, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        public static void DrawArc3Po(Graphics g, Pen p, PointD OnePo, double TwoPoX, double TwoPoY, double ThreePoX, double ThreePoY)
        {
            DrawArc3Po(g, p, OnePo.x, OnePo.y, TwoPoX, TwoPoY, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="ThreePo"></param>
        public static void DrawArc3Po(Graphics g, Pen p, PointD OnePo, double TwoPoX, double TwoPoY, PointD ThreePo)
        {
            DrawArc3Po(g, p, OnePo, TwoPoX, TwoPoY, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePoX"></param>
        /// <param name="ThreePoY"></param>
        public static void DrawArc3Po(Graphics g, Pen p, PointD OnePo, PointD TwoPo, double ThreePoX, double ThreePoY)
        {
            DrawArc3Po(g, p, OnePo, TwoPo.x, TwoPo.y, ThreePoX, ThreePoY);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="OnePo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="ThreePo"></param>
        public static void DrawArc3Po(Graphics g, Pen p, PointD OnePo, PointD TwoPo, PointD ThreePo)
        {
            DrawArc3Po(g, p, OnePo, TwoPo, ThreePo.x, ThreePo.y);
        }

        /// <summary>
        /// 画三点圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="Arc"></param>
        public static void DrawArc3Po(Graphics g, Pen p, ArcThreePoS Arc)
        {
            DrawArc3Po(g, p, Arc.StartPo, Arc.TwoPo, Arc.EndPo);
        }
        #endregion

        #region 画角度圆弧
        /// <summary>
        /// 画角度圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="CenterPo">圆心坐标CenterPo</param>
        /// <param name="Angle1">角度1</param>
        /// <param name="Angle2">角度2</param>
        /// <param name="R">半径</param>
        public static void 画角度圆弧(Graphics g, Pen p, PointD CenterPo, float Angle1, float Angle2, float R)
        {
            画角度圆弧(g, p, CenterPo.x, CenterPo.x, Angle1, Angle2, R);
        }

        /// <summary>
        /// 画角度圆弧
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="CenterPoX">圆心x坐标</param>
        /// <param name="CenterPoY">圆心y坐标</param>
        /// <param name="Angle1">角度1</param>
        /// <param name="Angle2">角度2</param>
        /// <param name="R">半径</param>
        public static void 画角度圆弧(Graphics g, Pen p, double CenterPoX, double CenterPoY, double Angle1, double Angle2, double R)
        {
            g.DrawArc(p, new RectangleF((float)(CenterPoX - R), (float)(CenterPoY - R), (float)(R * 2), (float)(R * 2)), (float)Angle1, (float)Angle2);
        }
        #endregion

        #region 绘制位图
        /// <summary>
        /// 绘制位图
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="img">位图</param>
        /// <param name="StartX">起始位置X坐标</param>
        /// <param name="StartY">起始位置Y坐标</param>
        /// <param name="W">位图宽度</param>
        /// <param name="Y">位图高度</param>
        public static void DrawImage(Graphics g,Image img ,double StartX,double StartY,double W,double H)
        {
            g.DrawImage(img, new Rectangle((int)StartX, (int)StartY, (int)W, (int)H));
        }

        /// <summary>
        /// 绘制位图
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="img">位图</param>
        /// <param name="StartPo">起始位置</param>
        /// <param name="W">位图宽度</param>
        /// <param name="Y">位图高度</param>
        public static void DrawImage(Graphics g, Image img, PointD StartPo, double W, double H)
        {
            g.DrawImage(img, new Rectangle((int)StartPo.x , (int)StartPo.y , (int)W, (int)H));
        }

        /// <summary>
        /// 绘制位图
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="img">位图</param>
        /// <param name="Re">位图矩形</param>
        public static void DrawImage(Graphics g, Image img, RectD Re)
        {
            g.DrawImage(img, new Rectangle((int)Re.x, (int)Re.y, (int)Re.w, (int)Re.h));
        }
        #endregion

        #region 绘制字符串
        /// <summary>
        /// 绘制字符串
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="Typeface">字体</param>
        /// <param name="emSize">文字大小</param>
        /// <param name="IsBold">是否加粗</param>
        /// <param name="Brush">画刷</param>
        /// <param name="str">要绘制的字符串</param>
        /// <param name="Po">坐标</param>
        public static void DrawString(Graphics g, string Typeface, float emSize, bool IsBold, SolidBrush Brush, string str, PointD Po)
        {
            g.DrawString(str, new System.Drawing.Font(Typeface, emSize, IsBold ? FontStyle.Bold : FontStyle.Regular), Brush, (float)Po.x, (float)Po.y);
        }

        /// <summary>
        /// 绘制字符串
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="Typeface">字体</param>
        /// <param name="emSize">文字大小</param>
        /// <param name="IsBold">是否加粗</param>
        /// <param name="Brush">画刷</param>
        /// <param name="str">要绘制的字符串</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public static void DrawString(Graphics g, string Typeface, float emSize, bool IsBold, SolidBrush Brush, string str, double x,double y)
        {
            g.DrawString(str, new System.Drawing.Font(Typeface, emSize, IsBold ? FontStyle.Bold : FontStyle.Regular), Brush, (float)x, (float)y);
        }

        /// <summary>
        /// 绘制字符串
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="font">字体</param>
        /// <param name="IsBold">是否加粗</param>
        /// <param name="Brush">画刷</param>
        /// <param name="str">要绘制的字符串</param>
        /// <param name="Po">坐标</param>
        public static void DrawString(Graphics g, System.Drawing.Font font, bool IsBold, SolidBrush Brush, string str, PointF Po)
        {
            g.DrawString(str, font, Brush, Po);
        }
        #endregion
    }

    /// <summary>
    /// 直线类
    /// </summary>
    public class LineS
    {
        /// <summary>
        /// 起始点
        /// </summary>
        public PointD StartPo = new PointD();

        /// <summary>
        /// 结束点
        /// </summary>
        public PointD EndPo = new PointD();

        /// <summary>
        /// 直线中点
        /// </summary>
        public PointD MidPo
        {
            get { return new PointD((this.StartPo.x + this.EndPo.x) / 2, (this.StartPo.y + this.EndPo.y) / 2); }
        }

        /// <summary>
        /// 直线角度
        /// </summary>
        public double Angle
        {
            get { return Algorithm.CalculateLineAngle(this); }
        }

        /// <summary>
        /// 直线长度
        /// </summary>
        public double Length
        {
            get { return Algorithm.CalculateLineLength(this); }
        }

        /// <summary>
        /// 构造函数1
        /// </summary>
        /// <param name="StartX"></param>
        /// <param name="StartY"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public LineS(double StartX, double StartY, double EndPoX, double EndPoY)
        {
            this.StartPo.x = StartX;
            this.StartPo.y = StartY;
            this.EndPo.x = EndPoX;
            this.EndPo.y = EndPoY;
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public LineS(PointD StartPo, double EndPoX, double EndPoY)
        {
            this.StartPo = StartPo;
            this.EndPo.x = EndPoX;
            this.EndPo.y = EndPoY;
        }

        /// <summary>
        /// 构造函数3
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="z"></param>
        /// <param name="EndPo"></param>
        public LineS(double StartPoX, double StartPoY, PointD EndPo)
        {
            this.StartPo.x = StartPoX;
            this.StartPo.y = StartPoY;
            this.EndPo = EndPo;
        }

        /// <summary>
        /// 构造函数4
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="EndPo"></param>
        public LineS(PointD StartPo, PointD EndPo)
        {
            this.StartPo = StartPo;
            this.EndPo = EndPo;
        }

        public new string ToString()
        {
            return "x1=" + this.StartPo.x.ToString("F3") + "  y1=" + this.StartPo.y.ToString("F3") + "  x2=" + this.EndPo.x.ToString("F3") + "  y2=" + this.EndPo.y.ToString("F3");
        }
    }

    /// <summary>
    /// 圆类
    /// </summary>
    public class CircleS
    {
        /// <summary>
        /// 圆心
        /// </summary>
        public PointD CenterPo = new PointD();

        /// <summary>
        /// 获取圆的所有象限点
        /// </summary>
        /// <returns></returns>
        public PointD[] GetQuadrantPo()
        {
            double x = this.CenterPo.x;
            double y = this.CenterPo.y;
            return new PointD[] { new PointD(x + this.R, y), new PointD(x - this.R, y), new PointD(x, y + this.R), new PointD(x, y - this.R) };
        }

        /// <summary>
        /// 半径
        /// </summary>
        public double R;

        /// <summary>
        /// 构造函数1
        /// </summary>
        /// <param name="Center"></param>
        /// <param name="R"></param>
        public CircleS(PointD CenterPo, double R)
        {
            this.CenterPo = CenterPo;
            this.R = R;
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="CenterPoX"></param>
        /// <param name="CenterPoY"></param>
        /// <param name="R"></param>
        public CircleS(double CenterPoX, double CenterPoY, double R)
        {
            this.CenterPo.x = CenterPoX;
            this.CenterPo.y = CenterPoY;
            this.R = R;
        }
    }

    /// <summary>
    /// 圆弧类
    /// </summary>
    public class ArcS
    {
        /// <summary>
        /// 圆心
        /// </summary>
        public PointD CenterPo = new PointD();

        /// <summary>
        /// 半径
        /// </summary>
        public double R;

        /// <summary>
        /// 起始角度
        /// </summary>
        public double StartAngle;

        /// <summary>
        /// 结束角度
        /// </summary>
        public double EndAngle;

        /// <summary>
        /// 构造函数1
        /// </summary>
        /// <param name="CenterPoX"></param>
        /// <param name="CenterPoY"></param>
        /// <param name="R"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        public ArcS(double CenterPoX, double CenterPoY, double R, double StartAngle, double EndAngle)
        {
            this.CenterPo.x = CenterPoX;
            this.CenterPo.y = CenterPoY;
            this.R = R;
            this.StartAngle = StartAngle;
            this.EndAngle = EndAngle;
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="Center"></param>
        /// <param name="R"></param>
        /// <param name="StartAngle"></param>
        /// <param name="EndAngle"></param>
        public ArcS(PointD CenterPo, double R, double StartAngle, double EndAngle)
        {
            this.CenterPo = CenterPo;
            this.R = R;
            this.StartAngle = StartAngle;
            this.EndAngle = EndAngle;
        }
    }

    /// <summary>
    /// 三点圆弧类
    /// </summary>
    public class ArcThreePoS
    {
        /// <summary>
        /// 第1点坐标
        /// </summary>
        public PointD StartPo = new PointD();

        /// <summary>
        /// 第2点坐标
        /// </summary>
        public PointD TwoPo = new PointD();

        /// <summary>
        /// 第3点坐标
        /// </summary>
        public PointD EndPo = new PointD();

        /// <summary>
        /// 构造函数1
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public ArcThreePoS(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            this.StartPo.x = StartPoX;
            this.StartPo.y = StartPoY;
            this.TwoPo.x = TwoPoX;
            this.TwoPo.y = TwoPoY;
            this.EndPo.x = EndPoX;
            this.EndPo.y = EndPoY;
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPo"></param>
        public ArcThreePoS(double StartPoX, double StartPoY, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            this.StartPo.x = StartPoX;
            this.StartPo.y = StartPoY;
            this.TwoPo.x = TwoPoX;
            this.TwoPo.y = TwoPoY;
            this.EndPo = EndPo;
        }

        /// <summary>
        /// 构造函数3
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public ArcThreePoS(double StartPoX, double StartPoY, PointD TwoPo, double EndPoX, double EndPoY)
        {
            this.StartPo.x = StartPoX;
            this.StartPo.y = StartPoY;
            this.TwoPo = TwoPo;
            this.EndPo.x = EndPoX;
            this.EndPo.y = EndPoY;
        }

        /// <summary>
        /// 构造函数4
        /// </summary>
        /// <param name="StartPoX"></param>
        /// <param name="StartPoY"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPo"></param>
        public ArcThreePoS(double StartPoX, double StartPoY, PointD TwoPo, PointD EndPo)
        {
            this.StartPo.x = StartPoX;
            this.StartPo.y = StartPoY;
            this.TwoPo = TwoPo;
            this.EndPo = EndPo;
        }

        /// <summary>
        /// 构造函数5
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public ArcThreePoS(PointD StartPo, double TwoPoX, double TwoPoY, double EndPoX, double EndPoY)
        {
            this.StartPo = StartPo;
            this.TwoPo.x = TwoPoX;
            this.TwoPo.y = TwoPoY;
            this.EndPo.x = EndPoX;
            this.EndPo.y = EndPoY;
        }

        /// <summary>
        /// 构造函数6
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPoX"></param>
        /// <param name="TwoPoY"></param>
        /// <param name="EndPo"></param>
        public ArcThreePoS(PointD StartPo, double TwoPoX, double TwoPoY, PointD EndPo)
        {
            this.StartPo = StartPo;
            this.TwoPo.x = TwoPoX;
            this.TwoPo.y = TwoPoY;
            this.EndPo = EndPo;
        }

        /// <summary>
        /// 构造函数7
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPoX"></param>
        /// <param name="EndPoY"></param>
        public ArcThreePoS(PointD StartPo, PointD TwoPo, double EndPoX, double EndPoY)
        {
            this.StartPo = StartPo;
            this.TwoPo = TwoPo;
            this.EndPo.x = EndPoX;
            this.EndPo.y = EndPoY;
        }

        /// <summary>
        /// 构造函数8
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="TwoPo"></param>
        /// <param name="EndPo"></param>
        public ArcThreePoS(PointD StartPo, PointD TwoPo, PointD EndPo)
        {
            this.StartPo = StartPo;
            this.TwoPo = TwoPo;
            this.EndPo = EndPo;
        }
    }

    /// <summary>
    /// 双精度坐标类
    /// </summary>
    public class PointD
    {
        /// <summary>
        /// x坐标
        /// </summary>
        public double x;

        /// <summary>
        /// y坐标
        /// </summary>
        public double y;

        /// <summary>
        /// 构造函数1
        /// </summary>
        public PointD()
        {
            this.x = 0;
            this.y = 0;
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public PointD(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(PointD a, PointD b)
        {
            if (!object.Equals(a, null) && !object.Equals(b, null))
            {
                double x = Math.Abs(a.x - b.x);
                double y = Math.Abs(a.y - b.y);
                return (x < 0.00000001 && y < 0.00000001);
            }
            else
                return object.Equals(a, null) == object.Equals(b, null);
        }

        public static bool operator !=(PointD a, PointD b)
        {
            if (object.Equals(a, null) || object.Equals(b, null))
                return object.Equals(a, null) != object.Equals(b, null);
            else
            {
                double x = Math.Abs(a.x - b.x);
                double y = Math.Abs(a.y - b.y);
                return (x > 0.00000001 || y > 0.00000001);
            }
        }

        /// <summary>
        /// 转字符串
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "x=" + this.x.ToString("F3") + "  y=" + this.y.ToString("F3");
        }
    }

    /// <summary>
    /// 双精度矩形类：具有起始坐标和中心坐标
    /// </summary>
    public class RectD
    {
        #region 变量声明
        /// <summary>
        /// 中心x坐标
        /// </summary>
        public double x = 0;

        /// <summary>
        /// 中心y坐标
        /// </summary>
        public double y = 0;

        /// <summary>
        /// 宽度
        /// </summary>
        public double w = 0;

        /// <summary>
        /// 高度
        /// </summary>
        public double h = 0;
        #endregion

        #region 属性
        /// <summary>
        /// 起始点坐标
        /// </summary>
        public PointD StartPo
        {
            get { return new PointD(this.x, this.y); }
        }

        /// <summary>
        /// 第二点坐标
        /// </summary>
        public PointD TwoPo
        {
            get { return new PointD(this.x + this.w, this.y); }
        }

        /// <summary>
        /// 第三点坐标
        /// </summary>
        public PointD ThreePo
        {
            get { return new PointD(this.x + this.w, this.y + h); }
        }

        /// <summary>
        /// 第三点坐标
        /// </summary>
        public PointD EndPo
        {
            get { return new PointD(this.x, this.y + h); }
        }

        /// <summary>
        /// 中心坐标
        /// </summary>
        public PointD CenterPo
        {
            get { return new PointD(this.x + this.w / 2, this.y + this.h / 2); }
        }
        #endregion

        public RectD() { }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public RectD(double x, double y, double w, double h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        /// <summary>
        /// 构造函数3
        /// </summary>
        /// <param name="StartPo"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public RectD(PointD StartPo, double w, double h)
        {
            this.x = StartPo.x;
            this.y = StartPo.y;
            this.w = w;
            this.h = h;
        }
    }

    /// <summary>
    /// 尺寸大小类
    /// </summary>
    public class SizeD
    {
        /// <summary>
        /// 宽
        /// </summary>
        public double w = 0;

        /// <summary>
        /// 高
        /// </summary>
        public double h = 0;

        /// <summary>
        /// 构造函数
        /// </summary>
        public SizeD()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public SizeD(double w, double h)
        {
            this.w = w;
            this.h = h;
        }

        /// <summary>
        /// 转字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.w.ToString("f3") + ", " + this.h.ToString("f3");
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <returns></returns>
        public PointD Copy()
        {
            return new PointD(this.w, this.h);
        }
    }

    /// <summary>
    /// 正多边形类
    /// </summary>
    public class PolygS: IrregularPolygS
    {
        #region 私有成员
        /// <summary>
        /// 半径1
        /// </summary>
        private double R1 = 0;

        /// <summary>
        /// 半径2
        /// </summary>
        private double R2 = 0;

        /// <summary>
        /// 角度
        /// </summary>
        private double angle = 0;

        /// <summary>
        /// 中心坐标
        /// </summary>
        private PointD centerPo = new PointD();
        #endregion

        #region 属性
        /// <summary>
        /// 多边形的顶点个数
        /// </summary>
        public int Count
        {
            get { return this.AllPo.Length; }
            set
            {
                if (this.AllPo.Length != value && value > 2)
                {
                    PointD centerPo = this.GetCenterPo();
                    this.Initializa(this.centerPo, this.R1, this.R2, this.AllPo.Length, this.angle);
                    this.CenterPo = centerPo;
                }
            }
        }

        /// <summary>
        /// 半径1
        /// </summary>
        public double r1
        {
            get { return this.R1; }
            set
            {
                if (this.R1 != value)
                {
                    this.R1 = value;
                    this.Initializa(this.centerPo, this.R1, this.R2, this.AllPo.Length, this.angle);
                }
            }
        }

        /// <summary>
        /// 半径2
        /// </summary>
        public double r2
        {
            get { return this.R2; }
            set
            {
                if (this.R2 != value)
                {
                    this.R2 = value;
                    this.Initializa(this.centerPo, this.R1, this.R2, this.AllPo.Length, this.angle);
                }
            }
        }

        /// <summary>
        /// 宽
        /// </summary>
        public double w
        {
            get { return this.GetSize().w; }
            set
            {
                double w = this.GetSize().w;
                if (w != value)
                {
                    double Scale = value / w;
                    for (int i = 0; i < this.AllPo.Length; i++)
                        this.AllPo[i].x = this.centerPo.x + (this.AllPo[i].x - this.centerPo.x) * Scale;
                    double r = this.angle;
                    if (r < 225 && r > 135)
                        this.R1 *= Scale;
                    else
                    {
                        if (r > 230)
                            r -= 360;
                        if (r < 45 && r > -45)
                            this.R1 *= Scale;
                        else
                            this.R2 *= Scale;
                    }
                }
            }
        }

        /// <summary>
        /// 高
        /// </summary>
        public double h
        {
            get { return this.GetSize().h; }
            set
            {
                double h = this.GetSize().h;
                if (h != value)
                {
                    double Scale = value / h;
                    for (int i = 0; i < this.AllPo.Length; i++)
                        this.AllPo[i].y = this.centerPo.y + (this.AllPo[i].y - this.centerPo.y) * Scale;
                    if (this.angle < 135 && this.angle > 45)
                        this.R1 *= Scale;
                    else
                    {
                        if (this.angle < 315 && this.angle > 225)
                            this.R1 *= Scale;
                        else
                            this.R2 *= Scale;
                    }
                }
            }
        }

        /// <summary>
        /// 角度
        /// </summary>
        public double Angle
        {
            get { return this.angle; }
            set
            {
                if (this.angle != value)
                {
                    double a = value - this.angle;
                    this.angle = value;
                    PointD centerPo = this.GetCenterPo();
                    for (int i = 0; i < this.AllPo.Length; i++)
                        this.AllPo[i] = Algorithm.CalculateRotatePo(this.centerPo, this.AllPo[i], a);
                    this.CenterPo = centerPo;
                }
            }
        }

        /// <summary>
        /// 中心
        /// </summary>
        public PointD CenterPo
        {
            get { return this.GetCenterPo(); }
            set
            {
                PointD centerPo = this.GetCenterPo();
                if (value.x != centerPo.x || value.y != centerPo.y)
                {
                    double x = value.x - centerPo.x;
                    double y = value.y - centerPo.y;
                    this.centerPo.x += x;
                    this.centerPo.y += y;
                    for (int i = 0; i < AllPo.Length; i++)
                    {
                        AllPo[i].x += x;
                        AllPo[i].y += y;
                    }
                }
            }
        }

        /// <summary>
        /// 圆心
        /// </summary>
        public PointD CirclePo
        {
            get { return this.centerPo; }
            set
            {
                if (value.x != this.centerPo.x || value.y != this.centerPo.y)
                {
                    double x = value.x - this.centerPo.x;
                    double y = value.y - this.centerPo.y;
                    for (int i = 0; i < AllPo.Length; i++)
                    {
                        AllPo[i].x += x;
                        AllPo[i].y += y;
                    }
                    this.centerPo = value;
                }
            }
        }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PolygS()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="x">中心坐标x</param>
        /// <param name="y">中心坐标y</param>
        /// <param name="r1">半径1</param>
        /// <param name="r2">半径2</param>
        /// <param name="Anage">角度</param>
        public PolygS(double x, double y, double r1, double r2, int Count, double Anage)
        {
            this.angle = Anage;
            this.Initializa(new PointD(x, y), r1, r2, Count, this.angle);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="CenterPo">中心坐标</param>
        /// <param name="r1">半径1</param>
        /// <param name="r2">半径2</param>
        /// <param name="Anage">角度</param>
        public PolygS(PointD CenterPo, double r1, double r2, int Count, double Anage)
        {
            this.angle = Anage;
            this.Initializa(CenterPo, r1, r2, Count, this.angle);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="x">中心坐标x</param>
        /// <param name="y">中心坐标y</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public PolygS(double x, double y, double w, double h)
        {
            this.Initializa(new PointD(x, y), w, h, 6);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="CenterPo">中心坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        public PolygS(PointD CenterPo, double w, double h)
        {
            this.Initializa(CenterPo, w, h, 6);
        }
        #endregion

        #region 功能函数
        /// <summary>
        /// 获取多边形的最小和最大点
        /// </summary>
        private PointD[] GetMinAndMax()
        {
            double MinX = this.AllPo[0].x;
            double MaxX = this.AllPo[0].x;
            double MinY = this.AllPo[0].y;
            double MaxY = this.AllPo[0].y;
            for (int i = 1; i < this.AllPo.Length; i++)
            {
                MinX = this.AllPo[i].x < MinX ? this.AllPo[i].x : MinX;
                MaxX = this.AllPo[i].x > MaxX ? this.AllPo[i].x : MaxX;
                MinY = this.AllPo[i].y < MinY ? this.AllPo[i].y : MinY;
                MaxY = this.AllPo[i].y > MaxY ? this.AllPo[i].y : MaxY;
            }
            return new PointD[] { new PointD(MinX, MinY), new PointD(MaxX, MaxY) };
        }

        /// <summary>
        /// 获取多边形的大小
        /// </summary>
        /// <returns></returns>
        private SizeD GetSize()
        {
            PointD[] PoS = this.GetMinAndMax();
            double ActualW = PoS[1].x - PoS[0].x;  //实际宽
            double ActualH = PoS[1].y - PoS[0].y;  //实际高
            return new SizeD(ActualW, ActualH);
        }

        /// <summary>
        /// 初使化
        /// </summary>
        /// <param name="CenterPo">中心坐标</param>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        /// <param name="Count">多边形的边数</param>
        private void Initializa(PointD CenterPo, double w, double h, int Count)
        {
            this.R1 = w / 2;
            this.R2 = h / 2;
            if (w > 0 && h > 0)
            {
                this.centerPo = CenterPo;
                double Scale = w / h;               //宽和高的比例
                double EquallyAngle = 360 / Count;  //平均角度
                for (int i = 0; i < Count; i++)
                {
                    this.AllPo[i] = Algorithm.获取圆上点(0, 0, i * EquallyAngle, h / 2);
                    if (w != h)
                        this.AllPo[i].x *= Scale;
                }
                SizeD si = this.GetSize();
                if (Math.Abs(w - si.w) > 0.00000001)
                {
                    Scale = w / si.w;
                    this.R1 *= Scale;
                    for (int i = 1; i < this.AllPo.Length; i++)
                        this.AllPo[i].x *= Scale;
                }
                if (Math.Abs(h - si.h) > 0.00000001)
                {
                    Scale = h / si.h;
                    this.R2 *= Scale;
                    for (int i = 1; i < this.AllPo.Length; i++)
                        this.AllPo[i].y *= Scale;
                }
                for (int i = 0; i < this.AllPo.Length; i++)
                {
                    this.AllPo[i].x += CenterPo.x;
                    this.AllPo[i].y += CenterPo.y;
                }
            }
        }

        /// <summary>
        /// 初使化
        /// </summary>
        /// <param name="CenterPo">中心坐标</param>
        /// <param name="r1">半径1</param>
        /// <param name="r2">半径2</param>
        /// <param name="Count">多边形的边数</param>
        /// <param name="Anage">角度</param>
        private void Initializa(PointD CenterPo, double r1, double r2, int Count, double Angle)
        {
            this.angle = Angle;
            this.R1 = r1;
            this.R2 = r2;
            this.centerPo = CenterPo;
            double EquallyAngle = 360 / Count;    //平均角度
            double Scale = r1 / r2;                    //宽和高的比例
            this.AllPo = new PointD[Count];
            for (int i = 0; i < Count; i++)
            {
                this.AllPo[i] = Algorithm.获取圆上点(0, 0, i * EquallyAngle, r2);
                if (r1 != r2)
                    this.AllPo[i].x *= Scale;
                this.AllPo[i].x += CenterPo.x;
                this.AllPo[i].y += CenterPo.y;
            }
            if (this.angle > 0)
                for (int i = 0; i < this.AllPo.Length; i++)
                    this.AllPo[i] = Algorithm.CalculateRotatePo(this.centerPo, this.AllPo[i], Angle);
        }

        /// <summary>
        /// 获取中心坐标
        /// </summary>
        /// <returns></returns>
        private PointD GetCenterPo()
        {
            PointD[] PoS = this.GetMinAndMax();
            return new PointD((PoS[0].x + PoS[1].x) / 2, (PoS[0].y + PoS[1].y) / 2);
        }
        #endregion
    }

    /// <summary>
    /// 不规则多边形类
    /// </summary>
    public class IrregularPolygS
    {
        /// <summary>
        /// 所有顶点
        /// </summary>
        public PointD[] AllPo = new PointD[6];

        /// <summary>
        /// 多边形的周长
        /// </summary>
        public double Len
        {
            get
            {
                double tLen = 0;
                for (int i = 0; i < this.AllPo.Length; i++)
                    tLen += Algorithm.CalculateTwoPoDistance(this.AllPo[i], this.AllPo[(i < this.AllPo.Length - 1) ? i + 1 : 0]);
                return tLen;
            }
        }
    }
}

/// <summary>
/// 数据操作类库
/// </summary>
namespace DataLib
{
    /// <summary>
    /// 信息数据基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InfoBase<T>
    {
        #region 变量声明
        /// <summary>
        /// 文件名
        /// </summary>
        protected string FileName = "";

        /// <summary>
        /// 初使路径
        /// </summary>
        protected string Path = "";

        /// <summary>
        /// 所有要操作的数据
        /// </summary>
        protected List<T> AllData = new List<T>();

        /// <summary>
        /// 所有列的宽度
        /// </summary>
        protected double[] AllColumnWidth;

        /// <summary>
        /// 所有列标题名称
        /// </summary>
        protected List<string> AllColumnName = new List<string>();
        #endregion

        #region 功能函数
        /// <summary>
        /// 创建列标题
        /// </summary>
        protected void ColumnName()
        {
            try
            {
                T t = Activator.CreateInstance<T>();
                Type Ty = t.GetType();
                System.Reflection.FieldInfo[] Fi = Ty.GetFields();
                if (this.AllColumnName.Count < (Fi.Length + 1))
                {
                    this.AllColumnName.Clear();
                    this.AllColumnName.Add("序号");
                    for (int i = 0; i < Fi.Length; i++)
                        this.AllColumnName.Add(Fi[i].Name);
                }
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 获取所有列的宽度
        /// </summary>
        protected void GetColumnWidth()
        {
            this.AllColumnWidth = new double[this.AllColumnName.Count];
            for (int i = 0; i < this.AllColumnName.Count; i++)
                this.AllColumnWidth[i] = this.GetTwoMax(this.AllColumnWidth[i], Encoding.Default.GetByteCount(this.AllColumnName[i]));

            for (int i = 0; i < this.AllData.Count; i++)
            {
                Type Ty = this.AllData[0].GetType();
                FieldInfo[] Fi = Ty.GetFields();

                for (int j = 0; j < Fi.Length; j++)
                {
                    string str = "";
                    if (Fi[j].FieldType.Name == "String")
                        str = (string)Fi[j].GetValue(this.AllData[i]);
                    if (Fi[j].FieldType.Name == "Int16")
                        str = Convert.ToInt16(Fi[j].GetValue(this.AllData[i])).ToString();
                    if (Fi[j].FieldType.Name == "Int32")
                        str = Convert.ToInt32(Fi[j].GetValue(this.AllData[i])).ToString();
                    if (Fi[j].FieldType.Name == "Double")
                        str = Convert.ToDouble(Fi[j].GetValue(this.AllData[i])).ToString("f3");
                    if (Fi[j].FieldType.Name == "Single")
                        str = Convert.ToSingle(Fi[j].GetValue(this.AllData[i])).ToString("f3");
                    if (Fi[j].FieldType.Name == "Boolean")
                        str = Convert.ToBoolean(Fi[j].GetValue(this.AllData[i])) ? "是" : "否";
                    this.AllColumnWidth[j + 1] = this.GetTwoMax(this.AllColumnWidth[j + 1], Encoding.Default.GetByteCount(str));
                }
            }
        }

        /// <summary>
        /// 获取两个数中最大的数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        protected double GetTwoMax(double a, double b)
        {
            return a > b ? a : b;
        }
        #endregion
    }

    /// <summary>
    /// Excel数据类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExcelDataS<T> : InfoBase<T>
    {
        #region 构造函数
        /// <summary>
        /// 构造函数1
        /// </summary>
        /// <param name="AllData"></param>
        /// <param name="FileName"></param>
        public ExcelDataS(List<T> AllData, string FileName)
        {
            this.AllData = AllData;
            this.FileName = FileName;
            this.ColumnName();   //创建列标题
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="AllData">所有数据</param>
        /// <param name="AllColumnName">所有列标是</param>
        /// <param name="FileName">保存文件名</param>
        /// <param name="frm"></param>
        public ExcelDataS(List<T> AllData, List<string> AllColumnName, string FileName)
        {
            this.AllData = AllData;
            this.AllColumnName = AllColumnName;
            this.FileName = FileName;
            this.ColumnName();   //创建列标题
        }
        #endregion

        #region 私有函数
        /// <summary>
        /// 设置列标题内容
        /// </summary>
        /// <param name="cell">单元格</param>
        /// <param name="str">内容</param>
        /// <param name="wk">表格对象</param>
        /// <param name="Size">单元格大小</param>
        /// <param name="IsCenter">是否居中</param>
        /// <param name="fontColor">字体颜色</param>
        /// <param name="BackColor">背景颜色</param>
        private void SetColumn(Cell cell, string str, HSSFWorkbook wk, int Size, bool IsCenter, short fontColor = 5000, short BackColor = 1000)
        {
            cell.SetCellValue(str);
            NPOI.SS.UserModel.Font font = wk.CreateFont();
            font.FontHeight = (short)(Size * Size);
            font.Boldweight = 10;//加粗
            font.Color = fontColor;
            HSSFCellStyle Style = (HSSFCellStyle)wk.CreateCellStyle();             //文字样式：大小，颜色，对齐方式
            if (IsCenter)
            {
                Style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;    //水平对齐
                Style.VerticalAlignment = VerticalAlignment.CENTER;                //垂直对齐
            }
            Style.SetFont(font);
            Style.FillBackgroundColor = BackColor;
            cell.CellStyle = Style;
        }

        /// <summary>
        /// 设置单元格内容
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="str"></param>
        private void SetCell(Cell cell, string str)
        {
            cell.SetCellValue(str);
        }

        /// <summary>
        /// 获取指定表的行数
        /// </summary>
        /// <returns></returns>
        private int GetRowCount(Sheet sheet)
        {
            int index = 0;
            int Count = 0;
            while (true)
            {
                Row firstRow = sheet.GetRow(index + 1);                                  //获取指定行数据  
                if (firstRow != null)
                {
                    index++;
                    Count++;                                                             //获取不为空行的行的数量
                }
                else
                    break;
            }
            return Count;
        }

        /// <summary>
        /// 获取单元格内容
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private string GetCellStr(Cell cell)
        {
            return cell == null ? "" : cell.ToString();
        }
        #endregion

        #region 公有函数
        /// <summary>
        /// 打开Excel文件
        /// </summary>
        public void Open()
        {
            this.AllData.Clear();
            try
            {
                if (File.Exists(this.FileName))//如果文件存在
                {
                    FileStream MyStream = new FileStream(this.FileName, FileMode.Open, FileAccess.Read);
                    HSSFWorkbook wk = new HSSFWorkbook(MyStream);
                    Sheet sheet = wk.GetSheetAt(0);//获取第一张表
                    if (sheet != null)
                    {
                        int Count = this.GetRowCount(sheet);
                        if (Count > 0)
                        {
                            for (int i = 0; i < Count; i++)
                            {
                                T t = Activator.CreateInstance<T>();
                                Type Ty = t.GetType();
                                System.Reflection.FieldInfo[] Fi = Ty.GetFields();
                                Row firstRow = sheet.GetRow(i + 1);
                                for (int j = 0; j < Fi.Length; j++)
                                {
                                    if (j == 16)
                                        ;
                                    if (Fi[j].FieldType.Name == "String")
                                        Fi[j].SetValue(t, this.GetCellStr(firstRow.GetCell(j + 1)));
                                    if (Fi[j].FieldType.Name == "Int16")
                                        Fi[j].SetValue(t, Convert.ToInt16(this.GetCellStr(firstRow.GetCell(j + 1))));
                                    if (Fi[j].FieldType.Name == "Int32")
                                        Fi[j].SetValue(t, Convert.ToInt32(this.GetCellStr(firstRow.GetCell(j + 1))));
                                    if (Fi[j].FieldType.Name == "Double")
                                        Fi[j].SetValue(t, Convert.ToDouble(this.GetCellStr(firstRow.GetCell(j + 1))));
                                    if (Fi[j].FieldType.Name == "Single")
                                        Fi[j].SetValue(t, Convert.ToSingle(this.GetCellStr(firstRow.GetCell(j + 1))));
                                    if (Fi[j].FieldType.Name == "Boolean")
                                        Fi[j].SetValue(t, this.GetCellStr(firstRow.GetCell(j + 1)) == "是" ? true : false);
                                }
                                this.AllData.Add(t);
                            }
                        }
                    }
                    MyStream.Close();
                }
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 保存数据到Excel中
        /// </summary>
        /// <param name="FileName"></param>
        public void Save(string FileName)
        {
            this.FileName = FileName;
            this.Save();
        }

        /// <summary>
        /// 更新数据：根据当前日期的变动删除以前的数据
        /// </summary>
        public void UpData()
        {
            string Path = this.GetPath(Application.StartupPath + "\\" + this.Path + "\\" + DateTime.Now.ToString("yyyy年MM月"));
            string FileName = Path + DateTime.Now.ToString("yyyy年MM月dd日") + ".xls";
            if (FileName != this.FileName)
            {
                this.FileName = FileName;
                this.AllData.Clear();
            }
        }

        /// <summary>
        /// 保存数据到Excel中
        /// </summary>
        public void Save()
        {
            if (this.AllData.Count > 0)
            {
                try
                {
                    HSSFWorkbook wk = new HSSFWorkbook();
                    Sheet sheet = wk.CreateSheet("Sheet1");                                                            //创建一个表
                    Row row = sheet.CreateRow(0);                                                                      //创建第一行

                    for (int i = 0; i < this.AllColumnName.Count; i++)
                        this.SetColumn(row.CreateCell(i), this.AllColumnName[i], wk, 15, true, 0, 0);                  //设置标题内容

                    for (int i = 0; i < this.AllData.Count; i++)
                    {
                        Type Ty = this.AllData[0].GetType();
                        System.Reflection.FieldInfo[] Fi = Ty.GetFields();
                        row = sheet.CreateRow(i + 1);                                                                  //创建下一行
                        this.SetCell(row.CreateCell(0), (i + 1).ToString());                                           //序号

                        for (int j = 0; j < Fi.Length; j++)
                        {
                            string str = "";
                            if (Fi[j].FieldType.Name == "String")
                                str = (string)Fi[j].GetValue(this.AllData[i]);
                            if (Fi[j].FieldType.Name == "Int16")
                                str = Convert.ToInt16(Fi[j].GetValue(this.AllData[i])).ToString();
                            if (Fi[j].FieldType.Name == "Int32")
                                str = Convert.ToInt32(Fi[j].GetValue(this.AllData[i])).ToString();
                            if (Fi[j].FieldType.Name == "Double")
                                str = Convert.ToDouble(Fi[j].GetValue(this.AllData[i])).ToString("F3");
                            if (Fi[j].FieldType.Name == "Single")
                                str = Convert.ToSingle(Fi[j].GetValue(this.AllData[i])).ToString("F3");
                            if (Fi[j].FieldType.Name == "Boolean")
                                str = Convert.ToBoolean(Fi[j].GetValue(this.AllData[i])) ? "是" : "否";
                            this.SetCell(row.CreateCell(j + 1), str);                                                  //设置单元格的值
                        }
                    }

                    this.GetColumnWidth();                                                                             //获取所有列的宽度
                    for (int i = 0; i < this.AllColumnWidth.Length; i++)
                        sheet.SetColumnWidth(i, 250 * (int)this.AllColumnWidth[i] + 600);                              //设定列宽

                    FileStream MyStream = new FileStream(this.FileName, FileMode.Create, FileAccess.Write);
                    wk.Write(MyStream);
                    MyStream.Close();
                }
                catch (Exception ex) { }
            }
        }

        /// <summary>
        /// 获取文件夹：如果不存在则创建
        /// </summary>
        /// <param name="Path">路径</param>
        /// <returns></returns>
        public string GetPath(string Path)
        {
            string[] AllPath = Path.Split('\\');
            Path = "";
            for (int i = 0; i < AllPath.Length; i++)
            {
                Path = Path + AllPath[i] + "\\";
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            return Path;
        }
        #endregion
    }

    /// <summary>
    /// 信息类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InfoS<T> : InfoBase<T>
    {
        #region 变量声明
        /// <summary>
        /// 最小日期列表框
        /// </summary>
        private DateTimePicker dtpMin = new DateTimePicker();

        /// <summary>
        /// 最大日期列表框
        /// </summary>
        private DateTimePicker dtpMax = new DateTimePicker();

        /// <summary>
        /// 工作视图列表框
        /// </summary>
        private ListView lvwWork = new ListView();

        /// <summary>
        /// 工作视图列表框的所有列
        /// </summary>
        private List<ColumnHeader> colAllHeader = new List<ColumnHeader>();
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数1
        /// </summary>
        /// <param name="AllData">要操作的数据列表</param>
        /// <param name="FileName">存储数据的文件名</param>
        public InfoS(List<T> AllData, string FileName)
        {
            this.AllData = AllData;
            this.FileName = FileName;
            this.ColumnName();   //创建列标题
        }

        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="AllData">要操作的数据列表</param>
        /// <param name="AllColumnName">所有列标题名称</param>
        /// <param name="FileName">存储数据的文件名</param>
        public InfoS(List<T> AllData, List<string> AllColumnName, string FileName)
        {
            this.AllData = AllData;
            this.AllColumnName = AllColumnName;
            this.FileName = FileName;
            this.ColumnName();   //创建列标题
        }
        #endregion

        #region 公有函数
        /// <summary>
        /// 打开文件
        /// </summary>
        public void Open()
        {
            this.AllData.Clear();
            try
            {
                if (File.Exists(this.FileName))//如果文件存在
                {

                    FileStream myStream = new FileStream(this.FileName, FileMode.Open, FileAccess.Read);//读取数据
                    BinaryReader myReader = new BinaryReader(myStream);
                    try
                    {
                        int Count = myReader.ReadInt32();
                        for (int i = 0; i < Count; i++)
                        {
                            T t = Activator.CreateInstance<T>();
                            Type Ty = t.GetType();
                            System.Reflection.FieldInfo[] Fi = Ty.GetFields();
                            for (int j = 0; j < Fi.Length; j++)
                            {
                                if (Fi[j].FieldType.Name == "String")
                                    Fi[j].SetValue(t, myReader.ReadString());
                                if (Fi[j].FieldType.Name == "Int16")
                                    Fi[j].SetValue(t, myReader.ReadInt16());
                                if (Fi[j].FieldType.Name == "Int32")
                                    Fi[j].SetValue(t, myReader.ReadInt32());
                                if (Fi[j].FieldType.Name == "Double")
                                    Fi[j].SetValue(t, myReader.ReadDouble());
                                if (Fi[j].FieldType.Name == "Single")
                                    Fi[j].SetValue(t, myReader.ReadSingle());
                                if (Fi[j].FieldType.Name == "Boolean")
                                    Fi[j].SetValue(t, myReader.ReadString() == "是" ? true : false);
                            }
                            this.AllData.Add(t);
                        }
                    }
                    catch (Exception ex) { }
                    myReader.Close();
                    myStream.Close();
                }
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="FileName"></param>
        public void Save(string FileName)
        {
            this.FileName = FileName;
            this.Save();
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        public void Save()
        {
            if (this.AllData.Count > 0)
            {
                Type Ty = this.AllData[0].GetType();
               FieldInfo[] Fi = Ty.GetFields();

                //string File = SundryS.GetContainFileNameForPath(this.FileName);
                FileStream myStream = new FileStream(this.FileName, FileMode.Create, FileAccess.Write);//写入文件
                BinaryWriter myWriter = new BinaryWriter(myStream);
                try
                {
                    myWriter.Write(this.AllData.Count);
                    for (int i = 0; i < this.AllData.Count; i++)
                    {
                        for (int j = 0; j < Fi.Length; j++)
                        {
                            if (Fi[j].FieldType.Name == "String")
                                myWriter.Write((string)Fi[j].GetValue(this.AllData[i]));
                            if (Fi[j].FieldType.Name == "Int16")
                                myWriter.Write(Convert.ToInt16(Fi[j].GetValue(this.AllData[i])));
                            if (Fi[j].FieldType.Name == "Int32")
                                myWriter.Write(Convert.ToInt32(Fi[j].GetValue(this.AllData[i])));
                            if (Fi[j].FieldType.Name == "Double")
                                myWriter.Write(Convert.ToDouble(Fi[j].GetValue(this.AllData[i])));
                            if (Fi[j].FieldType.Name == "Single")
                                myWriter.Write(Convert.ToSingle(Fi[j].GetValue(this.AllData[i])));
                            if (Fi[j].FieldType.Name == "Boolean")
                                myWriter.Write(Convert.ToBoolean(Fi[j].GetValue(this.AllData[i])) ? "是" : "否");
                        }
                    }
                }
                catch (Exception ex) { }
                myWriter.Flush();
                myWriter.Close();
                myStream.Close();
            }
        }

        /// <summary>
        /// 显示数据
        /// </summary>
        /// <param name=""></param>
        /// <param name="Title"></param>
        public void Show(string Title)
        {
            this.dtpMin.Font = new System.Drawing.Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.dtpMin.Location = new Point(15, 10);
            this.dtpMin.Size = new Size(180, 26);

            Label lblTo = new Label();
            lblTo.Font = new System.Drawing.Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            lblTo.Location = new Point(200, 10);
            lblTo.Size = new Size(20, 25);
            lblTo.Text = "至";
            lblTo.TextAlign = ContentAlignment.MiddleLeft;

            this.dtpMax.Font = new System.Drawing.Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.dtpMax.Location = new Point(225, 10);
            this.dtpMax.Size = new Size(180, 26);

            Button btnQuery = new Button();
            btnQuery.BackColor = Color.Gainsboro;
            btnQuery.Font = new System.Drawing.Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            btnQuery.Location = new Point(420, 10);
            btnQuery.Size = new Size(80, 25);
            btnQuery.Text = "查询";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += new EventHandler(this.btnQuery_Click);

            this.lvwWork.Font = new System.Drawing.Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.lvwWork.FullRowSelect = true;
            this.lvwWork.GridLines = true;
            this.lvwWork.HideSelection = false;
            this.lvwWork.Location = new Point(10, 45);
            this.lvwWork.MultiSelect = false;
            this.lvwWork.Size = new Size(560, 600);
            this.lvwWork.UseCompatibleStateImageBehavior = false;
            this.lvwWork.View = View.Details;

            this.colAllHeader.Clear();
            this.lvwWork.Columns.Clear();
            this.lvwWork.Columns.Add(new ColumnHeader());
            this.lvwWork.Columns[0].Width = 5;
            this.GetColumnWidth();               //获取所有列的宽度
            double W = 0;

            for (int i = 0; i < this.AllColumnName.Count; i++)
            {
                this.colAllHeader.Add(new ColumnHeader());
                this.colAllHeader[i].Text = this.AllColumnName[i];
                this.colAllHeader[i].Width = (int)(this.AllColumnWidth[i] * 6 + 20);
                this.lvwWork.Columns.Add(this.colAllHeader[i]);
                W = W + this.AllColumnWidth[i] * 6 + 20;
            }
            this.lvwWork.Width = (int)W + 40;
            this.lvwWork.Width = this.lvwWork.Width < 520 ? 520 : this.lvwWork.Width;
            int ScreenW = Screen.PrimaryScreen.WorkingArea.Width;
            if (this.lvwWork.Width > ScreenW - 40)
                this.lvwWork.Width = ScreenW - 40;

            Form frm = new Form();
            frm.Size = new Size(this.lvwWork.Width + 40, 700);
            frm.Text = Title;
            frm.MaximizeBox = false;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Controls.Add(this.dtpMin);
            frm.Controls.Add(lblTo);
            frm.Controls.Add(this.dtpMax);
            frm.Controls.Add(btnQuery);
            frm.Controls.Add(this.lvwWork);
            frm.ShowDialog();
        }
        #endregion

        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            int tYear1 = this.dtpMin.Value.Year;
            int tMonth1 = this.dtpMin.Value.Month;
            int tDay1 = this.dtpMin.Value.Day;
            int tDate1 = tYear1 * 10000 + tMonth1 * 100 + tDay1;

            int tYear2 = this.dtpMax.Value.Year;
            int tMonth2 = this.dtpMax.Value.Month;
            int tDay2 = this.dtpMax.Value.Day;
            int tDate2 = tYear2 * 10000 + tMonth2 * 100 + tDay2;

            List<T> tAllData = new List<T>();
            for (int i = 0; i < this.AllData.Count; i++)
            {
                Type Ty = this.AllData[i].GetType();
                FieldInfo[] Fi = Ty.GetFields();
                for (int j = 0; j < Fi.Length; j++)
                {
                    if (Fi[j].FieldType.Name == "String")
                    {
                        string str = (string)Fi[j].GetValue(this.AllData[i]);
                        if (str.Length > 10)
                        {
                            if (str.Substring(4, 1) == "-" && str.Substring(7, 1) == "-")
                            {
                                try
                                {
                                    int tDate = Convert.ToInt32(str.Substring(0, 10).Replace("-", ""));
                                    if (tDate >= tDate1 && tDate <= tDate2)
                                        tAllData.Add(this.AllData[i]);
                                }
                                catch (Exception ex) { }
                            }
                        }
                    }
                }
            }

            this.lvwWork.Items.Clear();
            for (int i = 0; i < tAllData.Count; i++)
            {
                Type Ty = tAllData[i].GetType();
                FieldInfo[] Fi = Ty.GetFields();
                ListViewItem it = new ListViewItem();
                it.SubItems.Add((i + 1).ToString());                 //序号 
                for (int j = 0; j < Fi.Length; j++)
                {
                    string str = "";
                    if (Fi[j].FieldType.Name == "String")
                        str = (string)Fi[j].GetValue(tAllData[i]);
                    if (Fi[j].FieldType.Name == "Int16")
                        str = Convert.ToInt16(Fi[j].GetValue(tAllData[i])).ToString();
                    if (Fi[j].FieldType.Name == "Int32")
                        str = Convert.ToInt32(Fi[j].GetValue(tAllData[i])).ToString();
                    if (Fi[j].FieldType.Name == "Double")
                        str = Convert.ToDouble(Fi[j].GetValue(tAllData[i])).ToString("F3");
                    if (Fi[j].FieldType.Name == "Single")
                        str = Convert.ToSingle(Fi[j].GetValue(tAllData[i])).ToString("F3");
                    if (Fi[j].FieldType.Name == "Boolean")
                        str = Convert.ToBoolean(Fi[j].GetValue(tAllData[i])) ? "是" : "否";
                    it.SubItems.Add(str);
                }
                this.lvwWork.Items.Add(it);
            }
        }
    }
}
