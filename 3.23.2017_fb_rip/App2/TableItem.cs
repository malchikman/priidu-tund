using System.Collections.Generic;

namespace fb_rip {
    internal class TableItem {
        public int img { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public bool iscommenting { get; set; }
        public List<string> comments = new List<string>();
    }
}