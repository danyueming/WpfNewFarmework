using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class SampleVm
    {
        public SampleVm()
        {
            Id = _idCount++;
            Tags = string.Empty;
        }

        public SampleVm(string title, Type content, string tags = "")
        {
            Id = _idCount++;
            Title = title;
            Content = content;
            Tags = tags;
        }

        private static int _idCount;

        public int Id { get; private set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public Type Content { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }




    }
}
