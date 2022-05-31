using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using Terminal.Component.Pages;

namespace Terminal.Common
{
    class ClassHelper
    {
        public delegate void RouteEvent(ClassHelper.PageType pageName);
        public delegate void MessageEvent(int messageType, string message);
        public delegate void DataPassing(ClassHelper.DataPassingType dataType, object data);


        #region （属性）变量
        // 用户ID
        //public static string UserID { get; set; }
        public static string UserID = "0";

        // 选中的聊天好友ID
        public static string ChatFriendID { get; set; }

        #endregion

        #region 枚举类型
        // Page类型
        public enum PageType
        {
            AutoTest,
            ManualTest,
            AddressBook,
            DataCollect,
            EnergyAssess,
        }

        // 类数据传递类型
        public enum DataPassingType
        {
            SelectMessage,
            SelectFriend,
            ScreenCapture,
            Paste,
            MessageFocus,
            SelectCall
        }

        // 文件类型
        public enum FileType
        {
            Image,
            Word,
            Excel,
            PPT,
        }

        // 富文本内容类别
        public enum RichMessageType
        {
            Text,
            Image
        }
        #endregion

        #region 事件
        // 改变路由
        public static event RouteEvent RoutedChanged;

        // 消息提醒
        public static event MessageEvent MessageHint;

        // 类直接数据传递
        public static event DataPassing DataPassingChanged;

        #endregion

        #region 页面
        // 自动测试
        public static readonly AutoTest autoTest = new AutoTest();
        // 手动测试
        public static readonly ManualTest manualTest = new ManualTest();
        //通讯录
        public static readonly AddressBook addressBook = new AddressBook();
        //数据采集
        public static readonly DataCollect dataCollect = new DataCollect();
        //效能评估
        public static readonly EnergyAssess energyAssess = new EnergyAssess();
        //语音通话
        public static readonly VoiceTalk voiceTalk = new VoiceTalk();  
        //视频通话
        public static readonly VideoTalk videoTalk = new VideoTalk();  
        #endregion
       

        //————————方法————————

        /// <summary>
        /// 切换路由
        /// </summary>
        /// <param name="routeName">页面名称</param>
        public static void SwitchRoute(PageType pageName)
        {
            RoutedChanged.Invoke(pageName);
        }




        /// <summary>
        /// 窗体消息通知
        /// </summary>
        /// <param name="window">显示窗体</param>
        /// <param name="messageType">0 成功 1 警告 2 默认 3 错误</param>
        /// <param name="message">提示信息</param>
        public static void MessageAlert(Type window, int messageType, string message)
        {
            if (window != null)
            {
                foreach (Delegate item in (MessageHint.GetInvocationList()).Where(item => item.Target.GetType() == window))
                {
                    item.DynamicInvoke(messageType, message);
                }
            }
            else
            {
                MessageHint.Invoke(messageType, message);
            }
        }


        /// <summary>
        /// 查找资源
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        public static T FindResource<T>(string key)
        {
            return (T)Application.Current.Resources[key]; //根据名称返回资源字典对象
        }


        /// <summary>
        /// 类数据传递
        /// </summary>
        /// <param name="type">类</param>
        /// <param name="dataType">数据类型</param>
        /// <param name="data">数据</param>
        /// GetInvocationList(),在多播情况，假如某些函数有返回值，用来获取返回值
        ///list.where(a => a.arg == xx)  集合过滤数据

        public static void TransferringData(Type type, DataPassingType dataType, object data)
        {
            foreach (Delegate item in (DataPassingChanged?.GetInvocationList()).Where(item => item.Target.GetType() == type))
            {
                item.DynamicInvoke(dataType, data);//ClassHelper_DataPassingChanged(DataPassingType, System.Object)
            }
        }
    }
}
