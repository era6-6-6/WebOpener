using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebOpener.Manager
{
    class WriteReadManager
    {
        private readonly string PATH = $@"{Environment.CurrentDirectory}/smallDB/info.txt";
        
        public static int Count { get; set; }
        public void Read(string page)
        {
            if (!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            string text = "";
            using(StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();

            }
            Match match = Regex.Match(text, $"!{page} , (.*)!");
            if (match.Success)
            {
                Count = int.Parse(match.Groups[1].ToString());
            }
            else
            {
                throw new Exception("nothing found");
            }
            
        }
        public void Write(string page)
        {
            if (!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            string text = "";
            using (StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            Match match = Regex.Match(text, $"!{page} , (.*)!");
            if (match.Success)
            {
                string newline = $"!{page} , {int.Parse(match.Groups[1].ToString()) + 1}";

                using (StreamWriter write = File.CreateText(PATH))
                {
                    write.Write(text.Replace($"!{page} , {match.Groups[1]}", newline));
                }
            }
            else
            {
                using (StreamWriter write = File.CreateText(PATH))
                {
                    write.Write(text);
                    write.WriteLine($"!{page} , 1!");
                }
            }
        }


    }
}
