using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOPScript
{
    public static class Script
    {
        public static List<ScriptTopic> scriptTopics = new List<ScriptTopic>();

        public static int LINE_COUNT = 0;
        public static int TOPIC_COUNT = 0;
        public static int CURRENT_LINE = 0;
        public static bool SHOULD_SEND_TITLE_PHRASE = true;

        public static void createTopic(ScriptTopic scriptTopicInCreation)
        {
            if (scriptTopicInCreation != null)
            {
                scriptTopics.Add(scriptTopicInCreation);
            } else
            {
                throw new Exception("Cannot create a new undefined topic. Please create a new ScriptTopic instance and set the proper fields.");
            }
        }

        public static void Reset()
        {
            scriptTopics.Clear();
            TOPIC_COUNT = 0;
            LINE_COUNT = 0;
            CURRENT_LINE = 0;
            SHOULD_SEND_TITLE_PHRASE = true;
        }

        public class ScriptTopic
        {
            public string topicTitle;
            public int key;
            private List<ScriptLine> scriptLines= new List<ScriptLine>();

            public ScriptTopic(string topicTitle = null)
            {
                this.topicTitle = topicTitle ?? $"TOPIC {key}";
                this.key = Script.TOPIC_COUNT;

                TOPIC_COUNT++;
            }

            public void addLine(string line) {
                scriptLines.Add(new ScriptLine(line));
            }

            public void setTitle(string topicTitle)
            {
                this.topicTitle = topicTitle; 
            }

            public string getTopicTitle() => this.topicTitle;
            public List<ScriptLine> getTopicLines() => this.scriptLines;

            public class ScriptLine
            {
                private string line;
                private int key;

                public ScriptLine(string line)
                {
                    this.line = line;
                    this.key = Script.LINE_COUNT;

                    LINE_COUNT++;
                }

                public string getLine() => this.line;
                public int getKey() => this.key;
            }
        }
    }
}
