using System;
using System.Collections.Generic;

namespace TelerikControls
{
    public class SourceItem
    {
        public SourceItem(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

    }

    public class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<SourceItem> { new SourceItem("Tom"), new
        SourceItem("Anna"), new SourceItem("Peter"), new SourceItem("Teodor"), new
        SourceItem("Lorenzo"), new SourceItem("Andrea"), new SourceItem("Martin") };
        }
        public List<SourceItem> Source { get; set; }
    }
}
