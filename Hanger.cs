using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Hanger
{
    // 键盘Hook管理类,

    public class HangerS
    {
        /// <summary>
        /// 键盘
        /// </summary>
        private const int WH_KEYBOARD_LL = 13; 

        /// <summary>
        /// 键盘处理事件委托 ,当捕获键盘输入时调用定义该委托的方法.
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private delegate int HookHandle(int nCode, int wParam, IntPtr lParam);

        /// <summary>
        /// 客户端键盘处理事件
        /// </summary>
        /// <param name="param"></param>
        /// <param name="handle"></param>
        public delegate void ProcessKeyHandle(HookStruct param, out bool handle);

        /// <summary>
        /// 接收SetWindowsHookEx返回值
        /// </summary>
        private static int _hHookValue = 0;

        /// <summary>
        /// 勾子程序处理事件
        /// </summary>
        private HookHandle _KeyBoardHookProcedure;

        /// <summary>
        /// Hook结构
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public class HookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        /// <summary>
        /// 设置钩子
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="lpfn"></param>
        /// <param name="hInstance"></param>
        /// <param name="threadId"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int SetWindowsHookEx(int idHook, HookHandle lpfn, IntPtr hInstance, int threadId);

        /// <summary>
        /// 取消钩子
        /// </summary>
        /// <param name="idHook"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnhookWindowsHookEx(int idHook);

        /// <summary>
        /// 调用下一个钩子
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        /// <summary>
        /// 获取当前线程ID
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetCurrentThreadId();

        /// <summary>
        /// 获取关联进程的主模块
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string name);

        private IntPtr _hookWindowPtr = IntPtr.Zero;

        /// <summary>
        /// 外部调用的键盘处理事件
        /// </summary>
        private static ProcessKeyHandle _clientMethod = null;

        /// <summary>
        /// 安装勾子
        /// </summary>
        /// <param name="hookProcess">外部调用的键盘处理事件</param>
        public void InstallHook(ProcessKeyHandle clientMethod)
        {
            _clientMethod = clientMethod;
            if (_hHookValue == 0)     // 安装键盘钩子
            {
                _KeyBoardHookProcedure = new HookHandle(OnHookProc);
                _hookWindowPtr = GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);  //获取关联进程的主模块
                _hHookValue = SetWindowsHookEx(WH_KEYBOARD_LL, _KeyBoardHookProcedure, _hookWindowPtr, 0);
                if (_hHookValue == 0)   //如果设置钩子失败.
                    this.UninstallHook();
            }
        }

        /// <summary>
        /// 取消钩子
        /// </summary>
        public void UninstallHook()
        {
            if (_hHookValue != 0)
            {
                bool ret = UnhookWindowsHookEx(_hHookValue);
                if (ret)
                    _hHookValue = 0;
            }
        }

        /// <summary>
        /// 钩子事件内部调用,调用_clientMethod方法转发到客户端应用。
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private static int OnHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                HookStruct hookStruct = (HookStruct)Marshal.PtrToStructure(lParam, typeof(HookStruct));    //转换结构
                if (_clientMethod != null)
                {
                    bool handle = false;
                    _clientMethod(hookStruct, out handle);    //调用客户提供的事件处理程序。
                    if (handle)
                        return 1; //1:表示拦截键盘,return 退出
                }
            }
            return CallNextHookEx(_hHookValue, nCode, wParam, lParam);
        }
    }
}