using System;
using System.Collections.Generic;
using System.Text;

namespace TelerikControls.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        ListViewTemplateCell
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
