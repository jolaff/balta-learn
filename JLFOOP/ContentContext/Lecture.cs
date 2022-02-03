using JLFOOP.ContentContext.Enums;
using JLFOOP.SharedContext;

namespace JLFOOP.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string? Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}