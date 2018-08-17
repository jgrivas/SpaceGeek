using System.Collections.Generic;

namespace SpaceGeek
{
    internal class FactResource
    {
        public FactResource(string language)
        {
            this.Language = language;
        }

        public string Language { get; set; }
        public string SkillName { get; set; }
        public List<string> Facts { get; } = new List<string>();
        public string GetFactMessage { get; set; }
        public string HelpMessage { get; set; }
        public string HelpReprompt { get; set; }
        public string StopMessage { get; set; }
    }
}
