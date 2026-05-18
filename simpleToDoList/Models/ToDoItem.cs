using Avalonia.Metadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace simpleToDoList.Models
{
    public class ToDoItem
    {
        public bool IsChecked { get; set; }

        public string? Content { get; set; }
    }
}
