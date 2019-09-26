using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace QuickMonery.Common
{
    public class IniFile
    {
        public string path;     //INI文件名
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary>
        /// 添加section
        /// </summary>
        /// <param name="section">section name</param>
        /// <param name="keys">键值对,多个用\0分隔，如key1=value1\0key2=value2</param>
        /// <param name="filePath">ini文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32",CharSet=CharSet.Auto )]
        private static extern bool WritePrivateProfileSection(string lpAppName, string lpString, string lpFileName);

        //声明读写INI文件的API函数     
        public IniFile(string INIPath)
        {
            path = INIPath;
        }

        //类的构造函数，传递INI文件名
        public  void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        //读INI文件         
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(256);
            int i = GetPrivateProfileString(Section, Key, "", temp, 256, this.path);
            return temp.ToString();
        }
        /// <summary>
        /// 添加ini配置项到某个节点，如果节点不存在则创建
        /// </summary>
        /// <param name="sectionName">节点名称</param>
        /// <param name="keys">多个用\0分隔，如key1=value1\0key2=value2</param>
        /// <param name="filePath">ini文件全路径名</param>
        public void  IniCreateSection(string sectionName,string items ,string filePath)
        {
            try
            {
                bool b = WritePrivateProfileSection(sectionName, items, filePath);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
