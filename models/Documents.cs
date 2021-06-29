using Elasticsearch.Net;
using Nest;

namespace indexationCv.models
{
    public class Document
    {
        public int Id { get; set; }
        /// <summary>
        /// FileData Base64 encoded
        /// </summary>
        public string Content { get; set; }
        public string Path {get; set;}
        public Attachment Attachment { get; set; }


    }
}