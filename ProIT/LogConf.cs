using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using log4net.Core;
using Microsoft.Extensions.Logging;

namespace ProIT
{
    public class LogConf
    {
        
        private string Message;
        private string Type;
        private string TimeStamp;
        private string MachineName;
        private string UserName;
        private string Level;
        private string Category; 
        private int Priority;
        private int EventId; 
        private string Title; 
        private int ProcessId; 
        private string ProcessName; 
        private string AppDomainName; 
        private string ManagedThreadName; 
        private int Win32ThreadId;
        private string filename;
       
        private static readonly ILog log 
            = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly Dictionary<string, string> ExtendedProperties 
            = new Dictionary<string, string>();

        public LogConf()
        {
            XmlConfigurator.Configure(new FileInfo(filename));
            ILog log = LogManager.GetLogger(typeof(Program));
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(filename));
        }

        public void addFilename(string name)
        {
            this.filename = name;
        }

        public void init(object sender, EventArgs e)
        {
            ExtendedProperties.Add("key", "value");
            Form form = sender as Form;
            if (form != null)
            {
                string formName = form.Text;
                log4net.GlobalContext.Properties["FormName"] = formName;
            }
        }

        public void entry(string message)
        {
            Info(message);
        }

        public void Debug(string message)
        {
            var Entry = $"{message}, {ExtendedProperties}";
            log.Debug(Entry);
        }

        public void Info(string message)
        {
        
            var Entry  = $"{message}, {ExtendedProperties}";
            log.Info(Entry);
        }

        public void Warn(string message)
        {
        
            var Entry  = $"{message}, {ExtendedProperties}";
            log.Warn(Entry);
        }

        public void Error(string message)
        {
        
            var Entry = $"{message}, {ExtendedProperties}";
            log.Error(Entry);
        }

        public void Fatal(string message)
        {
        
            var Entry = $"{message}, {ExtendedProperties}";
            log.Fatal(Entry);
        }
    }
}