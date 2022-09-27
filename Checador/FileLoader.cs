using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Checador
{
    public class dataRow : List<String>
    {
        public string LineText { get; set; }
    }

    public class FileLoader : StreamReader
    {
        public FileLoader(Stream stream) : base(stream)
        {

        }

        public FileLoader(string filename) : base(filename)
        {

        }

        public bool ReadRow(dataRow row)
        {
            row.LineText = ReadLine();
            if (string.IsNullOrEmpty(row.LineText))
                return false;

            int pos = 0;
            int rows = 0;

            while (pos < row.LineText.Length)
            {
                string value = "";

                if (row.LineText[pos] == '"')
                {
                    pos++;
                    int start = pos;
                    while (pos < row.LineText.Length)
                    {
                        if (row.LineText[pos] == '"')
                        {
                            pos++;

                            if (pos >= row.LineText.Length || row.LineText[pos] != '"')
                            {
                                pos--;
                                break;
                            }
                        }
                        pos++;
                    }
                    value = row.LineText.Substring(start, pos - start);
                    value = value.Replace("\"\"", "\"");   
                }
                else
                {
                    int start = pos;
                    while (pos < row.LineText.Length && row.LineText[pos] != ',')
                        pos++;
                    value = row.LineText.Substring(start, pos - start);
                }

                value = Encoding.UTF8.GetString(Encoding.Default.GetBytes(value));
                
                if (rows < row.Count)
                    row[rows] = value;
                else
                    row.Add(value);
                rows++;

                while (pos < row.LineText.Length && row.LineText[pos] != ',')
                    pos++;
                if (pos < row.LineText.Length)
                    pos++;
            }
                while (row.Count > rows)
                    row.RemoveAt(rows);

            return (row.Count > 0);
        }
    }
}