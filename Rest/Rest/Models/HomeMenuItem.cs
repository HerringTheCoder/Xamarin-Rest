﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Models
{
    public enum MenuItemType
    {
        Browse,
        Login,
        Profile,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
