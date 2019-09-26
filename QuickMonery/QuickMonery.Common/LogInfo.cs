using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickMonery.Common
{
    public class LogInfo
    {
        /// <summary>
        /// 把异常信息写入到本地Log文件中
        /// </summary>
        /// <param name="action"></param>
        /// <param name="description"></param>
        public static void WriteLog(string action, string description)
        {
            object lockObject = new object();
            lock (lockObject)
            {

                try
                {
                    string logPath = "";
                    if (string.IsNullOrEmpty(logPath))
                    {
                        logPath = Application.StartupPath + "\\Log";
                    }
                    if (!File.Exists(logPath))
                    {
                        Directory.CreateDirectory(logPath);
                    }
                    string filePath = logPath + "\\log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                    if (File.Exists(filePath))
                    {
                        FileInfo fi = new FileInfo(filePath);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;

                    }
                    FileStream fs = new FileStream(filePath, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " | " + action + " | " + description);
                    sw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {

                }
                
            }
        }

    }
}
