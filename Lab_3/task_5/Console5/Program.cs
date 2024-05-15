using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Console5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number (task_5 - '1', task_6 - '2':");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            switch (n)
            {
                case 1:
                    task_5();
                    break;
                case 2:

                    await task_6();
                    break;
                default:
                    Console.WriteLine("Invalid number. Please enter 1 or 2.");
                    break;
            }
        }

        static void task_5()
        {
            var children = new List<LightNode>
            {
                new LightTextNode("Hello, "),
                new LightElementNode("b", "inline", "closing", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("world")
                }),
                new LightTextNode("!")
            };

            var element = new LightElementNode("p", "block", "closing", new List<string> { "paragraph" }, children);

            Console.WriteLine("OuterHTML:");
            Console.WriteLine(element.OuterHTML);
            Console.WriteLine("\nInnerHTML:");
            Console.WriteLine(element.InnerHTML);
        }

        static async Task task_6()
        {
            try
            {
                string bookUrl = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
                string bookText = await DownloadBook(bookUrl);

                string[] lines = bookText.Split('\n');

                List<LightNode> nodes = new List<LightNode>();
                bool brAdded = false;

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();
                    string lineHtml = string.Empty;

                    if (string.IsNullOrEmpty(trimmedLine))
                    {
                        if (!brAdded)
                        {
                            nodes.Add(new LightElementNode("br", "", "self-closing", new List<string>(), new List<LightNode>()));
                            brAdded = true;
                        }
                    }
                    else if (trimmedLine.Length < 20)
                    {
                        lineHtml = $"<h2>{trimmedLine}</h2>";
                    }
                    else if (trimmedLine.StartsWith(' '))
                    {
                        lineHtml = $"<blockquote>{trimmedLine}</blockquote>";
                    }
                    else
                    {
                        lineHtml = $"<p>{trimmedLine}</p>";
                    }

                    if (!string.IsNullOrEmpty(lineHtml))
                    {
                        nodes.Add(new LightTextNode(lineHtml));
                    }

                }

                foreach (var node in nodes)
                {
                    Console.WriteLine(node.OuterHTML);
                }

                long totalMemory = 0;
                foreach (var node in nodes)
                {
                    totalMemory += ObjectSize(node);
                }

                Console.WriteLine($"Amount of memory: {totalMemory} bytes");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        static async Task<string> DownloadBook(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception($"Failed to download book. Status code: {response.StatusCode}");
                }
            }
        }
        public static long ObjectSize(object obj)
        {
            if (obj is LightNode lightNode)
            {               
                if (lightNode is LightTextNode textNode)
                {
                    return textNode.Text?.Length * sizeof(char) ?? 0;
                }
                else if (lightNode is LightElementNode elementNode)
                {
                    long size = 0;

                    size += sizeof(int) * 2; 
                    size += elementNode.TagName?.Length * sizeof(char) ?? 0; 


                    if (elementNode.ClassList != null)
                    {
                        foreach (string className in elementNode.ClassList)
                        {
                            size += className?.Length * sizeof(char) ?? 0;
                        }
                    }

                    if (elementNode.Attributes != null)
                    {
                        foreach (string attributeName in elementNode.Attributes)
                        {
                            size += attributeName?.Length * sizeof(char) ?? 0;
                        }
                    }

                    if (elementNode.ChildNodes != null)
                    {
                        foreach (LightNode childNode in elementNode.ChildNodes)
                        {
                            size += ObjectSize(childNode);
                        }
                    }

                    return size;
                }
            }
            return 0;
        }
    }
}
