using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CrawlerWinform
{
    class Crawlerw
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public List<string> lowUrls;
        string startUrl;
        
        public Crawlerw (string starturl)
        {
            startUrl = starturl;
            urls.Add(startUrl, false);
        }

        public void Crawl()
        {
            lowUrls = new List<string>();
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                // 下载
                string html = DownLoad(current);
                urls[current] = true;
                count++;
                //解析,并加入新的链接
                Parse(html, current);

            }
            Console.WriteLine("爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');

                if (strRef[0] == '/')
                {
                    strRef = current.Substring(0, current.LastIndexOf('/')) + strRef.Substring(1);
                }
                if (strRef.Length == 0 || strRef.Substring(strRef.LastIndexOf(".") + 1) != "html")
                {
                    lowUrls.Add(strRef);
                    continue;
                }
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}

   

