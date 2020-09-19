using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DOPScript.config
{
   public static class ScriptAttributes
    {
        // Regex patterns
        public static readonly Regex COMMENT_PATTERN = new Regex(@"^\/\/");
        public static readonly Regex LINE_PATTERN = new Regex(@"^>\s");  
        public static readonly Regex TOPIC_PATTERN = new Regex(@"^\[topico\]\s");
        public static readonly Regex STOP_PATTERN = new Regex(@"^\[parar]");
        public static readonly Regex IDENTIFICATION_PATTERN = new Regex(@"^\[script]\s");
        public static readonly Regex PAUSE_PATTERN = new Regex(@"^\[pause\]"); // ?

        // Speed patterns
        public static readonly int SIX_SECONDS = 6;
        public static readonly int SEVEN_SECONDS = 7;
        public static readonly int EIGHT_SECONDS = 8;
    }
}
