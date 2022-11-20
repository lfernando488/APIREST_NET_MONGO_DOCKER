using API.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.ViewModels
{
    public class NewsViewModel
    {
        public string Id { get; private set; }

        public string Hat { get; private set; }

        public string Title { get; private set; }

        public string Text { get; private set; }

        public string Author { get; private set; }

        public string Img { get; private set; }

        public string Link { get; private set; }

        public Status Status { get; private set; }
    }
}
