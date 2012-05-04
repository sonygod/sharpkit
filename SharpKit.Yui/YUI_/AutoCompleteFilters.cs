//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// Provides pre-built result matching filters for AutoComplete.
    /// </summary>
    public partial class AutoCompleteFilters
    {
        /// <summary>
        /// Returns an array of results that contain all of the characters in the query,
        /// in any order (not necessarily consecutive). Case-insensitive.
        /// </summary>
        public YUI_.Array charMatch(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Case-sensitive version of `charMatch()`.
        /// </summary>
        public YUI_.Array charMatchCase(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Accent folding version of `charMatch()`.
        /// </summary>
        public YUI_.Array charMatchFold(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Returns an array of results that contain the complete query as a phrase.
        /// Case-insensitive.
        /// </summary>
        public YUI_.Array phraseMatch(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Case-sensitive version of `phraseMatch()`.
        /// </summary>
        public YUI_.Array phraseMatchCase(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Accent folding version of `phraseMatch()`.
        /// </summary>
        public YUI_.Array phraseMatchFold(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Returns an array of results that start with the complete query as a phrase.
        /// Case-insensitive.
        /// </summary>
        public YUI_.Array startsWith(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Case-sensitive version of `startsWith()`.
        /// </summary>
        public YUI_.Array startsWithCase(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Accent folding version of `startsWith()`.
        /// </summary>
        public YUI_.Array startsWithFold(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Returns an array of results in which all the words of the query match either
        /// whole words or parts of words in the result. Non-word characters like
        /// whitespace and certain punctuation are ignored. Case-insensitive.
        /// This is basically a combination of `wordMatch()` (by ignoring whitespace and
        /// word order) and `phraseMatch()` (by allowing partial matching instead of
        /// requiring the entire word to match).
        /// Example use case: Trying to find personal names independently of name order
        /// (Western or Eastern order) and supporting immediate feedback by allowing
        /// partial occurences. So queries like "J. Doe", "Doe, John", and "J. D." would
        /// all match "John Doe".
        /// </summary>
        public YUI_.Array subWordMatch(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Case-sensitive version of `subWordMatch()`.
        /// </summary>
        public YUI_.Array subWordMatchCase(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Accent folding version of `subWordMatch()`.
        /// </summary>
        public YUI_.Array subWordMatchFold(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Returns an array of results that contain all of the words in the query, in
        /// any order. Non-word characters like whitespace and certain punctuation are
        /// ignored. Case-insensitive.
        /// </summary>
        public YUI_.Array wordMatch(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Case-sensitive version of `wordMatch()`.
        /// </summary>
        public YUI_.Array wordMatchCase(object query, YUI_.Array results){return null;}
        /// <summary>
        /// Accent folding version of `wordMatch()`.
        /// </summary>
        public YUI_.Array wordMatchFold(object query, YUI_.Array results){return null;}
    }
}
