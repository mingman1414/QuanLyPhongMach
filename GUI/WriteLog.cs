using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class WriteLog
    {
        public void FormWrite(string content)
        {
            using (StreamWriter sw = File.AppendText("Form.log"))
            {
                sw.WriteLine($"{DateTime.Now.ToString("dd MM yyyy HH:mm:ss: ")} {content}");
            }
            //ctrl + K + c hoặc là ctrl + shift + /
            //using giup tu dong close file
        }
        public void ButtonWrite(string content)
        {
            using (StreamWriter sw = File.AppendText("Button.log"))
            {
                sw.WriteLine($"{DateTime.Now.ToString("dd MM yyyy HH:mm:ss: ")}{content} ");
            }
            //ctrl + K + c hoặc là ctrl + shift + /
            //using giup tu dong close file
        }
    }
}
