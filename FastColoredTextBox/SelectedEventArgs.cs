﻿using System;

namespace FastColoredTextBoxNS
{
    public class SelectedEventArgs : EventArgs
    {
        public AutocompleteItem Item { get; internal set; }
        public FastColoredTextBox TextBox { get; set; }
    }
}
