using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public  class Comment
    {
        public int Id {  get; set; }
        private int _Id;
        public Comment() { }

        private string _content { get; set; }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public Comment(int id, string content)
        {
            _Id++;
            Id = _Id;
            Content = content;

        }

        public override string ToString()
        {
            return $"ID:{Id}, Content: {Content}";
        }
    }
}
